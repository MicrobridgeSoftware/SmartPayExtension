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
using SMARTPayExtension.TechLibrary;

namespace SMARTPayExtension.UI.Forms.Security
{
    public partial class SystemUserRightsForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();        
        int _existingUser = 0;

        public SystemUserRightsForm()
        {
            InitializeComponent();
        }

        private void SystemUserRightsForm_Load(object sender, EventArgs e)
        {
            var _menuOptions = dbContext.MenuOptions.AsNoTracking().ToList();
            var _suMenuOptions = dbContext.SystemMenuViews.AsNoTracking().ToList();
            var _user = dbContext.SystemUsers.AsNoTracking().ToList();

            if (_menuOptions.Count > 0)
            {
                GrdMenu.DataSource = _menuOptions;
                grdSubMenu.DataSource = _suMenuOptions;
            }

            bindingSourceUser.DataSource = _user;

           // ddlUser.SelectedIndex = -1;            
        }

        private void bindingSourceUser_PositionChanged(object sender, EventArgs e)
        {
            byte[] data;
            Bitmap bmp;
                        
            data = ((SystemUser)bindingSourceUser.Current).UserImage;

            if (data != null)
            {
                MemoryStream ms = new MemoryStream(data);
                bmp = new Bitmap(ms);
                pictureBoxUserImg.Image = bmp;

                ms.Flush();
                ms.Dispose();
            }
            else
                pictureBoxUserImg.Image = null; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ddlUser.SelectedValue == null || Convert.ToInt32(ddlUser.SelectedValue) == 0)
            {
                RadMessageBox.Show("Select a valid user from the drop-down-list proivided!", Application.ProductName);
                return;
            }

            var _rightsSelected = grdSubMenu.Rows.Where(x => x.Cells["Select"].Value != null && (bool)x.Cells["Select"].Value == true).ToList();

            if (_rightsSelected.Count == 0)
            {
                RadMessageBox.Show("No system access has been selected for this user!", Application.ProductName);
                return;
            }

            DialogResult _verifyAction = RadMessageBox.Show("Do you want to add selected right(s) to this User?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                int _userId = Convert.ToInt32(ddlUser.SelectedValue);

                try
                {
                    if (_existingUser > 0)
                    {
                        var _userInformation = dbContext.SystemUserAccesses.Where(x => x.SystemUserId == _existingUser).ToList();

                        foreach (var _userRecord in _userInformation)
                        {
                            var _record = dbContext.SystemUserAccesses.Where(x => x.UserAccessId == _userRecord.UserAccessId).First();
                            dbContext.SystemUserAccesses.Remove(_record);
                        }
                    }

                    for (int _row = 0; _row < grdSubMenu.Rows.Count; _row++)
                    {
                        if (grdSubMenu.Rows[_row].Cells["Select"].Value != null)
                        {
                            bool isChecked = (bool)grdSubMenu.Rows[_row].Cells["Select"].Value;

                            if (isChecked)
                            {
                                int _mnuId = (int)grdSubMenu.Rows[_row].Cells["MenuId"].Value;
                                int _nodeId = (int)grdSubMenu.Rows[_row].Cells["MenuNodesId"].Value;

                                SystemUserAccess _userAccess = new SystemUserAccess();
                                _userAccess.SystemUserId = _userId;
                                _userAccess.MenuId = _mnuId;
                                _userAccess.MenuNodesId = _nodeId;
                                _userAccess.LastModifiedDate = DateTime.Now;
                                _userAccess.LastModifiedBy = SMARTPayExtConstants._activeUser;

                                dbContext.SystemUserAccesses.Add(_userAccess);
                            }
                        }
                    }

                    dbContext.SaveChanges();
                    RadMessageBox.Show("User Added/updated successfully!", Application.ProductName);
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }

        private void ddlUser_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {            
            if (ddlUser.SelectedValue != null || Convert.ToInt32(ddlUser.SelectedValue) > 0)
            {
                DisplayUserAccess();
            }
        }

        private void DisplayUserAccess()
        {
            int _sysUserId = Convert.ToInt32(ddlUser.SelectedValue);

            var _getSysUser = dbContext.SystemUserAccesses.Where(x => x.SystemUserId == _sysUserId).ToList();

            if (_getSysUser.Count > 0)
            {
                _existingUser = _sysUserId;

                for (int i = 0; i < GrdMenu.Rows.Count; i++)
                {
                    GrdMenu.Rows[i].Cells["Select"].Value = false;
                }

                for (int s = 0; s < grdSubMenu.Rows.Count; s++)
                {
                    grdSubMenu.Rows[s].Cells["Select"].Value = false;
                }

                var _mainMenu = _getSysUser.Select(x => x.MenuId).Distinct().ToList();

                foreach (var _menu in _mainMenu)
                {
                    int _menuId = Convert.ToInt32(_menu);
                    int _mnuIndex = GrdMenu.Rows.Where(r => Convert.ToInt32(r.Cells["MenuId"].Value) == _menuId).Select(i => i.Index).FirstOrDefault();

                    GrdMenu.Rows[_mnuIndex].Cells["Select"].Value = true;
                }

                foreach (var _node in _getSysUser)
                {
                    var _subMenuRow = grdSubMenu.Rows.Where(r => Convert.ToInt32(r.Cells["MenuNodesId"].Value) == _node.MenuNodesId &&
                                      Convert.ToInt32(r.Cells["MenuId"].Value) == _node.MenuId).FirstOrDefault();

                    if (_subMenuRow != null)
                        _subMenuRow.Cells["Select"].Value = true;
                }
            }
            else
            {
                _existingUser = 0;

                for(int i = 0; i< GrdMenu.Rows.Count; i++)
                {
                    GrdMenu.Rows[i].Cells["Select"].Value = false;
                }

                for(int s= 0; s < grdSubMenu.Rows.Count; s++)
                {
                    grdSubMenu.Rows[s].Cells["Select"].Value = false;
                }
            }
        }
    }
}