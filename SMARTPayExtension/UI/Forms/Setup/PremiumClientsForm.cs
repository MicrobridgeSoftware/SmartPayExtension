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

namespace SMARTPayExtension.UI.Forms.Setup
{
    public partial class PremiumClientsForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public PremiumClientsForm()
        {
            InitializeComponent();
        }

        private void PremiumClientsForm_Load(object sender, EventArgs e)
        {
            getFormData();

            this.ddlAllowance.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlCustomer.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlDuty.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;

            this.ddlAllowance.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlCustomer.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlDuty.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        public void getFormData()
        {
            var _customers = dbContext.CustomerViews.OrderBy(x=> x.CustomerDescription).ToList();
            var _allowance = dbContext.Allowances.OrderBy(x=> x.AllowanceDescription).ToList();
            var _dutyType = dbContext.DutyCodeViews.OrderBy(x=> x.DutyCode).ToList();
            var _mapping = dbContext.PremiumClients.Include("Allowance").Include("DutyCodeView").Include("CustomerView").AsNoTracking().ToList();

            bindingSourceAllowance.DataSource = _allowance;
            bindingSourceClient.DataSource = _customers;
            bindingSourceDuty.DataSource = _dutyType;
            bindingSourceMapping.DataSource = _mapping;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new Premium Client?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceMapping.AddNew();

                ddlAllowance.SelectedIndex = 0;
                ddlCustomer.SelectedIndex = 0;
                ddlDuty.SelectedIndex = 0;
                spnRate.Value = 0;
                spnHours.Value = 0;

                ddlDuty.Enabled = true;
                ddlCustomer.Enabled = true;
                ddlAllowance.Enabled = true;
                spnHours.Enabled = true;
                spnRate.Enabled = true;
                txtDutyDescription.Enabled = true;

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
                int _premiumClientId = ((PremiumClient)bindingSourceMapping.Current).PremiumClientId;

                try
                {
                    if (_premiumClientId == 0)
                    {
                        PremiumClient _addClientMapping = new PremiumClient();
                        _addClientMapping.CustomerId = Convert.ToInt32(ddlCustomer.SelectedValue);
                        _addClientMapping.DutyId = Convert.ToInt32(ddlDuty.SelectedValue);
                        _addClientMapping.AllowanceId = Convert.ToInt32(ddlAllowance.SelectedValue);
                        _addClientMapping.LastModifiedDate = DateTime.Now;
                        _addClientMapping.AllowanceRate = Convert.ToDecimal(spnRate.Value);
                        _addClientMapping.CalculateOnMaxHours = Convert.ToDecimal(spnHours.Value);
                        _addClientMapping.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.PremiumClients.Add(_addClientMapping);
                    }
                    else
                    {
                        var _findClientMappingRecord = dbContext.PremiumClients.Where(z => z.PremiumClientId == _premiumClientId).FirstOrDefault();
                        _findClientMappingRecord.AllowanceId = Convert.ToInt32(ddlAllowance.SelectedValue);
                        _findClientMappingRecord.DutyId = Convert.ToInt32(ddlDuty.SelectedValue);
                        _findClientMappingRecord.LastModifiedDate = DateTime.Now;
                        _findClientMappingRecord.CalculateOnMaxHours = Convert.ToDecimal(spnHours.Value);
                        _findClientMappingRecord.AllowanceRate = Convert.ToDecimal(spnRate.Value);
                        _findClientMappingRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    ddlCustomer.Enabled = false;
                    ddlDuty.Enabled = false;
                    ddlAllowance.Enabled = false;
                    spnRate.Enabled = false;
                    spnHours.Enabled = false;
                    txtDutyDescription.Enabled = false;
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
                DialogResult _promptForDelete = RadMessageBox.Show("Would you like to totally remove this record?", Application.ProductName, MessageBoxButtons.YesNo);

                if (_promptForDelete == System.Windows.Forms.DialogResult.Yes)
                {
                    int _premiumClientId = ((PremiumClient)bindingSourceMapping.Current).PremiumClientId;

                    var _clientRecord = dbContext.PremiumClients.Where(z => z.PremiumClientId == _premiumClientId).FirstOrDefault();

                    if (_clientRecord != null)
                    {
                        try
                        {
                            _clientRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                            dbContext.SaveChanges();

                            dbContext.PremiumClients.Remove(_clientRecord);
                            dbContext.SaveChanges();
                            bindingSourceMapping.Clear();
                            getFormData();
                            RadMessageBox.Show("Record removed successfully!", Application.ProductName);
                        }
                        catch (Exception exp)
                        {
                            RadMessageBox.Show(exp.InnerException == null ? exp.Message : exp.InnerException.Message);
                        }
                    }
                }
                else
                {
                    grdDataDisplay.Enabled = false;
                    ddlAllowance.Enabled = true;
                    ddlDuty.Enabled = true;
                    spnHours.Enabled = true;
                    spnRate.Enabled = true;
                    txtDutyDescription.Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }
    }
}