using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Microsoft.VisualBasic.FileIO;
using SMARTPayExtension.TechLibrary;
using System.IO;
using System.Linq;
using Telerik.WinControls.UI;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Data.Objects;
using Telerik.WinControls.Export;
using System.Diagnostics;

namespace SMARTPayExtension.UI.Forms.Import
{
    public partial class TransactionImportForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        private List<CustomerView> _customerList;
        private List<DutyCodeView> _dutyList;
        private List<GuardMappingView> _contractorList;
        List<ImportCSVFile> _readFile;

        public static List<int> _companyId;// = 0;
        bool _transactionUploaded = false;
        string _actionType = string.Empty;

        public DataTable ConvertListForDatabaseUpdate(List<ImportCSVFile> _exportList, int _batchno, string _filepath, string _savename)
        {
            DataTable data = new DataTable();

            data.Columns.Add("ImportedTransId", typeof(int));
            data.Columns.Add("TransactionDate", typeof(string));
            data.Columns.Add("CustomerId", typeof(int));
            data.Columns.Add("ContractorId", typeof(int));
            data.Columns.Add("ServiceCode", typeof(string));
            data.Columns.Add("ShiftTotal", typeof(decimal));
            data.Columns.Add("BatchNo", typeof(int));
            data.Columns.Add("DateImported", typeof(DateTime));
            data.Columns.Add("LocationImportedFrom", typeof(string));
            data.Columns.Add("FileSaveName", typeof(string));
            data.Columns.Add("CompanyId", typeof(int));
            data.Columns.Add("ImportedBy", typeof(string));

            foreach (ImportCSVFile _record in _exportList)
            {
                data.Rows.Add(0, _record.Transdate, _record.CustomerId, _record.ContractorId, _record.ServiceCode,
                              _record.ShiftTotal, _batchno, DateTime.Now, _filepath, _savename, _companyId[0],
                              SMARTPayExtConstants._activeUser);
            }

            return data;
        }

        public TransactionImportForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog _fileDialog = new OpenFileDialog();
            _fileDialog.Filter = "CSV files (*.csv)|*.csv;*.tsv";
            _fileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(_fileDialog.FileName))
            {
                txtFilePath.Text = _fileDialog.FileName.ToString().Trim();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                RadMessageBox.Show("Select the path to which this file is located!", Application.ProductName);
                return;
            }

            string _fileName = txtFilePath.Text.Trim();
            string _fileType = Path.GetExtension(_fileName);

            if (!_fileType.Equals(".csv"))
            {
                RadMessageBox.Show("This file type is not supported", Application.ProductName);
                return;
            }

            _companyId = new List<int>();
            ImportCompanyForm _getCompanyId = new ImportCompanyForm();
            _getCompanyId.ShowDialog();

            if (_companyId.Count == 0)
            {
                RadMessageBox.Show("Cannot find information for the selected company!", Application.ProductName);
                return;
            }

            var _filepath = txtFilePath.Text;
            _readFile = new List<ImportCSVFile>();

            try
            {
                using (TextFieldParser csvParser = new TextFieldParser(_filepath))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { "," });
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    csvParser.ReadLine();

                    while (!csvParser.EndOfData)
                    {
                        string[] _fileFields = csvParser.ReadFields();

                        _readFile.Add(new ImportCSVFile
                        {
                            Transdate = _fileFields[0],
                            CustomerId = Convert.ToInt32(_fileFields[1]),
                            ContractorId = Convert.ToInt32(_fileFields[2]),
                            ServiceCode = _fileFields[3],
                            ShiftTotal = Convert.ToDecimal(_fileFields[4])
                        });
                    }

                    GrdDataDisplay.DataSource = _readFile;
                    txtrecordCount.Text = string.Format("{0:N0}", _readFile.Count);

                    if (GrdDataDisplay.Rows.Count > 0)
                        UpdateGirdViewValues();
                }
            }
            catch(Exception _exp)
            {
                RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
            }
        }

        private void UpdateGirdViewValues()
        {
            for (int i = 0; i < GrdDataDisplay.Rows.Count; i++)
            {
                if (GrdDataDisplay.Rows[i].Cells["ContractorId"].Value != null)
                {
                    string _contractorId = Convert.ToString(GrdDataDisplay.Rows[i].Cells["ContractorId"].Value);

                    foreach (int id in _companyId)
                    {
                        var _contractor = _contractorList.Where(c => c.ContractorRef.Trim() == _contractorId.Trim() && c.CompanyId == id).FirstOrDefault();

                        if (_contractor != null)
                            GrdDataDisplay.Rows[i].Cells["ContractorDescription"].Value = _contractor.ContractorDescription.Trim();
                    }
                }

                if (GrdDataDisplay.Rows[i].Cells["CustomerId"].Value != null)
                {
                    string _customerId = Convert.ToString(GrdDataDisplay.Rows[i].Cells["CustomerId"].Value);
                    var _customer = _customerList.Where(c => c.CustomerRef.Trim() == _customerId.Trim()).FirstOrDefault();

                    if (_customer != null)
                    {
                        GrdDataDisplay.Rows[i].Cells["CustomerDescription"].Value = _customer.CustomerDescription.Trim();

                        if (_customer.ZoneDescription != null)
                            GrdDataDisplay.Rows[i].Cells["Zone"].Value = _customer.ZoneDescription.Trim();
                        else
                            RadMessageBox.Show(_customer.CustomerDescription.Trim() + " is not mapped to a zone", Application.ProductName);
                    }
                }

                if (GrdDataDisplay.Rows[i].Cells["ServiceCode"].Value != null)
                {
                    string _dutyCode = GrdDataDisplay.Rows[i].Cells["ServiceCode"].Value.ToString().Trim();
                    var _duty = _dutyList.Where(d => d.DutyCode.Trim() == _dutyCode).FirstOrDefault();

                    if (_duty != null)
                        GrdDataDisplay.Rows[i].Cells["ServiceDescription"].Value = _duty.Description.Trim();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void TransactionImportForm_Load(object sender, EventArgs e)
        {
            SaveWaitingBar.Visible = false;
            SaveWaitingBar.StopWaiting();
            _contractorList = dbContext.GuardMappingViews.AsNoTracking().ToList();
            _customerList = dbContext.CustomerViews.AsNoTracking().ToList();
            _dutyList = dbContext.DutyCodeViews.AsNoTracking().ToList();
        }
        
        private void GrdDataDisplay_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["CustomerDescription"].Value == null || e.RowElement.RowInfo.Cells["ContractorDescription"].Value == null
              || e.RowElement.RowInfo.Cells["ServiceDescription"].Value == null || e.RowElement.RowInfo.Cells["Zone"].Value == null)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GrdDataDisplay.Rows.Count == 0)
                return;

            if (string.IsNullOrEmpty(txtSaveAs.Text.Trim()))
            {
                RadMessageBox.Show("Create a name to save this file as", Application.ProductName);
                return;
            }

            for (int row = 0; row < GrdDataDisplay.Rows.Count; row++)
            {
                var _cusdescription = GrdDataDisplay.Rows[row].Cells["CustomerDescription"].Value;
                var _condescription = GrdDataDisplay.Rows[row].Cells["ContractorDescription"].Value;
                var _dutydescription = GrdDataDisplay.Rows[row].Cells["ServiceDescription"].Value;

                if (_cusdescription == null || _condescription == null || _dutydescription == null)
                {
                    RadMessageBox.Show("There are discrepancies with all lines highlighted in red.\n" +
                                       "Consequently, this import cannot be saved. \n" +
                                       "Correct all anomolies and re-import file.", Application.ProductName);
                    return;
                }
            }

            if (!backgroundWorkerSaveTransactions.IsBusy)
            {
                _actionType = "Save";
                SaveWaitingBar.Show();
                SaveWaitingBar.StartWaiting();
                backgroundWorkerSaveTransactions.RunWorkerAsync();
            }               
        }

        public void ClearForm()
        {
            int _initializeRecordCount = 0;
            txtFilePath.Text = string.Empty;
            txtrecordCount.Text = _initializeRecordCount.ToString();
            txtSaveAs.Text = string.Empty;
            GrdDataDisplay.Rows.Clear();
            _transactionUploaded = false;
        }

        private void SaveImportedTransactions()
        {
            var _batchNo = dbContext.SysNumberSequences.Where(s => s.ObjectType.Equals("TransactionImport")).FirstOrDefault();
            string _importLocation = txtFilePath.Text.Trim();
            string _saveAs = txtSaveAs.Text.Trim();

            SqlConnection connection = this.dbContext.Database.Connection as SqlConnection;
            connection.Open();

            DataTable _recordReaderDataTable = new DataTable();
            _recordReaderDataTable = ConvertListForDatabaseUpdate(_readFile, _batchNo.NextTransNo, _importLocation, _saveAs);

            int _bulkCopybatchSize = _recordReaderDataTable.Rows.Count;

            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.ConnectionString))
            {
                bulkCopy.BatchSize = _bulkCopybatchSize;
                bulkCopy.DestinationTableName = "ImportedTransactions";
                bulkCopy.BulkCopyTimeout = 0;
                bulkCopy.WriteToServer(_recordReaderDataTable);
            }

            connection.Close();
            _transactionUploaded = true;

            _batchNo.NextTransNo = _batchNo.NextTransNo + 1;
            dbContext.SaveChanges();

            string _rootFolderPath = txtFilePath.Text.Trim();

            string _applicationFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            string _importFolderPath = _applicationFolderPath + "ImportedTransactions";
            string currentTime = DateTime.Now.ToString("_MMM_dd_yyyy_HH_mm_ss");
            string _fileName = "\\Transaction Import" + currentTime;

            string _fileToMove = _rootFolderPath;
            string _moveTo = _importFolderPath + _fileName + ".csv";
            File.Move(_fileToMove, _moveTo);
        }

        private void PerformTransactionExport(string _path)
        {
            string _destinationPath = _path;

            string _saveAs = "Imported Transaction Export";

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

            spreadExporter.RunExport(fullpath, exportRenderer);

            RadMessageBox.Show("File exported successfully!", Application.ProductName);
        }

        private void backgroundWorkerSaveTransactions_DoWork(object sender, DoWorkEventArgs e)
        {            
            try
            {
                if (_actionType == "Save")
                    SaveImportedTransactions();
                else if (_actionType == "Export")
                    PerformTransactionExport(e.Argument.ToString());
            }
            catch (Exception _exp)
            {
                RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
            }
        }

        private void backgroundWorkerSaveTransactions_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SaveWaitingBar.StopWaiting();
            SaveWaitingBar.Visible = false;

            if (_actionType == "Save")
            {
                if (_transactionUploaded)
                {
                    ClearForm();
                    RadMessageBox.Show("File saved sucessfully!", Application.ProductName);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (GrdDataDisplay.Rows.Count <= 0)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to export the information displayed?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                _actionType = "Export";

                if (!backgroundWorkerSaveTransactions.IsBusy)
                {
                    object BgwArgument = new object();
                    SaveWaitingBar.Show();
                    SaveWaitingBar.StartWaiting();

                    string _path = SaveDestination();

                    if (string.IsNullOrEmpty(_path))
                    {
                        RadMessageBox.Show("A destination must be selected for the saving of this file", Application.ProductName);
                        return;
                    }

                    BgwArgument = _path;
                    backgroundWorkerSaveTransactions.RunWorkerAsync(BgwArgument);
                }
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
    }
}