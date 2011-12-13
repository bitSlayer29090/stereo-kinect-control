#include "stereoCommand.h"
#include "vrpnClient.h"
#include <XnOpenNI.h>
#include <XnCppWrapper.h>
#include <XnHash.h>
#include <XnLog.h>
#include <XnVNite.h>

//header for NITE
#include "PointDrawer.h"




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