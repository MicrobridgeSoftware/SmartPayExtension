using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using System.IO;
using System.Diagnostics;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using SMARTPayExtension.TechLibrary;
using System.Data.SqlClient;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Reflection;

namespace SMARTPayExtension.UI.Forms.Export
{
    public partial class TransactionExportForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        List<ImportCalcuationDetailsView> _calculationDetails;
        List<ImportCaluclationSummaryView> _calculationSummary;
        private List<string> CSVContent;

        public DataTable ConvertListForDatabaseUpdate(List<ImportCalcuationDetailsView> _exportList, bool _isAllowance)
        {
            DataTable data = new DataTable();

            data.Columns.Add("ExportedTransId", typeof(int));
            data.Columns.Add("ImportedTransId", typeof(int));
            data.Columns.Add("DateExported", typeof(DateTime));
            data.Columns.Add("Rate", typeof(decimal));
            data.Columns.Add("Quantity", typeof(decimal));
            data.Columns.Add("AllowanceId", typeof(int));
            data.Columns.Add("IsAllowance", typeof(bool));
            data.Columns.Add("ExportedBy", typeof(string));

            if (!_isAllowance)
            {
                foreach (ImportCalcuationDetailsView _record in _exportList)
                {
                    data.Rows.Add(0, _record.ImportedTransId, DateTime.Now, _record.DutyRate, _record.ShiftTotal, 
                                  _record.ReferenceId, _record.IsAllowance, SMARTPayExtConstants._activeUser);
                }
            }
            else
            {
                foreach (ImportCalcuationDetailsView _record in _exportList)
                {
                    data.Rows.Add(0, _record.ImportedTransId, DateTime.Now, _record.DutyRate, _record.AllowanceHrs,
                                  _record.ReferenceId, _record.IsAllowance, SMARTPayExtConstants._activeUser);
                }
            }

            return data;
        }

        public TransactionExportForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void TransactionExportForm_Load(object sender, EventArgs e)
        {
            ExportWaitingBar.Show();
            ExportWaitingBar.StartWaiting();
            
            if (!BGWExport.IsBusy)
                BGWExport.RunWorkerAsync();
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }  

        private void BGWExport_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlConnection connection = this.dbContext.Database.Connection as SqlConnection;
            connection.Open();

            DataTable detailsDataTable = new DataTable("ImportCalcuationDetailsView");
            using (SqlCommand _calculationDetailsCommand = new SqlCommand("SELECT * FROM ImportCalcuationDetailsView "))
            {
                _calculationDetailsCommand.Connection = connection;
                _calculationDetailsCommand.CommandTimeout = 0;

                using (SqlDataReader _calculationDetailsdataTable = _calculationDetailsCommand.ExecuteReader())
                {
                    detailsDataTable.Load(_calculationDetailsdataTable);
                }
            }

            if (detailsDataTable.Rows.Count == 0)
            {
                RadMessageBox.Show("There are no transaction(s) to be exported at this time!", Application.ProductName);
                connection.Close();
                return;
            }
                        
            DataTable summaryDataTable = new DataTable("ImportCaluclationSummaryView");   
            using (SqlCommand _calculationSummaryCommand = new SqlCommand("SELECT * FROM ImportCaluclationSummaryView "))
            {
                _calculationSummaryCommand.Connection = connection;
                _calculationSummaryCommand.CommandTimeout = 0;

                using (SqlDataReader _calculationSummarydataTable = _calculationSummaryCommand.ExecuteReader())
                {
                    summaryDataTable.Load(_calculationSummarydataTable);
                }                
            }

            if (GrdDataDisplay.InvokeRequired)
            {
                GrdDataDisplay.Invoke(new MethodInvoker(() => { this.GrdDataDisplay.DataSource = summaryDataTable; }));
            }
            else
            {
                this.GrdDataDisplay.DataSource = summaryDataTable;
            }

            bindingSourceCalculationdetails.DataSource = detailsDataTable;
                        
             //_calculationDetails = detailsDataTable.AsEnumerable().ToList();
            //_calculationDetails = ConvertDataTable<ImportCalcuationDetailsView>(detailsDataTable);

            LoadDetailsList(detailsDataTable);
            LoadSummaryList(summaryDataTable);
            connection.Close();
            GC.Collect();
        }

        private void LoadSummaryList(DataTable summaryDataTable)
        {
            _calculationSummary = (from DataRow dr in summaryDataTable.Rows
            select new ImportCaluclationSummaryView()
            {                
                ContractorRef = dr["ContractorRef"].ToString(),
                PayrollCode = dr["PayrollCode"].ToString(),
                ServiceCode = dr["ServiceCode"].ToString(),
                DutyRate = Convert.ToDecimal(dr["DutyRate"]),
                Quantity = Convert.ToDecimal(dr["Quantity"]),
                TransactionDate = Convert.ToDateTime(dr["TransactionDate"]),
                GLAccount = dr["GLAccount"].ToString(),
                Location = dr["Location"].ToString(),
                Branch = dr["Branch"].ToString(),
                Department = dr["Department"].ToString(),
                Notes = dr["Notes"].ToString(),
                Amount = Convert.ToDecimal(dr["Amount"]),
                ContractorDescription = dr["ContractorDescription"].ToString(),
                ReferenceId = Convert.ToInt32(dr["ReferenceId"]),
                IsAllowance = Convert.ToBoolean(dr["IsAllowance"])
            }).ToList();
        }

        private void LoadDetailsList(DataTable detailsDataTable)
        {
            _calculationDetails = (from DataRow dr in detailsDataTable.Rows
            select new ImportCalcuationDetailsView()
            {
                ImportedTransId = Convert.ToInt32(dr["ImportedTransId"]),
                TransactionDate = dr["TransactionDate"].ToString(),
                ServiceCode = dr["ServiceCode"].ToString(),
                ShiftTotal = Convert.ToDecimal(dr["ShiftTotal"]),
                CustomerId = Convert.ToInt32(dr["CustomerId"]),
                ContractorId = Convert.ToInt32(dr["ContractorId"]),
                ContractorFirstName = dr["ContractorFirstName"].ToString(),
                ContractorLastName = dr["ContractorLastName"].ToString(),
                ContractorDescription = dr["ContractorDescription"].ToString(),
                CustomerDescription = dr["CustomerDescription"].ToString(),
                DutyRate = Convert.ToDecimal(dr["DutyRate"]),
                ContractorRef = dr["ContractorRef"].ToString(),
                DutyDescription = dr["DutyDescription"].ToString(),
                PayrollCode = dr["PayrollCode"].ToString(),
                ReferenceId = Convert.ToInt32(dr["ReferenceId"]),
                IsAllowance = Convert.ToBoolean(dr["IsAllowance"]),
                DutyAllowanceId = Convert.ToInt32(dr["DutyAllowanceId"]),
                DutyId = Convert.ToInt32(dr["DutyId"]),
                AllowanceHrs = Convert.ToDecimal(dr["AllowanceHrs"]),
                Branch = dr["Branch"].ToString()
            }).ToList();              
        }

        private void BGWExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ExportWaitingBar.StopWaiting();
            ExportWaitingBar.Visible = false;

            if (GrdDataDisplay.Rows.Count > 0)
            {
                GroupDescriptor Jobdescriptor = new GroupDescriptor();
                Jobdescriptor.GroupNames.Add("ContractorDescription", ListSortDirection.Ascending);
                this.GrdDataDisplay.GroupDescriptors.Add(Jobdescriptor);
                GrdDataDisplay.MasterTemplate.ExpandAllGroups();

                GridViewSummaryItem summaryItem = new GridViewSummaryItem("Amount", "Total = {0:N2}", GridAggregateFunction.Sum);
                GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
                summaryRowItem.Add(summaryItem);
                this.GrdDataDisplay.SummaryRowsBottom.Add(summaryRowItem);

                int _guardCount = GrdDataDisplay.Groups.Count;
                lblTransaction.Text = lblTransaction.Text + " - " + String.Format("{0:N0}", _guardCount);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (GrdDataDisplay.Rows.Count == 0)
                return;

            
            for (int row = 0; row < GrdDataDisplay.Rows.Count; row++)
            {
                var _cusZone = GrdDataDisplay.Rows[row].Cells["Branch"].Value;

                if (_cusZone == null)
                {
                    RadMessageBox.Show("There are discrepancies with all lines highlighted in red.\n" +
                                       "Consequently, these transactions cannot be exported. \n" +
                                       "Correct all anomolies and try re-exporting this file.", Application.ProductName);
                    return;
                }
            }


            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to export these transaction(s)?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                FolderBrowserDialog _browser = new FolderBrowserDialog();
                _browser.Description = "Select save destination";
                _browser.ShowDialog();
                string path = string.Empty;

                if (!string.IsNullOrEmpty(_browser.SelectedPath))
                    path = _browser.SelectedPath;

                if (string.IsNullOrEmpty(path))
                {
                    RadMessageBox.Show("A destination must be selected to export this file", Application.ProductName);
                    return;
                }

                path = path + "\\Transaction Export.csv";

                bool fileExist = File.Exists(path);

                if (fileExist)
                {
                    FileInfo file = new FileInfo(path);

                    Process[] AllProcesses = Process.GetProcessesByName("excel");
                    foreach (Process ExcelProcess in AllProcesses)
                    {
                        RadMessageBox.Show("A file with the same name is detected or is currently opened \n" +
                                           "Close all related files or change file destination and try again", Application.ProductName);
                        return;
                    }
                }

                Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

                data.Add("EmployeeRef", new List<string> { });
                data.Add("PayrollCode", new List<string> { });
                data.Add("DutyCode", new List<string> { });
                data.Add("Rate", new List<string> { });
                data.Add("Quantity", new List<string> { });
                data.Add("Amount", new List<string> { });
                data.Add("TransactionDate", new List<string> { });
                data.Add("GlAccount", new List<string> { });
                data.Add("Location", new List<string> { });
                data.Add("Branch", new List<string> { });
                data.Add("Department", new List<string> { });
                data.Add("Notes", new List<string> { });

                foreach (var _data in _calculationSummary)
                {
                    data["EmployeeRef"].Add(_data.ContractorRef.Trim());
                    data["PayrollCode"].Add(_data.PayrollCode.Trim());
                    data["DutyCode"].Add(_data.ServiceCode.Trim().ToString());
                    data["Rate"].Add(_data.DutyRate.ToString());
                    data["Quantity"].Add(_data.Quantity.ToString());
                    data["Amount"].Add(_data.Amount.ToString());
                    data["TransactionDate"].Add(DateTime.Today.Date.ToString("dd/MM/yyyy"));
                    data["GlAccount"].Add(_data.GLAccount.ToString().Trim());
                    data["Location"].Add(_data.Location.ToString().Trim());
                    data["Branch"].Add(_data.Branch.ToString().Trim());
                    data["Department"].Add(_data.Department.ToString().Trim());
                    data["Notes"].Add(_data.Notes.Trim());
                }

                ConvertDatatoCSV(data, path);

                if (!BGWUpdateTables.IsBusy)
                {
                    ExportWaitingBar.StartWaiting();
                    ExportWaitingBar.Visible = true;
                    BGWUpdateTables.RunWorkerAsync();
                }                   
            }                
        }

        public void ConvertDatatoCSV(Dictionary<string, List<string>> dict, string path)
        {
            StringBuilder sb = new StringBuilder();
            CSVContent = new List<string>();

            String csv = String.Join(",", dict.Select(d => d.Key));
            sb.Append(csv + Environment.NewLine);

            int count = -1;
            foreach (var data in _calculationSummary)
            {
                count++;
                String csv2 = String.Join(",", dict.Select(d => string.Join(",", d.Value.Skip(count).Take(1))));

                sb.Append(csv2 + Environment.NewLine);

                CSVContent.Add(csv2);
            }

            File.WriteAllText(path, sb.ToString());

            string _applicationFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            string _exportFolderPath = _applicationFolderPath + "ExportedTransactions";
            string currentTime = DateTime.Now.ToString("_MMM_dd_yyyy_HH_mm_ss");
            _exportFolderPath = _exportFolderPath + "\\Transaction Export" + currentTime + ".csv";

            File.WriteAllText(_exportFolderPath, sb.ToString());
        }

        private void GrdDataDisplay_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.ForeColor = Color.Red;
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
                e.CellElement.Font = new Font("Segoe UI", 8.0f, FontStyle.Bold);
            }     
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            
            return table;
        }

        private void BGWUpdateTables_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                SqlConnection connection = this.dbContext.Database.Connection as SqlConnection;
                connection.Open();

                var _updateImportedTrans = _calculationDetails.Where(x => x.IsAllowance == false).ToList();
                var _updateImportedTransAllowances = _calculationDetails.Where(x => x.IsAllowance == true).ToList();
                
                DataTable _recordReaderDataTable = new DataTable();
                _recordReaderDataTable = ConvertListForDatabaseUpdate(_updateImportedTrans, false);
                
                DataTable _allowanceReaderDataTable = new DataTable();
                _allowanceReaderDataTable = ConvertListForDatabaseUpdate(_updateImportedTransAllowances, true);

                DataTable _finalExportList = new DataTable();
                _finalExportList.Merge(_recordReaderDataTable);
                _finalExportList.Merge(_allowanceReaderDataTable);

                int _bulkCopybatchSize = _finalExportList.Rows.Count;

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.ConnectionString))
                {
                    bulkCopy.BatchSize = _bulkCopybatchSize;
                    bulkCopy.DestinationTableName = "ExportedTransactions";
                    bulkCopy.BulkCopyTimeout = 0;
                    bulkCopy.WriteToServer(_finalExportList);
                }

                connection.Close();

                //var _updateImportedTrans = _calculationDetails.OrderBy(x => x.ImportedTransId).ThenBy(x => x.ReferenceId).ToList();

                //foreach (var _transaction in _updateImportedTrans)
                //{
                //    ExportedTransaction _expTrans = new ExportedTransaction();

                //    _expTrans.AllowanceId = _transaction.ReferenceId;
                //    _expTrans.DateExported = DateTime.Now;
                //    _expTrans.ExportedBy = SMARTPayExtConstants._activeUser;
                //    _expTrans.ImportedTransId = _transaction.ImportedTransId;
                //    _expTrans.IsAllowance = Convert.ToBoolean(_transaction.IsAllowance);

                //    if (Convert.ToBoolean(_transaction.IsAllowance) == true)
                //        _expTrans.Quantity = Convert.ToDecimal(_transaction.AllowanceHrs);
                //    else
                //        _expTrans.Quantity = _transaction.ShiftTotal;

                //    _expTrans.Rate = Convert.ToDecimal(_transaction.DutyRate);

                //    dbContext.ExportedTransactions.Add(_expTrans);
                //}
                
                //dbContext.SaveChanges();
            }
            catch (Exception _exp)
            {
                RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
            }
        }

        private void BGWUpdateTables_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ExportWaitingBar.StopWaiting();
            ExportWaitingBar.Visible = false;
            RadMessageBox.Show("File exported for period Successfully!", Application.ProductName);
            btnExport.Enabled = false;
        }

        private void GrdDataDisplay_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.ZIndex >= 0)
            {
                if (e.RowElement.RowInfo.HierarchyLevel == 1)
                {
                    if (e.RowElement.RowInfo.Cells["Branch"].Value == null)
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
            }
        }
    }
}