namespace SMARTPayExtension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.btnExit = new Telerik.WinControls.UI.CommandBarButton();
            this.Seperator = new Telerik.WinControls.UI.CommandBarSeparator();
            this.btnBackgroundImage = new Telerik.WinControls.UI.CommandBarButton();
            this.Seperator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.MainMenu = new Telerik.WinControls.UI.CommandBarButton();
            this.CommandBar = new Telerik.WinControls.UI.RadCommandBar();
            this.lblDisplay = new Telerik.WinControls.UI.RadLabel();
            this.ddlTheme = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ColPanelUser = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblExpDate = new Telerik.WinControls.UI.RadLabel();
            this.lblAccountInfo = new Telerik.WinControls.UI.RadLabel();
            this.lblUserName = new Telerik.WinControls.UI.RadLabel();
            this.lblUserflName = new Telerik.WinControls.UI.RadLabel();
            this.pictureBoxActiveUser = new System.Windows.Forms.PictureBox();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.BGWTheme = new System.ComponentModel.BackgroundWorker();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            ((System.ComponentModel.ISupportInitialize)(this.CommandBar)).BeginInit();
            this.CommandBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColPanelUser)).BeginInit();
            this.ColPanelUser.PanelContainer.SuspendLayout();
            this.ColPanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserflName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActiveUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
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
            this.btnExit,
            this.Seperator,
            this.btnBackgroundImage,
            this.Seperator2,
            this.MainMenu});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.Text = "";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnExit
            // 
            this.btnExit.DisplayName = "commandBarButton1";
            this.btnExit.Image = global::SMARTPayExtension.Properties.Resources.if_Log_Out_27856;
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExit.Text = "commandBarButton1";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Seperator
            // 
            this.Seperator.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Seperator.DisplayName = "commandBarSeparator1";
            this.Seperator.Name = "Seperator";
            this.Seperator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Seperator.VisibleInOverflowMenu = false;
            // 
            // btnBackgroundImage
            // 
            this.btnBackgroundImage.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnBackgroundImage.Image = global::SMARTPayExtension.Properties.Resources.Apps_background_icon;
            this.btnBackgroundImage.Name = "btnBackgroundImage";
            this.btnBackgroundImage.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBackgroundImage.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnBackgroundImage.Click += new System.EventHandler(this.btnBackgroundImage_Click);
            // 
            // Seperator2
            // 
            this.Seperator2.DisplayName = "commandBarSeparator1";
            this.Seperator2.Name = "Seperator2";
            this.Seperator2.VisibleInOverflowMenu = false;
            // 
            // MainMenu
            // 
            this.MainMenu.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.MainMenu.Image = global::SMARTPayExtension.Properties.Resources.home;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MainMenu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click_1);
            // 
            // CommandBar
            // 
            this.CommandBar.Controls.Add(this.lblDisplay);
            this.CommandBar.Controls.Add(this.ddlTheme);
            this.CommandBar.Controls.Add(this.radLabel1);
            this.CommandBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommandBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CommandBar.Location = new System.Drawing.Point(0, 0);
            this.CommandBar.Name = "CommandBar";
            this.CommandBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommandBar.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.CommandBar.Size = new System.Drawing.Size(807, 40);
            this.CommandBar.TabIndex = 1;
            this.CommandBar.Text = "radCommandBar1";
            // 
            // lblDisplay
            // 
            this.lblDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDisplay.Font = new System.Drawing.Font("Traditional Arabic", 11F, System.Drawing.FontStyle.Bold);
            this.lblDisplay.Location = new System.Drawing.Point(298, 11);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(73, 26);
            this.lblDisplay.TabIndex = 7;
            this.lblDisplay.Text = "radLabel2";
            this.lblDisplay.Visible = false;
            // 
            // ddlTheme
            // 
            this.ddlTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlTheme.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlTheme.Location = new System.Drawing.Point(568, 12);
            this.ddlTheme.Name = "ddlTheme";
            this.ddlTheme.Size = new System.Drawing.Size(227, 20);
            this.ddlTheme.TabIndex = 5;
            this.ddlTheme.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlTheme_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(520, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(42, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Theme";
            // 
            // ColPanelUser
            // 
            this.ColPanelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ColPanelUser.ExpandDirection = Telerik.WinControls.UI.RadDirection.Up;
            this.ColPanelUser.HeaderText = "Active User Details";
            this.ColPanelUser.IsExpanded = false;
            this.ColPanelUser.Location = new System.Drawing.Point(2, 393);
            this.ColPanelUser.Name = "ColPanelUser";
            this.ColPanelUser.OwnerBoundsCache = new System.Drawing.Rectangle(2, 393, 292, 173);
            // 
            // ColPanelUser.PanelContainer
            // 
            this.ColPanelUser.PanelContainer.Controls.Add(this.radGroupBox1);
            this.ColPanelUser.PanelContainer.Size = new System.Drawing.Size(0, 0);
            this.ColPanelUser.Size = new System.Drawing.Size(292, 21);
            this.ColPanelUser.TabIndex = 5;
            this.ColPanelUser.Text = "radCollapsiblePanel1";
            this.ColPanelUser.Expanded += new System.EventHandler(this.ColPanelUser_Expanded);
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.ColPanelUser.GetChildAt(0))).ExpandDirection = Telerik.WinControls.UI.RadDirection.Up;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.ColPanelUser.GetChildAt(0))).IsExpanded = false;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.ColPanelUser.GetChildAt(0))).Shape = null;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblExpDate);
            this.radGroupBox1.Controls.Add(this.lblAccountInfo);
            this.radGroupBox1.Controls.Add(this.lblUserName);
            this.radGroupBox1.Controls.Add(this.lblUserflName);
            this.radGroupBox1.Controls.Add(this.pictureBoxActiveUser);
            this.radGroupBox1.HeaderText = "Current User";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(284, 141);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Current User";
            // 
            // lblExpDate
            // 
            this.lblExpDate.Location = new System.Drawing.Point(142, 107);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(55, 18);
            this.lblExpDate.TabIndex = 4;
            this.lblExpDate.Text = "radLabel2";
            this.lblExpDate.Visible = false;
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.Location = new System.Drawing.Point(142, 83);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(55, 18);
            this.lblAccountInfo.TabIndex = 3;
            this.lblAccountInfo.Text = "radLabel4";
            this.lblAccountInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(142, 59);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(59, 18);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserflName
            // 
            this.lblUserflName.Location = new System.Drawing.Point(142, 33);
            this.lblUserflName.Name = "lblUserflName";
            this.lblUserflName.Size = new System.Drawing.Size(100, 18);
            this.lblUserflName.TabIndex = 1;
            this.lblUserflName.Text = "First and Lastname";
            this.lblUserflName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxActiveUser
            // 
            this.pictureBoxActiveUser.Location = new System.Drawing.Point(5, 21);
            this.pictureBoxActiveUser.Name = "pictureBoxActiveUser";
            this.pictureBoxActiveUser.Size = new System.Drawing.Size(101, 95);
            this.pictureBoxActiveUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxActiveUser.TabIndex = 0;
            this.pictureBoxActiveUser.TabStop = false;
            // 
            // radMenu1
            // 
            this.radMenu1.AutoSize = false;
            this.radMenu1.Location = new System.Drawing.Point(0, 40);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(807, 10);
            this.radMenu1.TabIndex = 3;
            this.radMenu1.Text = "radMenu1";
            // 
            // BGWTheme
            // 
            this.BGWTheme.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWTheme_DoWork);
            this.BGWTheme.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWTheme_RunWorkerCompleted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMARTPayExtension.Properties.Resources.sc_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 416);
            this.Controls.Add(this.ColPanelUser);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.CommandBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SMART Transaction Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CommandBar)).EndInit();
            this.CommandBar.ResumeLayout(false);
            this.CommandBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ColPanelUser.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColPanelUser)).EndInit();
            this.ColPanelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAccountInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserflName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActiveUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton MainMenu;
        private Telerik.WinControls.UI.CommandBarSeparator Seperator;
        private Telerik.WinControls.UI.CommandBarButton btnBackgroundImage;
        private Telerik.WinControls.UI.RadCommandBar CommandBar;
        private Telerik.WinControls.UI.CommandBarSeparator Seperator2;
        private Telerik.WinControls.UI.CommandBarButton btnExit;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadDropDownList ddlTheme;
        private System.ComponentModel.BackgroundWorker BGWTheme;
        private Telerik.WinControls.UI.RadCollapsiblePanel ColPanelUser;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel lblAccountInfo;
        private Telerik.WinControls.UI.RadLabel lblUserName;
        private Telerik.WinControls.UI.RadLabel lblUserflName;
        private System.Windows.Forms.PictureBox pictureBoxActiveUser;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadLabel lblDisplay;
        private Telerik.WinControls.UI.RadLabel lblExpDate;


    }
}
