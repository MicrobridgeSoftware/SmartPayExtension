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
using Telerik.WinControls.UI;

namespace SMARTPayExtension.UI.Forms.Employee
{
    public partial class ContractorAddonFrom : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();

        public ContractorAddonFrom()
        {
            InitializeComponent();
        }

        private void ContractorAddonFrom_Load(object sender, EventArgs e)
        {
            getFormData();

            this.ddlAllowance.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlCustomer.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlDuty.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlGuard.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
        }

        public void getFormData()
        {            
            var _contractor = (from _contractors in dbContext.ContractorViews
                               join _armGuards in dbContext.EmployeeOwnWeapons
                               on _contractors.ContractorId equals _armGuards.ContractorId
                               select (_contractors)).Distinct().OrderBy(x=> x.ContractorDescription).ToList();
                        
            var _customers = (from _customer in dbContext.CustomerViews
                              join _premiumClients in dbContext.PremiumClients
                              on _customer.CustomerId equals _premiumClients.CustomerId
                              select (_customer)).Distinct().OrderBy(x=> x.CustomerDescription).ToList();

            var _allowance = dbContext.Allowances.OrderBy(x=> x.AllowanceDescription).ToList();
            var _dutyType = dbContext.DutyCodeViews.OrderBy(x=> x.Description).ToList();
            var _mapping = dbContext.ContractorAddons.Include("Allowance").Include("DutyCodeView").
                           Include("CustomerView").Include("ContractorView").AsNoTracking().ToList();

            bindingSourceAllowance.DataSource = _allowance;
            bindingSourceClient.DataSource = _customers;
            bindingSourceDuty.DataSource = _dutyType;
            bindingSourceGuard.DataSource = _contractor;
            bindingSourceMapping.DataSource = _mapping;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new Fire-arm configuration?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceMapping.AddNew();

                ddlAllowance.SelectedIndex = 0;
                ddlCustomer.SelectedIndex = 0;
                ddlDuty.SelectedIndex = 0;
                ddlGuard.SelectedIndex = 0;
                spnHours.Value = 0;
                spnRate.Value = 0;

                ddlDuty.Enabled = true;
                ddlCustomer.Enabled = true;
                ddlAllowance.Enabled = true;
                ddlGuard.Enabled = true;
                spnHours.Enabled = true;
                spnRate.Enabled = true;

                grdDataDisplay.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grdDataDisplay.Enabled)
                return;

            if (ddlCustomer.SelectedValue == null || Convert.ToInt32(ddlCustomer.SelectedValue) == 0)
            {
                RadMessageBox.Show("A customer must be selected!", Application.ProductName);
                return;
            }

            if (ddlAllowance.SelectedValue == null || Convert.ToInt32(ddlAllowance.SelectedValue) == 0)
            {
                RadMessageBox.Show("An allowance must be selected!", Application.ProductName);
                return;
            }

            if (ddlDuty.SelectedValue == null || Convert.ToInt32(ddlDuty.SelectedValue) == 0)
            {
                RadMessageBox.Show("A duty/service must be selected!", Application.ProductName);
                return;
            }

            if (ddlGuard.SelectedValue == null || Convert.ToInt32(ddlGuard.SelectedValue) == 0)
            {
                RadMessageBox.Show("A guard/contractor must be selected!", Application.ProductName);
                return;
            }

            if (Convert.ToDecimal(spnRate.Value) <= 0)
            {
                RadMessageBox.Show("Invalid rate detected", Application.ProductName);
                return;
            }

            if (Convert.ToDecimal(spnHours.Value) == 0)
            {
                DialogResult _prompt = RadMessageBox.Show("This allowance will be calculated on all hours worked\n" +
                                                          "Are you sure you want to continue with this transaction?",
                                                          Application.ProductName);

                if (_prompt == System.Windows.Forms.DialogResult.No)
                    return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _addOnId = ((ContractorAddon)bindingSourceMapping.Current).ContractorAddonId;

                try
                {
                    if (_addOnId == 0)
                    {
                        ContractorAddon _addMapping = new ContractorAddon();
                        _addMapping.CustomerId = Convert.ToInt32(ddlCustomer.SelectedValue);
                        _addMapping.DutyId = Convert.ToInt32(ddlDuty.SelectedValue);
                        _addMapping.AllowanceId = Convert.ToInt32(ddlAllowance.SelectedValue);
                        _addMapping.ContractorId = Convert.ToInt32(ddlGuard.SelectedValue);
                        _addMapping.LastModifiedDate = DateTime.Now;
                        _addMapping.AllowanceRate = Convert.ToDecimal(spnRate.Value);
                        _addMapping.CalculateOnMaxHours = Convert.ToDecimal(spnHours.Value);
                        _addMapping.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.ContractorAddons.Add(_addMapping);
                    }
                    else
                    {
                        var _findMappingRecord = dbContext.ContractorAddons.Where(z => z.ContractorAddonId == _addOnId).FirstOrDefault();
                        _findMappingRecord.AllowanceId = Convert.ToInt32(ddlAllowance.SelectedValue);
                        _findMappingRecord.DutyId = Convert.ToInt32(ddlDuty.SelectedValue);
                        _findMappingRecord.CustomerId = Convert.ToInt32(ddlCustomer.SelectedValue);
                        _findMappingRecord.LastModifiedDate = DateTime.Now;
                        _findMappingRecord.CalculateOnMaxHours = Convert.ToDecimal(spnHours.Value);
                        _findMappingRecord.AllowanceRate = Convert.ToDecimal(spnRate.Value);
                        _findMappingRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    ddlCustomer.Enabled = false;
                    ddlDuty.Enabled = false;
                    ddlAllowance.Enabled = false;
                    ddlGuard.Enabled = false;
                    spnHours.Enabled = false;
                    spnRate.Enabled = false;
                    bindingSourceMapping.Clear();
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
                ddlAllowance.Enabled = true;
                ddlDuty.Enabled = true;
                ddlCustomer.Enabled = true;
                spnHours.Enabled = true;
                spnRate.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void bindingSourceAllowance_PositionChanged(object sender, EventArgs e)
        {
            if (ddlAllowance.Enabled)
            {
                decimal _allowanceRate = ((Allowance)bindingSourceAllowance.Current).AllowanceRate;
                decimal _allowanceHrs = ((Allowance)bindingSourceAllowance.Current).CalculateOnMaxHours;

                spnHours.Value = _allowanceHrs;
                spnRate.Value = _allowanceRate;
            }
        }
    }
}
