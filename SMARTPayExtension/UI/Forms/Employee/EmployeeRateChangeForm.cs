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

namespace SMARTPayExtension.UI.Forms.Employee
{
    public partial class EmployeeRateChangeForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        private int _contractorId;
        private decimal _contractorRate;

        public EmployeeRateChangeForm()
        {
            InitializeComponent();
        }

        public EmployeeRateChangeForm(int _contractorId, decimal _contractorRate) : this()
        {
            // TODO: Complete member initialization
            this._contractorId = _contractorId;
            this._contractorRate = _contractorRate;
        }

        private void EmployeeRateChangeForm_Load(object sender, EventArgs e)
        {
            spnCurrentRate.Value = _contractorRate;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult _askUser = RadMessageBox.Show("Do you really want to update this employee rate?", 
                                    Application.ProductName, MessageBoxButtons.YesNo);

            if (_askUser == DialogResult.Yes)
            {
                try
                {
                    var _findContractor = dbContext.GuardStatusMappings.Where(x => x.ContractorId == _contractorId).FirstOrDefault();

                    if (_findContractor != null)
                    {
                        _findContractor.Rate = Convert.ToDecimal(spnChangedRate.Value);
                        _findContractor.LastModifiedDate = DateTime.Now;
                        _findContractor.LastModifiedBy = SMARTPayExtConstants._activeUser;
                        dbContext.SaveChanges();

                        RadMessageBox.Show("Rate changed successfully!", Application.ProductName);
                        Close();
                    }
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }
    }
}
