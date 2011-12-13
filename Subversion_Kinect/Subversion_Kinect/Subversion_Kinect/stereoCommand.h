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
	public: OLECHAR * pOLEStr;
	public: VARIANT stereoCommand[15];
	WCHAR stringCommand[MAX_PATH];  //MAX_PATH defined as 260
	LPCWSTR str;

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


		hresult = myInvoke();

		return hresult;
	}

	HRESULT SetPause()
	{
		//sets up the dispparams structure for sending to the INVOKE command
		set_params(&dispparams,1,1);

		//identify the command to invoke
		pOLEStr = OLESTR("SetPlaybackState");

		hresult = myInvoke();

		return hresult;

	}

	HRESULT SetPlay()
	{
		//sets up the dispparams structure for sending to the INVOKE command
		set_params(&dispparams,3,1);

		//identify the command to invoke
		pOLEStr = OLESTR("SetPlaybackState");

		hresult = myInvoke();
		
		
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
		return hresult;
	}

	HRESULT SetStop()
	{
		set_params(&dispparams,2,1);
		pOLEStr = OLESTR("SetPlaybackState");
		
		hresult = myInvoke();

		return hresult;
	}

private:

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




	}
};