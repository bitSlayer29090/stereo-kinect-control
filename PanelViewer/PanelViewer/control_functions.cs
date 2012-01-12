/********************************************************************
*   control_functions.cs											*
*   Copyright (C) 2012 Marquette University & David Quam			*
*	Created on 7 Jan 2012 by David J. Quam							*
*																	*
*	All software is provided "as is" without warranty				*
********************************************************************/

using System;
using System.Windows.Forms;
using StereoPlayer;


namespace PanelViewer
{

	class Control_Functions
	{
		public Control_Functions()
		{
			control = new StereoPlayer.Automation();

			/*Initialize Variables*/
			play = true;
			pause = false;
			stop = false;
			fullscreen = false;
			zoom = 100;
			sliderMode = false;
			debug = false;
		}

		public void togglePlay()
		{
			if (play == true && pause == false && stop == false)
			{
				control.SetPlaybackState( PlaybackState.PlaybackState_Pause );
				play = false;
				pause = true;
				stop = false;
			}
			else if (play == false && pause == true && stop == false)
			{
				control.SetPlaybackState( PlaybackState.PlaybackState_Play );
				play = true;
				pause = false;
				stop = false;
			}

			else if (play == false && pause == false && stop == true)
			{
				control.SetPlaybackState( PlaybackState.PlaybackState_Play );
				play = true;
				pause = false;
				stop = false;
			}
		}

		public void setStop()
		{
			control.SetPlaybackState( PlaybackState.PlaybackState_Stop );
		}

		public void toggleFullscreen()
		{

			if (fullscreen)
			{
				control.LeaveFullscreenMode();
				fullscreen = false;
			}
			else
			{
				control.EnterFullscreenMode( true );
				fullscreen = true;
			}

		}

		public void increaseZoom()
		{
			if (debug)
			{
				Console.WriteLine( "Increaseing Zoom 10%." );
			}

			double newZoom;

			newZoom = zoom + 10;
			zoom = newZoom;

			control.SetZoom( newZoom );

		}

		public void decreaseZoom()
		{
			if (debug)
			{
				Console.WriteLine( "Decreaseing Zoom 10%." );
			}

			double newZoom;

			newZoom = zoom - 10;
			zoom = newZoom;

			control.SetZoom( newZoom );
		}

		public void enterSliderMode()
		{
			sliderMode = true;
			if (debug)
			{
				Console.WriteLine( "Setting sliderMode to true." );
			}
		}

		public void leaveSliderMode()
		{
			sliderMode = false;

			if (debug)
			{
				Console.WriteLine( "Setting sliderMode to false." );
			}
		}

		public void closePlayer()
		{
			control.ClosePlayer();
		}

		public string open2DFile()
		{
			//TODO move this code the the control_functions class

			string filename;
			DialogResult result;
			OpenFileDialog tempclass = new OpenFileDialog();
			tempclass.Title = "Select a 3D File to Open:";

			result = tempclass.ShowDialog();

			if (result == DialogResult.OK)
			{
			    filename = tempclass.FileName;
			    control.OpenFile(filename.ToString());
			    control.SetVolume(0.0);
			    control.SetZoom(100.0);
				return tempclass.FileName.ToString();
			}
			else
			{
			    Error_Result tempclass2 = new Error_Result("Unable to proceed without a specified file");
			    tempclass2.ShowDialog();
				return "ERROR: NoFileOpened";
			}
		}

		public string open3DFile()
		{
			//TODO move this code the the control_functions class

			string filename;
			DialogResult result;
			OpenFileDialog tempclass = new OpenFileDialog();


			tempclass.Title = "Select a 3D Video File to Open:";
			result = tempclass.ShowDialog();

			if (result == DialogResult.OK)
			{
				filename = tempclass.FileName;
				control.OpenFile( filename.ToString() );
				control.SetVolume( 0.0 );
				control.SetZoom( 100.0 );
				return tempclass.FileName.ToString();
			}
			else
			{
				Error_Result tempclass2 = new Error_Result( "Unable to proceed without a specified file" );
				tempclass2.ShowDialog();
				return "ERROR: NoFileOpened";
			}
		}

		public string open_LR_files_control()
		{
			int multi_result;
			Select_MultiFile_Format multi_dialog = new Select_MultiFile_Format();
			multi_dialog.ShowDialog();
			multi_result = multi_dialog.return_value;


			DialogResult result;
			string leftfile = "";
			string rightfile = "";
			AudioMode audiomode = AudioMode.AudioMode_NoAudio;
			string audiofile = "";
			string return_string = "empty";
			bool proceed = true;

			OpenFileDialog opendlg = new OpenFileDialog();

			opendlg.Title = "Select Left Eye Video File to view";
			result = opendlg.ShowDialog();
			if (result == DialogResult.OK)
			{
				leftfile = opendlg.FileName.ToString();
				return_string = leftfile;
			}
			else if (result == DialogResult.Cancel && proceed == true)
			{
				return_string = "Cancelled by user";
				proceed = false;
				return return_string;
			}

			if (proceed == true)
			{
				opendlg.Title = "Select Right Eve Video File to view";
				result = opendlg.ShowDialog();
				if (result == DialogResult.OK && proceed == true)
				{
					rightfile = opendlg.FileName.ToString();
					return_string = return_string + ", " + rightfile;
				}
				else if (result == DialogResult.Cancel)
				{
					return_string = "Cancelled by user";
					proceed = false;
					return return_string;
				}
			}

			if (multi_result == 0)
			{
				return_string = "ERROR: Unable to determine audio/video selection";
				proceed = false;
				return return_string;
			}

			if (multi_result == 4 && proceed == true)
			{
				opendlg.Title = "Select Audio file";
				result = opendlg.ShowDialog();

				if (result == DialogResult.OK)
				{
					audiofile = opendlg.FileName.ToString();
					return_string = return_string + ", " + audiofile;
				}
				else
				{
					proceed = false;
					return_string = "Cancelled by User";
					return return_string;
				}
			}

			if (multi_result == 1&& proceed == true)
			{
				audiomode = AudioMode.AudioMode_NoAudio;
				return_string = return_string + " AudioMode: No Audio";
			}

			else if (multi_result == 2 && proceed == true)
			{
				audiomode = AudioMode.AudioMode_LeftFile;
				return_string = return_string + " AudioMode: Left";
			}
			else if (multi_result == 3 && proceed == true)
			{
				audiomode = AudioMode.AudioMode_RightFile;
				return_string = return_string + " AudioMode: Right";
			}

			else
			{
				audiomode = AudioMode.AudioMode_SeparateFile;
				return_string = return_string + " AudioMode: Separate";
			}

			control.OpenLeftRightFiles( leftfile, rightfile, audiofile, audiomode );
			control.SetPlaybackState( PlaybackState.PlaybackState_Play );
			control.SetZoom( zoom );
			control.SetVolume( 0.0 );

			return return_string;
		}

		public double getDuration()
		{
			object tempResult;

			control.GetDuration( out tempResult );
			duration = (double)tempResult;

			return duration;
		}

		public void setPlaybackPosition( double input )
		{
			control.SetPosition( input );
			control.SetPlaybackState( PlaybackState.PlaybackState_Play );
		}

#region Global-type Variables
		private StereoPlayer.IAutomation control;
		protected bool play;
		protected bool pause;
		protected bool stop;
		protected bool fullscreen;
		public bool sliderMode;
		protected bool ready;
		protected bool debug;
		protected double zoom;
		public double duration = 0;

#endregion
	}

}