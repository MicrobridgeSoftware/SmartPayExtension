namespace SMARTPayExtension.UI.Forms.Setup
{
    partial class HolidayForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ddlRate = new Telerik.WinControls.UI.RadDropDownList();
            this.dtpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.grdDataDisplay = new Telerik.WinControls.UI.RadGridView();
            this.txtPayrollCode = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.bindingSourceHoliday = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceHolidayRates = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayrollCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHolidayRates)).BeginInit();
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
            this.radGroupBox3.Location = new System.Drawing.Point(133, 460);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(294, 77);
            this.radGroupBox3.TabIndex = 5;
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
            this.radGroupBox2.Controls.Add(this.txtPayrollCode);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.ddlRate);
            this.radGroupBox2.Controls.Add(this.dtpDate);
            this.radGroupBox2.Controls.Add(this.txtDescription);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.HeaderText = "Holiday Type";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(556, 144);
            this.radGroupBox2.TabIndex = 4;
            this.radGroupBox2.Text = "Holiday Type";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(79, 86);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(40, 18);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Paid at";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(35, 57);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(84, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Date of Holiday";
            // 
            // ddlRate
            // 
            this.ddlRate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceHoliday, "HolidayRateId", true));
            this.ddlRate.DataSource = this.bindingSourceHolidayRates;
            this.ddlRate.DisplayMember = "Description";
            this.ddlRate.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlRate.Enabled = false;
            this.ddlRate.Location = new System.Drawing.Point(134, 86);
            this.ddlRate.Name = "ddlRate";
            this.ddlRate.Size = new System.Drawing.Size(195, 20);
            this.ddlRate.TabIndex = 3;
            this.ddlRate.ValueMember = "HolidayRateId";
            // 
            // dtpDate
            // 
            this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceHoliday, "Date", true));
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(134, 56);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(195, 20);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.TabStop = false;
            this.dtpDate.Text = "Tuesday, March 06, 2018";
            this.dtpDate.Value = new System.DateTime(2018, 3, 6, 15, 14, 28, 793);
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHoliday, "Description", true));
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(134, 26);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(16, 27);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(103, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Holiday description";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.grdDataDisplay);
            this.radGroupBox1.HeaderText = "Holiday(s) Display";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 162);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(556, 281);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Holiday(s) Display";
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
            gridViewTextBoxColumn1.FieldName = "Description";
            gridViewTextBoxColumn1.HeaderText = "Holiday Description";
            gridViewTextBoxColumn1.Name = "Description";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 142;
            gridViewTextBoxColumn2.FieldName = "PayrollCode";
            gridViewTextBoxColumn2.HeaderText = "Payroll Code";
            gridViewTextBoxColumn2.Name = "PayrollCode";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 70;
            gridViewTextBoxColumn3.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "LastModified";
            gridViewTextBoxColumn3.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Created/Modified";
            gridViewTextBoxColumn3.Name = "LastModified";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 87;
            gridViewTextBoxColumn4.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Date";
            gridViewTextBoxColumn4.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn4.HeaderText = "Date of Holiday";
            gridViewTextBoxColumn4.Name = "Date";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 87;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "HolidayRate.Description";
            gridViewTextBoxColumn5.HeaderText = "Rate paid at";
            gridViewTextBoxColumn5.Name = "PayRate";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 68;
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
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
            this.grdDataDisplay.MasterTemplate.DataSource = this.bindingSourceHoliday;
            this.grdDataDisplay.MasterTemplate.EnableFiltering = true;
            this.grdDataDisplay.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdDataDisplay.Name = "grdDataDisplay";
            this.grdDataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdDataDisplay.Size = new System.Drawing.Size(546, 255);
            this.grdDataDisplay.TabIndex = 0;
            this.grdDataDisplay.Text = "radGridView1";
            this.grdDataDisplay.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdDataDisplay_CellClick);
            this.grdDataDisplay.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.grdDataDisplay_CommandCellClick);
            // 
            // txtPayrollCode
            // 
            this.txtPayrollCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPayrollCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHoliday, "PayrollCode", true));
            this.txtPayrollCode.Enabled = false;
            this.txtPayrollCode.Location = new System.Drawing.Point(134, 116);
            this.txtPayrollCode.Name = "txtPayrollCode";
            this.txtPayrollCode.Size = new System.Drawing.Size(195, 20);
            this.txtPayrollCode.TabIndex = 7;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(50, 117);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(69, 18);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Payroll Code";
            // 
            // bindingSourceHoliday
            // 
            this.bindingSourceHoliday.DataSource = typeof(SMARTPayExtension.Holiday);
            // 
            // bindingSourceHolidayRates
            // 
            this.bindingSourceHolidayRates.DataSource = typeof(SMARTPayExtension.HolidayRate);
            // 
            // HolidayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 549);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HolidayForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "HolidayForm";
            this.Load += new System.EventHandler(this.HolidayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayrollCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHolidayRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList ddlRate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDate;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView grdDataDisplay;
        private System.Windows.Forms.BindingSource bindingSourceHoliday;
        private System.Windows.Forms.BindingSource bindingSourceHolidayRates;
        private Telerik.WinControls.UI.RadTextBox txtPayrollCode;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}
