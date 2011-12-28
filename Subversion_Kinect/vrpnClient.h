#ifndef VRPNCLIENT_H
#define VRPNCLIENT_H
#endif

#include <C:\vrpn\vrpn_Tracker.h>
#include <C:\vrpn\vrpn_Analog.h>
#include <C:\vrpn\vrpn_Button.h>
#include <iostream>
using namespace std;

void VRPN_CALLBACK handle_tracker(void * userData, const vrpn_TRACKERCB t)
{
	cout << "   TRACKER: '" << t.sensor << "' : " << "," << 1000*t.pos[0] << "," << 1000*t.pos[1] << "," << 1000*t.pos[2] << endl;
}

void VRPN_CALLBACK handle_button(void * userData, const vrpn_BUTTONCB t)
{
	cout <<"Button press" << endl;
}