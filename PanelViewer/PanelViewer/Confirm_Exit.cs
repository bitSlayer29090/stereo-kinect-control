using System;
using System.Windows.Forms;

namespace PanelViewer
{
    public partial class Confirm_Exit : Form
    {
        public Confirm_Exit()
        {
            InitializeComponent();
        }

        private void app_confirm_exit(object sender, EventArgs e)
        {
			StereoPlayer.IAutomation temp = new StereoPlayer.Automation();

			temp.ClosePlayer();

			this.Close();
			Application.Exit();
            
        }

        private void confirm_no_exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
