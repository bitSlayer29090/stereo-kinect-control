using System;
using System.Windows.Forms;

namespace PanelViewer
{
    public partial class Error_Result : Form
    {
        public Error_Result(string error_message)
        {
            InitializeComponent();
            error_full_description.Text = error_message.ToString();
        }

        private void acknowlge_error_ok(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
