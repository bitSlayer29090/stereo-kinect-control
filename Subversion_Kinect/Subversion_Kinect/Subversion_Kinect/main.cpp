#include "stereoCommand.h"

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
	
	while (temp!=9)
	{
	switch (temp)
	{
		case(1):
			{
				hr = command.SetPause();

				if FAILED(hr)
				{
					cout << "Main - Failed to SetPause. " << format_error(hr) << endl;
					goto exit;
				}
				break;
			}
		case(2):
			{
				hr= command.SetPlay();
				
				if FAILED(hr)
				{
					cout << "Main - Failed to SetPlay. " << format_error(hr) << endl;
					goto exit;
				}
				break;
			}
		case(3):
			{
				hr = command.SetFullScreen();

				if(FAILED(hr))
				{
					cout<<"Main - Failed to SetPlay." << format_error(hr) << endl;
					goto exit;
				}
				break;
			}
		case(4):
			{
				hr = command.SetStop();

				if (FAILED(hr))
				{
					cout<<"Main - Failed to SetStop. " << format_error(hr) << endl;
					goto exit;
				}
				break;
			}
		default:
			{
				cout << "DEFAULT ERROR!" << endl;
				break;
			}
	}
exit:
	cout << "What Should I do next?" << endl;
	cin >> temp;
	}
	return temp;

error:
    return hr;
}