using System;
using System.Windows.Forms;

namespace PanelViewer
{
	public partial class Select_MultiFile_Format : Form
	{
		public Select_MultiFile_Format()
		{
			InitializeComponent();
		}

		public int return_value = 0;

		private void set_no_audio( object sender, EventArgs e )
		{
			return_value = 1;
			this.Close();
		}

		private void set_left_audio( object sender, EventArgs e )
		{
			return_value = 2;
			this.Close();

		}

		private void set_right_audio( object sender, EventArgs e )
		{
			return_value = 3;
			this.Close();
		}

		private void set_sep_audio( object sender, EventArgs e )
		{
			return_value = 4;
			this.Close();

		}
	}
}
