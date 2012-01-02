//headers for OpenNI
#include <XnOpenNI.h>
#include <XnCppWrapper.h>
#include <XnHash.h>
#include <XnLog.h>
#include <ole2.h>
#include <OleAuto.h>
#include <ObjBase.h>
#include <iostream>
#include <string>
#include <stdlib.h>
#include <math.h>
#include <stdio.h>
#include <WinError.h>
#include <Guiddef.h>
#include <InitGuid.h>
#include <sstream>
#include <iomanip>
#include <OAIdl.h>
#include <XnVNite.h>
#include "PointDrawer.h"
#include "stereoplayer_h.h"
#import "./Debug/Subversion_Kinect.tlb" named_guids

HRESULT hr;
HRESULT hresult;
int temp;
VARIANT vResult;
VARIANT_BOOL vBoolTrue = true;
VARIANT_BOOL vBoolFalse = false;

bool play;
bool stop;
bool pause;
bool fullScreen;
double zoom = 100.0;
int circleCount = 0;

using namespace StereoPlayer;
using namespace std;

//headers for gesture recognition
#include <XnVSwipeDetector.h>
#include <XnVSteadyDetector.h>
#include <XnVCircleDetector.h>
#include <XnVWaveDetector.h>
#include <XnVPushDetector.h>

#define CHECK_RC(rc, what)											\
	if (rc != XN_STATUS_OK)											\
	{																\
		printf("%s failed: %s\n", what, xnGetStatusString(rc));		\
		return rc;													\
	}																\

#define CHECK_ERRORS(rc, errors, what)		\
	if (rc == XN_STATUS_NO_NODE_PRESENT)	\
	{										\
		XnChar strError[1024];				\
		errors.ToString(strError, 1024);	\
		printf("%s\n", strError);			\
		return (rc);						\
	}

#ifdef USE_GLUT
	#if (XN_PLATFORM == XN_PLATFORM_MACOSX)
		#include <GLUT/glut.h>
	#else
		#include <glut.h>
	#endif
#elif defined(USE_GLES)
	#include "opengles.h"
	#include "kbhit.h"
#endif
#include "signal_catch.h"

#ifdef USE_GLES
static EGLDisplay display = EGL_NO_DISPLAY;
static EGLSurface surface = EGL_NO_SURFACE;
static EGLContext context = EGL_NO_CONTEXT;
#endif


//creating the OpenNI objects that get used in the NITE application
xn::Context g_Context;
xn::ScriptNode g_ScriptNode;
xn::DepthGenerator g_DepthGenerator;
xn::HandsGenerator g_HandsGenerator;
xn::GestureGenerator g_GestureGenerator;

//NITE-specific objects
XnVSessionManager* g_pSessionManager;
XnVFlowRouter* g_pFlowRouter;

//the OpenGL drawer
XnVPointDrawer* g_pDrawer;

//instantiating circle detector
XnVCircleDetector* g_pCircle = NULL;

//instantiating swipe detector
XnVSwipeDetector* g_pSwipe = NULL;

//steady detector
XnVSteadyDetector* g_pSteady = NULL;

//wave detector
XnVWaveDetector* g_pWave = NULL;

//push detector
XnVPushDetector* g_pPush = NULL;

#define GL_WIN_SIZE_X 720
#define GL_WIN_SIZE_Y 480

//Logic for deciding whether or not to render certain pieces
XnBool g_bDrawDepthMap = true;
XnBool g_bPrintFrameID = false;

//use smoothing?
XnFloat g_fSmoothing = 0.5f;
XnBool g_bPause = false;
XnBool g_bQuit = false;

SessionState g_SessionState = NOT_IN_SESSION;

void CleanupExit()
{
	g_ScriptNode.Release();
	g_DepthGenerator.Release();
	g_HandsGenerator.Release();
	g_GestureGenerator.Release();
	g_Context.Release();
	
	StereoPlayer::IAutomationPtr pApp(__uuidof(StereoPlayer::Automation));
	pApp->ClosePlayer();

	exit(1);
}

//this function gets called when the focus gesture is being performed
void XN_CALLBACK_TYPE FocusProgress(const XnChar* strFocus, const XnPoint3D& ptPosition, XnFloat fProgress, void* UserCxt)
{
	//we won't print or do anything when the user is doing the focus gesturwe
}

//callback function for when the session begin
void XN_CALLBACK_TYPE SessionStarting(const XnPoint3D& ptPosition, void* UserCxt)
{
	printf("Session start: (%f, %f, %f)\n",ptPosition.X, ptPosition.Y, ptPosition.Z);
	g_SessionState = IN_SESSION;
}

//callback for the session getting teminated
void XN_CALLBACK_TYPE SessionEnding(void* UserCxt)
{
	printf("Session end\n");
	g_SessionState = NOT_IN_SESSION;
}

//this function gets called when the system detects that someone has removed their hands from the tracking area
void XN_CALLBACK_TYPE NoHands(void * UserCxt)
{
	printf("Quick refocus state\n");
	g_SessionState = QUICK_REFOCUS;
}

void XN_CALLBACK_TYPE TouchingCallback(xn::HandTouchingFOVEdgeCapability& generator, XnUserID id, const XnPoint3D* pPosition, XnFloat fTime, XnDirection eDir, void* pCookie)
{
	//printf("Hand at edge of FIELD OF VIEW\n");

	g_pDrawer->SetTouchingFOVEdge(id);
}

//the glutDisplay loop gets called on every frame
void glutDisplay (void)
{

	glClear (GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

	// Setup the OpenGL viewpoint
	glMatrixMode(GL_PROJECTION);
	glPushMatrix();
	glLoadIdentity();

	XnMapOutputMode mode;
	g_DepthGenerator.GetMapOutputMode(mode);
#ifdef USE_GLUT
	glOrtho(0, mode.nXRes, mode.nYRes, 0, -1.0, 1.0);
#elif defined(USE_GLES)
	glOrthof(0, mode.nXRes, mode.nYRes, 0, -1.0, 1.0);
#endif

	glDisable(GL_TEXTURE_2D);

	if (!g_bPause)
	{
		// Read next available data
		g_Context.WaitOneUpdateAll(g_DepthGenerator);
		// Update NITE tree
		g_pSessionManager->Update(&g_Context);
#ifdef USE_GLUT
		PrintSessionState(g_SessionState);
#endif
	}

#ifdef USE_GLUT
	glutSwapBuffers();
#endif
}

#ifdef USE_GLUT
void glutIdle (void)
{
	if (g_bQuit) {
		CleanupExit();
	}

	// Display the frame
	glutPostRedisplay();
}

void glutKeyboard (unsigned char key, int x, int y)
{
	switch (key)
	{
	case 27:
		// Exit
		CleanupExit();
	case'p':
		// Toggle pause
		g_bPause = !g_bPause;
		break;
	case 'd':
		// Toggle drawing of the depth map
		g_bDrawDepthMap = !g_bDrawDepthMap;
		g_pDrawer->SetDepthMap(g_bDrawDepthMap);
		break;
	case 'f':
		g_bPrintFrameID = !g_bPrintFrameID;
		g_pDrawer->SetFrameID(g_bPrintFrameID);
		break;
	case 's':
		// Toggle smoothing
		if (g_fSmoothing == 0)
			g_fSmoothing = 0.1;
		else 
			g_fSmoothing = 0;
		g_HandsGenerator.SetSmoothing(g_fSmoothing);
		break;
	case 'e':
		// end current session
		g_pSessionManager->EndSession();
		break;
	}
}
void glInit (int * pargc, char ** argv)
{
	glutInit(pargc, argv);
	glutInitDisplayMode(GLUT_RGB | GLUT_DOUBLE | GLUT_DEPTH);
	glutInitWindowSize(GL_WIN_SIZE_X, GL_WIN_SIZE_Y);
	glutCreateWindow ("PrimeSense Nite Point Viewer");
	//glutFullScreen();
	glutSetCursor(GLUT_CURSOR_NONE);

	glutKeyboardFunc(glutKeyboard);
	glutDisplayFunc(glutDisplay);
	glutIdleFunc(glutIdle);

	glDisable(GL_DEPTH_TEST);
	glEnable(GL_TEXTURE_2D);

	glEnableClientState(GL_VERTEX_ARRAY);
	glDisableClientState(GL_COLOR_ARRAY);
}
#endif

void togglePlay()
{

	StereoPlayer::IAutomationPtr pApp(__uuidof(StereoPlayer::Automation));
	
	if(play)
	{
		pApp->SetPlaybackState(StereoPlayer::PlaybackState_Pause);
		play = false;
		pause = true;
		stop = false;
	}
	else if(pause | stop)
	{
		pApp->SetPlaybackState(StereoPlayer::PlaybackState_Play);
		pause = false;
		stop = true;
		play = false;
	}
}

void setStop()
{
	StereoPlayer::IAutomationPtr pApp(__uuidof(StereoPlayer::Automation));

	pApp->SetPlaybackState(StereoPlayer::PlaybackState_Stop);
}

void toggleScreen()
{
	StereoPlayer::IAutomationPtr pApp(__uuidof(StereoPlayer::Automation));
	
	if(!fullScreen)
	{
		pApp->EnterFullscreenMode(vBoolTrue);
		fullScreen = true;
	}
	else
	{
		pApp->LeaveFullscreenMode();
		fullScreen = false;
	}
}

void increaseZoom()
{
	StereoPlayer::IAutomationPtr pApp(__uuidof(StereoPlayer::Automation));

	double tempZoom;
	double newZoom;
	pApp->GetZoom(&vResult);
	tempZoom = vResult.dblVal;

	if (zoom==tempZoom)
	{
		newZoom = zoom + 10.0;
		pApp->SetZoom(newZoom);
		zoom = newZoom;
	}
	else
	{
		cout <<"Warning: The zoom setting is not consistently set. Check the initial settings." << endl;

		zoom = tempZoom;
		newZoom = zoom + 10.0;
		pApp->SetZoom(newZoom);
		zoom = newZoom;
	}
}


void decreaseZoom()
{
	StereoPlayer::IAutomationPtr pApp(__uuidof(StereoPlayer::Automation));

	double tempZoom;
	double newZoom;
	pApp->GetZoom(&vResult);
	tempZoom = vResult.dblVal;

	if (zoom==tempZoom)
	{
		newZoom = zoom - 10.0;
		pApp->SetZoom(newZoom);
		OutputDebugString(TEXT("NEW ZOOM LEVEL: %g\n",newZoom));
		zoom = newZoom;
	}
	else
	{
		cout <<"Warning: The zoom setting is not consistently set. Check the initial settings." << endl;

		zoom = tempZoom;
		newZoom = zoom - 10.0;
		pApp->SetZoom(newZoom);
		zoom = newZoom;
	}
}

void XN_CALLBACK_TYPE GestureIntermediateStageCompletedHandler(xn::GestureGenerator& generator, const XnChar* strGesture, const XnPoint3D* pPosition, void* pCookie)
{
	printf("Gesture %s: Intermediate stage complete (%f,%f,%f)\n", strGesture, pPosition->X, pPosition->Y, pPosition->Z);
}

void XN_CALLBACK_TYPE GestureReadyForNextIntermediateStageHandler(xn::GestureGenerator& generator, const XnChar* strGesture, const XnPoint3D* pPosition, void* pCookie)
{
	printf("Gesture %s: Ready for next intermediate stage (%f,%f,%f)\n", strGesture, pPosition->X, pPosition->Y, pPosition->Z);
}

void XN_CALLBACK_TYPE GestureProgressHandler(xn::GestureGenerator& generator, const XnChar* strGesture, const XnPoint3D* pPosition, XnFloat fProgress, void* pCookie)
{
	printf("Gesture %s progress: %f (%f,%f,%f)\n", strGesture, fProgress, pPosition->X, pPosition->Y, pPosition->Z);
}

void XN_CALLBACK_TYPE CircleCB(XnFloat fTimes, XnBool bConfident, const XnVCircle* pCircle, void* pUserCxt)
{
	printf("\nCircle Detected\n");
	g_pCircle->Reset();

	circleCount ++;


	//you must make the circle gesture twice to exit
	if (circleCount >=2)
		CleanupExit();
}

void XN_CALLBACK_TYPE NoCircleCB(XnFloat fLastValue, XnVCircleDetector::XnVNoCircleReason eReason, void* pUserCxt)
{
	//nothing goes here
}

void XN_CALLBACK_TYPE SwipeDownCB(XnFloat fVelocity, XnFloat fAngle, void* pUserCxt)
{
	printf("\nSwipe Down\n");
	decreaseZoom();
}

void XN_CALLBACK_TYPE SwipeUpCB(XnFloat fVelocity, XnFloat fAngle, void* pUserCxt)
{
	printf("\nSwipe Up\n");
	increaseZoom();
}

void XN_CALLBACK_TYPE SwipeLeftCB(XnFloat fVelocity, XnFloat fAngle, void* pUserCxt)
{
	printf("\n Left Swipe -- SWITCH FULLSCREEN STATE\n");
	toggleScreen();
}

void XN_CALLBACK_TYPE SwipeRightCB(XnFloat fVelocity, XnFloat fAngle, void* pUserCxt)
{
	printf("\nSwipe Right\n");
	togglePlay();
}

void XN_CALLBACK_TYPE WaveCB(void* pUserCxt)
{
	printf("\nWave Detected\n");
}

void XN_CALLBACK_TYPE PushCB(XnFloat fVelocity, XnFloat fAngle, void* UserCxt)
{
	printf("\nPush Detected\n");
	setStop();
}

//sample XML code that will initialize the OpenNI interface
#define SAMPLE_XML_PATH "Sample-Tracking.xml"




int main(int argc, char** argv)
{
	//error handling variables
	XnStatus rc = XN_STATUS_OK;
	xn::EnumerationErrors errors;


	hr = CoInitialize(NULL);
	play = false;
	pause = false;
	stop = false;
	fullScreen = false;
	zoom = 100.0;
	circleCount = 0;

	if FAILED(hr)
	{
		cout << "Error" << endl;
	}

	StereoPlayer::IAutomationPtr app(__uuidof(StereoPlayer::Automation));

	
	/*
	//prepare the file to be opened by the computer
	string filename = "C:\\Users\\Public\\Videos\\Pulmonary.mov";
	cout << "File to Open: " << filename << endl;


	//prepare left, right video file names
	string LeftFile = "C:\\Users\\Public\\Videos\\IliacLeft.mov";
	cout <<"---Left Video File: " << LeftFile << endl;
	string RightFile = "C:\\Users\\Public\\Videos\\IliacRight.mov";
	cout <<"---Right Video File: " << RightFile << endl;
	int AudioMode = 2;
	string AudioFile;
	if (AudioFile.empty())
	{
		cout << "No audio file was indicated. Setting AudioMode to 0" << endl;
		AudioMode = 0;
	}
	*/

	hr = app->OpenFile(L"C:\\Users\\Public\\Videos\\Pulmonary.mov");
	play = true;

	if FAILED(hr)
		goto error;


	hr = app->GetDuration(&vResult);
	double duration;
	duration = vResult.dblVal;

	if (duration >= 60)
	{
		cout << "Video duration is greater than 60 seconds. Turning off repeat..." << endl;
		app->SetRepeat(vBoolFalse);
	}

	else
	{
		cout << "Video duration less than 60 seconds. Turning on repeat..." << endl;
		app->SetRepeat(vBoolTrue);
	}


	//create instance using COMMAND::CreateInstance
	//hr = command.CreateInstance();
	//if FAILED(hr)
	//{
	//	cout << "Main - Failed to CreateInstance: " << format_error(hr) << endl;
	//	goto error;
	//}

	//open the file of interest using COMMAND::OpenFile() where the argument is the string of the filepath
	//hr = command.OpenFile(filename);

	//hr = command.SetOpenLRFiles(LeftFile,RightFile,0);
	//if FAILED(hr)
	//{
	//	//cout << "Main - Failed to Open File: " << format_error(hr) << endl;
	//	cout << "Will now exit.  Press any key to continue..." << endl;
	//	int temp;
	//	cin >> temp;
	//	CleanupExit();
	//}
	
	//Initialize the OpenNI interface to the Kinect Camera
	rc = g_Context.InitFromXmlFile(SAMPLE_XML_PATH, g_ScriptNode,&errors);
	CHECK_ERRORS(rc,errors,"InitFromXMLFile");
	CHECK_RC(rc,"InitFromXMLFile");

	rc=g_Context.FindExistingNode(XN_NODE_TYPE_DEPTH, g_DepthGenerator);
	CHECK_RC(rc,"Find depth generator");

	rc= g_Context.FindExistingNode(XN_NODE_TYPE_HANDS,g_HandsGenerator);
	CHECK_RC(rc,"Find Hands Generator");

	rc=g_Context.FindExistingNode(XN_NODE_TYPE_GESTURE,g_GestureGenerator);
	CHECK_RC(rc,"Find Gesture Generator");

	XnCallbackHandle h;

	//if we've activating the sensor for knowing whether or not the hand is near the FOV edge, register the callback
	if (g_HandsGenerator.IsCapabilitySupported(XN_CAPABILITY_HAND_TOUCHING_FOV_EDGE))
	{
		g_HandsGenerator.GetHandTouchingFOVEdgeCap().RegisterToHandTouchingFOVEdge(TouchingCallback, NULL,h);
	}

	XnCallbackHandle hGestureIntermediateStageCompleted, hGestureProgress, hGestureReadyForNextIntermediateStage;
	g_GestureGenerator.RegisterToGestureIntermediateStageCompleted(GestureIntermediateStageCompletedHandler, NULL, hGestureIntermediateStageCompleted);
	g_GestureGenerator.RegisterToGestureReadyForNextIntermediateStage(GestureReadyForNextIntermediateStageHandler, NULL, hGestureReadyForNextIntermediateStage);
	g_GestureGenerator.RegisterGestureCallbacks(NULL, GestureProgressHandler, NULL, hGestureProgress);

	//We already created OpenNI objects, now we need to Create NITE objects

	g_pSessionManager = new XnVSessionManager;
	rc = g_pSessionManager->Initialize(&g_Context,"Click,Wave","RaiseHand");
	CHECK_RC(rc, "SessionManager Initialization");

	g_pSessionManager->RegisterSession(NULL,SessionStarting,SessionEnding,FocusProgress);

	g_pDrawer = new XnVPointDrawer(20, g_DepthGenerator);
	g_pFlowRouter = new XnVFlowRouter;
	g_pFlowRouter->SetActive(g_pDrawer);

	//will now draw the circle on the hand
	g_pSessionManager->AddListener(g_pFlowRouter);

	//logic and registration for the circle detector
	g_pCircle = new XnVCircleDetector;
	g_pCircle->RegisterCircle(NULL,&CircleCB); //when circle is recognized, CircleCB will be called
	g_pCircle->RegisterNoCircle(NULL,&NoCircleCB); //when circle stops being detector, NoCircleCB will be called
	
	//UNCOMMENT TO ENABLE THE CIRCLE DETECTOR
	g_pSessionManager->AddListener(g_pCircle);

	//logic and registration for the swipe detector and its 4 events
	g_pSwipe = new XnVSwipeDetector;
	g_pSwipe->SetSteadyDuration(500);
	g_pSwipe->RegisterSwipeDown(NULL, &SwipeDownCB);
	g_pSwipe->RegisterSwipeLeft(NULL, &SwipeLeftCB);
	g_pSwipe->RegisterSwipeRight(NULL, &SwipeRightCB);
	g_pSwipe->RegisterSwipeUp(NULL, &SwipeUpCB);

	g_pSessionManager->AddListener(g_pSwipe);

	//registration for wave detector
	g_pWave = new XnVWaveDetector;
	g_pWave->RegisterWave(NULL, &WaveCB);

	g_pSessionManager->AddListener(g_pWave);

	//register for the push detector
	g_pPush = new XnVPushDetector;
	g_pPush->RegisterPush(NULL, &PushCB);

	g_pSessionManager->AddListener(g_pPush);

	g_pDrawer->RegisterNoPoints(NULL, NoHands);
	g_pDrawer->SetDepthMap(g_bDrawDepthMap);

	rc = g_Context.StartGeneratingAll();
	CHECK_RC(rc,"Start Generating");



#ifdef USE_GLUT

	glInit(&argc, argv);
	glutMainLoop();

#elif defined(USE_GLES)
	if (!opengles_init(GL_WIN_SIZE_X, GL_WIN_SIZE_Y, &display, &surface, &context))
	{
		printf("Error initializing opengles\n");
		CleanupExit();
	}
	glDisable(GL_DEPTH_TEST);
	glEnable(GL_TEXTURE_2D);
	glEnableClientState(GL_VERTEX_ARRAY);
	glDisableClientState(GL_COLOR_ARRAY);

	while ((!_kbhit()) && (!g_bQuit))
	{
		glutDisplay();
		eglSwapBuffers(display, surface);
	}
	opengles_shutdown(display, surface, context);

	CleanupExit();
#endif

	cout << "Please press a key" << endl;
	int temp;
	cin >> temp;
error:
    return hr;
}

