namespace SMARTPayExtension.UI.Forms.Security
{
    partial class SystemUserForm
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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnImage = new Telerik.WinControls.UI.RadButton();
            this.pictureBoxUserImg = new System.Windows.Forms.PictureBox();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.txtMiddlename = new Telerik.WinControls.UI.RadTextBox();
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.spnExpiryPeriod = new Telerik.WinControls.UI.RadSpinEditor();
            this.chkExpire = new Telerik.WinControls.UI.RadCheckBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddlename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnExpiryPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.ItemSizeMode = ((Telerik.WinControls.UI.PageViewItemSizeMode)((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth | Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight)));
            this.radPageView1.Location = new System.Drawing.Point(-1, -1);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(606, 449);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radLabel1);
            this.radPageViewPage1.Controls.Add(this.radSeparator1);
            this.radPageViewPage1.Controls.Add(this.btnSave);
            this.radPageViewPage1.Controls.Add(this.btnClose);
            this.radPageViewPage1.Controls.Add(this.radGroupBox1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(604F, 24F);
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 29);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(596, 391);
            this.radPageViewPage1.Text = "User Configuration";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGroupBox3);
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.HeaderText = "Add System User";
            this.radGroupBox1.Location = new System.Drawing.Point(23, 63);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(542, 328);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Add System User";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.btnImage);
            this.radGroupBox3.Controls.Add(this.pictureBoxUserImg);
            this.radGroupBox3.Controls.Add(this.txtLastName);
            this.radGroupBox3.Controls.Add(this.txtMiddlename);
            this.radGroupBox3.Controls.Add(this.txtFirstName);
            this.radGroupBox3.HeaderText = "User Information";
            this.radGroupBox3.Location = new System.Drawing.Point(29, 30);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(475, 163);
            this.radGroupBox3.TabIndex = 1;
            this.radGroupBox3.Text = "User Information";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(10, 134);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(453, 24);
            this.btnImage.TabIndex = 9;
            this.btnImage.Text = "Get Image";
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // pictureBoxUserImg
            // 
            this.pictureBoxUserImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxUserImg.Location = new System.Drawing.Point(10, 23);
            this.pictureBoxUserImg.Name = "pictureBoxUserImg";
            this.pictureBoxUserImg.Size = new System.Drawing.Size(122, 105);
            this.pictureBoxUserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserImg.TabIndex = 8;
            this.pictureBoxUserImg.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(156, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.NullText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(307, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(156, 69);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.NullText = "Middle Name";
            this.txtMiddlename.Size = new System.Drawing.Size(307, 20);
            this.txtMiddlename.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.NullText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(307, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.spnExpiryPeriod);
            this.radGroupBox2.Controls.Add(this.chkExpire);
            this.radGroupBox2.Controls.Add(this.txtPassword);
            this.radGroupBox2.Controls.Add(this.txtUserName);
            this.radGroupBox2.HeaderText = "Account Information";
            this.radGroupBox2.Location = new System.Drawing.Point(29, 209);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(475, 100);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Account Information";
            // 
            // spnExpiryPeriod
            // 
            this.spnExpiryPeriod.Location = new System.Drawing.Point(314, 73);
            this.spnExpiryPeriod.Name = "spnExpiryPeriod";
            this.spnExpiryPeriod.ShowUpDownButtons = false;
            this.spnExpiryPeriod.Size = new System.Drawing.Size(100, 20);
            this.spnExpiryPeriod.TabIndex = 8;
            this.spnExpiryPeriod.TabStop = false;
            this.spnExpiryPeriod.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkExpire
            // 
            this.chkExpire.Location = new System.Drawing.Point(85, 74);
            this.chkExpire.Name = "chkExpire";
            this.chkExpire.Size = new System.Drawing.Size(145, 18);
            this.chkExpire.TabIndex = 7;
            this.chkExpire.Text = "Allow Account Expiration";
            this.chkExpire.CheckStateChanged += new System.EventHandler(this.chkExpire_CheckStateChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Password";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(329, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(85, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NullText = "User Name";
            this.txtUserName.Size = new System.Drawing.Size(329, 20);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Image = global::SMARTPayExtension.Properties.Resources.Symbols_Delete_icon;
            this.btnClose.Location = new System.Drawing.Point(484, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Exit";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = global::SMARTPayExtension.Properties.Resources.save_icon;
            this.btnSave.Location = new System.Drawing.Point(381, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(-5, 41);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(598, 10);
            this.radSeparator1.TabIndex = 4;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.radLabel1.Location = new System.Drawing.Point(23, 7);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(213, 29);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Add/Edit System User(s)";
            // 
            // SystemUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 451);
            this.Controls.Add(this.radPageView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SystemUserForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "System User ";
            this.Load += new System.EventHandler(this.SystemUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddlename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnExpiryPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton btnImage;
        private System.Windows.Forms.PictureBox pictureBoxUserImg;
        private Telerik.WinControls.UI.RadTextBox txtLastName;
        private Telerik.WinControls.UI.RadTextBox txtMiddlename;
        private Telerik.WinControls.UI.RadTextBox txtFirstName;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadSpinEditor spnExpiryPeriod;
        private Telerik.WinControls.UI.RadCheckBox chkExpire;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtUserName;

    }
}
