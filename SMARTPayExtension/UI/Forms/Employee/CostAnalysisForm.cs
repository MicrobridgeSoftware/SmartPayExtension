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
using Telerik.WinControls.Data;
using Telerik.WinControls.Export;
using System.IO;
using System.Diagnostics;
using Telerik.WinControls.UI.Export;

namespace SMARTPayExtension.UI.Forms.Employee
{
    public partial class CostAnalysisForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        List<ServiceAnalysisView> _analysis;
        List<ServiceAnalysisView> _timeAnalysis;
        public CostAnalysisForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _analysis = new List<ServiceAnalysisView>();

            if (rbnFileName.IsChecked && string.IsNullOrEmpty(txtCostComponent.Text))
            {
                RadMessageBox.Show("Enter the cost component for which you want to search", Application.ProductName);
                return;
            }

            if (!rbnFileName.IsChecked && !rbnClient.IsChecked && !rbnZone.IsChecked && !rbntype.IsChecked)
                getDataByDate();
            else if (rbnFileName.IsChecked)
                getDataByCostComponenet();
            else if (rbnClient.IsChecked)
                getCostByCustomer();
            else if (rbnZone.IsChecked)
                getCostByZone();
            else if (rbntype.IsChecked)
                getCostByGuard();

            grdCostAnalysis.GroupDescriptors.Remove("DateExported");
            grdCostAnalysis.SummaryRowsBottom.Clear();
            
            bindingSourceChartDisplay.DataSource = _analysis;

            if (_analysis.Count > 0)
            {
                GroupDescriptor _groupDescriptor = new GroupDescriptor();
                _groupDescriptor.GroupNames.Add("DateExported", ListSortDirection.Ascending);
                this.grdCostAnalysis.GroupDescriptors.Add(_groupDescriptor);
                grdCostAnalysis.MasterTemplate.ExpandAllGroups();

                GridViewSummaryItem summaryItem = new GridViewSummaryItem("Cost", "Total = {0:N2}", GridAggregateFunction.Sum);
                GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
                summaryRowItem.Add(summaryItem);
                this.grdCostAnalysis.SummaryRowsBottom.Add(summaryRowItem);
            }
        }

        private void getDataByDate()
        {
            _analysis = dbContext.ServiceAnalysisViews.Where(d => d.DateExported >= dtpStartDate.Value && d.DateExported <= dtpEndDate.Value
                                                             && d.Hours == 0 && d.AnalysisType.Equals("Duty")).ToList();
        }

        private void getDataByCostComponenet()
        {
            string _costComponenet = txtCostComponent.Text.Trim();
            _analysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate.Value && x.DateExported <= dtpEndDate.Value
                                                             && x.CostComponent.Trim() == _costComponenet && x.Hours == 0 && x.AnalysisType
                                                             .Equals("Duty")).ToList();
        }

        private void getCostByCustomer()
        {
            string _client = txtClient.Text.Trim();

            if (string.IsNullOrEmpty(_client))
                _analysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate.Value && x.DateExported <= dtpEndDate.Value
                                                                 && x.Hours == 0 && x.AnalysisType.Equals("Customer")).ToList();
            else
                _analysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate.Value && x.DateExported <= dtpEndDate.Value
                                                                 && x.Hours == 0 && x.AnalysisType.Equals("Customer") && x.CostComponent.Trim()
                                                                 == _client).ToList();
        }

        private void getCostByZone()
        {
            string _zone = txtZone.Text.Trim();

            if (string.IsNullOrEmpty(_zone))
                _analysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate.Value && x.DateExported <= dtpEndDate.Value
                                                                 && x.Hours == 0 && x.AnalysisType.Equals("Zone")).ToList();
            else
                _analysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate.Value && x.DateExported <= dtpEndDate.Value
                                                                 && x.Hours == 0 && x.AnalysisType.Equals("Zone") && x.CostComponent.Trim()
                                                                 == _zone).ToList();
        }

        private void getCostByGuard()
        {
            string _guard = txtType.Text.Trim();

            if (string.IsNullOrEmpty(_guard))
                _analysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate.Value && x.DateExported <= dtpEndDate.Value
                                                                     && x.Hours == 0 && x.AnalysisType.Equals("Guard")).ToList();
            else
                _analysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate.Value && x.DateExported <= dtpEndDate.Value
                                                                     && x.Hours == 0 && x.AnalysisType.Equals("Guard") && x.CostComponent.Trim()
                                                                     == _guard).ToList();
        }
        
        private void CostAnalysisForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.Date;
            dtpStartDate2.Value = DateTime.Today.Date;
            LoadAutoCompleteInfo();

            //this.ChartView.ChartElement.TitleElement.TextOrientation = Orientation.Horizontal;
            //this.ChartView.ChartElement.TitlePosition = TitlePosition.Left;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_analysis == null || _analysis.Count == 0)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to export the below displayed data?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                //this.ChartView.Print(true);
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "Select Path to save this export";
                folder.ShowDialog();
                string path = string.Empty;
                
                if (!string.IsNullOrEmpty(folder.SelectedPath))
                    path = folder.SelectedPath;
                else
                    return;

                string _destinationPath = path;

                string _saveAs = "Cost Analysis Export";

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

                GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.grdCostAnalysis);
                SpreadExportRenderer exportRenderer = new SpreadExportRenderer();

                //grdDataDisplay.Columns["column10"].IsVisible = false;

                spreadExporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
                spreadExporter.SheetName = _saveAs;
                spreadExporter.ExportVisualSettings = true;
                spreadExporter.FileExportMode = FileExportMode.CreateOrOverrideFile;
                //this.grdCostAnalysis.Columns["DateOfBirth"].ExcelExportType = DisplayFormatType.Custom;
                //this.grdCostAnalysis.Columns["DateOfBirth"].ExcelExportFormatString = "dd/MMM/yyyy";

                spreadExporter.RunExport(fullpath, exportRenderer);

                //grdDataDisplay.Columns["column10"].IsVisible = true;

                RadMessageBox.Show("File exported successfully!", Application.ProductName);
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void LoadAutoCompleteInfo()
        {
            this.txtCostComponent.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtCostComponent2.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtClient.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtClient2.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtZone.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtZone2.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtType.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtType2.AutoCompleteMode = AutoCompleteMode.Suggest;

            RadListDataItemCollection _autoCompleteItems1 = this.txtCostComponent.AutoCompleteItems;
            RadListDataItemCollection _autoCompleteItems2 = this.txtCostComponent2.AutoCompleteItems;
            RadListDataItemCollection _clientItems = this.txtClient.AutoCompleteItems;
            RadListDataItemCollection _clientItems2 = this.txtClient2.AutoCompleteItems;
            RadListDataItemCollection _zoneItems = this.txtZone.AutoCompleteItems;
            RadListDataItemCollection _zoneItems2 = this.txtZone2.AutoCompleteItems;
            RadListDataItemCollection _typeItems = this.txtType.AutoCompleteItems;
            RadListDataItemCollection _typeItems2 = this.txtType2.AutoCompleteItems;

            var _history = dbContext.CostAnalysisViews.Select(s => s.CostComponent).Distinct().ToList();
            var _customer = dbContext.CustomerViews.Select(c => c.CustomerDescription).Distinct().ToList();
            var _zone = dbContext.Zones.Select(z => z.Description).Distinct().ToList();
            var _guardType = dbContext.GuardTypes.Select(g => g.GuardTypeDescription).Distinct().ToList();

            foreach (var _description in _history)
            {
                _autoCompleteItems1.Add(new RadListDataItem(_description));
                _autoCompleteItems2.Add(new RadListDataItem(_description));
            }

            foreach (var customer in _customer)
            {
                _clientItems.Add(new RadListDataItem(customer));
                _clientItems2.Add(new RadListDataItem(customer));
            }

            foreach (var zone in _zone)
            {
                _zoneItems.Add(new RadListDataItem(zone));
                _zoneItems2.Add(new RadListDataItem(zone));
            }

            foreach (var type in _guardType)
            {
                _typeItems.Add(new RadListDataItem(type));
                _typeItems2.Add(new RadListDataItem(type));
            }
        }
                
        private void btnPrint2_Click(object sender, EventArgs e)
        {
            if (_timeAnalysis == null || _timeAnalysis.Count == 0)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to export the below displayed data?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                //this.ChartView2.Print(true);
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "Select Path to save this export";
                folder.ShowDialog();
                string path = string.Empty;
                
                if (!string.IsNullOrEmpty(folder.SelectedPath))
                    path = folder.SelectedPath;
                else
                    return;

                string _destinationPath = path;

                string _saveAs = "Time Analysis Export";

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

                GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.grdTimeAnalysis);
                SpreadExportRenderer exportRenderer = new SpreadExportRenderer();

                //grdDataDisplay.Columns["column10"].IsVisible = false;

                spreadExporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
                spreadExporter.SheetName = _saveAs;
                spreadExporter.ExportVisualSettings = true;
                spreadExporter.FileExportMode = FileExportMode.CreateOrOverrideFile;
                //this.grdCostAnalysis.Columns["DateOfBirth"].ExcelExportType = DisplayFormatType.Custom;
                //this.grdCostAnalysis.Columns["DateOfBirth"].ExcelExportFormatString = "dd/MMM/yyyy";

                spreadExporter.RunExport(fullpath, exportRenderer);

                //grdDataDisplay.Columns["column10"].IsVisible = true;

                RadMessageBox.Show("File exported successfully!", Application.ProductName);
            }         
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void dtpStartDate2_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate2.MinDate = dtpStartDate2.Value;
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            _timeAnalysis = new List<ServiceAnalysisView>();

            if (rbnFileName2.IsChecked && string.IsNullOrEmpty(txtCostComponent2.Text))
            {
                RadMessageBox.Show("Enter the cost component for which you want to search", Application.ProductName);
                return;
            }

            if (!rbnFileName2.IsChecked && !rbnClient2.IsChecked && !rbnZone2.IsChecked && !rbnType2.IsChecked)
                getTimeByDate();
            else if (rbnFileName2.IsChecked)
                getTimeByCostComponenet();
            else if (rbnClient2.IsChecked)
                getTimeByCustomer();
            else if (rbnZone2.IsChecked)
                getTimeByZone();
            else if (rbnType2.IsChecked)
                getTimeByGuard();

            grdTimeAnalysis.GroupDescriptors.Remove("DateExported");
            grdTimeAnalysis.SummaryRowsBottom.Clear();

            bindingSourceChartDisplay2.DataSource = _timeAnalysis;

            if (_timeAnalysis.Count > 0)
            {
                GroupDescriptor _groupDescriptor = new GroupDescriptor();
                _groupDescriptor.GroupNames.Add("DateExported", ListSortDirection.Ascending);
                this.grdTimeAnalysis.GroupDescriptors.Add(_groupDescriptor);
                grdTimeAnalysis.MasterTemplate.ExpandAllGroups();

                GridViewSummaryItem summaryItem = new GridViewSummaryItem("Hours", "Total = {0:N2}", GridAggregateFunction.Sum);
                GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
                summaryRowItem.Add(summaryItem);
                this.grdTimeAnalysis.SummaryRowsBottom.Add(summaryRowItem);
            }            
        }

        private void getTimeByDate()
        {
            _timeAnalysis = dbContext.ServiceAnalysisViews.Where(d => d.DateExported >= dtpStartDate2.Value && d.DateExported <= dtpEndDate2.Value
                                                                 && d.Cost == 0 && d.AnalysisType.Equals("Duty")).ToList();
        }

        private void getTimeByCostComponenet()
        {
            string _costComponent = txtCostComponent2.Text.Trim();
            _timeAnalysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate2.Value && x.DateExported <= dtpEndDate2.Value
                                                                 && x.CostComponent.Trim() == _costComponent && x.Cost == 0 && x.AnalysisType
                                                                 .Equals("Duty")).ToList();
        }

        private void getTimeByCustomer()
        {
            string _client = txtClient2.Text.Trim();

            if (string.IsNullOrEmpty(_client))
                _timeAnalysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate2.Value && x.DateExported <= dtpEndDate2.Value
                                                                     && x.Cost == 0 && x.AnalysisType.Equals("Customer")).ToList();
            else
                _timeAnalysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate2.Value && x.DateExported <= dtpEndDate2.Value
                                                                     && x.Cost == 0 && x.AnalysisType.Equals("Customer") && x.CostComponent.Trim()
                                                                     == _client).ToList();
        }

        private void getTimeByZone()
        {
            string _zone = txtZone2.Text.Trim();

            if (string.IsNullOrEmpty(_zone))
                _timeAnalysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate2.Value && x.DateExported <= dtpEndDate2.Value
                                                                     && x.Cost == 0 && x.AnalysisType.Equals("Zone")).ToList();
            else
                _timeAnalysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate2.Value && x.DateExported <= dtpEndDate2.Value
                                                                     && x.Cost == 0 && x.AnalysisType.Equals("Zone") && x.CostComponent.Trim()
                                                                     == _zone).ToList();
        }

        private void getTimeByGuard()
        {
            string _guard = txtType2.Text.Trim();

            if (string.IsNullOrEmpty(_guard))
                _timeAnalysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate2.Value && x.DateExported <= dtpEndDate2.Value
                                                                     && x.Cost == 0 && x.AnalysisType.Equals("Guard")).ToList();
            else
                _timeAnalysis = dbContext.ServiceAnalysisViews.Where(x => x.DateExported >= dtpStartDate2.Value && x.DateExported <= dtpEndDate2.Value
                                                                     && x.Cost == 0 && x.AnalysisType.Equals("Guard") && x.CostComponent.Trim()
                                                                     == _guard).ToList();
        }
        
        private void rbnFileName_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnFileName.IsChecked)
                txtCostComponent.Enabled = true;
            else
                txtCostComponent.Enabled = false;
        }

        private void rbnFileName2_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnFileName2.IsChecked)
                txtCostComponent2.Enabled = true;
            else
                txtCostComponent2.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in radGroupBox1.Controls)
            {
                if (control is RadRadioButton)
                {
                    RadRadioButton _radiobutton = (RadRadioButton)control;

                    _radiobutton.IsChecked = false;
                }
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            foreach (Control control in radGroupBox4.Controls)
            {
                if (control is RadRadioButton)
                {
                    RadRadioButton _radiobutton = (RadRadioButton)control;
                                        
                    _radiobutton.IsChecked = false;
                }
            }
        }

        private void rbnClient_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnClient.IsChecked)
                txtClient.Enabled = true;
            else
                txtClient.Enabled = false;
        }

        private void rbnZone_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnZone.IsChecked)
                txtZone.Enabled = true;
            else
                txtZone.Enabled = false;
        }

        private void rbntype_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbntype.IsChecked)
                txtType.Enabled = true;
            else
                txtType.Enabled = false;
        }

        private void rbnClient2_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnClient2.IsChecked)
                txtClient2.Enabled = true;
            else
                txtClient2.Enabled = false;
        }

        private void rbnZone2_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnZone2.IsChecked)
                txtZone2.Enabled = true;
            else
                txtZone2.Enabled = false;
        }

        private void rbnType2_CheckStateChanged(object sender, EventArgs e)
        {
            if (rbnType2.IsChecked)
                txtType2.Enabled = true;
            else
                txtType2.Enabled = false;
        }

        private void grdCostAnalysis_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.ForeColor = Color.Red;
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
                e.CellElement.Font = new Font("Segoe UI", 8.0f, FontStyle.Bold);
            }   
        }

        private void grdTimeAnalysis_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
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