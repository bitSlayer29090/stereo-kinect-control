namespace PanelViewer
{
    partial class Confirm_Exit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Confirm_Exit ) );
			this.label1 = new System.Windows.Forms.Label();
			this.confirm_yes = new System.Windows.Forms.Button();
			this.confirm_no = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 137, 57 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 219, 13 );
			this.label1.TabIndex = 1;
			this.label1.Text = "Are you sure you wish to exit the application?";
			// 
			// confirm_yes
			// 
			this.confirm_yes.Location = new System.Drawing.Point( 155, 103 );
			this.confirm_yes.Name = "confirm_yes";
			this.confirm_yes.Size = new System.Drawing.Size( 75, 23 );
			this.confirm_yes.TabIndex = 2;
			this.confirm_yes.Text = "Yes";
			this.confirm_yes.UseVisualStyleBackColor = true;
			this.confirm_yes.Click += new System.EventHandler( this.app_confirm_exit );
			// 
			// confirm_no
			// 
			this.confirm_no.Location = new System.Drawing.Point( 262, 104 );
			this.confirm_no.Name = "confirm_no";
			this.confirm_no.Size = new System.Drawing.Size( 75, 23 );
			this.confirm_no.TabIndex = 3;
			this.confirm_no.Text = "No";
			this.confirm_no.UseVisualStyleBackColor = true;
			this.confirm_no.Click += new System.EventHandler( this.confirm_no_exit );
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PanelViewer.Properties.Resources.new_mu_bell1;
			this.pictureBox1.Location = new System.Drawing.Point( 12, 12 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size( 100, 114 );
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Confirm_Exit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 408, 139 );
			this.ControlBox = false;
			this.Controls.Add( this.confirm_no );
			this.Controls.Add( this.confirm_yes );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.pictureBox1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Confirm_Exit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Marquette CVTEC Lab - Cardiovascular Research";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_yes;
        private System.Windows.Forms.Button confirm_no;
    }
}