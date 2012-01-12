using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using NITE;
using OpenNI;

namespace PanelViewer
{
	public partial class ViewingPaneForm : Form
	{

		//constructor function
		public ViewingPaneForm()
		{
			InitializeComponent();
			
			#region Initializations
			CheckForIllegalCrossThreadCalls = false;
			this.context = Context.CreateFromXmlFile( SAMPLE_XML_FILE, out this.scriptNode );
			this.sessionManager = new NITE.SessionManager( this.context, "Wave,Click", "RaiseHand" );
			this.Instruction_Display.Text = "Connected to the Kinect Camera";
			this.depth = context.FindExistingNode( NodeType.Depth ) as DepthGenerator;
			if (this.depth == null)
			{
				throw new Exception( "Viewer must have a depth node!" );
			}
			this.hands = context.FindExistingNode( NodeType.Hands ) as HandsGenerator;
			this.hands.SetSmoothing( 0.8f );
			#endregion

			#region Setup Components
			pushDetector = new PushDetector( "PushDetector" );
			aux_pushDect = new PushDetector( "Auxilary Push Detector" );
			slider = new SelectableSlider1D( 1, Axis.X );
			swipeDetector = new SwipeDetector( "SwipeDectector" );
			steadyDetector = new SteadyDetector( 350, 15 );
			broadcaster = new Broadcaster( "Broadcaster" );
			aux_broadcaster = new Broadcaster( "Auxilary Broadcaster" );
			router = new FlowRouter( "router" ); 
			#endregion

			#region SignalRouting
			this.sessionManager.AddListener( this.router );
			this.router.ActiveListener = this.steadyDetector;

			this.broadcaster.AddListener( pushDetector );
			this.broadcaster.AddListener( swipeDetector );

			this.aux_broadcaster.AddListener( this.slider );
			this.aux_broadcaster.AddListener( this.aux_pushDect );
			#endregion

			#region SetUp Drawing Function
			this.histogram = new int[this.depth.DeviceMaxDepth];
			MapOutputMode mapMode = this.depth.MapOutputMode;
			this.bitmap = new Bitmap( (int)mapMode.XRes, (int)mapMode.YRes, System.Drawing.Imaging.PixelFormat.Format24bppRgb );
			this.shouldRun = true;
			this.readerThread = new Thread( RenderThread );
			this.readerThread.Start(); 
			#endregion

			#region setProp values

			vars = new configurationVars();
			this.sessionManager.PrimaryStaticTimeout = 7;
			vars.SteadyReq = 1000;
			vars.SteadyStddevReq = 1;
			vars.SwipeVelmin = 0.2f;
			vars.SwipeMinDuration = 500;
			vars.SwipeXangle = 45;
			vars.SwipeYangle = 45;
			vars.CircleMaxError = 2;
			vars.CircleRadMin = 80;
			vars.SliderHeight = 100;
			vars.SliderWidth = 200;
			vars.SwipeUseSteady = true;
			vars.SwipeSteadyDur = 75;

			this.populateConfiguration();
			this.customizeSwipe();
			this.customizeSteady();
			this.customizeCircle();
			#endregion

			#region Event Registration
			this.sessionManager.SessionStart += new EventHandler<PositionEventArgs>( sessionManager_SessionStart );
			this.sessionManager.SessionFocusProgress += new EventHandler<SessionProgressEventArgs>( sessionManager_SessionFocusProgress );
			this.sessionManager.SessionEnd += new EventHandler( sessionManager_SessionEnd );
			this.hands.HandDestroy += new EventHandler<HandDestroyEventArgs>( hands_HandDestroy );
			this.hands.HandCreate += new EventHandler<HandCreateEventArgs>( hands_HandCreate );
			this.pushDetector.Push += new EventHandler<VelocityAngleEventArgs>( pushDetector_Push );
			this.swipeDetector.SwipeRight += new EventHandler<VelocityAngleEventArgs>( swipeDetector_SwipeRight );
			this.swipeDetector.SwipeLeft += new EventHandler<VelocityAngleEventArgs>( swipeDetector_SwipeLeft );
			this.swipeDetector.SwipeUp += new EventHandler<VelocityAngleEventArgs>( swipeDetector_SwipeUp );
			this.swipeDetector.SwipeDown += new EventHandler<VelocityAngleEventArgs>( swipeDetector_SwipeDown );
			this.steadyDetector.Steady += new EventHandler<SteadyEventArgs>( steadyDetector_Steady );
			this.slider.ValueChange += new EventHandler<ValueEventArgs>( slider_ValueChange );
			this.aux_pushDect.Push += new EventHandler<VelocityAngleEventArgs>( aux_pushDect_Push );


			//aux_pushDect.
			#endregion
		}

		#region Non Event Handling Functions

		private void customizeSwipe()
		{
			swipeDetector.MinimumVelocity = vars.SwipeVelmin;
			swipeDetector.Duration = vars.SwipeMinDuration;
			swipeDetector.XAngleThreshold = vars.SwipeXangle;
			swipeDetector.YAngleThreshold = vars.SwipeYangle;
			swipeDetector.UseSteady = vars.SwipeUseSteady;
			swipeDetector.SteadyDuration = vars.SwipeSteadyDur;

			if (debug == true)
			{
				_print = true;
				debug_text = "Finished customizing the swipe detector";
			}
		}

		private void customizeSteady()
		{
			this.steadyDetector.DetectionDuration = vars.SteadyReq;
			if (debug == true)
			{
				_print = true;
				debug_text = "Configured steady detector : " + vars.SteadyReq.ToString();
			}

		}

		private void customizeCircle()
		{


			//circleDectector.MinRadius = vars.CircleRadMin;
			//circleDectector.MaxErrors = vars.CircleMaxError;

			if (debug == true)
			{
				_print = true;
				debug_text = "Finished customizing the circle detector";
			}


		}

		private void customizeSlider()
		{
			this.slider.SliderSize = vars.SliderWidth;
			this.slider.BorderWidth = vars.SliderHeight;

			_print = true;
			debug_text = "Customize slider Width: " + vars.SliderWidth.ToString();
		}

		private void populateConfiguration()
		{
			config.form_circle_minrad.Text = vars.CircleRadMin.ToString();
			config.form_circle_sensitivity.Text = vars.CircleMaxError.ToString();
			config.form_slider_height.Text = vars.SliderHeight.ToString();
			config.form_slider_width.Text = vars.SliderWidth.ToString();
			config.form_swipe_duration.Text = vars.SwipeMinDuration.ToString();
			config.form_swipe_minvel.Text = vars.SwipeVelmin.ToString();
			config.form_swipe_xangle.Text = vars.SwipeXangle.ToString();
			config.form_swipe_yangle.Text = vars.SwipeYangle.ToString();
			config.form_steadyduration_val.Text = vars.SteadyReq.ToString();
			config.form_steady_stddev.Text = vars.SteadyStddevReq.ToString();
		}

		#endregion

		#region Gesture Event Handlers
		void circleDectector_OnCircle( object sender, CircleEventArgs e )
		{
			circleDectector.Reset();

			if (debug == true)
			{
				_print = true;
				debug_text = "Circle detected";
			}
		}

		void swipeDetector_SwipeDown( object sender, VelocityAngleEventArgs e )
		{
			control.decreaseZoom();

			if (debug == true)
			{
				_print = true;
				debug_text = "Downward swipe detected";
			}
			this.router.ActiveListener = this.steadyDetector;
			this.gesture_display.Text = "Swipe Down";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/arrow_down.ico" );
		}

		void swipeDetector_SwipeUp( object sender, VelocityAngleEventArgs e )
		{
			control.increaseZoom();

			if (debug == true)
			{
				_print = true;
				debug_text = "Upward swipe detected";
			}

			this.router.ActiveListener = this.steadyDetector;
			this.gesture_display.Text = "Upward Swipe";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/arrow_up.ico" );
		}

		void swipeDetector_SwipeLeft( object sender, VelocityAngleEventArgs e )
		{
			control.toggleFullscreen();

			if (debug == true)
			{
				_print = true;
				debug_text = "Left swipe detected.";
			}
			this.router.ActiveListener = this.steadyDetector;

			this.gesture_display.Text = "Left Swipe";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/arrow_left.ico" );

		}

		void swipeDetector_SwipeRight( object sender, VelocityAngleEventArgs e )
		{
			control.togglePlay();

			if (debug == true)
			{
				this._print = true;
				this.debug_text = "Right swipe detected";
			}
			this.router.ActiveListener = this.steadyDetector;
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/arrow_right.ico" );
			this.gesture_display.Text = "Right Swipe";

			if (control._play == true)
			{
				this.play_status_icon.Image = Bitmap.FromFile( "../../CVTEC Resources/play.ico" );
			}
			else if (control._pause == true)
			{
				this.play_status_icon.Image = Bitmap.FromFile( "../../CVTEC Resources/pause.ico" );
			}

		}

		void pushDetector_Push( object sender, VelocityAngleEventArgs e )
		{
			if (control.sliderMode == true)
			{
				control.setPlaybackPosition( playback_position );
				this.router.ActiveListener = this.steadyDetector;
				control.leaveSliderMode();

				if (debug == true)
				{
					_print = true;
					debug_text = "Leaving Slider Mode and setting playback position--setting active listener to Steady Detector";
				}
			}
			else if (control.sliderMode == false)
			{
				this.router.ActiveListener = this.steadyDetector;
				control.enterSliderMode();

				if (debug == true)
				{
					_print = true;
					debug_text = "Entering slider mode; use hand to set a position";
				}

			}

			if (debug == true)
			{
				this._print = true;
				this.debug_text = "Push event detected";
			}

			this.gesture_display.Text = "Push Gesture";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/delete.ico" );
		}

		void slider_ValueChange( object sender, ValueEventArgs e )
		{
			if (debug == true)
			{
				_print = true;
				debug_text = "Slider Value: " + 100 * e.Value + "%";
			}

			this.playback_position = e.Value * control.duration;

		}

		void aux_pushDect_Push( object sender, VelocityAngleEventArgs e )
		{

			control.setPlaybackPosition( playback_position );
			this.router.ActiveListener = this.steadyDetector;
			control.leaveSliderMode();

			if (debug == true)
			{
				_print = true;
				debug_text = "Leaving Slider Mode and setting playback position--setting active listener to Steady Detector";
			}
		}

		void steadyDetector_Steady( object sender, SteadyEventArgs e )
		{


			if (control.sliderMode == true)
			{
				this.router.ActiveListener = this.aux_broadcaster;
				if (debug == true)
				{
					_print = true;
					debug_text = "Steady point - setting Listener to Auxilary Broadcast";
				}
			}
			else
			{
				this.router.ActiveListener = this.broadcaster;
				if (debug == true)
				{
					_print = true;
					debug_text = "Steady point - setting Listener to Primary Broadcast";
				}
			}

			this.gesture_display.Text = "Steady";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/link.ico" );
		}
		#endregion

		#region SessionManager Event Handlers

		void hands_HandCreate( object sender, HandCreateEventArgs e )
		{
			_print = true;
			debug_text = "hand created";
			this.router.ActiveListener = this.steadyDetector;
		}

		void hands_HandDestroy( object sender, HandDestroyEventArgs e )
		{
			_print = true;
			debug_text = "hand destroyed";
			this.router.ActiveListener = null;
			this.state = SessionState.QUICK_REFOCUS;

			this.gesture_display.Text = "Must be in Session";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/exclamation.ico" );
		}

		void sessionManager_SessionEnd( object sender, EventArgs e )
		{
			if (debug == true)
			{
				_print = true;
				debug_text = "Session has ended";
				Console.WriteLine( "Not in Session" );
			}

			state = SessionState.NOT_IN_SESSION;
		}

		void sessionManager_SessionFocusProgress( object sender, SessionProgressEventArgs e )
		{

			if (debug == true)
			{
				_print = true;
				debug_text = "Gesture progress: " + 100 * e.Progress + "%";
				Console.WriteLine( "Progress: {0}%", 100 * e.Progress );
			}


		}

		void sessionManager_SessionStart( object sender, PositionEventArgs e )
		{
			if (debug == true)
			{
				_print = true;
				debug_text = "Session has begun";
				Console.WriteLine( "In Session" );
			}

			state = SessionState.IN_SESSION;

		}

		#endregion

		#region DepthMap Rendering Functions

		private unsafe void CalcHist( DepthMetaData depthMD )
		{
			// reset
			for (int i = 0; i < this.histogram.Length; ++i)
				this.histogram[i] = 0;

			ushort* pDepth = (ushort*)depthMD.DepthMapPtr.ToPointer();

			int points = 0;
			for (int y = 0; y < depthMD.YRes; ++y)
			{
				for (int x = 0; x < depthMD.XRes; ++x, ++pDepth)
				{
					ushort depthVal = *pDepth;
					if (depthVal != 0)
					{
						this.histogram[depthVal]++;
						points++;
					}
				}
			}

			for (int i = 1; i < this.histogram.Length; i++)
			{
				this.histogram[i] += this.histogram[i - 1];
			}

			if (points > 0)
			{
				for (int i = 1; i < this.histogram.Length; i++)
				{
					this.histogram[i] = (int)(1024 * (1.0f - (this.histogram[i] / (float)points)));
				}
			}
		}

		private unsafe void RenderThread()
		{
			DepthMetaData depthMD = new DepthMetaData();

			while (this.shouldRun)
			{
				try
				{
					this.context.WaitOneUpdateAll( this.depth );
				}
				catch (Exception)
				{
				}

				this.depth.GetMetaData( depthMD );

				CalcHist( depthMD );

				lock (this)
				{
					Rectangle rect = new Rectangle( 0, 0, this.bitmap.Width, this.bitmap.Height );
					BitmapData data = this.bitmap.LockBits( rect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb );

					ushort* pDepth = (ushort*)this.depth.DepthMapPtr.ToPointer();

					// set pixels
					for (int y = 0; y < depthMD.YRes; ++y)
					{
						byte* pDest = (byte*)data.Scan0.ToPointer() + y * data.Stride;
						for (int x = 0; x < depthMD.XRes; ++x, ++pDepth, pDest += 3)
						{
							byte pixel = (byte)this.histogram[*pDepth];
							pDest[0] = 0;
							pDest[1] = pixel;
							pDest[2] = pixel;
						}
					}

					this.bitmap.UnlockBits( data );
					FPS_Temp = depthMD.FPS;
				}

				this.Invalidate();
				this.sessionManager.Update( this.context );
			}
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			base.OnPaint( e );

			lock (this)
			{
				e.Graphics.DrawImage( this.bitmap,
					this.panelViewer.Location.X,
					this.panelViewer.Location.Y,
					this.panelViewer.Size.Width,
					this.panelViewer.Size.Height );
			}
		}

		protected override void OnPaintBackground( PaintEventArgs pevent )
		{
			//TODO make the play_status_icon object update only when changed

			if (this.state == SessionState.IN_SESSION)
			{
				this.Instruction_Display.Text = "In Session";
				this.Instruction_Display.Image = Bitmap.FromFile( "../../CVTEC Resources/accept.ico" );
			}

			else if (this.state == SessionState.NOT_IN_SESSION)
			{
				this.Instruction_Display.Text = "Not In Session";
				this.Instruction_Display.Image = Bitmap.FromFile( "../../CVTEC Resources/warning.ico" );
			}

			else if (this.state == SessionState.QUICK_REFOCUS)
			{
				this.Instruction_Display.Text = "Quick Refocus - Raise Hand";
				this.Instruction_Display.Image = Bitmap.FromFile( "../../CVTEC Resources/help.ico" );
			}

			FPS_Display.Text = "Frames Per Second: " + FPS_Temp.ToString();
			FPS_Bar.Value = FPS_Temp;

			if (_print == true)
			{
				this.debugBox.AppendText( "\r\n" + debug_text );
				_print = false;
			}

			if (config._newvalues == true)
			{
				if (debug == true)
				{
					_print = true;
					debug_text = "NEW VALUES FROM CONFIGURATION FILE";
				}

				vars.SteadyStddevReq = config._steady_stddev;
				vars.SteadyReq = config._steady_duration;
				vars.SwipeMinDuration = config._swipe_duration;
				vars.SwipeSteadyDur = config._swipe_steadyDur;
				vars.SwipeUseSteady = config._swipe_usesteay;
				vars.SwipeVelmin = config._swipe_vel;
				vars.SwipeXangle = config._swipe_xangle;
				vars.SwipeYangle = config._swipe_yangle;
				vars.CircleMaxError = config._circle_maxerr;
				vars.CircleRadMin = config._circle_radmin;
				vars.SliderHeight = config._slider_height;
				vars.SliderWidth = config._slider_width;

				this.customizeCircle();
				//this.customizeSlider();
				this.customizeSteady();
				this.customizeSwipe();
				config._newvalues = false;
			}

		}

		protected override void OnClosing( CancelEventArgs e )
		{
			this.shouldRun = false;
			this.readerThread.Join();
			base.OnClosing( e );
		}

		protected override void OnKeyPress( KeyPressEventArgs e )
		{
			if (e.KeyChar == 27)
			{
				Close();
			}
			base.OnKeyPress( e );
		}

		#endregion

		#region Main Window Form Event Handlers

		private void ViewingPane_Load( object sender, EventArgs e )
		{
			this.Height = 730;
			this.Width = 680;
			this.debugBox.Visible = true;
			this.toggle_Debug_switch.Checked = true;
			this.toggle_Debug_switch.CheckState = CheckState.Checked;
			this.debug = true;
		}

		private void main_window_exit( object sender, EventArgs e )
		{

			this.gesture_display.Text = "Exiting Application";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/shut_down.ico" );

			control.closePlayer();
			Application.Exit();
			Environment.Exit( 0 );
		}

		private void toggle_debug( object sender, EventArgs e )
		{
			if (this.toggle_Debug_switch.CheckState == CheckState.Checked)
			{
				debug = true;
				debugBox.Visible = true;
				debugBox.Update();
				this.Height = 730;
				this.Width = 680;
				this.Refresh();

			}
			else if (this.toggle_Debug_switch.CheckState == CheckState.Unchecked)
			{
				debug = false;
				debugBox.Visible = false;
				debugBox.Update();
				this.Height = 580;
				this.Width = 680;
				this.Refresh();
			}
			else
			{
				debug = false;
				debugBox.Visible = false;
				debugBox.Update();
				this.Height = 580;
				this.Width = 680;
			}
		}

		private void form_form_2d( object sender, EventArgs e )
		{
			string result;
			result = control.open2DFile();
			control.duration = control.getDuration();

			if(debug == true)
			{
				_print = true;
				debug_text = "SUCCESS: " + result;
				//debug_text = playback_position.ToString();
			}

			this.gesture_display.Text = "Successfully opened file";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/add.ico" );
			this.play_status_icon.Image = Bitmap.FromFile( "../../CVTEC Resources/add.ico" );


		}

		private void form_open_LR( object sender, EventArgs e )
		{
			string result;
			result = control.open_LR_files_control();
			control.duration = control.getDuration();

			//print the results of the open file command
			if (debug == true)
			{
				_print = true;
				debug_text = "SUCCESS: " + result;
			}

			this.gesture_display.Text = "Successfully opened file";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/add.ico" );
			this.play_status_icon.Image = Bitmap.FromFile( "../../CVTEC Resources/add.ico" );
		}

		private void form_open3d( object sender, EventArgs e )
		{
			string result =	control.open3DFile();
			control.duration = control.getDuration();

			if (debug == true)
			{
				_print = true;
				debug_text = "SUCCESS: " + result;
			}

			this.gesture_display.Text = "Successfully opened file";
			this.gesture_display.Image = Bitmap.FromFile( "../../CVTEC Resources/add.ico" );
			this.play_status_icon.Image = Bitmap.FromFile( "../../CVTEC Resources/add.ico" );
		}

		private void form_open_folder( object sender, EventArgs e )
		{

		}

		private void click_mucvtec_about( object sender, EventArgs e )
		{
			About_Diag_Box abt_box = new About_Diag_Box();

			abt_box.ShowDialog();
		}

		private void form_configure_click( object sender, EventArgs e )
		{

			config.ShowDialog();
		}

		#endregion

		#region Member Variables
		private string debug_text = "";
		private readonly string SAMPLE_XML_FILE = @"../CVTEC-Tracking.xml";
		private Context context;
		private ScriptNode scriptNode;
		private DepthGenerator depth;
		private HandsGenerator hands;
		private Thread readerThread;
		private FlowRouter router;
		private bool shouldRun;
		private Bitmap bitmap;
		private int[] histogram;
		private NITE.SessionManager sessionManager;
		private NITE.Broadcaster broadcaster;
		private NITE.Broadcaster aux_broadcaster;
		public NITE.PushDetector pushDetector;
		public NITE.PushDetector aux_pushDect;
		public NITE.SwipeDetector swipeDetector;
		public NITE.CircleDetector circleDectector;
		public NITE.SteadyDetector steadyDetector;
		public NITE.SelectableSlider1D slider;
		Control_Functions control = new Control_Functions();
		config_dlg config = new config_dlg();
		configurationVars vars;
		protected bool gl_loaded = false;
		private bool debug = true;
		private SessionState state = SessionState.NOT_IN_SESSION;
		public int FPS_Temp;
		private bool _print = false;
		private double playback_position = 0;
		private bool _changed = false;
		public enum SessionState
		{
			NOT_IN_SESSION,
			IN_SESSION,
			QUICK_REFOCUS
		};
		#endregion

		private void force_kill_session( object sender, EventArgs e )
		{
			this.hands.StopTracking( 1 );
			this.state = SessionState.QUICK_REFOCUS;
		}
	}


}
