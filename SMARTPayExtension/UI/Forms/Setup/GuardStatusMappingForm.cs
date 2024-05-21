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
    public partial class GuardStatusMappingForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public GuardStatusMappingForm()
        {
            InitializeComponent();
        }

        private void GuardStatusMappingForm_Load(object sender, EventArgs e)
        {
            getFormData();

            this.ddlContractor.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlStatus.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;

            this.ddlContractor.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlStatus.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        public void getFormData()
        {
            var _guard = dbContext.ContractorViews.OrderBy(x=> x.ContractorDescription).ToList();
            var _status = dbContext.GuardTypes.OrderBy(x=> x.GuardTypeDescription).ToList();
            var _mappings = dbContext.GuardStatusMappings.Include("ContractorView").Include("GuardType").AsNoTracking().ToList();

            bindingSourceGuard.DataSource = _guard;
            bindingSourceStatus.DataSource = _status;
            bindingSourceMapping.DataSource = _mappings;
        }

        private void grdDataDisplay_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to edit this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                grdDataDisplay.Enabled = false;
                ddlStatus.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grdDataDisplay.Enabled)
                return;

            if (ddlContractor.SelectedValue == null || (int)ddlContractor.SelectedValue == 0)
            {
                RadMessageBox.Show("A contractor must be selected!", Application.ProductName);
                return;
            }

            if (ddlStatus.SelectedValue == null || (int)ddlStatus.SelectedValue == 0)
            {
                RadMessageBox.Show("A status type must be selected!", Application.ProductName);
                return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _contractorId = ((GuardStatusMapping)bindingSourceMapping.Current).ContractorId;
                bool _contractorExist = dbContext.GuardStatusMappings.Any(x => x.ContractorId == _contractorId);

                try
                {
                    if (!_contractorExist)
                    {
                        GuardStatusMapping _addMapping = new GuardStatusMapping();
                        _addMapping.ContractorId = (int)ddlContractor.SelectedValue;
                        _addMapping.GuardTypeId = (int)ddlStatus.SelectedValue;
                        _addMapping.LastModifiedDate = DateTime.Now;
                        decimal _rateValue = Convert.ToDecimal(txtRate.Text);
                        decimal _rate = Math.Round(_rateValue, 2);
                        _addMapping.Rate = _rate;
                        _addMapping.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.GuardStatusMappings.Add(_addMapping);
                    }
                    else
                    {
                        var _findMappingRecord = dbContext.GuardStatusMappings.Where(m => m.ContractorId == _contractorId).FirstOrDefault();
                        _findMappingRecord.GuardTypeId = (int)ddlStatus.SelectedValue;
                        decimal _rateValue = Convert.ToDecimal(txtRate.Text);
                        decimal _rate = Math.Round(_rateValue, 2);
                        _findMappingRecord.Rate = _rate; 
                        _findMappingRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        _findMappingRecord.LastModifiedDate = DateTime.Now;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    ddlContractor.Enabled = false;
                    ddlStatus.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a mapping?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceMapping.AddNew();
                ddlContractor.Enabled = true;
                ddlStatus.Enabled = true;
                ddlContractor.SelectedIndex = -1;
                ddlStatus.SelectedIndex = -1;
                grdDataDisplay.Enabled = false;
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
