namespace SMARTPayExtension.UI.Forms.Employee
{
    partial class EmployeeRateChangeForm
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
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.spnCurrentRate = new Telerik.WinControls.UI.RadSpinEditor();
            this.spnChangedRate = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCurrentRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnChangedRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Image = global::SMARTPayExtension.Properties.Resources.Save_as_icon;
            this.btnUpdate.Location = new System.Drawing.Point(149, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(63, 20);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(86, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Current Rate :  ";
            // 
            // spnCurrentRate
            // 
            this.spnCurrentRate.DecimalPlaces = 2;
            this.spnCurrentRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.spnCurrentRate.Location = new System.Drawing.Point(155, 18);
            this.spnCurrentRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnCurrentRate.Name = "spnCurrentRate";
            this.spnCurrentRate.ReadOnly = true;
            this.spnCurrentRate.ShowUpDownButtons = false;
            this.spnCurrentRate.Size = new System.Drawing.Size(139, 21);
            this.spnCurrentRate.TabIndex = 6;
            this.spnCurrentRate.TabStop = false;
            this.spnCurrentRate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // spnChangedRate
            // 
            this.spnChangedRate.DecimalPlaces = 2;
            this.spnChangedRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.spnChangedRate.ForeColor = System.Drawing.Color.Red;
            this.spnChangedRate.Location = new System.Drawing.Point(155, 47);
            this.spnChangedRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnChangedRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnChangedRate.Name = "spnChangedRate";
            this.spnChangedRate.ShowUpDownButtons = false;
            this.spnChangedRate.Size = new System.Drawing.Size(139, 21);
            this.spnChangedRate.TabIndex = 8;
            this.spnChangedRate.TabStop = false;
            this.spnChangedRate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.spnChangedRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(72, 49);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(75, 18);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Change To :  ";
            // 
            // EmployeeRateChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 140);
            this.Controls.Add(this.spnChangedRate);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.spnCurrentRate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeRateChangeForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Employee Rate Change";
            this.Load += new System.EventHandler(this.EmployeeRateChangeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCurrentRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnChangedRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadSpinEditor spnCurrentRate;
        private Telerik.WinControls.UI.RadSpinEditor spnChangedRate;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
