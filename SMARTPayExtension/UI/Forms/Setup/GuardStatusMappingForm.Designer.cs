namespace SMARTPayExtension.UI.Forms.Setup
{
    partial class GuardStatusMappingForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtRate = new Telerik.WinControls.UI.RadTextBox();
            this.bindingSourceStatus = new System.Windows.Forms.BindingSource(this.components);
            this.ddlStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.bindingSourceMapping = new System.Windows.Forms.BindingSource(this.components);
            this.ddlContractor = new Telerik.WinControls.UI.RadDropDownList();
            this.bindingSourceGuard = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.grdDataDisplay = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGuard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radGroupBox3.Controls.Add(this.btnAdd);
            this.radGroupBox3.Controls.Add(this.btnExit);
            this.radGroupBox3.Controls.Add(this.btnSave);
            this.radGroupBox3.HeaderText = "User Controls";
            this.radGroupBox3.Location = new System.Drawing.Point(118, 435);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(294, 77);
            this.radGroupBox3.TabIndex = 14;
            this.radGroupBox3.Text = "User Controls";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = global::SMARTPayExtension.Properties.Resources.if_todo_list_add_17451;
            this.btnAdd.Location = new System.Drawing.Point(12, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.Image = global::SMARTPayExtension.Properties.Resources.if_close_36841;
            this.btnExit.Location = new System.Drawing.Point(194, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Close";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = global::SMARTPayExtension.Properties.Resources.Save_as_icon;
            this.btnSave.Location = new System.Drawing.Point(103, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.txtRate);
            this.radGroupBox2.Controls.Add(this.ddlStatus);
            this.radGroupBox2.Controls.Add(this.ddlContractor);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.HeaderText = "Guard Mapping";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(527, 114);
            this.radGroupBox2.TabIndex = 13;
            this.radGroupBox2.Text = "Guard Mapping";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(84, 90);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(28, 18);
            this.radLabel3.TabIndex = 9;
            this.radLabel3.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceStatus, "Rate", true));
            this.txtRate.Location = new System.Drawing.Point(118, 89);
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 8;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bindingSourceStatus
            // 
            this.bindingSourceStatus.DataSource = typeof(SMARTPayExtension.GuardType);
            // 
            // ddlStatus
            // 
            this.ddlStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceMapping, "GuardTypeId", true));
            this.ddlStatus.DataSource = this.bindingSourceStatus;
            this.ddlStatus.DisplayMember = "GuardTypeDescription";
            this.ddlStatus.Enabled = false;
            this.ddlStatus.Location = new System.Drawing.Point(118, 58);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(347, 20);
            this.ddlStatus.TabIndex = 7;
            this.ddlStatus.ValueMember = "GuardTypeId";
            // 
            // bindingSourceMapping
            // 
            this.bindingSourceMapping.DataSource = typeof(SMARTPayExtension.GuardStatusMapping);
            // 
            // ddlContractor
            // 
            this.ddlContractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlContractor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceMapping, "ContractorId", true));
            this.ddlContractor.DataSource = this.bindingSourceGuard;
            this.ddlContractor.DisplayMember = "ContractorDescription";
            this.ddlContractor.Enabled = false;
            this.ddlContractor.Location = new System.Drawing.Point(118, 28);
            this.ddlContractor.Name = "ddlContractor";
            this.ddlContractor.Size = new System.Drawing.Size(347, 20);
            this.ddlContractor.TabIndex = 6;
            this.ddlContractor.ValueMember = "ContractorId";
            // 
            // bindingSourceGuard
            // 
            this.bindingSourceGuard.DataSource = typeof(SMARTPayExtension.ContractorView);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(19, 58);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(87, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Contractor Type";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(18, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(94, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Contractor/Guard";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.grdDataDisplay);
            this.radGroupBox1.HeaderText = "Guard Mapping Display";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 132);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(527, 286);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.Text = "Guard Mapping Display";
            // 
            // grdDataDisplay
            // 
            this.grdDataDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDataDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.grdDataDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdDataDisplay.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdDataDisplay.ForeColor = System.Drawing.Color.Black;
            this.grdDataDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdDataDisplay.Location = new System.Drawing.Point(5, 21);
            // 
            // 
            // 
            this.grdDataDisplay.MasterTemplate.AllowAddNewRow = false;
            this.grdDataDisplay.MasterTemplate.AllowColumnReorder = false;
            this.grdDataDisplay.MasterTemplate.AutoExpandGroups = true;
            this.grdDataDisplay.MasterTemplate.AutoGenerateColumns = false;
            this.grdDataDisplay.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ContractorView.ContractorDescription";
            gridViewTextBoxColumn1.HeaderText = "Contractor/Guard";
            gridViewTextBoxColumn1.Name = "Description";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 200;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "GuardType.GuardTypeDescription";
            gridViewTextBoxColumn2.HeaderText = "Status";
            gridViewTextBoxColumn2.Name = "Zone";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 119;
            gridViewTextBoxColumn3.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "LastModifiedDate";
            gridViewTextBoxColumn3.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Created/Modified";
            gridViewTextBoxColumn3.Name = "LastModifiedDate";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 110;
            gridViewCommandColumn1.DefaultText = "Edit";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "EDIT?";
            gridViewCommandColumn1.MaxWidth = 70;
            gridViewCommandColumn1.MinWidth = 70;
            gridViewCommandColumn1.Name = "Edit";
            gridViewCommandColumn1.StretchVertically = false;
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 70;
            this.grdDataDisplay.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1});
            this.grdDataDisplay.MasterTemplate.DataSource = this.bindingSourceMapping;
            this.grdDataDisplay.MasterTemplate.EnableFiltering = true;
            this.grdDataDisplay.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdDataDisplay.Name = "grdDataDisplay";
            this.grdDataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdDataDisplay.Size = new System.Drawing.Size(517, 260);
            this.grdDataDisplay.TabIndex = 0;
            this.grdDataDisplay.Text = "radGridView1";
            this.grdDataDisplay.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.grdDataDisplay_CommandCellClick);
            // 
            // GuardStatusMappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 524);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuardStatusMappingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Guard Status Mapping";
            this.Load += new System.EventHandler(this.GuardStatusMappingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGuard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadDropDownList ddlStatus;
        private Telerik.WinControls.UI.RadDropDownList ddlContractor;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView grdDataDisplay;
        private System.Windows.Forms.BindingSource bindingSourceStatus;
        private System.Windows.Forms.BindingSource bindingSourceGuard;
        private System.Windows.Forms.BindingSource bindingSourceMapping;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtRate;
    }
}
