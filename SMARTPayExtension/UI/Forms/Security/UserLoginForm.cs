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

namespace SMARTPayExtension.UI.Forms.Security
{
    public partial class UserLoginForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        List<SystemUserView> _sysUsers;
        private CurrentUserCredentials _credentials;

        public static bool _passwordChanged = false;

        public UserLoginForm()
        {
            InitializeComponent();
        }

        public UserLoginForm(CurrentUserCredentials _credentials) : this()
        {
            // TODO: Complete member initialization
            this._credentials = _credentials;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to close this Application?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            _sysUsers = new List<SystemUserView>();
            _sysUsers = dbContext.SystemUserViews.AsNoTracking().ToList();
            txtUserName.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void GetUserAccess(string _currentUser)
        {
            var _userAccess = _sysUsers.Where(x => x.UserName.Trim().ToUpper().Equals(_currentUser)).ToList();

            foreach(var _access in _userAccess)
            {
                _credentials._userDetails(_access.ControlName, _access.NodeControlName, _access.UserName, _access.FirstName, _access.LastName, _access.MiddleName);
            }

            _credentials.setAccountConfig(_userAccess.First().AccountExpirable);

            if (_userAccess.First().UserImage != null)
                _credentials.setImageData(_userAccess.First().UserImage);
            else
                _credentials.setImageData(null);
        }

        private void PerformLogin()
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                RadMessageBox.Show("Enter a valid Username!", Application.ProductName);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                RadMessageBox.Show("Enter a valid Password!", Application.ProductName);
                return;
            }

            string _userName = txtUserName.Text.Trim().ToUpper();
            var _user = dbContext.SystemUserViews.Where(x => x.UserName.Trim().ToUpper().Equals(_userName)).FirstOrDefault();

            if (_user != null)
            {                
                string _password = txtPassword.Text.Trim();
                string _encryptedPassword = Encryption.Encrypt(_password);

                if (_user.Password.Trim().Equals(_encryptedPassword))
                {
                    if (_user.AccountExpirable)
                    {
                        DateTime _currentDate = DateTime.Today.Date;

                        if (_user.AccountExpirationDate <= _currentDate)
                        {
                            RadMessageBox.Show("This account has expired. Contact your system Administrator!", Application.ProductName);
                            return;
                        }
                    }

                    if (_user.RequireUserChange)
                    {
                        bool _reguireUserChange = false;
                        string _currentUser = _userName;

                        PasswordChangeForm _changePassword = new PasswordChangeForm(_currentUser, _reguireUserChange);
                        _changePassword.ShowDialog();

                        if (!_passwordChanged)
                        {
                            RadMessageBox.Show("Password must be changed to continue!", Application.ProductName);
                            return;
                        }
                    }

                    GetUserAccess(_userName);
                    var _updateUserLoginStatus = dbContext.SystemUsers.Where(x => x.SystemUserId == _user.SystemUserId).First();
                    _updateUserLoginStatus.CurrentlyLoggedIn = true;
                    dbContext.SaveChanges();
                    this.Close();
                }
                else
                {
                    RadMessageBox.Show("Invalid Password!", Application.ProductName);
                    return;
                }
            }
            else
                RadMessageBox.Show("Invalid Username/No access is assigned!", Application.ProductName);      
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PerformLogin();
            }    
        }
    }
}