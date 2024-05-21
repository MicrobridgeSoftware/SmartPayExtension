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
    public partial class HolidayPayRate : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public HolidayPayRate()
        {
            InitializeComponent();
        }

        private void HolidayPayRate_Load(object sender, EventArgs e)
        {
            getFormData();
        }

        public void getFormData()
        {
            var _holidayRates = dbContext.HolidayRates.Where(x=> x.Active).ToList();

            bindingSourceHolidayRate.DataSource = _holidayRates;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new Pay Rate?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceHolidayRate.AddNew();
                txtDescription.Text = string.Empty;
                txtDescription.Enabled = true;
                spnMultiplier.Value = 0;
                spnMultiplier.Enabled = true;
                chkActive.Checked = true;
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
                RadMessageBox.Show("Holiday rate description cannot be empty!", Application.ProductName);
                return;
            }

            if ((decimal)spnMultiplier.Value <= 0)
            {
                RadMessageBox.Show("Multiplier must be greater than zero!", Application.ProductName);
                return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _holidayRateId = ((HolidayRate)bindingSourceHolidayRate.Current).HolidayRateId;

                try
                {
                    if (_holidayRateId == 0)
                    {
                        HolidayRate _addHolidayRate = new HolidayRate();
                        _addHolidayRate.Description = txtDescription.Text.Trim();
                        _addHolidayRate.RateMultiplier = spnMultiplier.Value;
                        _addHolidayRate.Active = true;
                        _addHolidayRate.LastModiedDate = DateTime.Now;
                        _addHolidayRate.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.HolidayRates.Add(_addHolidayRate);
                    }
                    else
                    {
                        var _findHolidayRateRecord = dbContext.HolidayRates.Where(h => h.HolidayRateId == _holidayRateId).FirstOrDefault();
                        _findHolidayRateRecord.Description = txtDescription.Text.Trim();
                        _findHolidayRateRecord.Active = chkActive.Checked ? true : false;
                        _findHolidayRateRecord.LastModiedDate = DateTime.Now;
                        _findHolidayRateRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    txtDescription.Enabled = false;
                    chkActive.Enabled = false;
                    spnMultiplier.Enabled = false;
                    bindingSourceHolidayRate.Clear();
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
                chkActive.Enabled = true;
            }
        }
    }
}
