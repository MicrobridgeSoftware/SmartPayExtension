using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Linq;
using System.Data.Entity;
using Telerik.WinControls.Export;
using System.IO;
using System.Diagnostics;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.Data;
using SMARTPayExtension.TechLibrary;


namespace SMARTPayExtension.UI.Forms.Employee
{
    public partial class GuardLocationForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        List<ImportedTransactionsLocationView> _importedTransactions;

        public GuardLocationForm()
        {
            InitializeComponent();
        }

        private void GuardLocationForm_Load(object sender, EventArgs e)
        {
            rbnDateRange.IsChecked = false;
            rbnFileName.IsChecked = false;
            rbnPath.IsChecked = false;

            dtpStartDate.Value = DateTime.Today.Date;
            LoadAutoCompleteInfo();            
        }

        private void LoadAutoCompleteInfo()
        {
            this.tbcFileName.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.tbcImportedFrom.AutoCompleteMode = AutoCompleteMode.Suggest;

            RadListDataItemCollection _autoCompleteItems1 = this.tbcFileName.AutoCompleteItems;
            RadListDataItemCollection _autoCompleteItems2 = this.tbcImportedFrom.AutoCompleteItems;

            var _history = dbContext.ImportedTransactions.Select(s => new { s.ImportedBy, s.FileSaveName }).Distinct().ToList();

            foreach (var _description in _history)
            {
                _autoCompleteItems1.Add(new RadListDataItem(_description.FileSaveName));
                _autoCompleteItems2.Add(new RadListDataItem(_description.ImportedBy));
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool _filterSelected = ValidateFilterStatus();

            if (!_filterSelected)
            {
                RadMessageBox.Show("No filter option selected", Application.ProductName);
                return;
            }

            _importedTransactions = new List<ImportedTransactionsLocationView>();
            DateTime _startDate = dtpStartDate.Value;
            DateTime _endDate = dtpEndDate.Value;
            string _fileName = tbcFileName.Text.Trim();
            string _user = tbcImportedFrom.Text.Trim();

            GrdDataDisplay.GroupDescriptors.Remove("ContractorDescription");

            if (rbnDateRange.IsChecked)
                _importedTransactions = dbContext.ImportedTransactionsLocationViews.Where(x => x.DateImported >= _startDate && x.DateImported <= _endDate).AsNoTracking().ToList();
            else if (rbnFileName.IsChecked)
                _importedTransactions = dbContext.ImportedTransactionsLocationViews.Where(x => x.FileSaveName.Trim().Equals(_fileName)).AsNoTracking().ToList();
            else if (rbnPath.IsChecked)
                _importedTransactions = dbContext.ImportedTransactionsLocationViews.Where(x => x.ImportedBy.Trim().Equals(_user)).AsNoTracking().ToList();

            chkUpdate.Checked = false;

            GrdDataDisplay.DataSource = _importedTransactions;

            if (GrdDataDisplay.Rows.Count > 0)
            {
                UpdateGuardClientAmount();

                GroupDescriptor _groupDescriptor = new GroupDescriptor();
                _groupDescriptor.GroupNames.Add("ContractorDescription", ListSortDirection.Ascending);
                this.GrdDataDisplay.GroupDescriptors.Add(_groupDescriptor);
                GrdDataDisplay.MasterTemplate.ExpandAllGroups();

                btnExport.Enabled = true;
            }
        }

        private void UpdateGuardClientAmount()
        {
            for (int _row = 0; _row < GrdDataDisplay.Rows.Count; _row++)
            {
                int _contractorId = Convert.ToInt32(GrdDataDisplay.Rows[_row].Cells["ContractorId"].Value);

                int _locationCount = _importedTransactions.Where(x => x.ContractorId == _contractorId).GroupBy(x => x.CustomerRef).Select(x=> x.Key).Count();

                GrdDataDisplay.Rows[_row].Cells["NoOfLocation"].Value = _locationCount;
            }
        }

        private bool ValidateFilterStatus()
        {
            foreach (Control control in radGroupBox1.Controls)
            {
                if (control is RadRadioButton)
                {
                    RadRadioButton _radiobutton = (RadRadioButton)control;

                    if (_radiobutton.IsChecked)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void chkUpdate_CheckStateChanged(object sender, EventArgs e)
        {
            if (GrdDataDisplay.Rows.Count > 0)
            {
                for (int _row = 0; _row < GrdDataDisplay.Rows.Count; _row++)
                {                    
                    int _locationCount = Convert.ToInt32(GrdDataDisplay.Rows[_row].Cells["NoOfLocation"].Value);

                    if (_locationCount == 1)
                    {
                        if (chkUpdate.Checked == true)
                            GrdDataDisplay.Rows[_row].Cells["Update"].Value = true;
                        else
                            GrdDataDisplay.Rows[_row].Cells["Update"].Value = false;
                    }
                }
            }
        }

        private void GrdDataDisplay_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["NoOfLocation"].Value != null && Convert.ToInt32(e.RowElement.RowInfo.Cells["NoOfLocation"].Value) > 1)
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.Tomato;
            }
            else
            {
                e.RowElement.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (GrdDataDisplay.Rows.Count <= 0)
                return;
            
            var _selectedRows = GrdDataDisplay.Rows.Where(x => x.Cells["Update"].Value != null && Convert.ToBoolean(x.Cells["Update"].Value) == true).ToList();

            if (_selectedRows.Count == 0)
            {
                RadMessageBox.Show("No record has been selected to facilitate an update", Application.ProductName);
                return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to Update the Selected Guard Location(s)?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    foreach (var _row in _selectedRows)
                    {
                        GuardLocationPayrollUpdate _createRecord = new GuardLocationPayrollUpdate();
                        _createRecord.ContractorId = Convert.ToInt32(_row.Cells["ContractorId"].Value);
                        _createRecord.CreatedBy = SMARTPayExtConstants._activeUser;
                        _createRecord.DateCreated = DateTime.Now;
                        _createRecord.LocationId = Convert.ToInt32(_row.Cells["CustomerId"].Value);
                        _createRecord.PayrollUpdated = false;
                        dbContext.GuardLocationPayrollUpdates.Add(_createRecord);
                    }

                    dbContext.SaveChanges();

                    dbContext.UpdateGuardLocation();

                    RadMessageBox.Show("SMARTPay Employee Location(s) updated successfully!", Application.ProductName);
                    btnExport.Enabled = false;
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void rbnDateRange_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnDateRange.IsChecked)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
            }
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
            }
        }

        private void rbnFileName_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnFileName.IsChecked)
                tbcFileName.Enabled = true;
            else
                tbcFileName.Enabled = false;
        }

        private void rbnPath_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnPath.IsChecked)
                tbcImportedFrom.Enabled = true;
            else
                tbcImportedFrom.Enabled = false;
        }

        private void GrdDataDisplay_RowValidating(object sender, RowValidatingEventArgs e)
        {
            if (e.Row.Cells["Update"].Value != null && (bool)e.Row.Cells["Update"].Value == true)
            {
                int _contractorId = Convert.ToInt32(e.Row.Cells["ContractorId"].Value);

                var _countSelectedRows = GrdDataDisplay.Rows.Where(x => Convert.ToInt32(x.Cells["ContractorId"].Value) == _contractorId 
                                         && Convert.ToBoolean(x.Cells["Update"].Value) == true).ToList();

                if (_countSelectedRows.Count > 1)
                {
                    RadMessageBox.Show("Only one row is eleigible for selection per employee!", Application.ProductName);
                    e.Cancel = true;
                }
            }
            
        }
    }
}