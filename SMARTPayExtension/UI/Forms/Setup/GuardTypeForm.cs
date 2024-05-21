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
    public partial class GuardTypeForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public GuardTypeForm()
        {
            InitializeComponent();
        }

        private void GuardTypeForm_Load(object sender, EventArgs e)
        {
            getFormData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;  

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new Gaurd type?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceGuardType.AddNew();
                txtDescription.Text = string.Empty;
                spnRate.Value = 0;
                chkActive.Checked = false;
                txtDescription.Enabled = true;
                chkActive.Enabled = true;
                spnRate.Enabled = true;
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
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                RadMessageBox.Show("Guard type cannot be empty!", Application.ProductName);
                return;
            }

            if (Convert.ToDecimal(spnRate.Value) <= 0)
            {
                RadMessageBox.Show("Guard rate value is invalid!", Application.ProductName);
                return;
            }

            if (grdDataDisplay.Enabled)
                return;            
            
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _guardTypeId = ((GuardType)bindingSourceGuardType.Current).GuardTypeId;

                try
                {
                    if (_guardTypeId == 0)
                    {
                        GuardType _addguardType = new GuardType();
                        _addguardType.GuardTypeDescription = txtDescription.Text.Trim();
                        _addguardType.Allowance = chkActive.Checked == true ? true : false;
                        _addguardType.Rate = (decimal)spnRate.Value;
                        _addguardType.LastModifiedDate = DateTime.Now;
                        _addguardType.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.GuardTypes.Add(_addguardType);
                    }
                    else
                    {
                        var _findGuardtypeRecord = dbContext.GuardTypes.Where(g => g.GuardTypeId == _guardTypeId).FirstOrDefault();
                        _findGuardtypeRecord.GuardTypeDescription = txtDescription.Text.Trim();
                        _findGuardtypeRecord.Rate = (decimal)spnRate.Value;
                        _findGuardtypeRecord.LastModifiedDate = DateTime.Now;
                        _findGuardtypeRecord.Allowance = chkActive.Checked == true ? true : false;
                        _findGuardtypeRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                    }

                    dbContext.SaveChanges();
                    txtDescription.Enabled = false;
                    chkActive.Enabled = false;
                    spnRate.Enabled = false;
                    grdDataDisplay.Enabled = true;
                    bindingSourceGuardType.Clear();
                    getFormData();
                    RadMessageBox.Show("Record created successfully!", Application.ProductName);
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }

        public void getFormData()
        {
            var _guradType = dbContext.GuardTypes.AsNoTracking().ToList();
            bindingSourceGuardType.DataSource = _guradType;
        }

        private void grdDataDisplay_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to edit this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                txtDescription.Enabled = true;
                chkActive.Enabled = true;
                spnRate.Enabled = true;
                grdDataDisplay.Enabled = false;
            }
        }
    }
}
