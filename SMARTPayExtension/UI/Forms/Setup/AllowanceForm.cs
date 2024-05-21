using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using SMARTPayExtension.TechLibrary;

namespace SMARTPayExtension.UI.Forms.Setup
{
    public partial class AllowanceForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();

        public AllowanceForm()
        {
            InitializeComponent();
        }

        public void getFormData()
        {
            var _allowance = dbContext.Allowances.AsNoTracking().ToList();
            bindingSourceAllowance.DataSource = _allowance;
        }

        private void AllowanceForm_Load(object sender, EventArgs e)
        {
            getFormData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new Allowance?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceAllowance.AddNew();
                txtDescription.Text = string.Empty;
                txtDescription.Enabled = true;
                txtPayrollCode.Text = string.Empty;
                txtPayrollCode.Enabled = true;
                spnHours.Enabled = true;
                spnHours.Value = 0;
                spnRate.Enabled = true;
                spnRate.Value = 0;
                grdDataDisplay.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grdDataDisplay.Enabled)
                return;

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                RadMessageBox.Show("Allowance description cannot be empty!", Application.ProductName);
                return;
            }

            if (string.IsNullOrEmpty(txtPayrollCode.Text))
            {
                RadMessageBox.Show("Payroll code cannot be empty!", Application.ProductName);
                return;
            }
            else
            {
                var _payrollCodeExist = dbContext.PayrollCodeViews.Where(x => x.PayrollCode.Trim() == txtPayrollCode.Text.Trim()).FirstOrDefault();

                if (_payrollCodeExist == null)
                {
                    RadMessageBox.Show("This payroll code does not exist in the SMARTPay", Application.ProductName);
                    return;
                }
            }

            if ((decimal)spnRate.Value <= 0)
            {
                RadMessageBox.Show("Please enter a rate for this Allowance!", Application.ProductName);
                return;
            }

            if ((decimal)spnHours.Value == 0)
            {
                DialogResult _promptUser =  RadMessageBox.Show("Maximum hours is set to zero (0). \n" +
                                            "Allowance will be calculated on all hours! \n"+
                                            "Are you sure you want to continue?", Application.ProductName, MessageBoxButtons.YesNo);

                if (_promptUser == System.Windows.Forms.DialogResult.No)
                    return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _allowanceId = ((Allowance)bindingSourceAllowance.Current).AllowanceId;

                try
                {
                    if (_allowanceId == 0)
                    {
                        Allowance _addAllowance = new Allowance();
                        _addAllowance.AllowanceDescription = txtDescription.Text.Trim();
                        _addAllowance.AllowanceRate = (decimal)spnRate.Value;
                        _addAllowance.CalculateOnMaxHours = (decimal)spnHours.Value;
                        _addAllowance.PayrollCode = txtPayrollCode.Text.Trim();
                        _addAllowance.LastModifiedDate = DateTime.Now;
                        _addAllowance.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.Allowances.Add(_addAllowance);
                    }
                    else
                    {
                        var _findAllowanceRecord = dbContext.Allowances.Where(a => a.AllowanceId == _allowanceId).FirstOrDefault();
                        _findAllowanceRecord.AllowanceDescription = txtDescription.Text.Trim();
                        _findAllowanceRecord.AllowanceRate = (decimal)spnRate.Value;
                        _findAllowanceRecord.CalculateOnMaxHours = (decimal)spnHours.Value;
                        _findAllowanceRecord.PayrollCode = txtPayrollCode.Text.Trim();
                        _findAllowanceRecord.LastModifiedDate = DateTime.Now;
                        _findAllowanceRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    txtDescription.Enabled = false;
                    txtPayrollCode.Enabled = false;
                    spnHours.Enabled = false;
                    spnRate.Enabled = false;
                    bindingSourceAllowance.Clear();
                    getFormData();
                    RadMessageBox.Show("Record created successfully!", Application.ProductName);
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }

        private void grdDataDisplay_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to edit this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {                
                grdDataDisplay.Enabled = false;
                txtDescription.Enabled = true;
                txtPayrollCode.Enabled = true;
                spnHours.Enabled = true;
                spnRate.Enabled = true;
            }
        }
    }
}
