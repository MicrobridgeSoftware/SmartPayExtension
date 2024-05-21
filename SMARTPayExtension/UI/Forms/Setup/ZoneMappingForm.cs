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
    public partial class ZoneMappingForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();

        public ZoneMappingForm()
        {
            InitializeComponent();
        }

        private void ZoneMappingForm_Load(object sender, EventArgs e)
        {
            getFormData();

            this.ddlZone.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.ddlCustomer.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;

            this.ddlCustomer.DropDownListElement.AutoCompleteAppend.LimitToList = true;
            this.ddlZone.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        public void getFormData()
        {
            grdDataDisplay.GroupDescriptors.Remove("Zone");
                        
            var _zones = dbContext.Zones.OrderBy(x=> x.Description).ToList();
            var _customers = dbContext.CustomerViews.OrderBy(x=> x.CustomerDescription).ToList();
            var _zoneMapping = dbContext.ZoneMappings.Include("Zone").Include("CustomerView").AsNoTracking().ToList();

            bindingSourceZone.DataSource = _zones;
            bindingSourceCustomer.DataSource = _customers;
            bindingSourceMapping.DataSource = _zoneMapping;

            GroupDescriptor _groupDescriptor = new GroupDescriptor();
            _groupDescriptor.GroupNames.Add("Zone", ListSortDirection.Ascending);
            this.grdDataDisplay.GroupDescriptors.Add(_groupDescriptor);
            grdDataDisplay.MasterTemplate.ExpandAllGroups();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new Zone Mapping?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceMapping.AddNew();
                ddlCustomer.SelectedIndex = -1;
                ddlZone.SelectedIndex = -1;
                ddlZone.Enabled = true;
                ddlCustomer.Enabled = true;
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

            if (ddlCustomer.SelectedValue == null || Convert.ToInt32(ddlCustomer.SelectedValue) == 0)
            {
                RadMessageBox.Show("A customer must be selected!", Application.ProductName);
                return;
            }

            if (ddlZone.SelectedValue == null || Convert.ToInt32(ddlZone.SelectedValue) == 0)
            {
                RadMessageBox.Show("A zone must be selected!", Application.ProductName);
                return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _customerId = ((ZoneMapping)bindingSourceMapping.Current).CustomerId;
                bool _customerExist = dbContext.ZoneMappings.Any(x => x.CustomerId == _customerId);

                try
                {
                    if (!_customerExist)
                    {
                        ZoneMapping _addZoneMapping = new ZoneMapping();
                        _addZoneMapping.CustomerId = Convert.ToInt32(ddlCustomer.SelectedValue);
                        _addZoneMapping.ZoneId = Convert.ToInt32(ddlZone.SelectedValue);
                        _addZoneMapping.LastModifiedDate = DateTime.Now;
                        _addZoneMapping.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.ZoneMappings.Add(_addZoneMapping);
                    }
                    else
                    {
                        var _findZoneMappingRecord = dbContext.ZoneMappings.Where(z => z.CustomerId == _customerId).FirstOrDefault();
                        _findZoneMappingRecord.ZoneId = Convert.ToInt32(ddlZone.SelectedValue);
                        _findZoneMappingRecord.LastModifiedDate = DateTime.Now;
                        _findZoneMappingRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    ddlCustomer.Enabled = false;
                    ddlZone.Enabled = false;
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
                ddlZone.Enabled = true;
            }
        }
    }
}
