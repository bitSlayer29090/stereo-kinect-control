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
			this.steady_duration_label = new System.Windows.Forms.Label();
			this.config_save = new System.Windows.Forms.Button();
			this.config_cancel = new System.Windows.Forms.Button();
			this.instructions = new System.Windows.Forms.Label();
			this.steady_box = new System.Windows.Forms.GroupBox();
			this.steady_stddev_unit = new System.Windows.Forms.Label();
			this.steady_dur_units = new System.Windows.Forms.Label();
			this.stead_stddev_label = new System.Windows.Forms.Label();
			this.form_steady_stddev = new System.Windows.Forms.TextBox();
			this.swipe_box = new System.Windows.Forms.GroupBox();
			this.swipe_steady_duraion = new System.Windows.Forms.Label();
			this.swipe_angle_unit = new System.Windows.Forms.Label();
			this.swipe_yangle_label = new System.Windows.Forms.Label();
			this.form_swipe_yangle = new System.Windows.Forms.TextBox();
			this.swipe_xangle_label = new System.Windows.Forms.Label();
			this.form_swipe_xangle = new System.Windows.Forms.TextBox();
			this.swipe_angle_label = new System.Windows.Forms.Label();
			this.swipe_dura_unit = new System.Windows.Forms.Label();
			this.form_swipe_duration = new System.Windows.Forms.TextBox();
			this.swipe_duration_label = new System.Windows.Forms.Label();
			this.swipe_vel_unit = new System.Windows.Forms.Label();
			this.form_swipe_minvel = new System.Windows.Forms.TextBox();
			this.swipe_velocity_label = new System.Windows.Forms.Label();
			this.swipe_steady_duration = new System.Windows.Forms.TextBox();
			this.swipe_use_Steady = new System.Windows.Forms.CheckBox();
			this.button_panel = new System.Windows.Forms.Panel();
			this.circle_box = new System.Windows.Forms.GroupBox();
			this.circle_rad_unit = new System.Windows.Forms.Label();
			this.circle_sensi_unit = new System.Windows.Forms.Label();
			this.form_circle_sensitivity = new System.Windows.Forms.TextBox();
			this.form_circle_minrad = new System.Windows.Forms.TextBox();
			this.circle_sensitivity_label = new System.Windows.Forms.Label();
			this.circle_radius_label = new System.Windows.Forms.Label();
			this.slider_box = new System.Windows.Forms.GroupBox();
			this.slider_height_unit = new System.Windows.Forms.Label();
			this.slider_width_unit = new System.Windows.Forms.Label();
			this.form_slider_height = new System.Windows.Forms.TextBox();
			this.form_slider_width = new System.Windows.Forms.TextBox();
			this.slider_h_label = new System.Windows.Forms.Label();
			this.slider_w_label = new System.Windows.Forms.Label();
			this.steady_box.SuspendLayout();
			this.swipe_box.SuspendLayout();
			this.button_panel.SuspendLayout();
			this.circle_box.SuspendLayout();
			this.slider_box.SuspendLayout();
			this.SuspendLayout();
			// 
			// form_steadyduration_val
			// 
			this.form_steadyduration_val.Location = new System.Drawing.Point( 113, 23 );
			this.form_steadyduration_val.Name = "form_steadyduration_val";
			this.form_steadyduration_val.Size = new System.Drawing.Size( 100, 20 );
			this.form_steadyduration_val.TabIndex = 0;
			// 
			// steady_duration_label
			// 
			this.steady_duration_label.AutoSize = true;
			this.steady_duration_label.Location = new System.Drawing.Point( 14, 26 );
			this.steady_duration_label.Name = "steady_duration_label";
			this.steady_duration_label.Size = new System.Drawing.Size( 83, 13 );
			this.steady_duration_label.TabIndex = 1;
			this.steady_duration_label.Text = "Steady Duration";
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
			// instructions
			// 
			this.instructions.Location = new System.Drawing.Point( 13, 13 );
			this.instructions.Name = "instructions";
			this.instructions.Size = new System.Drawing.Size( 360, 34 );
			this.instructions.TabIndex = 4;
			this.instructions.Text = "Use this form to customize the performance of the Kinect Camera and its parameter" +
				"s for detecting gestures.";
			this.instructions.UseMnemonic = false;
			// 
			// steady_box
			// 
			this.steady_box.Controls.Add( this.steady_stddev_unit );
			this.steady_box.Controls.Add( this.steady_dur_units );
			this.steady_box.Controls.Add( this.stead_stddev_label );
			this.steady_box.Controls.Add( this.form_steady_stddev );
			this.steady_box.Controls.Add( this.form_steadyduration_val );
			this.steady_box.Controls.Add( this.steady_duration_label );
			this.steady_box.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
			this.steady_box.Location = new System.Drawing.Point( 16, 50 );
			this.steady_box.Name = "steady_box";
			this.steady_box.Size = new System.Drawing.Size( 357, 98 );
			this.steady_box.TabIndex = 5;
			this.steady_box.TabStop = false;
			this.steady_box.Text = "Steady Detector";
			// 
			// steady_stddev_unit
			// 
			this.steady_stddev_unit.AutoSize = true;
			this.steady_stddev_unit.Location = new System.Drawing.Point( 220, 59 );
			this.steady_stddev_unit.Name = "steady_stddev_unit";
			this.steady_stddev_unit.Size = new System.Drawing.Size( 29, 13 );
			this.steady_stddev_unit.TabIndex = 5;
			this.steady_stddev_unit.Text = "units";
			// 
			// steady_dur_units
			// 
			this.steady_dur_units.AutoSize = true;
			this.steady_dur_units.Location = new System.Drawing.Point( 220, 29 );
			this.steady_dur_units.Name = "steady_dur_units";
			this.steady_dur_units.Size = new System.Drawing.Size( 88, 13 );
			this.steady_dur_units.TabIndex = 4;
			this.steady_dur_units.Text = "ms (default 1000)";
			// 
			// stead_stddev_label
			// 
			this.stead_stddev_label.AutoSize = true;
			this.stead_stddev_label.Location = new System.Drawing.Point( 14, 56 );
			this.stead_stddev_label.Name = "stead_stddev_label";
			this.stead_stddev_label.Size = new System.Drawing.Size( 98, 13 );
			this.stead_stddev_label.TabIndex = 3;
			this.stead_stddev_label.Text = "Standard Deviation";
			// 
			// form_steady_stddev
			// 
			this.form_steady_stddev.Location = new System.Drawing.Point( 113, 53 );
			this.form_steady_stddev.Name = "form_steady_stddev";
			this.form_steady_stddev.Size = new System.Drawing.Size( 100, 20 );
			this.form_steady_stddev.TabIndex = 2;
			// 
			// swipe_box
			// 
			this.swipe_box.Controls.Add( this.swipe_steady_duraion );
			this.swipe_box.Controls.Add( this.swipe_angle_unit );
			this.swipe_box.Controls.Add( this.swipe_yangle_label );
			this.swipe_box.Controls.Add( this.form_swipe_yangle );
			this.swipe_box.Controls.Add( this.swipe_xangle_label );
			this.swipe_box.Controls.Add( this.form_swipe_xangle );
			this.swipe_box.Controls.Add( this.swipe_angle_label );
			this.swipe_box.Controls.Add( this.swipe_dura_unit );
			this.swipe_box.Controls.Add( this.form_swipe_duration );
			this.swipe_box.Controls.Add( this.swipe_duration_label );
			this.swipe_box.Controls.Add( this.swipe_vel_unit );
			this.swipe_box.Controls.Add( this.form_swipe_minvel );
			this.swipe_box.Controls.Add( this.swipe_velocity_label );
			this.swipe_box.Controls.Add( this.swipe_steady_duration );
			this.swipe_box.Controls.Add( this.swipe_use_Steady );
			this.swipe_box.Location = new System.Drawing.Point( 16, 154 );
			this.swipe_box.Name = "swipe_box";
			this.swipe_box.Size = new System.Drawing.Size( 357, 127 );
			this.swipe_box.TabIndex = 6;
			this.swipe_box.TabStop = false;
			this.swipe_box.Text = "Swipe Detector";
			// 
			// swipe_steady_duraion
			// 
			this.swipe_steady_duraion.AutoSize = true;
			this.swipe_steady_duraion.Location = new System.Drawing.Point( 252, 102 );
			this.swipe_steady_duraion.Name = "swipe_steady_duraion";
			this.swipe_steady_duraion.Size = new System.Drawing.Size( 76, 13 );
			this.swipe_steady_duraion.TabIndex = 14;
			this.swipe_steady_duraion.Text = "ms (default 75)";
			// 
			// swipe_angle_unit
			// 
			this.swipe_angle_unit.AutoSize = true;
			this.swipe_angle_unit.Location = new System.Drawing.Point( 220, 75 );
			this.swipe_angle_unit.Name = "swipe_angle_unit";
			this.swipe_angle_unit.Size = new System.Drawing.Size( 81, 13 );
			this.swipe_angle_unit.TabIndex = 13;
			this.swipe_angle_unit.Text = "deg (default 45)";
			// 
			// swipe_yangle_label
			// 
			this.swipe_yangle_label.AutoSize = true;
			this.swipe_yangle_label.Location = new System.Drawing.Point( 162, 76 );
			this.swipe_yangle_label.Name = "swipe_yangle_label";
			this.swipe_yangle_label.Size = new System.Drawing.Size( 14, 13 );
			this.swipe_yangle_label.TabIndex = 12;
			this.swipe_yangle_label.Text = "Y";
			// 
			// form_swipe_yangle
			// 
			this.form_swipe_yangle.Location = new System.Drawing.Point( 182, 73 );
			this.form_swipe_yangle.Name = "form_swipe_yangle";
			this.form_swipe_yangle.Size = new System.Drawing.Size( 31, 20 );
			this.form_swipe_yangle.TabIndex = 11;
			// 
			// swipe_xangle_label
			// 
			this.swipe_xangle_label.AutoSize = true;
			this.swipe_xangle_label.Location = new System.Drawing.Point( 110, 76 );
			this.swipe_xangle_label.Name = "swipe_xangle_label";
			this.swipe_xangle_label.Size = new System.Drawing.Size( 14, 13 );
			this.swipe_xangle_label.TabIndex = 10;
			this.swipe_xangle_label.Text = "X";
			// 
			// form_swipe_xangle
			// 
			this.form_swipe_xangle.Location = new System.Drawing.Point( 130, 73 );
			this.form_swipe_xangle.Name = "form_swipe_xangle";
			this.form_swipe_xangle.Size = new System.Drawing.Size( 31, 20 );
			this.form_swipe_xangle.TabIndex = 9;
			// 
			// swipe_angle_label
			// 
			this.swipe_angle_label.AutoSize = true;
			this.swipe_angle_label.Location = new System.Drawing.Point( 14, 76 );
			this.swipe_angle_label.Name = "swipe_angle_label";
			this.swipe_angle_label.Size = new System.Drawing.Size( 89, 13 );
			this.swipe_angle_label.TabIndex = 8;
			this.swipe_angle_label.Text = "Max Angular Dev";
			// 
			// swipe_dura_unit
			// 
			this.swipe_dura_unit.AutoSize = true;
			this.swipe_dura_unit.Location = new System.Drawing.Point( 220, 50 );
			this.swipe_dura_unit.Name = "swipe_dura_unit";
			this.swipe_dura_unit.Size = new System.Drawing.Size( 82, 13 );
			this.swipe_dura_unit.TabIndex = 7;
			this.swipe_dura_unit.Text = "ms (default 500)";
			// 
			// form_swipe_duration
			// 
			this.form_swipe_duration.Location = new System.Drawing.Point( 113, 47 );
			this.form_swipe_duration.Name = "form_swipe_duration";
			this.form_swipe_duration.Size = new System.Drawing.Size( 100, 20 );
			this.form_swipe_duration.TabIndex = 6;
			// 
			// swipe_duration_label
			// 
			this.swipe_duration_label.AutoSize = true;
			this.swipe_duration_label.Location = new System.Drawing.Point( 14, 50 );
			this.swipe_duration_label.Name = "swipe_duration_label";
			this.swipe_duration_label.Size = new System.Drawing.Size( 79, 13 );
			this.swipe_duration_label.TabIndex = 5;
			this.swipe_duration_label.Text = "Swipe Duration";
			// 
			// swipe_vel_unit
			// 
			this.swipe_vel_unit.AutoSize = true;
			this.swipe_vel_unit.Location = new System.Drawing.Point( 220, 23 );
			this.swipe_vel_unit.Name = "swipe_vel_unit";
			this.swipe_vel_unit.Size = new System.Drawing.Size( 90, 13 );
			this.swipe_vel_unit.TabIndex = 4;
			this.swipe_vel_unit.Text = "m/s (default 0.20)";
			// 
			// form_swipe_minvel
			// 
			this.form_swipe_minvel.Location = new System.Drawing.Point( 113, 20 );
			this.form_swipe_minvel.Name = "form_swipe_minvel";
			this.form_swipe_minvel.Size = new System.Drawing.Size( 100, 20 );
			this.form_swipe_minvel.TabIndex = 3;
			// 
			// swipe_velocity_label
			// 
			this.swipe_velocity_label.AutoSize = true;
			this.swipe_velocity_label.Location = new System.Drawing.Point( 14, 23 );
			this.swipe_velocity_label.Name = "swipe_velocity_label";
			this.swipe_velocity_label.Size = new System.Drawing.Size( 88, 13 );
			this.swipe_velocity_label.TabIndex = 2;
			this.swipe_velocity_label.Text = "Minimum Velocity";
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
			// button_panel
			// 
			this.button_panel.Controls.Add( this.config_cancel );
			this.button_panel.Controls.Add( this.config_save );
			this.button_panel.Location = new System.Drawing.Point( 16, 454 );
			this.button_panel.Name = "button_panel";
			this.button_panel.Size = new System.Drawing.Size( 221, 43 );
			this.button_panel.TabIndex = 7;
			// 
			// circle_box
			// 
			this.circle_box.Controls.Add( this.circle_rad_unit );
			this.circle_box.Controls.Add( this.circle_sensi_unit );
			this.circle_box.Controls.Add( this.form_circle_sensitivity );
			this.circle_box.Controls.Add( this.form_circle_minrad );
			this.circle_box.Controls.Add( this.circle_sensitivity_label );
			this.circle_box.Controls.Add( this.circle_radius_label );
			this.circle_box.Location = new System.Drawing.Point( 16, 287 );
			this.circle_box.Name = "circle_box";
			this.circle_box.Size = new System.Drawing.Size( 357, 77 );
			this.circle_box.TabIndex = 8;
			this.circle_box.TabStop = false;
			this.circle_box.Text = "Circle Detector";
			// 
			// circle_rad_unit
			// 
			this.circle_rad_unit.AutoSize = true;
			this.circle_rad_unit.Location = new System.Drawing.Point( 223, 20 );
			this.circle_rad_unit.Name = "circle_rad_unit";
			this.circle_rad_unit.Size = new System.Drawing.Size( 79, 13 );
			this.circle_rad_unit.TabIndex = 5;
			this.circle_rad_unit.Text = "mm (default 80)";
			// 
			// circle_sensi_unit
			// 
			this.circle_sensi_unit.AutoSize = true;
			this.circle_sensi_unit.Location = new System.Drawing.Point( 220, 50 );
			this.circle_sensi_unit.Name = "circle_sensi_unit";
			this.circle_sensi_unit.Size = new System.Drawing.Size( 112, 13 );
			this.circle_sensi_unit.TabIndex = 4;
			this.circle_sensi_unit.Text = "1 - 5 (1 most sensitive)";
			// 
			// form_circle_sensitivity
			// 
			this.form_circle_sensitivity.Location = new System.Drawing.Point( 113, 47 );
			this.form_circle_sensitivity.Name = "form_circle_sensitivity";
			this.form_circle_sensitivity.Size = new System.Drawing.Size( 100, 20 );
			this.form_circle_sensitivity.TabIndex = 3;
			// 
			// form_circle_minrad
			// 
			this.form_circle_minrad.Location = new System.Drawing.Point( 113, 17 );
			this.form_circle_minrad.Name = "form_circle_minrad";
			this.form_circle_minrad.Size = new System.Drawing.Size( 100, 20 );
			this.form_circle_minrad.TabIndex = 2;
			// 
			// circle_sensitivity_label
			// 
			this.circle_sensitivity_label.AutoSize = true;
			this.circle_sensitivity_label.Location = new System.Drawing.Point( 14, 50 );
			this.circle_sensitivity_label.Name = "circle_sensitivity_label";
			this.circle_sensitivity_label.Size = new System.Drawing.Size( 54, 13 );
			this.circle_sensitivity_label.TabIndex = 1;
			this.circle_sensitivity_label.Text = "Sensitivity";
			// 
			// circle_radius_label
			// 
			this.circle_radius_label.AutoSize = true;
			this.circle_radius_label.Location = new System.Drawing.Point( 14, 20 );
			this.circle_radius_label.Name = "circle_radius_label";
			this.circle_radius_label.Size = new System.Drawing.Size( 60, 13 );
			this.circle_radius_label.TabIndex = 0;
			this.circle_radius_label.Text = "Min Radius";
			// 
			// slider_box
			// 
			this.slider_box.Controls.Add( this.slider_height_unit );
			this.slider_box.Controls.Add( this.slider_width_unit );
			this.slider_box.Controls.Add( this.form_slider_height );
			this.slider_box.Controls.Add( this.form_slider_width );
			this.slider_box.Controls.Add( this.slider_h_label );
			this.slider_box.Controls.Add( this.slider_w_label );
			this.slider_box.Location = new System.Drawing.Point( 16, 370 );
			this.slider_box.Name = "slider_box";
			this.slider_box.Size = new System.Drawing.Size( 357, 78 );
			this.slider_box.TabIndex = 9;
			this.slider_box.TabStop = false;
			this.slider_box.Text = "Sliding Value Selector";
			// 
			// slider_height_unit
			// 
			this.slider_height_unit.AutoSize = true;
			this.slider_height_unit.Location = new System.Drawing.Point( 223, 45 );
			this.slider_height_unit.Name = "slider_height_unit";
			this.slider_height_unit.Size = new System.Drawing.Size( 85, 13 );
			this.slider_height_unit.TabIndex = 5;
			this.slider_height_unit.Text = "mm (default 100)";
			// 
			// slider_width_unit
			// 
			this.slider_width_unit.AutoSize = true;
			this.slider_width_unit.Location = new System.Drawing.Point( 223, 19 );
			this.slider_width_unit.Name = "slider_width_unit";
			this.slider_width_unit.Size = new System.Drawing.Size( 85, 13 );
			this.slider_width_unit.TabIndex = 4;
			this.slider_width_unit.Text = "mm (default 200)";
			// 
			// form_slider_height
			// 
			this.form_slider_height.Location = new System.Drawing.Point( 113, 39 );
			this.form_slider_height.Name = "form_slider_height";
			this.form_slider_height.Size = new System.Drawing.Size( 100, 20 );
			this.form_slider_height.TabIndex = 3;
			// 
			// form_slider_width
			// 
			this.form_slider_width.Location = new System.Drawing.Point( 113, 16 );
			this.form_slider_width.Name = "form_slider_width";
			this.form_slider_width.Size = new System.Drawing.Size( 100, 20 );
			this.form_slider_width.TabIndex = 2;
			// 
			// slider_h_label
			// 
			this.slider_h_label.AutoSize = true;
			this.slider_h_label.Location = new System.Drawing.Point( 14, 46 );
			this.slider_h_label.Name = "slider_h_label";
			this.slider_h_label.Size = new System.Drawing.Size( 38, 13 );
			this.slider_h_label.TabIndex = 1;
			this.slider_h_label.Text = "Height";
			// 
			// slider_w_label
			// 
			this.slider_w_label.AutoSize = true;
			this.slider_w_label.Location = new System.Drawing.Point( 14, 19 );
			this.slider_w_label.Name = "slider_w_label";
			this.slider_w_label.Size = new System.Drawing.Size( 35, 13 );
			this.slider_w_label.TabIndex = 0;
			this.slider_w_label.Text = "Width";
			// 
			// config_dlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 402, 502 );
			this.Controls.Add( this.slider_box );
			this.Controls.Add( this.circle_box );
			this.Controls.Add( this.button_panel );
			this.Controls.Add( this.swipe_box );
			this.Controls.Add( this.steady_box );
			this.Controls.Add( this.instructions );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "config_dlg";
			this.Text = "Configuration Options";
			this.steady_box.ResumeLayout( false );
			this.steady_box.PerformLayout();
			this.swipe_box.ResumeLayout( false );
			this.swipe_box.PerformLayout();
			this.button_panel.ResumeLayout( false );
			this.circle_box.ResumeLayout( false );
			this.circle_box.PerformLayout();
			this.slider_box.ResumeLayout( false );
			this.slider_box.PerformLayout();
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Label steady_duration_label;
		private System.Windows.Forms.Button config_save;
		private System.Windows.Forms.Button config_cancel;
		private System.Windows.Forms.Label instructions;
		public System.Windows.Forms.TextBox form_steadyduration_val;
		private System.Windows.Forms.GroupBox steady_box;
		private System.Windows.Forms.Label steady_stddev_unit;
		private System.Windows.Forms.Label steady_dur_units;
		private System.Windows.Forms.Label stead_stddev_label;
		private System.Windows.Forms.GroupBox swipe_box;
		private System.Windows.Forms.Panel button_panel;
		private System.Windows.Forms.Label swipe_dura_unit;
		private System.Windows.Forms.Label swipe_duration_label;
		private System.Windows.Forms.Label swipe_vel_unit;
		private System.Windows.Forms.Label swipe_velocity_label;
		private System.Windows.Forms.CheckBox swipe_use_Steady;
		private System.Windows.Forms.Label swipe_xangle_label;
		private System.Windows.Forms.Label swipe_angle_label;
		private System.Windows.Forms.Label swipe_angle_unit;
		private System.Windows.Forms.Label swipe_yangle_label;
		private System.Windows.Forms.GroupBox circle_box;
		private System.Windows.Forms.GroupBox slider_box;
		private System.Windows.Forms.Label swipe_steady_duraion;
		private System.Windows.Forms.Label circle_sensi_unit;
		private System.Windows.Forms.Label circle_sensitivity_label;
		private System.Windows.Forms.Label circle_radius_label;
		private System.Windows.Forms.Label slider_h_label;
		private System.Windows.Forms.Label slider_w_label;
		private System.Windows.Forms.Label circle_rad_unit;
		private System.Windows.Forms.Label slider_width_unit;
		private System.Windows.Forms.Label slider_height_unit;
		public System.Windows.Forms.TextBox form_steady_stddev;
		public System.Windows.Forms.TextBox form_swipe_duration;
		public System.Windows.Forms.TextBox form_swipe_minvel;
		public System.Windows.Forms.TextBox swipe_steady_duration;
		public System.Windows.Forms.TextBox form_swipe_xangle;
		public System.Windows.Forms.TextBox form_swipe_yangle;
		public System.Windows.Forms.TextBox form_circle_sensitivity;
		public System.Windows.Forms.TextBox form_circle_minrad;
		public System.Windows.Forms.TextBox form_slider_height;
		public System.Windows.Forms.TextBox form_slider_width;
	}
}