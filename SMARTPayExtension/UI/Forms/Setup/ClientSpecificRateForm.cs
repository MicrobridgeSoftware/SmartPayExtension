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
    public partial class ClientSpecificRateForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public ClientSpecificRateForm()
        {
            InitializeComponent();
        }

        public void getFormData()
        {
            var _client = dbContext.CustomerViews.OrderBy(x=> x.CustomerDescription).ToList();
            var _guardType = dbContext.GuardTypes.Where(x => x.Allowance == false).OrderBy(x => x.GuardTypeDescription).ToList();
            var _clientRates = dbContext.CustomerSpecificRates.Include("CustomerView").AsNoTracking().ToList();

            bindingSourceCustomer.DataSource = _client;
            bindingSourceGuardType.DataSource = _guardType;
            bindingSourceClientRate.DataSource = _clientRates;            
        }

        private void grdDataDisplay_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to edit this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                grdDataDisplay.Enabled = false;
                ddlGuardType.Enabled = true;
                spnRate.Enabled = true;
                chkAllowance.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grdDataDisplay.Enabled)
                return;

            if (ddlCustomer.SelectedValue == null || (int)ddlCustomer.SelectedValue == 0)
            {
                RadMessageBox.Show("A client must be selected!", Application.ProductName);
                return;
            }

            if (ddlGuardType.SelectedValue == null || (int)ddlGuardType.SelectedValue == 0)
            {
                RadMessageBox.Show("A Guard Type must be selected!", Application.ProductName);
                return;
            }
            
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _customerId = ((CustomerSpecificRate)bindingSourceClientRate.Current).CustomerId;
                bool _customerExist = dbContext.CustomerSpecificRates.Any(x => x.CustomerId == _customerId);

                try
                {
                    if (!_customerExist)
                    {
                        CustomerSpecificRate _addRate = new CustomerSpecificRate();
                        _addRate.CustomerId = (int)ddlCustomer.SelectedValue;
                        _addRate.GuardTypeId = (int)ddlGuardType.SelectedValue;
                        _addRate.Allowance = chkAllowance.Checked == true ? true : false;
                        _addRate.Rate = Convert.ToDecimal(spnRate.Value);
                        _addRate.LastModifiedDate = DateTime.Now;
                        _addRate.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.CustomerSpecificRates.Add(_addRate);
                    }
                    else
                    {
                        var _findClientRecord = dbContext.CustomerSpecificRates.Where(m => m.CustomerId == _customerId).FirstOrDefault();
                        _findClientRecord.GuardTypeId = (int)ddlGuardType.SelectedValue;
                        _findClientRecord.Allowance = chkAllowance.Checked == true ? true : false;
                        _findClientRecord.Rate = Convert.ToDecimal(spnRate.Value);
                        _findClientRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        _findClientRecord.LastModifiedDate = DateTime.Now;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    ddlCustomer.Enabled = false;
                    ddlGuardType.Enabled = false;
                    chkAllowance.Enabled = false;
                    spnRate.Enabled = false;
                    bindingSourceClientRate.Clear();
                    getFormData();
                    RadMessageBox.Show("Record created successfully!", Application.ProductName);
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceClientRate.AddNew();
                ddlCustomer.Enabled = true;
                ddlGuardType.Enabled = true;
                spnRate.Enabled = true;
                chkAllowance.Enabled = true;
                ddlCustomer.SelectedIndex = -1;
                ddlGuardType.SelectedIndex = -1;
                spnRate.Value = 1;
                grdDataDisplay.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void ClientSpecificRateForm_Load(object sender, EventArgs e)
        {
            getFormData();
            
            this.ddlCustomer.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlGuardType.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;

            this.ddlCustomer.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlGuardType.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }
    }
}