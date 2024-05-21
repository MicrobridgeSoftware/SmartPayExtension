using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using System.Linq;
using Telerik.WinControls.Data;

namespace SMARTPayExtension.UI.Forms.Export
{
    public partial class ExportTransactionLookup : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        List<ExportedTransactionSummary> _exportedList;
        object BgwArgument;
        public ExportTransactionLookup()
        {
            InitializeComponent();
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

            _exportedList = new List<ExportedTransactionSummary>();

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
            else if (rbnContractorName.IsChecked)
            {
                if (string.IsNullOrEmpty(tbcContractorName.Text))
                {
                    RadMessageBox.Show("Enter the Contractor for which you want to search", Application.ProductName);
                    return;
                }

                RecallExportByContractorName();
            }

            GrdDataDisplay.DataSource = _exportedList;

            if (GrdDataDisplay.Rows.Count > 0)
            {
                GrdDataDisplay.GroupDescriptors.Remove("ContractorDescription");
                GrdDataDisplay.SummaryRowsBottom.Clear();

                GroupDescriptor _groupDescriptor = new GroupDescriptor();
                _groupDescriptor.GroupNames.Add("ContractorDescription", ListSortDirection.Ascending);
                this.GrdDataDisplay.GroupDescriptors.Add(_groupDescriptor);
                GrdDataDisplay.MasterTemplate.ExpandAllGroups();

                GridViewSummaryItem summaryItem = new GridViewSummaryItem("Amount", "Total = {0:N2}", GridAggregateFunction.Sum);
                GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
                summaryRowItem.Add(summaryItem);
                this.GrdDataDisplay.SummaryRowsBottom.Add(summaryRowItem);
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

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
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

        private void rbnContractorName_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnContractorName.IsChecked)
                tbcContractorName.Enabled = true;
            else
                tbcContractorName.Enabled = false;
        }

        private void RecallImportByDateRange()
        {
            _exportedList = dbContext.ExportedTransactionSummaries.Where(t => t.DateExported >= dtpStartDate.Value
                            && t.DateExported <= dtpEndDate.Value).ToList();
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

        private void backgroundWorkerExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ExportWaitingBar.StopWaiting();
            ExportWaitingBar.Visible = false;
        }

        private void backgroundWorkerExport_DoWork(object sender, DoWorkEventArgs e)
        {
            string _destinationPath = e.Argument.ToString();

            string _saveAs = "Exported Tansactions";

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
            this.GrdDataDisplay.Columns["DateExported"].ExcelExportType = DisplayFormatType.Custom;
            this.GrdDataDisplay.Columns["DateExported"].ExcelExportFormatString = "dd/MMM/yyyy";
            this.GrdDataDisplay.Columns["ShiftTotal"].ExcelExportType = DisplayFormatType.Fixed;
            this.GrdDataDisplay.Columns["DutyRate"].ExcelExportType = DisplayFormatType.Fixed;
            this.GrdDataDisplay.Columns["Quantity"].ExcelExportType = DisplayFormatType.Fixed;

            spreadExporter.RunExport(fullpath, exportRenderer);

            RadMessageBox.Show("File exported successfully!", Application.ProductName);
        }

        private void RecallImportByFileName()
        {
            _exportedList = dbContext.ExportedTransactionSummaries.Where(t => t.FileSaveName.Trim() == tbcFileName.Text.Trim()).ToList();
        }

        private void RecallExportByContractorName()
        {
            _exportedList = dbContext.ExportedTransactionSummaries.Where(t => t.ContractorDescription == tbcContractorName.Text.Trim()).ToList();
        }

        private void LoadAutoCompleteInfo()
        {
            this.tbcFileName.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.tbcContractorName.AutoCompleteMode = AutoCompleteMode.Suggest;

            RadListDataItemCollection _autoCompleteItems1 = this.tbcFileName.AutoCompleteItems;
            RadListDataItemCollection _autoCompleteItems2 = this.tbcContractorName.AutoCompleteItems;

            var _history = dbContext.ExportedTransactionDetails.Select(s => new { s.FileSaveName, s.ContractorFirstName, s.ContractorLastName, s.ContractorRef }).Distinct().ToList();

            foreach (var _description in _history)
            {
                _autoCompleteItems1.Add(new RadListDataItem(_description.FileSaveName));
                _autoCompleteItems2.Add(new RadListDataItem(_description.ContractorRef.Trim() + " - " + _description.ContractorFirstName.Trim() + " " + _description.ContractorLastName.Trim()));
            }
        }

        private void ExportTransactionLookup_Load(object sender, EventArgs e)
        {
            ExportWaitingBar.StopWaiting();
            ExportWaitingBar.Visible = false;
            dtpStartDate.Value = DateTime.Today.Date;
            LoadAutoCompleteInfo();
        }

        private void GrdDataDisplay_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.ForeColor = Color.Red;
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
                e.CellElement.Font = new Font("Segoe UI", 8.0f, FontStyle.Bold);
            }   
        }
    }
}