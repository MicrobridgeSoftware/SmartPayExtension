using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;

namespace SMARTPayExtension.UI.Forms.Import
{
    public partial class ImportCompanyForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        public ImportCompanyForm()
        {
            InitializeComponent();
        }

        private void ImportCompanyForm_Load(object sender, EventArgs e)
        {
            var _company = dbContext.SMARTPayCompanyViews.AsNoTracking().ToList();
            bindingSourceCompany.DataSource = _company;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var _selectedCompanies = grdCompany.Rows.Where(x => x.Cells[0].Value != null && Convert.ToBoolean(x.Cells[0].Value) == true).ToList();

            if (_selectedCompanies.Count > 0)
            {
                DialogResult _verifyAction = RadMessageBox.Show("Are you sure the imported employee(s) are within the selected company(s)?", Application.ProductName, MessageBoxButtons.YesNo);

                if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach(var company in _selectedCompanies)
                        TransactionImportForm._companyId.Add(Convert.ToInt32(company.Cells[4].Value));


                    Close();
                }
            }
            else
                RadMessageBox.Show("Atleast one company must be selected!", Application.ProductName);
        }
    }
}