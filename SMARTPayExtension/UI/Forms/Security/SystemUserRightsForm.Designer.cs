namespace SMARTPayExtension.UI.Forms.Security
{
    partial class SystemUserRightsForm
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewRelation gridViewRelation1 = new Telerik.WinControls.UI.GridViewRelation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemUserRightsForm));
            this.grdSubMenu = new Telerik.WinControls.UI.GridViewTemplate();
            this.GrdMenu = new Telerik.WinControls.UI.RadGridView();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ddlUser = new Telerik.WinControls.UI.RadDropDownList();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.pictureBoxUserImg = new System.Windows.Forms.PictureBox();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.txtMiddlename = new Telerik.WinControls.UI.RadTextBox();
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMenu.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddlename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSubMenu
            // 
            this.grdSubMenu.AllowAddNewRow = false;
            this.grdSubMenu.AllowColumnReorder = false;
            this.grdSubMenu.AllowColumnResize = false;
            this.grdSubMenu.AllowDeleteRow = false;
            this.grdSubMenu.AllowDragToGroup = false;
            this.grdSubMenu.AutoGenerateColumns = false;
            this.grdSubMenu.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "MenuDescription";
            gridViewTextBoxColumn1.HeaderText = "Menu Object Description";
            gridViewTextBoxColumn1.Name = "MenuDescription";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.FieldName = "NodeDescription";
            gridViewTextBoxColumn2.HeaderText = "Sub-Menu Object Description";
            gridViewTextBoxColumn2.Name = "NodeDescription";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewCheckBoxColumn1.HeaderText = "Grant Access?";
            gridViewCheckBoxColumn1.MaxWidth = 90;
            gridViewCheckBoxColumn1.MinWidth = 90;
            gridViewCheckBoxColumn1.Name = "Select";
            gridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn1.Width = 90;
            gridViewTextBoxColumn3.FieldName = "MenuId";
            gridViewTextBoxColumn3.HeaderText = "MenuId";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "MenuId";
            gridViewTextBoxColumn4.FieldName = "MenuNodesId";
            gridViewTextBoxColumn4.HeaderText = "MenuNodesId";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "MenuNodesId";
            this.grdSubMenu.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.grdSubMenu.EnableGrouping = false;
            this.grdSubMenu.ShowFilteringRow = false;
            this.grdSubMenu.ViewDefinition = tableViewDefinition1;
            // 
            // GrdMenu
            // 
            this.GrdMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdMenu.Location = new System.Drawing.Point(5, 21);
            // 
            // 
            // 
            this.GrdMenu.MasterTemplate.AllowAddNewRow = false;
            this.GrdMenu.MasterTemplate.AllowColumnReorder = false;
            this.GrdMenu.MasterTemplate.AllowDragToGroup = false;
            this.GrdMenu.MasterTemplate.AutoGenerateColumns = false;
            this.GrdMenu.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.FieldName = "MenuDescription";
            gridViewTextBoxColumn5.HeaderText = "Menu Object Description";
            gridViewTextBoxColumn5.Name = "MenuDescription";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 693;
            gridViewCheckBoxColumn2.HeaderText = "Access Granted?";
            gridViewCheckBoxColumn2.MaxWidth = 90;
            gridViewCheckBoxColumn2.MinWidth = 90;
            gridViewCheckBoxColumn2.Name = "Select";
            gridViewCheckBoxColumn2.ReadOnly = true;
            gridViewCheckBoxColumn2.StretchVertically = false;
            gridViewCheckBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn2.Width = 90;
            gridViewTextBoxColumn6.FieldName = "MenuId";
            gridViewTextBoxColumn6.HeaderText = "MenuId";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "MenuId";
            gridViewTextBoxColumn6.Width = 42;
            gridViewTextBoxColumn7.FieldName = "MenuDescription";
            gridViewTextBoxColumn7.HeaderText = "MenuDescription";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "GroupingMenuDescription";
            gridViewTextBoxColumn7.Width = 42;
            this.GrdMenu.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.GrdMenu.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.grdSubMenu});
            this.GrdMenu.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.GrdMenu.Name = "GrdMenu";
            gridViewRelation1.ChildColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ChildColumnNames")));
            gridViewRelation1.ChildTemplate = this.grdSubMenu;
            gridViewRelation1.ParentColumnNames = ((System.Collections.Specialized.StringCollection)(resources.GetObject("gridViewRelation1.ParentColumnNames")));
            gridViewRelation1.ParentTemplate = this.GrdMenu.MasterTemplate;
            gridViewRelation1.RelationName = "MnuToSubMnu";
            this.GrdMenu.Relations.AddRange(new Telerik.WinControls.UI.GridViewRelation[] {
            gridViewRelation1});
            this.GrdMenu.Size = new System.Drawing.Size(825, 240);
            this.GrdMenu.TabIndex = 0;
            this.GrdMenu.Text = "radGridView1";
            // 
            // radPageView1
            // 
            this.radPageView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.ItemSizeMode = ((Telerik.WinControls.UI.PageViewItemSizeMode)((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth | Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight)));
            this.radPageView1.Location = new System.Drawing.Point(0, 1);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(856, 602);
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
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(840F, 28F);
            this.radPageViewPage1.Location = new System.Drawing.Point(13, 29);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(830, 531);
            this.radPageViewPage1.Text = "System Security Configuration";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.radLabel1.Location = new System.Drawing.Point(4, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(300, 29);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Access Control - Add User Right(s)";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeparator1.Location = new System.Drawing.Point(-5, 47);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(856, 10);
            this.radSeparator1.TabIndex = 9;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = global::SMARTPayExtension.Properties.Resources.save_icon;
            this.btnSave.Location = new System.Drawing.Point(638, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Image = global::SMARTPayExtension.Properties.Resources.Symbols_Delete_icon;
            this.btnClose.Location = new System.Drawing.Point(741, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.ddlUser);
            this.radGroupBox1.Controls.Add(this.radGroupBox3);
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.HeaderText = "Access Control";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 61);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(846, 477);
            this.radGroupBox1.TabIndex = 6;
            this.radGroupBox1.Text = "Access Control";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(197, 22);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(30, 18);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "User";
            // 
            // ddlUser
            // 
            this.ddlUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ddlUser.DataSource = this.bindingSourceUser;
            this.ddlUser.DisplayMember = "UserName";
            this.ddlUser.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlUser.Location = new System.Drawing.Point(233, 22);
            this.ddlUser.Name = "ddlUser";
            this.ddlUser.Size = new System.Drawing.Size(439, 20);
            this.ddlUser.TabIndex = 10;
            this.ddlUser.ValueMember = "SystemUserId";
            this.ddlUser.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlUser_SelectedIndexChanged);
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataSource = typeof(SMARTPayExtension.SystemUser);
            this.bindingSourceUser.PositionChanged += new System.EventHandler(this.bindingSourceUser_PositionChanged);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.pictureBoxUserImg);
            this.radGroupBox3.Controls.Add(this.txtLastName);
            this.radGroupBox3.Controls.Add(this.txtMiddlename);
            this.radGroupBox3.Controls.Add(this.txtFirstName);
            this.radGroupBox3.HeaderText = "User Information";
            this.radGroupBox3.Location = new System.Drawing.Point(5, 51);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(835, 143);
            this.radGroupBox3.TabIndex = 1;
            this.radGroupBox3.Text = "User Information";
            // 
            // pictureBoxUserImg
            // 
            this.pictureBoxUserImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxUserImg.Location = new System.Drawing.Point(123, 26);
            this.pictureBoxUserImg.Name = "pictureBoxUserImg";
            this.pictureBoxUserImg.Size = new System.Drawing.Size(122, 105);
            this.pictureBoxUserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserImg.TabIndex = 8;
            this.pictureBoxUserImg.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(269, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.NullText = "Last Name";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(412, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddlename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "MiddleName", true));
            this.txtMiddlename.Location = new System.Drawing.Point(269, 68);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.NullText = "Middle Name";
            this.txtMiddlename.ReadOnly = true;
            this.txtMiddlename.Size = new System.Drawing.Size(412, 20);
            this.txtMiddlename.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(269, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.NullText = "First Name";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(412, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.GrdMenu);
            this.radGroupBox2.HeaderText = "System Information";
            this.radGroupBox2.Location = new System.Drawing.Point(5, 206);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(835, 266);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "System Information";
            // 
            // SystemUserRightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 598);
            this.Controls.Add(this.radPageView1);
            this.Name = "SystemUserRightsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "System User Rights";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SystemUserRightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSubMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMenu.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddlename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBoxUserImg;
        private Telerik.WinControls.UI.RadTextBox txtLastName;
        private Telerik.WinControls.UI.RadTextBox txtMiddlename;
        private Telerik.WinControls.UI.RadTextBox txtFirstName;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView GrdMenu;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList ddlUser;
        private Telerik.WinControls.UI.GridViewTemplate grdSubMenu;
        private System.Windows.Forms.BindingSource bindingSourceUser;
    }
}
