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
using System.IO;
using System.Diagnostics;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI;

namespace SMARTPayExtension.UI.Forms.Employee
{
    public partial class GuardForceForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        decimal _contractorRate = 0;
        object BgwArgument;
        int _contractorId = 0;

        public GuardForceForm()
        {
            InitializeComponent();
        }

        private void getFormData()
        {
            grdDataDisplay.GroupDescriptors.Remove("GuardTypeDescription");
            grdDataDisplay.SummaryRowsBottom.Clear();
                        
            var _getguardForce = dbContext.GuardForceDisplayViews.AsNoTracking().ToList();
            bindingSourceGuardForce.DataSource = _getguardForce;

            GroupDescriptor _groupDescriptor = new GroupDescriptor();
            _groupDescriptor.GroupNames.Add("GuardTypeDescription", ListSortDirection.Ascending);
            this.grdDataDisplay.GroupDescriptors.Add(_groupDescriptor);
            grdDataDisplay.MasterTemplate.ExpandAllGroups();

            GridViewSummaryItem summaryItem = new GridViewSummaryItem("ContractorRef", "Total = {0:N0}", GridAggregateFunction.Count);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            summaryRowItem.Add(summaryItem);
            this.grdDataDisplay.SummaryRowsBottom.Add(summaryRowItem);
        }

        private void GuardForceForm_Load(object sender, EventArgs e)
        {
            ExportWaitingBar.Visible = false;
            ExportWaitingBar.StopWaiting();

            getFormData();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void bindingSourceGuardForce_PositionChanged(object sender, EventArgs e)
        {
            _contractorRate = ((GuardForceDisplayView)bindingSourceGuardForce.Current).Rate;
            _contractorId = ((GuardForceDisplayView)bindingSourceGuardForce.Current).ContractorId;
        }

        private void backgroundWorkerExport_DoWork(object sender, DoWorkEventArgs e)
        {
            string _destinationPath = e.Argument.ToString();

            string _saveAs = "Guard Force Export";

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

            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.grdDataDisplay);
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();

            grdDataDisplay.Columns["column10"].IsVisible = false;

            spreadExporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            spreadExporter.SheetName = _saveAs;
            spreadExporter.ExportVisualSettings = true;
            spreadExporter.FileExportMode = FileExportMode.CreateOrOverrideFile;
            this.grdDataDisplay.Columns["DateOfBirth"].ExcelExportType = DisplayFormatType.Custom;
            this.grdDataDisplay.Columns["DateOfBirth"].ExcelExportFormatString = "dd/MMM/yyyy";

            spreadExporter.RunExport(fullpath, exportRenderer);

            grdDataDisplay.Columns["column10"].IsVisible = true;

            RadMessageBox.Show("File exported successfully!", Application.ProductName);
        }

        private void backgroundWorkerExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ExportWaitingBar.StopWaiting();
            ExportWaitingBar.Visible = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdDataDisplay.Rows.Count <= 0)
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

        private void grdDataDisplay_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to edit this employee Rate?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                EmployeeRateChangeForm _rateForm = new EmployeeRateChangeForm(_contractorId, _contractorRate);
                _rateForm.ShowDialog();
                getFormData();
            }
        }

        private void grdDataDisplay_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.ForeColor = Color.Red;
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft;
                e.CellElement.Font = new Font("Segoe UI", 8.0f, FontStyle.Bold);
            }   
        }
    }
}