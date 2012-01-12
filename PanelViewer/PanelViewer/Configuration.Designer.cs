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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( config_dlg ) );
			this.form_steadyduration_val = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.config_save = new System.Windows.Forms.Button();
			this.config_cancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.swipe_steady_duration = new System.Windows.Forms.TextBox();
			this.swipe_use_Steady = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// form_steadyduration_val
			// 
			this.form_steadyduration_val.Location = new System.Drawing.Point( 113, 23 );
			this.form_steadyduration_val.Name = "form_steadyduration_val";
			this.form_steadyduration_val.Size = new System.Drawing.Size( 100, 20 );
			this.form_steadyduration_val.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 14, 26 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 83, 13 );
			this.label1.TabIndex = 1;
			this.label1.Text = "Steady Duration";
			// 
			// config_save
			// 
			this.config_save.Location = new System.Drawing.Point( 24, 10 );
			this.config_save.Name = "config_save";
			this.config_save.Size = new System.Drawing.Size( 75, 23 );
			this.config_save.TabIndex = 2;
			this.config_save.Text = "Save";
			this.config_save.UseVisualStyleBackColor = true;
			this.config_save.Click += new System.EventHandler( this.config_save_button );
			// 
			// config_cancel
			// 
			this.config_cancel.Location = new System.Drawing.Point( 122, 10 );
			this.config_cancel.Name = "config_cancel";
			this.config_cancel.Size = new System.Drawing.Size( 75, 23 );
			this.config_cancel.TabIndex = 3;
			this.config_cancel.Text = "Cancel";
			this.config_cancel.UseVisualStyleBackColor = true;
			this.config_cancel.Click += new System.EventHandler( this.config_cancel_button );
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point( 13, 13 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 360, 34 );
			this.label2.TabIndex = 4;
			this.label2.Text = "Use this form to customize the performance of the Kinect Camera and its parameter" +
				"s for detecting gestures.";
			this.label2.UseMnemonic = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add( this.label5 );
			this.groupBox1.Controls.Add( this.label4 );
			this.groupBox1.Controls.Add( this.label3 );
			this.groupBox1.Controls.Add( this.textBox1 );
			this.groupBox1.Controls.Add( this.form_steadyduration_val );
			this.groupBox1.Controls.Add( this.label1 );
			this.groupBox1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
			this.groupBox1.Location = new System.Drawing.Point( 16, 50 );
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size( 357, 98 );
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Steady Detector";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 220, 59 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 29, 13 );
			this.label5.TabIndex = 5;
			this.label5.Text = "units";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 220, 29 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 88, 13 );
			this.label4.TabIndex = 4;
			this.label4.Text = "ms (default 1000)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 14, 56 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 98, 13 );
			this.label3.TabIndex = 3;
			this.label3.Text = "Standard Deviation";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point( 113, 53 );
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size( 100, 20 );
			this.textBox1.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add( this.label14 );
			this.groupBox2.Controls.Add( this.label13 );
			this.groupBox2.Controls.Add( this.label12 );
			this.groupBox2.Controls.Add( this.textBox5 );
			this.groupBox2.Controls.Add( this.label11 );
			this.groupBox2.Controls.Add( this.textBox2 );
			this.groupBox2.Controls.Add( this.label10 );
			this.groupBox2.Controls.Add( this.label9 );
			this.groupBox2.Controls.Add( this.textBox4 );
			this.groupBox2.Controls.Add( this.label8 );
			this.groupBox2.Controls.Add( this.label7 );
			this.groupBox2.Controls.Add( this.textBox3 );
			this.groupBox2.Controls.Add( this.label6 );
			this.groupBox2.Controls.Add( this.swipe_steady_duration );
			this.groupBox2.Controls.Add( this.swipe_use_Steady );
			this.groupBox2.Location = new System.Drawing.Point( 16, 154 );
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size( 357, 127 );
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Swipe Detector";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point( 252, 102 );
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size( 76, 13 );
			this.label14.TabIndex = 14;
			this.label14.Text = "ms (default 75)";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point( 220, 75 );
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size( 81, 13 );
			this.label13.TabIndex = 13;
			this.label13.Text = "deg (default 45)";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point( 162, 76 );
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size( 14, 13 );
			this.label12.TabIndex = 12;
			this.label12.Text = "Y";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point( 182, 73 );
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size( 31, 20 );
			this.textBox5.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point( 110, 76 );
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size( 14, 13 );
			this.label11.TabIndex = 10;
			this.label11.Text = "X";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point( 130, 73 );
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size( 31, 20 );
			this.textBox2.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point( 14, 76 );
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size( 89, 13 );
			this.label10.TabIndex = 8;
			this.label10.Text = "Max Angular Dev";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point( 220, 50 );
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size( 82, 13 );
			this.label9.TabIndex = 7;
			this.label9.Text = "ms (default 500)";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point( 113, 47 );
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size( 100, 20 );
			this.textBox4.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point( 14, 50 );
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size( 79, 13 );
			this.label8.TabIndex = 5;
			this.label8.Text = "Swipe Duration";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point( 220, 23 );
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size( 90, 13 );
			this.label7.TabIndex = 4;
			this.label7.Text = "m/s (default 0.20)";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point( 113, 20 );
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size( 100, 20 );
			this.textBox3.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point( 14, 23 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size( 88, 13 );
			this.label6.TabIndex = 2;
			this.label6.Text = "Minimum Velocity";
			// 
			// swipe_steady_duration
			// 
			this.swipe_steady_duration.Location = new System.Drawing.Point( 145, 99 );
			this.swipe_steady_duration.Name = "swipe_steady_duration";
			this.swipe_steady_duration.Size = new System.Drawing.Size( 100, 20 );
			this.swipe_steady_duration.TabIndex = 1;
			// 
			// swipe_use_Steady
			// 
			this.swipe_use_Steady.AutoSize = true;
			this.swipe_use_Steady.Location = new System.Drawing.Point( 14, 102 );
			this.swipe_use_Steady.Name = "swipe_use_Steady";
			this.swipe_use_Steady.Size = new System.Drawing.Size( 125, 17 );
			this.swipe_use_Steady.TabIndex = 0;
			this.swipe_use_Steady.Text = "Use Steady Detector";
			this.swipe_use_Steady.UseVisualStyleBackColor = true;
			this.swipe_use_Steady.CheckedChanged += new System.EventHandler( this.swipe_duration_checkbox );
			// 
			// panel1
			// 
			this.panel1.Controls.Add( this.config_cancel );
			this.panel1.Controls.Add( this.config_save );
			this.panel1.Location = new System.Drawing.Point( 16, 454 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size( 221, 43 );
			this.panel1.TabIndex = 7;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add( this.label21 );
			this.groupBox3.Controls.Add( this.label17 );
			this.groupBox3.Controls.Add( this.textBox7 );
			this.groupBox3.Controls.Add( this.textBox6 );
			this.groupBox3.Controls.Add( this.label16 );
			this.groupBox3.Controls.Add( this.label15 );
			this.groupBox3.Location = new System.Drawing.Point( 16, 287 );
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size( 357, 77 );
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Circle Detector";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point( 220, 50 );
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size( 112, 13 );
			this.label17.TabIndex = 4;
			this.label17.Text = "1 - 5 (1 most sensitive)";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point( 113, 47 );
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size( 100, 20 );
			this.textBox7.TabIndex = 3;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point( 113, 17 );
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size( 100, 20 );
			this.textBox6.TabIndex = 2;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point( 14, 50 );
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size( 54, 13 );
			this.label16.TabIndex = 1;
			this.label16.Text = "Sensitivity";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point( 14, 20 );
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size( 60, 13 );
			this.label15.TabIndex = 0;
			this.label15.Text = "Min Radius";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add( this.label22 );
			this.groupBox4.Controls.Add( this.label20 );
			this.groupBox4.Controls.Add( this.textBox9 );
			this.groupBox4.Controls.Add( this.textBox8 );
			this.groupBox4.Controls.Add( this.label19 );
			this.groupBox4.Controls.Add( this.label18 );
			this.groupBox4.Location = new System.Drawing.Point( 16, 370 );
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size( 357, 78 );
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Sliding Value Selector";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point( 14, 46 );
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size( 38, 13 );
			this.label19.TabIndex = 1;
			this.label19.Text = "Height";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point( 14, 19 );
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size( 35, 13 );
			this.label18.TabIndex = 0;
			this.label18.Text = "Width";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point( 113, 16 );
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size( 100, 20 );
			this.textBox8.TabIndex = 2;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point( 113, 39 );
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size( 100, 20 );
			this.textBox9.TabIndex = 3;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point( 223, 19 );
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size( 85, 13 );
			this.label20.TabIndex = 4;
			this.label20.Text = "mm (default 200)";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point( 223, 20 );
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size( 79, 13 );
			this.label21.TabIndex = 5;
			this.label21.Text = "mm (default 80)";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point( 223, 45 );
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size( 85, 13 );
			this.label22.TabIndex = 5;
			this.label22.Text = "mm (default 100)";
			// 
			// config_dlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 402, 502 );
			this.Controls.Add( this.groupBox4 );
			this.Controls.Add( this.groupBox3 );
			this.Controls.Add( this.panel1 );
			this.Controls.Add( this.groupBox2 );
			this.Controls.Add( this.groupBox1 );
			this.Controls.Add( this.label2 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "config_dlg";
			this.Text = "Configuration Options";
			this.groupBox1.ResumeLayout( false );
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout( false );
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout( false );
			this.groupBox3.ResumeLayout( false );
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout( false );
			this.groupBox4.PerformLayout();
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button config_save;
		private System.Windows.Forms.Button config_cancel;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox form_steadyduration_val;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox swipe_steady_duration;
		private System.Windows.Forms.CheckBox swipe_use_Steady;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label22;
	}
}