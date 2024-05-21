using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using SMARTPayExtension.TechLibrary;

namespace SMARTPayExtension.UI.Forms.Security
{
    public partial class SystemUserForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        byte[] data;
        int _sysUserId = 0;
        bool _editMode = false;

        public SystemUserForm()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";

            if (openFileDialog.ShowDialog(this.Parent) == DialogResult.OK)
            {
                //byte[] data;
                Bitmap bmp;

                string fileName = openFileDialog.FileName;

                FileStream fs = File.OpenRead(fileName);
                data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);

                MemoryStream ms = new MemoryStream(data);
                bmp = new Bitmap(ms);
                pictureBoxUserImg.Image = bmp;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private bool ValidateFormFields()
        {
            bool _valid = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                RadMessageBox.Show("First Name is reguired!", Application.ProductName);
                _valid = false;
                return _valid;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                RadMessageBox.Show("Last Name is reguired!", Application.ProductName);
                _valid = false;
                return _valid;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                RadMessageBox.Show("A UserName is reguired!", Application.ProductName);
                _valid = false;
                return _valid;
            }

            if (_editMode == false)
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    RadMessageBox.Show("A Password is reguired!", Application.ProductName);
                    _valid = false;
                    return _valid;
                }
            }

            if (chkExpire.Checked && (decimal)spnExpiryPeriod.Value <= 0)
            {
                RadMessageBox.Show("A valid active period for this Account must be entered!", Application.ProductName);
                _valid = false;
                return _valid;
            }

            return _valid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool _isFormValid = ValidateFormFields();

            if (!_isFormValid)
                return;

            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to add/Update this user?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (_sysUserId == 0)
                    {
                        SystemUser _sysUsers = new SystemUser();

                        string _password = Encryption.Encrypt(txtPassword.Text.Trim());

                        _sysUsers.FirstName = txtFirstName.Text.Trim();
                        _sysUsers.LastName = txtLastName.Text.Trim();
                        _sysUsers.UserName = txtUserName.Text.Trim();
                        _sysUsers.Password = _password;
                        _sysUsers.AccountExpirable = chkExpire.Checked == true ? true : false;
                        _sysUsers.RequireUserChange = true;
                        _sysUsers.LastModifiedDate = DateTime.Now;

                        if (!string.IsNullOrEmpty(txtMiddlename.Text))
                            _sysUsers.MiddleName = txtMiddlename.Text.Trim();

                        if (pictureBoxUserImg.Image != null)
                            _sysUsers.UserImage = data;

                        if (chkExpire.Checked == true)
                            _sysUsers.ActivePeriod = Convert.ToInt32(spnExpiryPeriod.Value);

                        dbContext.SystemUsers.Add(_sysUsers);
                    }
                    else
                    {
                        var _findUserRecord = dbContext.SystemUsers.Where(x => x.SystemUserId == _sysUserId).First();

                        _findUserRecord.FirstName = txtFirstName.Text.Trim();
                        _findUserRecord.LastModifiedDate = DateTime.Now;

                        if (!string.IsNullOrEmpty(txtMiddlename.Text))
                            _findUserRecord.MiddleName = txtMiddlename.Text.Trim();

                        _findUserRecord.LastName = txtLastName.Text.Trim();
                        _findUserRecord.AccountExpirable = chkExpire.Checked == true ? true : false;

                        if (chkExpire.Checked == true)
                            _findUserRecord.ActivePeriod = Convert.ToInt32(spnExpiryPeriod.Value);

                        if (data != null)
                            _findUserRecord.UserImage = data;
                    }

                    dbContext.SaveChanges();

                    if (_sysUserId == 0)
                        RadMessageBox.Show("User added successfully!", Application.ProductName);
                    else
                        RadMessageBox.Show("User record updated successfully!", Application.ProductName);

                    ClearFormControls();
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                string _enteredValue = txtUserName.Text.Trim();
                var _user = dbContext.SystemUsers.Where(user => user.UserName.Trim() == _enteredValue).FirstOrDefault();

                if (_user != null)
                {
                    _sysUserId = _user.SystemUserId;
                    txtFirstName.Text = _user.FirstName;
                    txtLastName.Text = _user.LastName;
                    txtMiddlename.Text = _user.MiddleName;
                    chkExpire.Checked = _user.AccountExpirable;

                    if (_user.AccountExpirable)
                        spnExpiryPeriod.Value = Convert.ToDecimal(_user.ActivePeriod);

                    if (_user.UserImage != null)
                    {                        
                        Bitmap bmp;
                        var bytes = (byte[])_user.UserImage;
                        MemoryStream ms = new MemoryStream(bytes);
                        bmp = new Bitmap(ms);
                        pictureBoxUserImg.Image = bmp;
                    }

                    txtPassword.ReadOnly = true;
                    txtUserName.ReadOnly = true;
                    _editMode = true;
                }                
            }
        }

        private void chkExpire_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkExpire.Checked)
                spnExpiryPeriod.ReadOnly = false;
            else
                spnExpiryPeriod.ReadOnly = true;
        }

        private void ClearFormControls()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMiddlename.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            pictureBoxUserImg.Image = null;
            spnExpiryPeriod.Value = 0;
            chkExpire.Checked = false;
            spnExpiryPeriod.ReadOnly = true;
            txtPassword.ReadOnly = false;
            txtUserName.ReadOnly = false;
            _editMode = false;
        }

        private void SystemUserForm_Load(object sender, EventArgs e)
        {
            ClearFormControls();
        }
    }
}