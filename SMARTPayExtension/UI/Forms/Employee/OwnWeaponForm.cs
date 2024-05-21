using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using Telerik.WinControls.Data;
using SMARTPayExtension.TechLibrary;
using Telerik.WinControls.UI;

namespace SMARTPayExtension.UI.Forms.Employee
{
    public partial class OwnWeaponForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public OwnWeaponForm()
        {
            InitializeComponent();
        }

        private void OwnWeaponForm_Load(object sender, EventArgs e)
        {
            dtpExpDate.Value = DateTime.Today.Date;
            dtpExpDate.MinDate = DateTime.Today.Date;

            getFormData();

            this.ddlAllowance.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlContractor.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        public void getFormData()
        {            
            var _guards = dbContext.ContractorViews.OrderBy(x=> x.ContractorDescription).ToList();
            var _allowance = dbContext.Allowances.OrderBy(x=> x.AllowanceDescription).ToList();
            var _ownGun = dbContext.EmployeeOwnWeapons.Include("ContractorView").AsNoTracking().ToList();

            bindingSourceGuard.DataSource = _guards;
            bindingSourceAllowance.DataSource = _allowance;
            bindingSourceOwnWeapon.DataSource = _ownGun;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceOwnWeapon.AddNew();
                ddlContractor.Enabled = true;
                ddlAllowance.Enabled = true;
                txtDescription.Enabled = true;
                txtSerialNumber.Enabled = true;
                dtpExpDate.Enabled = true;
                ddlContractor.SelectedIndex = -1;
                ddlAllowance.SelectedIndex = -1;
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

            if (ddlContractor.SelectedValue == null || (int)ddlContractor.SelectedValue == 0)
            {
                RadMessageBox.Show("A Guard/Contractor must be selected!", Application.ProductName);
                return;
            }

            if (ddlAllowance.SelectedValue == null || (int)ddlAllowance.SelectedValue == 0)
            {
                RadMessageBox.Show("An Allowance must be selected!", Application.ProductName);
                return;
            }
            
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _ownWeaponId = ((EmployeeOwnWeapon)bindingSourceOwnWeapon.Current).EmployeeOwnWeaponId;

                try
                {
                    if (_ownWeaponId == 0)
                    {
                        EmployeeOwnWeapon _addWeaponedEmp = new EmployeeOwnWeapon();
                        _addWeaponedEmp.ContractorId = (int)ddlContractor.SelectedValue;
                        _addWeaponedEmp.AllowanceId = (int)ddlAllowance.SelectedValue;
                        _addWeaponedEmp.LastmodifiedDate = DateTime.Now;
                        _addWeaponedEmp.LastModifiedBy = SMARTPayExtConstants._activeUser;

                        if (!string.IsNullOrEmpty(txtDescription.Text))
                            _addWeaponedEmp.FirearmDescription = txtDescription.Text.Trim();

                        if (!string.IsNullOrEmpty(txtSerialNumber.Text))
                            _addWeaponedEmp.SerialNumber = txtSerialNumber.Text.Trim();

                        if (!string.IsNullOrEmpty(dtpExpDate.Text))
                            _addWeaponedEmp.PermitExpiration = dtpExpDate.Value;

                        dbContext.EmployeeOwnWeapons.Add(_addWeaponedEmp);
                    }
                    else
                    {
                        var _findWeapongRecord = dbContext.EmployeeOwnWeapons.Where(m => m.EmployeeOwnWeaponId == _ownWeaponId).FirstOrDefault();

                        if (!string.IsNullOrEmpty(txtDescription.Text))
                            _findWeapongRecord.FirearmDescription = txtDescription.Text.Trim();

                        if (!string.IsNullOrEmpty(txtSerialNumber.Text))
                            _findWeapongRecord.SerialNumber = txtSerialNumber.Text.Trim();

                        if (!string.IsNullOrEmpty(dtpExpDate.Text))
                            _findWeapongRecord.PermitExpiration = dtpExpDate.Value;

                        _findWeapongRecord.AllowanceId = (int)ddlAllowance.SelectedValue;
                        _findWeapongRecord.LastmodifiedDate = DateTime.Now;
                        _findWeapongRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    txtDescription.Enabled = false;
                    txtSerialNumber.Enabled = false;
                    dtpExpDate.Enabled = false;
                    ddlContractor.Enabled = false;
                    ddlAllowance.Enabled = false;
                    bindingSourceOwnWeapon.Clear();
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
                txtSerialNumber.Enabled = true;
                dtpExpDate.Enabled = true;
                ddlAllowance.Enabled = true;
            }
        }
    }
}
