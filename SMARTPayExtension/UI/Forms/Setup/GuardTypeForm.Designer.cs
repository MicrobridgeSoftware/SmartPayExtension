namespace SMARTPayExtension.UI.Forms.Setup
{
    partial class GuardTypeForm
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.grdDataDisplay = new Telerik.WinControls.UI.RadGridView();
            this.bindingSourceGuardType = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.spnRate = new Telerik.WinControls.UI.RadSpinEditor();
            this.chkActive = new Telerik.WinControls.UI.RadCheckBox();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGuardType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.grdDataDisplay);
            this.radGroupBox1.HeaderText = "Guard Type Display";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 138);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(527, 280);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Guard Type Display";
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
            gridViewTextBoxColumn1.FieldName = "GuardTypeDescription";
            gridViewTextBoxColumn1.HeaderText = "Guard Type Description";
            gridViewTextBoxColumn1.Name = "GuardTypeDescription";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 192;
            gridViewTextBoxColumn2.DataType = typeof(decimal);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Rate";
            gridViewTextBoxColumn2.FormatString = "{0:C}";
            gridViewTextBoxColumn2.HeaderText = "Rate";
            gridViewTextBoxColumn2.Name = "Rate";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 65;
            gridViewTextBoxColumn3.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "LastModifiedDate";
            gridViewTextBoxColumn3.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Created/Modified";
            gridViewTextBoxColumn3.Name = "LastModifiedDate";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 107;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "Allowance";
            gridViewCheckBoxColumn1.HeaderText = "Allowance";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "Active";
            gridViewCheckBoxColumn1.ReadOnly = true;
            gridViewCheckBoxColumn1.Width = 66;
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
            gridViewCheckBoxColumn1,
            gridViewCommandColumn1});
            this.grdDataDisplay.MasterTemplate.DataSource = this.bindingSourceGuardType;
            this.grdDataDisplay.MasterTemplate.EnableFiltering = true;
            this.grdDataDisplay.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdDataDisplay.Name = "grdDataDisplay";
            this.grdDataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdDataDisplay.Size = new System.Drawing.Size(517, 254);
            this.grdDataDisplay.TabIndex = 0;
            this.grdDataDisplay.Text = "radGridView1";
            this.grdDataDisplay.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.grdDataDisplay_CommandCellClick);
            // 
            // bindingSourceGuardType
            // 
            this.bindingSourceGuardType.DataSource = typeof(SMARTPayExtension.GuardType);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.spnRate);
            this.radGroupBox2.Controls.Add(this.chkActive);
            this.radGroupBox2.Controls.Add(this.txtDescription);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.HeaderText = "Guard Type";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(527, 120);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Guard Type";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(100, 64);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(28, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Rate";
            // 
            // spnRate
            // 
            this.spnRate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceGuardType, "Rate", true));
            this.spnRate.DecimalPlaces = 2;
            this.spnRate.Enabled = false;
            this.spnRate.Location = new System.Drawing.Point(134, 63);
            this.spnRate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spnRate.Name = "spnRate";
            this.spnRate.ShowUpDownButtons = false;
            this.spnRate.Size = new System.Drawing.Size(100, 20);
            this.spnRate.TabIndex = 3;
            this.spnRate.TabStop = false;
            this.spnRate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.spnRate.ThousandsSeparator = true;
            // 
            // chkActive
            // 
            this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourceGuardType, "Allowance", true));
            this.chkActive.Enabled = false;
            this.chkActive.Location = new System.Drawing.Point(134, 93);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(127, 18);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Eligible for Allowance";
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGuardType, "GuardTypeDescription", true));
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(134, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(5, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(123, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Guard Type description";
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
            this.radGroupBox3.TabIndex = 2;
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
            // GuardTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 524);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuardTypeForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Guard Type";
            this.Load += new System.EventHandler(this.GuardTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGuardType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView grdDataDisplay;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadCheckBox chkActive;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private System.Windows.Forms.BindingSource bindingSourceGuardType;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadSpinEditor spnRate;
    }
}
