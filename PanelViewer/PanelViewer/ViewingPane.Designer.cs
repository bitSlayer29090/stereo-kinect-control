namespace PanelViewer
{
	partial class ViewingPaneForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ViewingPaneForm ) );
			this.panelViewer = new System.Windows.Forms.Panel();
			this.status_bar = new System.Windows.Forms.StatusStrip();
			this.Instruction_Display = new System.Windows.Forms.ToolStripStatusLabel();
			this.FPS_Display = new System.Windows.Forms.ToolStripStatusLabel();
			this.FPS_Bar = new System.Windows.Forms.ToolStripProgressBar();
			this.gesture_display = new System.Windows.Forms.ToolStripStatusLabel();
			this.menu_bar = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.leftAndRightFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dVideoFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playbackFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toggle_Debug_switch = new System.Windows.Forms.ToolStripMenuItem();
			this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.marquetteCVTECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.debugBox = new System.Windows.Forms.TextBox();
			this.play_status_icon = new System.Windows.Forms.PictureBox();
			this.status_bar.SuspendLayout();
			this.menu_bar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.play_status_icon)).BeginInit();
			this.SuspendLayout();
			// 
			// panelViewer
			// 
			this.panelViewer.Location = new System.Drawing.Point( 12, 38 );
			this.panelViewer.Margin = new System.Windows.Forms.Padding( 4 );
			this.panelViewer.Name = "panelViewer";
			this.panelViewer.Size = new System.Drawing.Size( 640, 480 );
			this.panelViewer.TabIndex = 0;
			this.panelViewer.Visible = false;
			// 
			// status_bar
			// 
			this.status_bar.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.Instruction_Display,
            this.FPS_Display,
            this.FPS_Bar,
            this.gesture_display} );
			this.status_bar.Location = new System.Drawing.Point( 0, 663 );
			this.status_bar.Name = "status_bar";
			this.status_bar.Padding = new System.Windows.Forms.Padding( 1, 0, 19, 0 );
			this.status_bar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.status_bar.Size = new System.Drawing.Size( 664, 26 );
			this.status_bar.TabIndex = 2;
			this.status_bar.Text = "statusStrip1";
			// 
			// Instruction_Display
			// 
			this.Instruction_Display.AutoSize = false;
			this.Instruction_Display.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
			this.Instruction_Display.Image = ((System.Drawing.Image)(resources.GetObject( "Instruction_Display.Image" )));
			this.Instruction_Display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Instruction_Display.Name = "Instruction_Display";
			this.Instruction_Display.Size = new System.Drawing.Size( 200, 21 );
			this.Instruction_Display.Text = "Ready...";
			// 
			// FPS_Display
			// 
			this.FPS_Display.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.FPS_Display.Name = "FPS_Display";
			this.FPS_Display.Size = new System.Drawing.Size( 118, 21 );
			this.FPS_Display.Text = "toolStripStatusLabel2";
			// 
			// FPS_Bar
			// 
			this.FPS_Bar.Maximum = 50;
			this.FPS_Bar.Name = "FPS_Bar";
			this.FPS_Bar.Size = new System.Drawing.Size( 75, 20 );
			// 
			// gesture_display
			// 
			this.gesture_display.AutoSize = false;
			this.gesture_display.Image = ((System.Drawing.Image)(resources.GetObject( "gesture_display.Image" )));
			this.gesture_display.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.gesture_display.Name = "gesture_display";
			this.gesture_display.Size = new System.Drawing.Size( 180, 21 );
			this.gesture_display.Text = "(No Gestures Recognized)";
			// 
			// menu_bar
			// 
			this.menu_bar.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem} );
			this.menu_bar.Location = new System.Drawing.Point( 0, 0 );
			this.menu_bar.Name = "menu_bar";
			this.menu_bar.Padding = new System.Windows.Forms.Padding( 8, 2, 0, 2 );
			this.menu_bar.Size = new System.Drawing.Size( 664, 24 );
			this.menu_bar.TabIndex = 3;
			this.menu_bar.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem} );
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.dFileToolStripMenuItem,
            this.dFileToolStripMenuItem1,
            this.playbackFolderToolStripMenuItem} );
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject( "openToolStripMenuItem.Image" )));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size( 103, 22 );
			this.openToolStripMenuItem.Text = "&Open";
			// 
			// dFileToolStripMenuItem
			// 
			this.dFileToolStripMenuItem.Name = "dFileToolStripMenuItem";
			this.dFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.dFileToolStripMenuItem.Size = new System.Drawing.Size( 197, 22 );
			this.dFileToolStripMenuItem.Text = "2D File";
			this.dFileToolStripMenuItem.Click += new System.EventHandler( this.form_form_2d );
			// 
			// dFileToolStripMenuItem1
			// 
			this.dFileToolStripMenuItem1.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.leftAndRightFilesToolStripMenuItem,
            this.dVideoFileToolStripMenuItem} );
			this.dFileToolStripMenuItem1.Name = "dFileToolStripMenuItem1";
			this.dFileToolStripMenuItem1.Size = new System.Drawing.Size( 197, 22 );
			this.dFileToolStripMenuItem1.Text = "3D File";
			// 
			// leftAndRightFilesToolStripMenuItem
			// 
			this.leftAndRightFilesToolStripMenuItem.Name = "leftAndRightFilesToolStripMenuItem";
			this.leftAndRightFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.leftAndRightFilesToolStripMenuItem.Size = new System.Drawing.Size( 214, 22 );
			this.leftAndRightFilesToolStripMenuItem.Text = "Left and Right Files";
			this.leftAndRightFilesToolStripMenuItem.Click += new System.EventHandler( this.form_open_LR );
			// 
			// dVideoFileToolStripMenuItem
			// 
			this.dVideoFileToolStripMenuItem.Name = "dVideoFileToolStripMenuItem";
			this.dVideoFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.dVideoFileToolStripMenuItem.Size = new System.Drawing.Size( 214, 22 );
			this.dVideoFileToolStripMenuItem.Text = "3D Video File";
			this.dVideoFileToolStripMenuItem.Click += new System.EventHandler( this.form_open3d );
			// 
			// playbackFolderToolStripMenuItem
			// 
			this.playbackFolderToolStripMenuItem.Name = "playbackFolderToolStripMenuItem";
			this.playbackFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.playbackFolderToolStripMenuItem.Size = new System.Drawing.Size( 197, 22 );
			this.playbackFolderToolStripMenuItem.Text = "Playback Folder";
			this.playbackFolderToolStripMenuItem.Click += new System.EventHandler( this.form_open_folder );
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size( 100, 6 );
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size( 103, 22 );
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler( this.main_window_exit );
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.toggle_Debug_switch,
            this.configureToolStripMenuItem} );
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size( 48, 20 );
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// toggle_Debug_switch
			// 
			this.toggle_Debug_switch.CheckOnClick = true;
			this.toggle_Debug_switch.Name = "toggle_Debug_switch";
			this.toggle_Debug_switch.Size = new System.Drawing.Size( 168, 22 );
			this.toggle_Debug_switch.Text = "&Show Debug Data";
			this.toggle_Debug_switch.CheckStateChanged += new System.EventHandler( this.toggle_debug );
			// 
			// configureToolStripMenuItem
			// 
			this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
			this.configureToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
			this.configureToolStripMenuItem.Text = "Configure ";
			this.configureToolStripMenuItem.Click += new System.EventHandler( this.form_configure_click );
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem} );
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.marquetteCVTECToolStripMenuItem} );
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size( 116, 22 );
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// marquetteCVTECToolStripMenuItem
			// 
			this.marquetteCVTECToolStripMenuItem.Name = "marquetteCVTECToolStripMenuItem";
			this.marquetteCVTECToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
			this.marquetteCVTECToolStripMenuItem.Text = "Marquette CVTEC";
			this.marquetteCVTECToolStripMenuItem.Click += new System.EventHandler( this.click_mucvtec_about );
			// 
			// debugBox
			// 
			this.debugBox.AcceptsReturn = true;
			this.debugBox.BackColor = System.Drawing.SystemColors.Window;
			this.debugBox.Location = new System.Drawing.Point( 12, 526 );
			this.debugBox.Margin = new System.Windows.Forms.Padding( 4 );
			this.debugBox.Multiline = true;
			this.debugBox.Name = "debugBox";
			this.debugBox.ReadOnly = true;
			this.debugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.debugBox.Size = new System.Drawing.Size( 640, 124 );
			this.debugBox.TabIndex = 4;
			this.debugBox.Visible = false;
			// 
			// play_status_icon
			// 
			this.play_status_icon.Image = ((System.Drawing.Image)(resources.GetObject( "play_status_icon.Image" )));
			this.play_status_icon.Location = new System.Drawing.Point( 640, 0 );
			this.play_status_icon.Name = "play_status_icon";
			this.play_status_icon.Size = new System.Drawing.Size( 24, 24 );
			this.play_status_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.play_status_icon.TabIndex = 5;
			this.play_status_icon.TabStop = false;
			// 
			// ViewingPaneForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 664, 689 );
			this.Controls.Add( this.play_status_icon );
			this.Controls.Add( this.debugBox );
			this.Controls.Add( this.status_bar );
			this.Controls.Add( this.menu_bar );
			this.Controls.Add( this.panelViewer );
			this.Font = new System.Drawing.Font( "MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
			this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
			this.Margin = new System.Windows.Forms.Padding( 4 );
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ViewingPaneForm";
			this.Text = "Marquette CVTEC Lab";
			this.Load += new System.EventHandler( this.ViewingPane_Load );
			this.status_bar.ResumeLayout( false );
			this.status_bar.PerformLayout();
			this.menu_bar.ResumeLayout( false );
			this.menu_bar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.play_status_icon)).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelViewer;
		private System.Windows.Forms.StatusStrip status_bar;
		private System.Windows.Forms.ToolStripStatusLabel Instruction_Display;
		private System.Windows.Forms.ToolStripProgressBar FPS_Bar;
		private System.Windows.Forms.MenuStrip menu_bar;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toggle_Debug_switch;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel FPS_Display;
		private System.Windows.Forms.TextBox debugBox;
		private System.Windows.Forms.ToolStripMenuItem dFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dFileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem playbackFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem marquetteCVTECToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem leftAndRightFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dVideoFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel gesture_display;
		private System.Windows.Forms.PictureBox play_status_icon;
	}
}

