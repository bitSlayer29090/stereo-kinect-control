namespace PanelViewer
{
	partial class config_dlg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( config_dlg ) );
			this.form_steadyduration_val = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip( this.components );
			this.SuspendLayout();
			// 
			// form_steadyduration_val
			// 
			this.form_steadyduration_val.Location = new System.Drawing.Point( 95, 53 );
			this.form_steadyduration_val.Name = "form_steadyduration_val";
			this.form_steadyduration_val.Size = new System.Drawing.Size( 100, 20 );
			this.form_steadyduration_val.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 12, 56 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 83, 13 );
			this.label1.TabIndex = 1;
			this.label1.Text = "Steady Duration";
			// 
			// toolTip1
			// 
			this.toolTip1.Tag = "This is the instruction test";
			this.toolTip1.ToolTipTitle = "Steady Duration";
			this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler( this.toolTip1_Popup );
			// 
			// config_dlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 729, 339 );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.form_steadyduration_val );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "config_dlg";
			this.Text = "Configuration Options";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox form_steadyduration_val;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}