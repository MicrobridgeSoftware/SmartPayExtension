namespace SMARTPayExtension.UI.Forms.Employee
{
    partial class OwnWeaponForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlAllowance = new Telerik.WinControls.UI.RadDropDownList();
            this.bindingSourceOwnWeapon = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceAllowance = new System.Windows.Forms.BindingSource(this.components);
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.dtpExpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtSerialNumber = new Telerik.WinControls.UI.RadTextBox();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.ddlAllowance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOwnWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllowance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
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
            this.radGroupBox3.TabIndex = 20;
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
            this.radGroupBox2.Controls.Add(this.ddlAllowance);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.dtpExpDate);
            this.radGroupBox2.Controls.Add(this.txtSerialNumber);
            this.radGroupBox2.Controls.Add(this.txtDescription);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.Controls.Add(this.ddlContractor);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.HeaderText = "Own Firearm Mapping";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(527, 192);
            this.radGroupBox2.TabIndex = 19;
            this.radGroupBox2.Text = "Own Firearm Mapping";
            // 
            // ddlAllowance
            // 
            this.ddlAllowance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlAllowance.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceOwnWeapon, "AllowanceId", true));
            this.ddlAllowance.DataSource = this.bindingSourceAllowance;
            this.ddlAllowance.DisplayMember = "AllowanceDescription";
            this.ddlAllowance.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlAllowance.Enabled = false;
            this.ddlAllowance.Location = new System.Drawing.Point(138, 59);
            this.ddlAllowance.Name = "ddlAllowance";
            this.ddlAllowance.Size = new System.Drawing.Size(347, 20);
            this.ddlAllowance.TabIndex = 18;
            this.ddlAllowance.ValueMember = "AllowanceId";
            // 
            // bindingSourceOwnWeapon
            // 
            this.bindingSourceOwnWeapon.DataSource = typeof(SMARTPayExtension.EmployeeOwnWeapon);
            // 
            // bindingSourceAllowance
            // 
            this.bindingSourceAllowance.DataSource = typeof(SMARTPayExtension.Allowance);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(66, 59);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(57, 18);
            this.radLabel4.TabIndex = 17;
            this.radLabel4.Text = "Allowance";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceOwnWeapon, "PermitExpiration", true));
            this.dtpExpDate.Enabled = false;
            this.dtpExpDate.Location = new System.Drawing.Point(138, 156);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(194, 20);
            this.dtpExpDate.TabIndex = 16;
            this.dtpExpDate.TabStop = false;
            this.dtpExpDate.Text = "Tuesday, March 20, 2018";
            this.dtpExpDate.Value = new System.DateTime(2018, 3, 20, 14, 8, 32, 875);
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceOwnWeapon, "SerialNumber", true));
            this.txtSerialNumber.Enabled = false;
            this.txtSerialNumber.Location = new System.Drawing.Point(138, 123);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(347, 20);
            this.txtSerialNumber.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceOwnWeapon, "FirearmDescription", true));
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(138, 91);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(347, 20);
            this.txtDescription.TabIndex = 14;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(45, 124);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(78, 18);
            this.radLabel3.TabIndex = 8;
            this.radLabel3.Text = "Serial Number";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(5, 157);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(118, 18);
            this.radLabel5.TabIndex = 10;
            this.radLabel5.Text = "Permit Expiration Date";
            // 
            // ddlContractor
            // 
            this.ddlContractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlContractor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceOwnWeapon, "ContractorId", true));
            this.ddlContractor.DataSource = this.bindingSourceGuard;
            this.ddlContractor.DisplayMember = "ContractorDescription";
            this.ddlContractor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlContractor.Enabled = false;
            this.ddlContractor.Location = new System.Drawing.Point(138, 27);
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
            this.radLabel2.Location = new System.Drawing.Point(19, 92);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(104, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Firearm Description";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(29, 27);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(94, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Guard/Contractor";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.grdDataDisplay);
            this.radGroupBox1.HeaderText = "Own Firearm Mapping Display";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 210);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(527, 217);
            this.radGroupBox1.TabIndex = 18;
            this.radGroupBox1.Text = "Own Firearm Mapping Display";
            // 
            // grdDataDisplay
            // 
            this.grdDataDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDataDisplay.Location = new System.Drawing.Point(5, 21);
            // 
            // 
            // 
            this.grdDataDisplay.MasterTemplate.AllowAddNewRow = false;
            this.grdDataDisplay.MasterTemplate.AllowColumnReorder = false;
            this.grdDataDisplay.MasterTemplate.AutoGenerateColumns = false;
            this.grdDataDisplay.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ContractorView.ContractorDescription";
            gridViewTextBoxColumn1.HeaderText = "Guard/Contractor";
            gridViewTextBoxColumn1.Name = "Contractor";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 160;
            gridViewTextBoxColumn2.FieldName = "FirearmDescription";
            gridViewTextBoxColumn2.HeaderText = "Firearm Description";
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 92;
            gridViewTextBoxColumn3.FieldName = "SerialNumber";
            gridViewTextBoxColumn3.HeaderText = "Serial Number";
            gridViewTextBoxColumn3.Name = "Duty";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 92;
            gridViewTextBoxColumn4.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn4.FieldName = "LastmodifiedDate";
            gridViewTextBoxColumn4.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn4.HeaderText = "Created/Modified";
            gridViewTextBoxColumn4.Name = "LastModifiedDate";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 86;
            gridViewCommandColumn1.DefaultText = "Edit";
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
            gridViewTextBoxColumn4,
            gridViewCommandColumn1});
            this.grdDataDisplay.MasterTemplate.DataSource = this.bindingSourceOwnWeapon;
            this.grdDataDisplay.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdDataDisplay.Name = "grdDataDisplay";
            this.grdDataDisplay.Size = new System.Drawing.Size(517, 191);
            this.grdDataDisplay.TabIndex = 0;
            this.grdDataDisplay.Text = "radGridView1";
            this.grdDataDisplay.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.grdDataDisplay_CommandCellClick);
            // 
            // OwnWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 524);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "OwnWeaponForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Employees with Own Weapon";
            this.Load += new System.EventHandler(this.OwnWeaponForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAllowance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOwnWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllowance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
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
        private Telerik.WinControls.UI.RadDateTimePicker dtpExpDate;
        private Telerik.WinControls.UI.RadTextBox txtSerialNumber;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList ddlContractor;
        private System.Windows.Forms.BindingSource bindingSourceGuard;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView grdDataDisplay;
        private System.Windows.Forms.BindingSource bindingSourceOwnWeapon;
        private Telerik.WinControls.UI.RadDropDownList ddlAllowance;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.BindingSource bindingSourceAllowance;
    }
}
