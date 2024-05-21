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

namespace SMARTPayExtension.UI.Forms.Import
{
    public partial class ImportTransactionLookup : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        List<ImportedTransactionsView> _importedList;
        object BgwArgument;
        public ImportTransactionLookup()
        {
            InitializeComponent();
        }

        private void ImportTransactionLookup_Load(object sender, EventArgs e)
        {
            ExportWaitingBar.Visible = false;
            ExportWaitingBar.StopWaiting();

            dtpStartDate.Value = DateTime.Today.Date;
            rbnDateRange.IsChecked = false;
            rbnFileName.IsChecked = false;
            rbnPath.IsChecked = false;

            LoadAutoCompleteInfo();
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

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool _filterSelected = ValidateFilterStatus();

            if (!_filterSelected)
            {
                RadMessageBox.Show("No filter option selected", Application.ProductName);
                return;
            }

            _importedList = new List<ImportedTransactionsView>();
            GrdDataDisplay.GroupDescriptors.Remove("GuardTypeDescription");

            if (rbnDateRange.IsChecked)
                RecallImportByDateRange();
            else if (rbnFileName.IsChecked)
            {
                if (string.IsNullOrEmpty(tbcFileName.Text))
                {
                    RadMessageBox.Show("Enter file name for which you want to search", Application.ProductName);
                    return;
                }

                RecallImportByFileName();
            }
            else if (rbnPath.IsChecked)
            {
                if (string.IsNullOrEmpty(tbcImportedFrom.Text))
                {
                    RadMessageBox.Show("Enter path for which you want to search", Application.ProductName);
                    return;
                }

                RecallImportByPath();
            }

            GrdDataDisplay.DataSource = _importedList;

            if (_importedList.Count > 0)
            {                
                GroupDescriptor _groupDescriptor = new GroupDescriptor();
                _groupDescriptor.GroupNames.Add("GuardTypeDescription", ListSortDirection.Ascending);
                this.GrdDataDisplay.GroupDescriptors.Add(_groupDescriptor);
                GrdDataDisplay.MasterTemplate.ExpandAllGroups();
            }
        }

        private void RecallImportByDateRange()
        {
            _importedList = dbContext.ImportedTransactionsViews.Where(t => t.ConvertedImportDate >= dtpStartDate.Value
                            && t.ConvertedImportDate <= dtpEndDate.Value).ToList();            
        }

        private void RecallImportByFileName()
        {
            _importedList = dbContext.ImportedTransactionsViews.Where(t => t.FileSaveName.Trim() == tbcFileName.Text.Trim()).ToList();
        }

        private void RecallImportByPath()
        {
            _importedList = dbContext.ImportedTransactionsViews.Where(t => t.LocationImportedFrom.Trim() == tbcImportedFrom.Text.Trim()).ToList();
        }

        private void LoadAutoCompleteInfo()
        {
            this.tbcFileName.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.tbcImportedFrom.AutoCompleteMode = AutoCompleteMode.Suggest;

            RadListDataItemCollection _autoCompleteItems1 = this.tbcFileName.AutoCompleteItems;
            RadListDataItemCollection _autoCompleteItems2 = this.tbcImportedFrom.AutoCompleteItems;
            
            var _history = dbContext.ImportedTransactions.Select(s => new { s.LocationImportedFrom, s.FileSaveName }).Distinct().ToList();

            foreach (var _description in _history)
            {
                _autoCompleteItems1.Add(new RadListDataItem(_description.FileSaveName));
                _autoCompleteItems2.Add(new RadListDataItem(_description.LocationImportedFrom));
            }
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (GrdDataDisplay.Rows.Count <= 0)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to export the information displayed?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                if (!backgroundWorkerExport.IsBusy)
                {
                    BgwArgument = new object();
                    ExportWaitingBar.Show();
                    ExportWaitingBar.StartWaiting();

                    string _path = SaveDestination();

                    if (string.IsNullOrEmpty(_path))
                    {
                        RadMessageBox.Show("A destination must be selected for the saving of this file", Application.ProductName);
                        return;
                    }

                    BgwArgument = _path;
                    backgroundWorkerExport.RunWorkerAsync(BgwArgument);
                }
                else
                    RadMessageBox.Show("Data export is currently in process", Application.ProductName);                
            }            
        }

        private void backgroundWorkerExport_DoWork(object sender, DoWorkEventArgs e)
        {            
            string _destinationPath = e.Argument.ToString();

            string _saveAs = "Imported Tansactions";

            string fullpath = _destinationPath + "\\" + _saveAs + ".xlsx";

            bool fileExist = File.Exists(fullpath);

            if (fileExist)
            {
                FileInfo file = new FileInfo(fullpath);

                Process[] AllProcesses = Process.GetProcessesByName("excel");
                foreach (Process ExcelProcess in AllProcesses)
                {
                    RadMessageBox.Show("A file with the same name is detected or is currently opened \n" +
                                        "Close all related files or change file destination and try again", Application.ProductName);
                    return;
                }
            }

            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.GrdDataDisplay);
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();

            spreadExporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            spreadExporter.SheetName = _saveAs;
            spreadExporter.ExportVisualSettings = true;
            spreadExporter.FileExportMode = FileExportMode.CreateOrOverrideFile;
            this.GrdDataDisplay.Columns["TransactionDate"].ExcelExportType = DisplayFormatType.Custom;
            this.GrdDataDisplay.Columns["TransactionDate"].ExcelExportFormatString = "dd/MMM/yyyy";
            this.GrdDataDisplay.Columns["DateImported"].ExcelExportType = DisplayFormatType.Custom;
            this.GrdDataDisplay.Columns["DateImported"].ExcelExportFormatString = "dd/MMM/yyyy";
            this.GrdDataDisplay.Columns["ShiftTotal"].ExcelExportType = DisplayFormatType.Fixed;

            spreadExporter.RunExport(fullpath, exportRenderer);

            RadMessageBox.Show("File exported successfully!", Application.ProductName);
        }

        private void backgroundWorkerExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ExportWaitingBar.StopWaiting();
            ExportWaitingBar.Visible = false;
        }

        public string SaveDestination()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Select Path to save this export";
            folder.ShowDialog();
            string path = string.Empty;

            if (!string.IsNullOrEmpty(folder.SelectedPath))
                path = folder.SelectedPath;

            return path;
        }
    }
}