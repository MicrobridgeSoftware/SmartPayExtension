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
    public partial class ZoneForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public ZoneForm()
        {
            InitializeComponent();
        }

        private void ZoneForm_Load(object sender, EventArgs e)
        {
            getFormData();
        }

        public void getFormData()
        {
            var _zones = dbContext.Zones.Where(x => x.Active).ToList();

            bindingSourceZone.DataSource = _zones;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            RadMessageBox.Show("Regions are automatically fed from the Payroll Application\n" +
                               "Kindly add your respective region(s) in SMARTPay!", 
                               Application.ProductName);            

            //DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new Zone?", Application.ProductName, MessageBoxButtons.YesNo);

            //if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            //{
            //    bindingSourceZone.AddNew();
            //    txtDescription.Text = string.Empty;
            //    txtDescription.Enabled = true;                
            //    chkActive.Checked = true;
            //    grdDataDisplay.Enabled = false;
            //}
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

            //if (string.IsNullOrEmpty(txtDescription.Text))
            //{
            //    RadMessageBox.Show("Holiday rate description cannot be empty!", Application.ProductName);
            //    return;
            //}
                        
            //DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            //if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            //{
            //    int _zoneId = ((Zone)bindingSourceZone.Current).ZoneId;

            //    try
            //    {
            //        if (_zoneId == 0)
            //        {
            //            Zone _addZone = new Zone();
            //            _addZone.Description = txtDescription.Text.Trim();
            //            _addZone.Active = true;
            //            _addZone.LastModifiedDate = DateTime.Now;
            //            _addZone.LastModifiedBy = SMARTPayExtConstants._activeUser;
            //            dbContext.Zones.Add(_addZone);
            //        }
            //        else
            //        {
            //            var _findZoneRecord = dbContext.Zones.Where(z => z.ZoneId == _zoneId).FirstOrDefault();
            //            _findZoneRecord.Description = txtDescription.Text.Trim();
            //            _findZoneRecord.Active = chkActive.Checked ? true : false;
            //            _findZoneRecord.LastModifiedDate = DateTime.Now;
            //            _findZoneRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
            //        }

            //        dbContext.SaveChanges();
            //        grdDataDisplay.Enabled = true;
            //        txtDescription.Enabled = false;
            //        chkActive.Enabled = false;
            //        bindingSourceZone.Clear();
            //        getFormData();
            //        RadMessageBox.Show("Record created successfully!", Application.ProductName);
            //    }
            //    catch (Exception _exp)
            //    {
            //        RadMessageBox.Show(_exp.InnerException.Message == null ? _exp.Message : _exp.InnerException.Message);
            //    }
            //}
        }

        private void grdDataDisplay_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RadMessageBox.Show("This record must be edited from SMARTPay?", Application.ProductName);

            
            //DialogResult _verifyAction = RadMessageBox.Show("Do you want to edit this record?", Application.ProductName, MessageBoxButtons.YesNo);

            //if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            //{
            //    grdDataDisplay.Enabled = false;
            //    txtDescription.Enabled = true;
            //    chkActive.Enabled = true;
            //}
        }
    }
}
