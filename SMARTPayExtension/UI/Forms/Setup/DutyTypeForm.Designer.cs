namespace SMARTPayExtension.UI.Forms.Setup
{
    partial class DutyTypeForm
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
            this.ddlAllowance = new Telerik.WinControls.UI.RadDropDownList();
            this.bindingSourceDutyAllowanceMapping = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceAllowance = new System.Windows.Forms.BindingSource(this.components);
            this.ddlDuty = new Telerik.WinControls.UI.RadDropDownList();
            this.bindingSourceDutyType = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDutyAllowanceMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllowance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDutyType)).BeginInit();
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
            this.radGroupBox3.Location = new System.Drawing.Point(133, 447);
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
            this.radGroupBox2.Controls.Add(this.ddlAllowance);
            this.radGroupBox2.Controls.Add(this.ddlDuty);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.HeaderText = "Duty Mapping";
            this.radGroupBox2.Location = new System.Drawing.Point(27, 24);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(527, 100);
            this.radGroupBox2.TabIndex = 13;
            this.radGroupBox2.Text = "Duty Mapping";
            // 
            // ddlAllowance
            // 
            this.ddlAllowance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlAllowance.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceDutyAllowanceMapping, "AllowanceId", true));
            this.ddlAllowance.DataSource = this.bindingSourceAllowance;
            this.ddlAllowance.DisplayMember = "AllowanceDescription";
            this.ddlAllowance.Enabled = false;
            this.ddlAllowance.Location = new System.Drawing.Point(118, 68);
            this.ddlAllowance.Name = "ddlAllowance";
            this.ddlAllowance.Size = new System.Drawing.Size(347, 20);
            this.ddlAllowance.TabIndex = 7;
            this.ddlAllowance.ValueMember = "AllowanceId";
            // 
            // bindingSourceDutyAllowanceMapping
            // 
            this.bindingSourceDutyAllowanceMapping.DataSource = typeof(SMARTPayExtension.DutyAllowanceMapping);
            // 
            // bindingSourceAllowance
            // 
            this.bindingSourceAllowance.DataSource = typeof(SMARTPayExtension.Allowance);
            // 
            // ddlDuty
            // 
            this.ddlDuty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlDuty.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceDutyAllowanceMapping, "DutyId", true));
            this.ddlDuty.DataSource = this.bindingSourceDutyType;
            this.ddlDuty.DisplayMember = "DutyCode";
            this.ddlDuty.Enabled = false;
            this.ddlDuty.Location = new System.Drawing.Point(118, 32);
            this.ddlDuty.Name = "ddlDuty";
            this.ddlDuty.Size = new System.Drawing.Size(347, 20);
            this.ddlDuty.TabIndex = 6;
            this.ddlDuty.ValueMember = "DutyId";
            // 
            // bindingSourceDutyType
            // 
            this.bindingSourceDutyType.DataSource = typeof(SMARTPayExtension.DutyCodeView);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(55, 68);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Allowance";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(18, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(94, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Duty/Service type";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.grdDataDisplay);
            this.radGroupBox1.HeaderText = "Duty Mapping Display";
            this.radGroupBox1.Location = new System.Drawing.Point(27, 144);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(527, 286);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.Text = "Duty Mapping Display";
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
            gridViewTextBoxColumn1.FieldName = "DutyCodeView.Description";
            gridViewTextBoxColumn1.HeaderText = "Duty Code description";
            gridViewTextBoxColumn1.Name = "Description";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 180;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Allowance.AllowanceDescription";
            gridViewTextBoxColumn2.HeaderText = "Allowance";
            gridViewTextBoxColumn2.Name = "Allowance";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 110;
            gridViewTextBoxColumn3.FieldName = "DutyCodeView.DutyCode";
            gridViewTextBoxColumn3.HeaderText = "Service Code";
            gridViewTextBoxColumn3.Name = "ServiceCode";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 67;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "DutyCodeView.DutyCode";
            gridViewTextBoxColumn4.HeaderText = "Duty Code";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "DutyCode";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 60;
            gridViewTextBoxColumn5.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "LastModifiedDate";
            gridViewTextBoxColumn5.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn5.HeaderText = "Created/Modified";
            gridViewTextBoxColumn5.Name = "LastModifiedDate";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 73;
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
            this.grdDataDisplay.MasterTemplate.DataSource = this.bindingSourceDutyAllowanceMapping;
            this.grdDataDisplay.MasterTemplate.EnableFiltering = true;
            this.grdDataDisplay.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdDataDisplay.Name = "grdDataDisplay";
            this.grdDataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdDataDisplay.Size = new System.Drawing.Size(517, 260);
            this.grdDataDisplay.TabIndex = 0;
            this.grdDataDisplay.Text = "radGridView1";
            this.grdDataDisplay.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.grdDataDisplay_CommandCellClick);
            // 
            // DutyTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 549);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "DutyTypeForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Duty Type";
            this.Load += new System.EventHandler(this.DutyTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAllowance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDutyAllowanceMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllowance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDutyType)).EndInit();
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
        private Telerik.WinControls.UI.RadDropDownList ddlAllowance;
        private System.Windows.Forms.BindingSource bindingSourceAllowance;
        private Telerik.WinControls.UI.RadDropDownList ddlDuty;
        private System.Windows.Forms.BindingSource bindingSourceDutyType;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView grdDataDisplay;
        private System.Windows.Forms.BindingSource bindingSourceDutyAllowanceMapping;
    }
}
