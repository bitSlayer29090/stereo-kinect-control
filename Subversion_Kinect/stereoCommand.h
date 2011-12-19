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


using namespace std;

//GUID for the StereoPlayer automation class
// {73B28B6E-D306-4589-9ED17AA4D182}
DEFINE_GUID(StereoPlayer, 0x73b28b6e, 0xd306, 0x4589, 0xb0, 0x32, 0x9e, 0xd1, 0x7a, 0xa4, 0xd1, 0x82);
//Could use the IDispatch::CoCreatefromProgID method, but this is more likely to work

//enumeration for the SetPlaybackState method
#define PLAY 0.0
#define PAUSE 1.0
#define STOP 2.0
#define FASTF 3.0
#define RWIND 4.0

//enumeration for the AudioMode method
#define NOAUDIO 0
#define SEPAUDIO 1
#define LEFTAUDIO 2
#define RIGHTAUDIO 3

//error handling subroutine returns the string of the error back to main
string format_error(unsigned __int32 hr)
{
  stringstream ss;
  ss << "Operation Failed. Error code = 0x" << hex << hr << std::endl;
  return ss.str();
}

class COMMAND
{
	HRESULT hresult;
	IUnknown * punk;
	IDispatch * pdisp;
	DISPID dispid;
	DISPPARAMS dispparams;
	EXCEPINFO excepinfo;
	UINT nArgErr;
	OLECHAR * pOLEStr;
	VARIANT stereoCommand[15]; //for most commands

	WCHAR stringCommand[MAX_PATH];  //MAX_PATH defined as 260
	LPCWSTR str;
	float videoDuration;
	float videoPosition;
	bool fullScreen;
	bool play;
	bool pause;
	bool stop;
	VARIANTARG varg0;
	double zoomLevel;

public:
	//this is the constructor for the class
	COMMAND() 
	{
		cout << "Constructor has been called" << endl;
		
		hresult = OleInitialize(NULL);
		if FAILED(hresult)
		{
			cout << "Failed to initialize OLE Object" << endl;
		}

		VariantInit(&stereoCommand[0]);


		initalize_CommandStruct();

		str = TEXT("\nConstructor Called\n");
		OutputDebugString(str);

		VariantInit(&varg0);

		fullScreen = false;
		play = false;
		pause = false;
		stop = false;
		zoomLevel = 100.0;
	}
	//this is the destructor for the class
	~COMMAND()
	{
		str = TEXT("\nDestructor Called\n");
		OutputDebugString(str);
		
		if(pdisp) pdisp->Release();
		if(punk) punk->Release();

		OleUninitialize();

	}

	HRESULT CreateInstance()
	{
		hresult = CoCreateInstance(StereoPlayer,NULL,CLSCTX_SERVER,IID_IUnknown, (void **) &punk);

		if FAILED(hresult)
		{
			cout << "StereoCommand - Failed to CreateInstance: " << format_error(hresult) << endl;
			return hresult;
		}
		return hresult;
	}
	
	HRESULT OpenFile(string filepath)
	{
		//get string with file path and set the proper stereoCommand element
		//convert to VARIANT structure element using a subroutine
		prepStringParam(filepath,stringCommand); //conversion
		stereoCommand[0].bstrVal=SysAllocString(stringCommand); //setting VARIANT struct
		
		set_params(&dispparams,0,1); //setting dispparam struct
		pOLEStr = OLESTR("OpenFile");

		double duration;
		hresult = myInvoke();

		if FAILED(hresult)
		{
			cout<<"FAILED TO OPEN FILE: " << format_error(hresult) << endl;
			return hresult;
		}
		else
		{
			play = true;
			pause = false;
			stop = false;

			getDuration();

			//determine_vtType(&varg0);

			cout << "varg0 type is: " << varg0.vt << endl;

			//eventually want to wrap into IF DURATION << 60 seconds
			SetRepeatTrue();


			return hresult;
		}
		
	}

	HRESULT SetPause()
	{
		//sets up the dispparams structure for sending to the INVOKE command
		set_params(&dispparams,1,1);

		//identify the command to invoke
		pOLEStr = OLESTR("SetPlaybackState");

		hresult = myInvoke();
		play = false;
		pause = true;
		stop = false;

		return hresult;

	}

	HRESULT SetPlay()
	{
		//sets up the dispparams structure for sending to the INVOKE command
		set_params(&dispparams,3,1);

		//identify the command to invoke
		pOLEStr = OLESTR("SetPlaybackState");

		hresult = myInvoke();

		play = true;
		pause = false;
		stop = false;
		
		
		return hresult;		
	}

	HRESULT SetFF()
	{
		set_params(&dispparams,4,1);

		pOLEStr = OLESTR("SetPlaybackState");

		hresult = myInvoke();

		return hresult;

	}

	HRESULT SetRW()
	{
		set_params(&dispparams,5,1);

		pOLEStr = OLESTR("SetPlaybackState");

		hresult=myInvoke();

		return hresult;
	}

	HRESULT SetFullScreen()
	{
		pOLEStr = OLESTR("EnterFullscreenMode");
		set_params(&dispparams,6,1);
		hresult = myInvoke();

		if FAILED(hresult)
		{
			std::cout << "FAILED TO SET FULL SCREEN " <<format_error(hresult) << endl;
		}

		fullScreen = true;


		return hresult;
	}

	HRESULT SetStop()
	{
		set_params(&dispparams,2,1);
		pOLEStr = OLESTR("SetPlaybackState");
		
		hresult = myInvoke();

		if FAILED(hresult)
		{
			std::cout << "FAILED TO SET STOP " << format_error(hresult) << endl;
		}

		play = false;
		pause = false;
		stop = true;


		return hresult;
	}

	HRESULT SetLeaveFullScreen()
	{
		set_params(&dispparams,8,0);
		pOLEStr = OLESTR("LeaveFullscreenMode");

		hresult = myInvoke();

		if FAILED(hresult)
		{
			std::cout<<"FAILED TO LEAVE FULL SCREEN" << endl;
			EmergencyExit();
		}

		fullScreen = false;

		return hresult;
	}

	HRESULT SwitchFullScreen()
	{
		if (!fullScreen)
		{
			hresult = SetFullScreen();

			if FAILED(hresult)
			{
				std::cout << "Failed to set full screen: " << format_error(hresult) << endl;
				return hresult;
			}

		}
		else if (fullScreen)
		{
			hresult = SetLeaveFullScreen();
			if FAILED(hresult)
			{
				std::cout << "Failed to set non-full screen: " << format_error(hresult) << endl;
				return hresult;
			}
		}

		return hresult;
	}

	HRESULT togglePlay()
	{
		if(!play | stop)
		{
			hresult = SetPlay();
			if FAILED(hresult)
			{
				std::cout << "FAILED TO SET PLAY: " << format_error(hresult) << endl;
				return hresult;
			}

		}

		else if (play)
		{
			hresult = SetPause();
			if FAILED(hresult)
			{
				std::cout << "FAILED TO SET PAUSE: " << format_error(hresult) << endl;
				return hresult;
			}
		}
	}

	void EmergencyExit()
	{
		if(pdisp) pdisp->Release();
		if(punk) punk->Release();


		pOLEStr = OLESTR("ClosePlayer");
		set_params(&dispparams,8,0);
		hresult = myInvoke();

		OleUninitialize();
		exit(1);
	}

	HRESULT SetZoomIncrement()
	{
		double zoomCheck = stereoCommand[9].dblVal;
		double newZoom;

		if (zoomLevel!= zoomCheck)
		{
			cout << "Zoom level mismatch! Expected: " << zoomLevel << " Actual: " << zoomCheck << endl;
			return E_ABORT;
		}
		else
		{
			cout << "Zoom level matches expectation" << endl;

			newZoom = zoomLevel+(double)10.0;

			stereoCommand[9].dblVal = newZoom;

			pOLEStr = OLESTR("SetZoom");
			set_params(&dispparams,9,1);

			hresult = myInvoke();

			if FAILED(hresult)
			{
				cout << "FAILED TO INVOKE ZOOM INCREMENT: " << format_error(hresult) << endl;
			}


			//set equal to new zoom
			zoomLevel = newZoom;
			return hresult;
		}
	}

	HRESULT SetZoomDecrement()
	{
		double zoomCheck = stereoCommand[9].dblVal;
		double newZoom;

		if (zoomLevel!= zoomCheck)
		{
			cout << "Zoom level mismatch! Expected: " << zoomLevel << " Actual: " << zoomCheck << endl;
			return E_ABORT;
		}
		else
		{
			cout << "Zoom level matches expectation" << endl;

			newZoom = zoomLevel-(double)10.0;

			stereoCommand[9].dblVal = newZoom;

			pOLEStr = OLESTR("SetZoom");
			set_params(&dispparams,9,1);

			hresult = myInvoke();

			if FAILED(hresult)
			{
				cout << "FAILED TO INVOKE ZOOM DECREMENT: " << format_error(hresult) << endl;
			}


			//set equal to new zoom
			zoomLevel = newZoom;
			return hresult;
		}


	}

	HRESULT SetRepeatTrue()
	{
		set_params(&dispparams,6,1);
		pOLEStr = OLESTR("SetRepeat");
		hresult = myInvoke();

		if FAILED(hresult)
		{
			cout << "FAILED TO SET REPEAT TRUE " << format_error(hresult) << endl;
		}
		else
			cout << "Repeat set to TRUE" << endl;

		return hresult;
	}

	HRESULT SetRepeatFalse()
	{
		set_params(&dispparams,7,1);
		pOLEStr = OLESTR("SetRepeat");
		hresult = myInvoke();

		if FAILED(hresult)
		{
			cout << "FAILED TO SET REPEAT FALSE " << format_error(hresult) << endl;
		}
		else
			cout << "Repeat set to FALSE" << endl;

		return hresult;
	}

	HRESULT SetOpenLRFiles(string LeftFile, string RightFile, int AudioMode)
	{
		//this function is for audio modes 0 (no audio), 2 (left video file's audio) or 3 (right video file's audio)
		//AudioMode=1 indicates that a separate file for audio is expected; this will throw an exception
		pOLEStr = OLESTR("OpenLeftRightFiles");
		
		//set LeftFile into stereoCommand structure
		prepStringParam(LeftFile,stringCommand);
		dispparams.rgvarg[0].vt = VT_BSTR;
		dispparams.rgvarg[0].bstrVal = SysAllocString(stringCommand);
		
		//set up right file
		prepStringParam(RightFile,stringCommand);
		dispparams.rgvarg[1].vt = VT_BSTR;
		dispparams.rgvarg[1].bstrVal = SysAllocString(stringCommand);

		//there is no separate audio file to identify
		dispparams.rgvarg[2].vt = VT_EMPTY;

		if (AudioMode ==1)
		{
			std::cout << "ERROR Parameters indicate a separate audio file is expected, but none was indicated." << endl;
			return DISP_E_BADPARAMCOUNT;
		}

		dispparams.rgvarg[3].vt = VT_UI4;
		dispparams.rgvarg[3].llVal = (long)AudioMode;



		hresult = punk->QueryInterface(&pdisp);

		//error checking

		hresult = pdisp->GetIDsOfNames(IID_NULL,&pOLEStr, 1, LOCALE_USER_DEFAULT, &dispid);

		//error checking

		hresult = pdisp->Invoke(dispid,IID_NULL,LOCALE_SYSTEM_DEFAULT,DISPATCH_METHOD,&dispparams, &varg0,NULL,NULL);








	}

	HRESULT SetOpenLRFiles(string LeftFile, string RightFile, int AudioMode, string AudioFile)
	{
		if(AudioMode != 1)
		{
			pOLEStr = OLESTR("OpenLeftRightFiles");

			//set LeftFile into stereoCommand structure
			prepStringParam(LeftFile,stringCommand);

			
			//set up right file
			prepStringParam(RightFile,stringCommand);

			
			//set up audio file
			prepStringParam(AudioFile,stringCommand);

			
			//set audio mode




		}
		else
		{
			std::cout << "ERROR Parameters indicate a separate audio file is expected, but none was indicated." << endl;
			return DISP_E_BADPARAMCOUNT;
		}
	}
	



private:

	VARENUM determine_vtType(VARIANT *test)
	{
		switch (test->vt)
		{
		case 0:
			return VT_EMPTY;
		case 1:
			return VT_NULL;
		case 2:
			return VT_I2;
		case 3:
			return VT_I4;
		case 4:
			return VT_R4;
		default:
			return VT_UNKNOWN;
		}
	}
	//TO DO:: FIX THE getDURATION method!
	void getDuration()
	{
		set_params(&dispparams,8,0,false);
		pOLEStr = OLESTR("GetDuration");
		
		//hresult = myInvoke(varg0);

		hresult = punk ->QueryInterface(&pdisp);
		//error checking
		hresult = pdisp->GetIDsOfNames(IID_NULL, &pOLEStr,  1, LOCALE_USER_DEFAULT, &dispid);
		//error checking
		hresult = pdisp->Invoke(dispid,IID_NULL,LOCALE_SYSTEM_DEFAULT,DISPATCH_METHOD | DISPATCH_PROPERTYGET,&dispparams,&varg0,NULL,NULL);

	}
	
	HRESULT myInvoke(VARIANTARG pArgs)
	{
		//query the interface
		hresult = punk->QueryInterface(&pdisp);

		if FAILED(hresult)
		{
			cout << "Failed at QueryInterface step: " << format_error(hresult) << endl;
			return hresult;
		}

		//find command's location in memory
		hresult = pdisp->GetIDsOfNames(IID_NULL,
			&pOLEStr,
			1,
			LOCALE_USER_DEFAULT,
			&dispid);

		if FAILED(hresult)
		{
			cout << "Failed at GetIDsOfNames step: " << format_error(hresult) << endl;
			return hresult;
		}


		//invoke the command
		hresult = pdisp->Invoke(dispid,
			IID_NULL,
			LOCALE_SYSTEM_DEFAULT,
			DISPATCH_PROPERTYGET,
			&dispparams,
			&pArgs,
			NULL,
			NULL);

		if FAILED(hresult)
		{
			cout << "Failed at Invoke step: " << format_error(hresult) << endl;
			return hresult;
		}

		cout << "varg0 type is " << hex << pArgs.vt << endl;

		return hresult;
	}
	
	HRESULT myInvoke()
	{
		//query the interface
		hresult = punk->QueryInterface(&pdisp);

		if FAILED(hresult)
		{
			cout << "Failed at QueryInterface step: " << format_error(hresult) << endl;
			return hresult;
		}

		//find command's location in memory
		hresult = pdisp->GetIDsOfNames(IID_NULL,
			&pOLEStr,
			1,
			LOCALE_USER_DEFAULT,
			&dispid);

		if FAILED(hresult)
		{
			cout << "Failed at GetIDsOfNames step: " << format_error(hresult) << endl;
			return hresult;
		}


		//invoke the command
		hresult = pdisp->Invoke(dispid,
			IID_NULL,
			LOCALE_SYSTEM_DEFAULT,
			DISPATCH_METHOD,
			&dispparams,
			NULL,
			NULL,
			NULL);

		if FAILED(hresult)
		{
			cout << "Failed at Invoke step: " << format_error(hresult) << endl;
			return hresult;
		}

		return hresult;
	}

	void prepStringParam(string argument, WCHAR formattedArg[])
	{
		//converts the "string" variable to the OLECHAR type for use in the VARIANT structure
		MultiByteToWideChar(CP_UTF8,0,argument.c_str(),argument.length()+1,formattedArg,MAX_PATH);
	}

	//sets up the dispparams structure with proper values for use in INVOKE	
	void set_params(DISPPARAMS *pdispparam, int which, int howMany, bool isNull)
	{
		//set up the DISPPARAMS struct for use in the IDispatch::Invoke command
		if (!isNull)
			howMany++;

		pdispparam->cArgs = howMany;
		pdispparam->cNamedArgs =0;
		pdispparam->rgdispidNamedArgs = NULL;
		if (howMany !=0)
		{
			pdispparam->rgvarg = &stereoCommand[which];
		}
		else
		{
			pdispparam->rgvarg=NULL;
		}
	}


	void set_params(DISPPARAMS *pdispparam, int which, int howMany)
	{
		//set up the DISPPARAMS struct for use in the IDispatch::Invoke command
		
		pdispparam->cArgs = howMany;
		pdispparam->cNamedArgs =0;
		pdispparam->rgdispidNamedArgs = NULL;
		if (howMany !=0)
		{
			pdispparam->rgvarg = &stereoCommand[which];
		}
		else
		{
			pdispparam->rgvarg=NULL;
		}
	}

	void initalize_CommandStruct()
	{
				
		//VARIANT struct for a string param like a filepath
		stereoCommand[0].vt=VT_BSTR;
		//we cannot set the bstrVal here, it must be done after converting the string to the BSTR VARIANT structure
		//stereoCommand[0].bstrVal = SysAllocString(stringCommand);

		//VARIANT struct for PAUSE command
		stereoCommand[1].vt = VT_UI4;
		stereoCommand[1].lVal = PAUSE;

		//VARIANT struct for STOP command
		stereoCommand[2].vt = VT_UI4;
		stereoCommand[2].lVal = STOP;
	
		//VARIANT struct for PLAY command
		stereoCommand[3].vt = VT_UI4;
		stereoCommand[3].lVal = PLAY;

		//VARIANT struct for FAST FORWARD command
		stereoCommand[4].vt = VT_UI4;
		stereoCommand[4].lVal = FASTF;

		//VARIANT struct for REWIND command
		stereoCommand[5].vt = VT_UI4;
		stereoCommand[5].lVal = RWIND;

		//VARIANT struct for (bool) TRUE
		stereoCommand[6].vt = VT_BOOL;
		stereoCommand[6].boolVal =1;

		//VARIANT struct for (bool) FALSE
		stereoCommand[7].vt = VT_BOOL;
		stereoCommand[7].boolVal = 0;

		//VARIANT struct for null
		stereoCommand[8].vt = VT_EMPTY;

		//VARIANT struct for Zoom
		stereoCommand[9].vt = VT_R8;
		stereoCommand[9].dblVal =100.0;

	}
};