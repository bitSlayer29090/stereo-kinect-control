namespace PanelViewer
{
	partial class Select_MultiFile_Format
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Select_MultiFile_Format ) );
			this.description_text = new System.Windows.Forms.Label();
			this.no_audio = new System.Windows.Forms.Button();
			this.left_audio = new System.Windows.Forms.Button();
			this.right_audio = new System.Windows.Forms.Button();
			this.sep_audio = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// description_text
			// 
			this.description_text.AutoSize = true;
			this.description_text.Location = new System.Drawing.Point( 40, 48 );
			this.description_text.Name = "description_text";
			this.description_text.Size = new System.Drawing.Size( 214, 13 );
			this.description_text.TabIndex = 0;
			this.description_text.Text = "Select the audio format for this video set up:";
			// 
			// no_audio
			// 
			this.no_audio.Location = new System.Drawing.Point( 43, 104 );
			this.no_audio.Name = "no_audio";
			this.no_audio.Size = new System.Drawing.Size( 101, 23 );
			this.no_audio.TabIndex = 1;
			this.no_audio.Text = "No Audio";
			this.no_audio.UseVisualStyleBackColor = true;
			this.no_audio.Click += new System.EventHandler( this.set_no_audio );
			// 
			// left_audio
			// 
			this.left_audio.Location = new System.Drawing.Point( 194, 104 );
			this.left_audio.Name = "left_audio";
			this.left_audio.Size = new System.Drawing.Size( 101, 23 );
			this.left_audio.TabIndex = 2;
			this.left_audio.Text = "Left Video Audio";
			this.left_audio.UseVisualStyleBackColor = true;
			this.left_audio.Click += new System.EventHandler( this.set_left_audio );
			// 
			// right_audio
			// 
			this.right_audio.Location = new System.Drawing.Point( 337, 104 );
			this.right_audio.Name = "right_audio";
			this.right_audio.Size = new System.Drawing.Size( 101, 23 );
			this.right_audio.TabIndex = 3;
			this.right_audio.Text = "Right Video Audio";
			this.right_audio.UseVisualStyleBackColor = true;
			this.right_audio.Click += new System.EventHandler( this.set_right_audio );
			// 
			// sep_audio
			// 
			this.sep_audio.Location = new System.Drawing.Point( 466, 104 );
			this.sep_audio.Name = "sep_audio";
			this.sep_audio.Size = new System.Drawing.Size( 101, 23 );
			this.sep_audio.TabIndex = 4;
			this.sep_audio.Text = "Separate File";
			this.sep_audio.UseVisualStyleBackColor = true;
			this.sep_audio.Click += new System.EventHandler( this.set_sep_audio );
			// 
			// Select_MultiFile_Format
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 618, 148 );
			this.ControlBox = false;
			this.Controls.Add( this.sep_audio );
			this.Controls.Add( this.right_audio );
			this.Controls.Add( this.left_audio );
			this.Controls.Add( this.no_audio );
			this.Controls.Add( this.description_text );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Select_MultiFile_Format";
			this.ShowInTaskbar = false;
			this.Text = "Select Audio/Video Format";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label description_text;
		private System.Windows.Forms.Button no_audio;
		private System.Windows.Forms.Button left_audio;
		private System.Windows.Forms.Button right_audio;
		private System.Windows.Forms.Button sep_audio;
	}
}