namespace PanelViewer
{
    partial class Error_Result
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Error_Result ) );
			this.error_lower_panel = new System.Windows.Forms.Panel();
			this.confirm = new System.Windows.Forms.Button();
			this.header_text = new System.Windows.Forms.Label();
			this.error_icon = new System.Windows.Forms.PictureBox();
			this.error_full_description = new System.Windows.Forms.Label();
			this.error_lower_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.error_icon)).BeginInit();
			this.SuspendLayout();
			// 
			// error_lower_panel
			// 
			this.error_lower_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.error_lower_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.error_lower_panel.Controls.Add( this.confirm );
			this.error_lower_panel.Location = new System.Drawing.Point( 0, 148 );
			this.error_lower_panel.Name = "error_lower_panel";
			this.error_lower_panel.Size = new System.Drawing.Size( 529, 51 );
			this.error_lower_panel.TabIndex = 0;
			// 
			// confirm
			// 
			this.confirm.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
			this.confirm.Location = new System.Drawing.Point( 440, 5 );
			this.confirm.Name = "confirm";
			this.confirm.Size = new System.Drawing.Size( 75, 32 );
			this.confirm.TabIndex = 0;
			this.confirm.Text = "OK";
			this.confirm.UseVisualStyleBackColor = true;
			this.confirm.Click += new System.EventHandler( this.acknowlge_error_ok );
			// 
			// header_text
			// 
			this.header_text.AutoSize = true;
			this.header_text.Font = new System.Drawing.Font( "Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
			this.header_text.ForeColor = System.Drawing.Color.Blue;
			this.header_text.Location = new System.Drawing.Point( 130, 38 );
			this.header_text.Name = "header_text";
			this.header_text.Size = new System.Drawing.Size( 147, 21 );
			this.header_text.TabIndex = 1;
			this.header_text.Text = "Unable to Open File";
			// 
			// error_icon
			// 
			this.error_icon.Image = ((System.Drawing.Image)(resources.GetObject( "error_icon.Image" )));
			this.error_icon.Location = new System.Drawing.Point( 30, 23 );
			this.error_icon.Name = "error_icon";
			this.error_icon.Size = new System.Drawing.Size( 85, 78 );
			this.error_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.error_icon.TabIndex = 4;
			this.error_icon.TabStop = false;
			// 
			// error_full_description
			// 
			this.error_full_description.AutoSize = true;
			this.error_full_description.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
			this.error_full_description.Location = new System.Drawing.Point( 134, 63 );
			this.error_full_description.Name = "error_full_description";
			this.error_full_description.Size = new System.Drawing.Size( 38, 15 );
			this.error_full_description.TabIndex = 3;
			this.error_full_description.Text = "label1";
			// 
			// Error_Result
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 527, 197 );
			this.ControlBox = false;
			this.Controls.Add( this.error_full_description );
			this.Controls.Add( this.error_icon );
			this.Controls.Add( this.header_text );
			this.Controls.Add( this.error_lower_panel );
			this.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Error_Result";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error";
			this.error_lower_panel.ResumeLayout( false );
			((System.ComponentModel.ISupportInitialize)(this.error_icon)).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel error_lower_panel;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label header_text;
        private System.Windows.Forms.PictureBox error_icon;
        private System.Windows.Forms.Label error_full_description;
    }
}