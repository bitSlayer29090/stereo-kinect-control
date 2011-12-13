//headers for OpenNI
#include <XnOpenNI.h>
#include <XnCppWrapper.h>
#include <XnHash.h>
#include <XnLog.h>

//header for NITE
#include <XnVNite.h>

//local headers
#include "PointDrawer.h"
#include "stereoCommand.h"
#include "vrpnClient.h"

//headers for gesture recognition
#include <XnVSwipeDetector.h>
#include <XnVSteadyDetector.h>
#include <XnVCircleDetector.h>

#define CHECK_RC(rc, what)											\
	if (rc != XN_STATUS_OK)											\
	{																\
		printf("%s failed: %s\n", what, xnGetStatusString(rc));		\
		return rc;													\
	}

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
		#include <gl\GL.h>
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







int main(int agrc, char *argv)
{



































	HRESULT hr;

	//prepare the file to be opened by the computer
	string filename = "C:\\Users\\Public\\Videos\\VascularVoyage.wmv";
	cout << "File to Open: " << filename << endl;
	
	//instantiate new instance of COMMAND class as "command"
	COMMAND command;

	//create instance using COMMAND::CreateInstance
	hr = command.CreateInstance();
	
	if FAILED(hr)
	{
		cout << "Main - Failed to CreateInstance: " << format_error(hr) << endl;
		goto error;
	}

	//open the file of interest using COMMAND::OpenFile() where the argument is the string of the filepath
	hr = command.OpenFile(filename);
	if FAILED(hr)
	{
		cout << "Main - Failed to Open File: " << format_error(hr) << endl;
		goto error;
	}

	
	cout << "Please press a key" << endl;
	int temp;
	cin >> temp;
	
//insert gesture code here.
exit:
	cout << "What Should I do next?" << endl;
	cin >> temp;
	return temp;

error:
    return hr;
}