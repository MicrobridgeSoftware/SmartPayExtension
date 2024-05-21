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

namespace SMARTPayExtension.UI.Forms.Setup
{
    public partial class DutyTypeForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public DutyTypeForm()
        {
            InitializeComponent();
        }

        private void DutyTypeForm_Load(object sender, EventArgs e)
        {
            getFormData();

            this.ddlAllowance.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlDuty.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;

            this.ddlAllowance.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlDuty.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a duty mapping?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceDutyAllowanceMapping.AddNew();
                ddlAllowance.Enabled = true;
                ddlDuty.Enabled = true;
                ddlAllowance.SelectedIndex = -1;
                ddlDuty.SelectedIndex = -1;
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

            if (ddlAllowance.SelectedValue == null || (int)ddlAllowance.SelectedValue == 0)
            {
                RadMessageBox.Show("An allowance must be selected!", Application.ProductName);
                return;
            }

            if (ddlDuty.SelectedValue == null || (int)ddlDuty.SelectedValue == 0)
            {
                RadMessageBox.Show("A duty type must be selected!", Application.ProductName);
                return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _dutyId = ((DutyAllowanceMapping)bindingSourceDutyAllowanceMapping.Current).DutyAllowanceId;//((DutyAllowanceMapping)bindingSourceDutyAllowanceMapping.Current).DutyId;

                try
                {
                    if (_dutyId == 0)
                    {
                        DutyAllowanceMapping _addMapping = new DutyAllowanceMapping();
                        _addMapping.DutyId = (int)ddlDuty.SelectedValue;
                        _addMapping.AllowanceId = (int)ddlAllowance.SelectedValue;
                        _addMapping.LastModifiedDate = DateTime.Now;
                        _addMapping.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.DutyAllowanceMappings.Add(_addMapping);
                    }
                    else
                    {
                        int _dutyAllowanceId = _dutyId;// ((DutyAllowanceMapping)bindingSourceDutyAllowanceMapping.Current).DutyAllowanceId;

                        var _findMappingRecord = dbContext.DutyAllowanceMappings.Where(m => m.DutyAllowanceId == _dutyAllowanceId).FirstOrDefault();
                        _findMappingRecord.AllowanceId = (int)ddlAllowance.SelectedValue;
                        _findMappingRecord.LastModifiedDate = DateTime.Now;
                        _findMappingRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    ddlAllowance.Enabled = false;
                    ddlDuty.Enabled = false;
                    bindingSourceDutyAllowanceMapping.Clear();
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
            }
        }

        public void getFormData()
        {
            grdDataDisplay.GroupDescriptors.Remove("DutyCode");

            var _allowances = dbContext.Allowances.OrderBy(x=> x.AllowanceDescription).ToList();
            var _dutyTypes = dbContext.DutyCodeViews.OrderBy(x=> x.DutyCode).ToList();
            var _mappings = dbContext.DutyAllowanceMappings.Include("Allowance").AsNoTracking().ToList();

            bindingSourceAllowance.DataSource = _allowances;
            bindingSourceDutyType.DataSource = _dutyTypes;
            bindingSourceDutyAllowanceMapping.DataSource = _mappings;

            GroupDescriptor descriptor = new GroupDescriptor();
            descriptor.GroupNames.Add("DutyCode", ListSortDirection.Ascending);
            this.grdDataDisplay.GroupDescriptors.Add(descriptor);
            grdDataDisplay.MasterTemplate.ExpandAllGroups();
        }
    }
}