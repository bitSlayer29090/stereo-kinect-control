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

	}
}
