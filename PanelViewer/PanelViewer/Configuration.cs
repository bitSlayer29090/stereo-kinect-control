using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PanelViewer
{
	public partial class config_dlg : Form
	{
		public config_dlg()
		{
			InitializeComponent();

			this.swipe_use_Steady.Checked = true;
			this.swipe_use_Steady.CheckState = CheckState.Checked;
		}

		private void config_cancel_button( object sender, EventArgs e )
		{
			this.Close();
		}

		private void saveAll()
		{
			this._steady_duration = int.Parse( form_steadyduration_val.Text.ToString() );
			this._steady_stddev = float.Parse( form_steady_stddev.Text.ToString() );
			this._swipe_duration = int.Parse( form_swipe_duration.Text.ToString() );
			this._swipe_steadyDur = int.Parse( form_steadyduration_val.Text.ToString() );
			this._swipe_vel = float.Parse( form_swipe_minvel.Text.ToString() );
			this._swipe_xangle = int.Parse( form_swipe_xangle.Text.ToString() );
			this._swipe_yangle = int.Parse( form_swipe_yangle.Text.ToString() );
			this._swipe_usesteay = bool.Parse( swipe_use_Steady.Checked.ToString() );
			this._circle_maxerr = int.Parse( form_circle_sensitivity.Text.ToString() );
			this._circle_radmin = int.Parse( form_circle_minrad.Text.ToString() );
			this._slider_height = float.Parse( form_slider_height.Text.ToString() );
			this._slider_width = float.Parse( form_slider_width.Text.ToString() );

			this._newvalues = true;
		}

		private void config_save_button( object sender, EventArgs e )
		{
			this.saveAll();
			this.Close();
		}

		private void swipe_duration_checkbox( object sender, EventArgs e )
		{
			if (this.swipe_use_Steady.Checked == true)
			{
				this.swipe_steady_duration.Enabled = true;
			}
			else
			{
				this.swipe_steady_duration.Enabled = false;
			}
		}


		#region ConfigurationVariables
		public int _steady_duration = 0;
		public float _steady_stddev = 0;
		public float _swipe_vel = 0;
		public int _swipe_duration = 0;
		public int _swipe_xangle = 0;
		public int _swipe_yangle = 0;
		public bool _swipe_usesteay = true;
		public int _swipe_steadyDur = 0;
		public int _circle_radmin = 0;
		public int _circle_maxerr = 0;
		public float _slider_height = 0;
		public float _slider_width = 0;
		public bool _newvalues = false;
		#endregion

	}
}
