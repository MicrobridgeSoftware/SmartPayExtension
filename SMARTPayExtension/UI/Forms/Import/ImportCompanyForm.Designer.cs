namespace SMARTPayExtension.UI.Forms.Import
{
    partial class ImportCompanyForm
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grdCompany = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            this.bindingSourceCompany = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCompany
            // 
            this.grdCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCompany.Location = new System.Drawing.Point(10, 21);
            // 
            // 
            // 
            this.grdCompany.MasterTemplate.AllowAddNewRow = false;
            this.grdCompany.MasterTemplate.AllowColumnReorder = false;
            this.grdCompany.MasterTemplate.AutoExpandGroups = true;
            this.grdCompany.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCheckBoxColumn1.HeaderText = "Select";
            gridViewCheckBoxColumn1.Name = "Select";
            gridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.FieldName = "CompanyName";
            gridViewTextBoxColumn1.HeaderText = "Company Name";
            gridViewTextBoxColumn1.Name = "CompanyName";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 167;
            gridViewTextBoxColumn2.FieldName = "Description";
            gridViewTextBoxColumn2.HeaderText = "Description";
            gridViewTextBoxColumn2.Name = "Description";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 166;
            gridViewTextBoxColumn3.FieldName = "TradeName";
            gridViewTextBoxColumn3.HeaderText = "Trade Name";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "TradeName";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 112;
            gridViewTextBoxColumn4.DataType = typeof(short);
            gridViewTextBoxColumn4.FieldName = "CompanyId";
            gridViewTextBoxColumn4.HeaderText = "CompanyId";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "CompanyId";
            this.grdCompany.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.grdCompany.MasterTemplate.DataSource = this.bindingSourceCompany;
            this.grdCompany.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdCompany.Name = "grdCompany";
            this.grdCompany.Size = new System.Drawing.Size(405, 275);
            this.grdCompany.TabIndex = 3;
            this.grdCompany.Text = "radGridView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.grdCompany);
            this.radGroupBox1.HeaderText = "Available Companies";
            this.radGroupBox1.Location = new System.Drawing.Point(2, 2);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(424, 301);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Available Companies";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Image = global::SMARTPayExtension.Properties.Resources.button_ok;
            this.btnSelect.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelect.Location = new System.Drawing.Point(151, 313);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 43);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // bindingSourceCompany
            // 
            this.bindingSourceCompany.DataSource = typeof(SMARTPayExtension.SMARTPayCompanyView);
            // 
            // ImportCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImportCompanyForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Import Company";
            this.Load += new System.EventHandler(this.ImportCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceCompany;
        private Telerik.WinControls.UI.RadGridView grdCompany;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnSelect;
    }
}
