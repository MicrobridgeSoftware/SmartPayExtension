namespace SmartAppraisal
{
    partial class MainWindow
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
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.CommandBar = new Telerik.WinControls.UI.RadCommandBar();
            this.Seperator = new Telerik.WinControls.UI.CommandBarSeparator();
            this.MainMenu = new Telerik.WinControls.UI.CommandBarButton();
            this.BackgroundImage = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.CommandBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            this.commandBarRowElement1.Text = "";
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "Main Menu";
            this.commandBarStripElement1.DrawBackgroundImage = true;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.MainMenu,
            this.Seperator,
            this.BackgroundImage});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // CommandBar
            // 
            this.CommandBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommandBar.Location = new System.Drawing.Point(0, 0);
            this.CommandBar.Name = "CommandBar";
            this.CommandBar.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.CommandBar.Size = new System.Drawing.Size(502, 57);
            this.CommandBar.TabIndex = 1;
            this.CommandBar.Text = "radCommandBar1";
            // 
            // Seperator
            // 
            this.Seperator.DisplayName = "commandBarSeparator1";
            this.Seperator.Name = "Seperator";
            this.Seperator.Text = "";
            this.Seperator.VisibleInOverflowMenu = false;
            // 
            // MainMenu
            // 
            this.MainMenu.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.MainMenu.DisplayName = "Main Menu";
            this.MainMenu.Image = global::SmartAppraisal.Properties.Resources.home;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.DisplayName = "commandBarButton2";
            this.BackgroundImage.Image = global::SmartAppraisal.Properties.Resources.Apps_background_icon;
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Text = "Background Image";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 416);
            this.Controls.Add(this.CommandBar);
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SMART Appraisal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CommandBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton MainMenu;
        private Telerik.WinControls.UI.RadCommandBar CommandBar;
        private Telerik.WinControls.UI.CommandBarButton BackgroundImage;
        private Telerik.WinControls.UI.CommandBarSeparator Seperator;

    }
}
