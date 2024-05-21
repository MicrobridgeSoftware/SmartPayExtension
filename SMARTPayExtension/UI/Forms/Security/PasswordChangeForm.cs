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
using System.Text.RegularExpressions;

namespace SMARTPayExtension.UI.Forms.Security
{
    public partial class PasswordChangeForm : Telerik.WinControls.UI.RadForm
    {
        SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities();
        private string _currentUser;
        private bool _reguireUserChange;
        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        public PasswordChangeForm(string _currentUser, bool _reguireUserChange) : this()
        {
            // TODO: Complete member initialization
            this._currentUser = _currentUser;
            this._reguireUserChange = _reguireUserChange;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtconfirmPassword.Text))
            {
                RadMessageBox.Show("Password and/or confirm password fields cannot be empty", Application.ProductName);
                return;
            }

            if (txtPassword.Text.Trim().Count() < 8)
            {
                RadMessageBox.Show("Password length should be atleast 8 characters. \n"+
                                   "Include upper letter(s), special character(s), number(s) and symbol(s).", 
                                   Application.ProductName);
                return;
            }

            if (txtPassword.Text.Trim() != txtconfirmPassword.Text.Trim())
            {
                RadMessageBox.Show("Passwords entered are not the same!", Application.ProductName);
                return;
            }

            var _userCredentials = dbContext.SystemUsers.Where(x => x.UserName.Trim() == _currentUser.Trim()).First();
            string _decryptPassword = Encryption.Decrypt(_userCredentials.Password.Trim());

            if (txtPassword.Text.Trim() == _decryptPassword)
            {
                RadMessageBox.Show("This and the existing password are the same.",
                                   Application.ProductName);
                return;
            }

            var _dissemblePassword = txtPassword.Text.Trim().ToCharArray();
            Dictionary<int, string> _passwordFormat = new Dictionary<int, string>();
            int _count = 0;

            foreach(var _letter in _dissemblePassword)
            {
                _count++;
                bool _isSymbol = false;
                //if (char.IsUpper(_letter))
                //    _passwordFormat.Add(_count, "Upper");
                //else if (char.IsSymbol(_letter))
                //    _passwordFormat.Add(_count, "Symbol");
                //else if (char.IsNumber(_letter))
                //    _passwordFormat.Add(_count, "Number");  

                if (char.IsUpper(_letter))
                    _passwordFormat.Add(_count, "Upper");
                else if (char.IsNumber(_letter))
                    _passwordFormat.Add(_count, "Number");
                else
                    _isSymbol = CheckCharacter(_letter);

                if (_isSymbol)
                {
                    _passwordFormat.Add(_count, "Symbol");
                }
            }

            
            bool _upperFound = _passwordFormat.Where(x => x.Value.Equals("Upper")).Any();
            bool _symbolFound = _passwordFormat.Where(x => x.Value.Equals("Symbol")).Any();
            bool _numberFound = _passwordFormat.Where(x => x.Value.Equals("Number")).Any();

            if (!_upperFound || !_symbolFound || !_numberFound)
            {
                RadMessageBox.Show("Invalid password format detected. Password should include \n" +
                                   "upper letter(s), number(s) & special character(s) excluding _.",
                                   Application.ProductName);
                return;
            }
            
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want change this user password?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtconfirmPassword.Text))
                {
                    string _user = txtUserName.Text.Trim();

                    var _findUser = dbContext.SystemUsers.Where(x => x.UserName.Trim() == _user).FirstOrDefault();

                    if (_findUser != null)
                    {
                        string _newPassword = txtPassword.Text.Trim();
                        _newPassword = Encryption.Encrypt(_newPassword);

                        try
                        {
                            _findUser.Password = _newPassword;
                            _findUser.RequireUserChange = _reguireUserChange;
                            dbContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            RadMessageBox.Show(ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.ToString());
                        }

                        RadMessageBox.Show(txtUserName.Text.Trim() + " password has been changed successfully!", Application.ProductName);

                        if (!_reguireUserChange)
                            UserLoginForm._passwordChanged = true;

                        Close();
                    }
                }
            }
        }

        private bool CheckCharacter(char _character)
        {
            return Regex.Match(_character.ToString(), @"^\W+$").Success;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = _currentUser;
        }
    }
}