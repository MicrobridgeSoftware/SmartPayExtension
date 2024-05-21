using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using SMARTPayExtension.UI.Forms.Import;
using SMARTPayExtension.UI.Forms.Setup;
using SMARTPayExtension.UI.Forms.Export;
using SMARTPayExtension.UI.Forms.Employee;
using SMARTPayExtension.UI.Forms.Security;
using SMARTPayExtension.TechLibrary;
using System.Linq;
using Telerik.WinControls.UI;

namespace SMARTPayExtension
{
    public partial class FromMenu : Telerik.WinControls.UI.RadForm
    {
        private TechLibrary.CurrentUserCredentials _credentials;
        
        public FromMenu()
        {
            InitializeComponent();                        
        }

        public FromMenu(TechLibrary.CurrentUserCredentials _credentials) : this()
        {
            // TODO: Complete member initialization
            this._credentials = _credentials;
        }
                
        private void LLImportTransactions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionImportForm _transactionForm = new TransactionImportForm();
            //_transactionForm.Owner = this;
            _transactionForm.MdiParent = this.MdiParent;
            _transactionForm.Show();
        }

        private void LLGuardType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuardTypeForm _guardType = new GuardTypeForm();
            _guardType.Owner = this;
            _guardType.MdiParent = this.MdiParent;
            _guardType.Show();
        }

        private void LLHoilday_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
             HolidayForm _holiday = new HolidayForm();
             _holiday.Owner = this;
             _holiday.MdiParent = this.MdiParent;
            _holiday.Show();
        }

        private void LLHolidayRates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HolidayPayRate _holidayrate = new HolidayPayRate();
            _holidayrate.Owner = this;
            _holidayrate.MdiParent = this.MdiParent;
            _holidayrate.Show();
        }

        private void LLZones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ZoneForm _zone = new ZoneForm();
            _zone.Owner = this;
            _zone.MdiParent = this.MdiParent;
            _zone.Show();
        }

        private void LLZoneMapping_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ZoneMappingForm _zoneMapping = new ZoneMappingForm();
            _zoneMapping.Owner = this;
            _zoneMapping.MdiParent = this.MdiParent;
            _zoneMapping.Show();
        }

        private void LLAllowance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllowanceForm _allowance = new AllowanceForm();
            _allowance.Owner = this;
            _allowance.MdiParent = this.MdiParent;
            _allowance.Show();
        }

        private void LLImportedTransLookup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ImportTransactionLookup _importTrans = new ImportTransactionLookup();
            _importTrans.Owner = this;
            _importTrans.MdiParent = this.MdiParent;
            _importTrans.Show();
        }

        private void LLDutyType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DutyTypeForm _dutyType = new DutyTypeForm();
            _dutyType.Owner = this;
            _dutyType.MdiParent = this.MdiParent;
            _dutyType.Show();
        }

        private void LLStatusMapping_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuardStatusMappingForm _statusMapping = new GuardStatusMappingForm();
            _statusMapping.Owner = this;
            _statusMapping.MdiParent = this.MdiParent;
            _statusMapping.Show();
        }

        private void LLExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionExportForm _exportTrans = new TransactionExportForm();
            _exportTrans.Owner = this;
            _exportTrans.MdiParent = this.MdiParent;
            _exportTrans.Show();
        }

        private void LLPremiumClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PremiumClientsForm _premiumClients = new PremiumClientsForm();
            _premiumClients.Owner = this;
            _premiumClients.MdiParent = this.MdiParent;
            _premiumClients.Show();
        }

        private void LLAddon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OwnWeaponForm _ownGun = new OwnWeaponForm();
            _ownGun.Owner = this;
            _ownGun.MdiParent = this.MdiParent;
            _ownGun.Show();
        }

        private void LLOwnWeaponMapping_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContractorAddonFrom _addOn = new ContractorAddonFrom();
            _addOn.Owner = this;
            _addOn.MdiParent = this.MdiParent;
            _addOn.Show();
        }

        private void LLSystemUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SystemUserForm _sysUser = new SystemUserForm();
            _sysUser.Owner = this;
            _sysUser.MdiParent = this.MdiParent;
            _sysUser.Show();
        }

        private void LLSecurityPrivilege_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SystemUserRightsForm _rights = new SystemUserRightsForm();
            _rights.Owner = this;
            _rights.MdiParent = this.MdiParent;
            _rights.Show();
        }

        private void FromMenu_Load(object sender, EventArgs e)
        {
            foreach (Control control in radPageView1.Controls)
            {
                if (!control.Name.Equals("MnuCategories"))
                {
                    control.Enabled = false;
                }
            }

            var _distinctMenu = _credentials._userCredentials().Select(x=> x.getMenuName()).Distinct().ToList();

            foreach(var _value in _distinctMenu)
            {
                string _mainMenu = _value.ToString();

                var _sysMenu = radPageView1.Pages.Where(x=> x.Name == _mainMenu).First();
                
                _sysMenu.Enabled = true;

                DisableSubMenu(_sysMenu);

                var _nodes = _credentials._userCredentials().Where(x=> x.getMenuName().Equals(_mainMenu)).ToList();

                foreach(var node in _nodes)
                {
                    var _subMenu = _sysMenu.Controls.Find(node.getNodeName(), true).FirstOrDefault();

                    if (_subMenu != null)
                        _subMenu.Enabled = true;
                    else
                        _subMenu.Enabled = false;
                }
            }            
        }

        private void DisableSubMenu(Control _control)
        {
            foreach (Control linkLabelcontrol in _control.Controls)
            {
                linkLabelcontrol.Enabled = false;        
            }
        }

        private void LLSystemUserDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SystemUserDisplayForm _displayForm = new SystemUserDisplayForm();
            _displayForm.Owner = this;
            _displayForm.MdiParent = this.MdiParent;
            _displayForm.Show();
        }

        private void LLExpTransLookup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportTransactionLookup _exportLookUp = new ExportTransactionLookup();
            _exportLookUp.Owner = this;
            _exportLookUp.MdiParent = this.MdiParent;
            _exportLookUp.Show();
        }

        private void LLGuardForceDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuardForceForm _display = new GuardForceForm();
            _display.Owner = this;
            _display.MdiParent = this.MdiParent;
            _display.Show();
        }

        private void LLClientRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientSpecificRateForm _clientRate = new ClientSpecificRateForm();
            _clientRate.Owner = this;
            _clientRate.MdiParent = this.MdiParent;
            _clientRate.Show();
        }

        private void LLGuardCost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CostAnalysisForm _analysisForm = new CostAnalysisForm();
            _analysisForm.Owner = this;
            _analysisForm.MdiParent = this.MdiParent;
            _analysisForm.Show();
        }

        private void llGuardLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuardLocationForm _guardLocation = new GuardLocationForm();
            _guardLocation.Owner = this;
            _guardLocation.MdiParent = this.MdiParent;
            _guardLocation.Show();
        }
    }
}