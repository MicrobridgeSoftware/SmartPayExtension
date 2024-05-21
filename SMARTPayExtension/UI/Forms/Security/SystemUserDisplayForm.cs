using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;

namespace SMARTPayExtension.UI.Forms.Security
{
    public partial class SystemUserDisplayForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        string _currentUser = string.Empty;
        bool _reguireUserChange = true;

        public SystemUserDisplayForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void grdDataDisplay_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Do you want to change this user password?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                PasswordChangeForm _changePassword = new PasswordChangeForm(_currentUser, _reguireUserChange);
                _changePassword.ShowDialog();
            }
        }

        private void SystemUserDisplayForm_Load(object sender, EventArgs e)
        {
            var _sysUsers = dbContext.SystemUsers.AsNoTracking().ToList();
            bindingSourceUsers.DataSource = _sysUsers;
        }

        private void bindingSourceUsers_PositionChanged(object sender, EventArgs e)
        {
            _currentUser = ((SystemUser)(bindingSourceUsers).Current).UserName;
        }

        private void grdDataDisplay_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            e.RowElement.RowInfo.Height = 50;
        }
    }
}