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
    public partial class HolidayForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        DateTime _holidayDate = DateTime.Today.Date;
        public HolidayForm()
        {
            InitializeComponent();
        }

        private void HolidayForm_Load(object sender, EventArgs e)
        {
            dtpDate.MinDate = DateTime.Today.Date;
            getFormData();
        }

        public void getFormData()
        {
            var _holiday = dbContext.Holidays.Include("HolidayRate").AsNoTracking().ToList();
            var _holidayRates = dbContext.HolidayRates.AsNoTracking().ToList();

            bindingSourceHolidayRates.DataSource = _holidayRates;
            bindingSourceHoliday.DataSource = _holiday;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!grdDataDisplay.Enabled)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add a new Holiday?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                bindingSourceHoliday.AddNew();
                txtDescription.Text = string.Empty;
                txtDescription.Enabled = true;
                txtPayrollCode.Text = string.Empty;
                txtPayrollCode.Enabled = true;
                dtpDate.Enabled = true;
                ddlRate.Enabled = true;
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
                RadMessageBox.Show("Holiday description cannot be empty!", Application.ProductName);
                return;
            }

            if (ddlRate.SelectedValue == null || (int)ddlRate.SelectedValue == 0)
            {
                RadMessageBox.Show("Select rate of pay for this Holiday!", Application.ProductName);
                return;
            }

            if (string.IsNullOrEmpty(txtPayrollCode.Text))
            {
                RadMessageBox.Show("Payroll code cannot be empty!", Application.ProductName);
                return;
            }
            else
            {
                var _payrollCodeExist = dbContext.PayrollCodeViews.Where(x => x.Code.Trim() == txtPayrollCode.Text.Trim()).FirstOrDefault();

                if (_payrollCodeExist == null)
                {
                    RadMessageBox.Show("This payroll code does not exist in the SMARTPay", Application.ProductName);
                    return;
                }
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to save this record?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _holidayId = ((Holiday)bindingSourceHoliday.Current).HolidayId;

                try
                {
                    if (_holidayId == 0)
                    {
                        Holiday _addHoliday = new Holiday();
                        _addHoliday.Description = txtDescription.Text.Trim();
                        _addHoliday.Date = dtpDate.Value;
                        _addHoliday.HolidayRateId = (int)ddlRate.SelectedValue;
                        _addHoliday.LastModified = DateTime.Now;
                        _addHoliday.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        _addHoliday.PayrollCode = txtPayrollCode.Text.Trim();
                        dbContext.Holidays.Add(_addHoliday);
                    }
                    else
                    {
                        var _findHolidayRecord = dbContext.Holidays.Where(h => h.HolidayId == _holidayId).FirstOrDefault();
                        _findHolidayRecord.Description = txtDescription.Text.Trim();
                        _findHolidayRecord.Date = dtpDate.Value;
                        _findHolidayRecord.HolidayRateId = (int)ddlRate.SelectedValue;
                        _findHolidayRecord.LastModified = DateTime.Now;
                        _findHolidayRecord.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        _findHolidayRecord.PayrollCode = txtPayrollCode.Text.Trim();
                    }

                    dbContext.SaveChanges();
                    grdDataDisplay.Enabled = true;
                    txtDescription.Enabled = false;
                    txtPayrollCode.Enabled = false;
                    dtpDate.Enabled = false;
                    ddlRate.Enabled = false;
                    bindingSourceHoliday.Clear();
                    bindingSourceHolidayRates.Clear();
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
                if (_holidayDate < DateTime.Today.Date)
                {
                    RadMessageBox.Show("This transaction cannot be modified!", Application.ProductName);
                    return;
                }
                
                grdDataDisplay.Enabled = false;
                txtDescription.Enabled = true;
                txtPayrollCode.Enabled = true;
                dtpDate.Enabled = true;
                ddlRate.Enabled = true;
            }
        }

        private void grdDataDisplay_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (grdDataDisplay.CurrentRow != null && e.RowIndex >= 0)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(e.Row.Cells["Date"].Value)))
                {
                    _holidayDate = ((DateTime)e.Row.Cells["Date"].Value).Date;
                }
            }
        }
    }
}
