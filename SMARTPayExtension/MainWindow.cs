using SMARTPayExtension.UI.Forms.Import;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using SMARTPayExtension.TechLibrary;
using SMARTPayExtension.UI.Forms.Security;

namespace SMARTPayExtension
{
    public partial class MainWindow : Telerik.WinControls.UI.RadForm
    {
        CurrentUserCredentials _credentials = new CurrentUserCredentials();
        public MainWindow()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "Office2010Blue";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UserLoginForm _login = new UserLoginForm(_credentials);
            _login.ShowDialog();

            int _userValueCount = _credentials._userCredentials().Count;

            if (_userValueCount == 0)
            {
                btnBackgroundImage.Enabled = false;
                MainMenu.Enabled = false;
                return;
            }

            lblUserflName.Text = _credentials.getFirstName() + " " + _credentials.getLastName();
            lblUserName.Text = _credentials.getUserName();
            lblAccountInfo.Text = "Account Expirable : " + _credentials.getAccountConfig().ToString();
            SMARTPayExtConstants._activeUser = _credentials._loggedInUserName();

            if (_credentials.getAccountConfig() == true)
            {
                using (SMARTPayExtensionEntities DB = new SMARTPayExtensionEntities())
                {
                    DateTime _accountExpDate = (DateTime)DB.SystemUserViews.Where(x => x.UserName.Trim() == SMARTPayExtConstants._activeUser)
                                                                           .Select(x=> x.AccountExpirationDate).First();
                    
                    lblExpDate.Text = _accountExpDate.ToLongDateString();
                    lblExpDate.Visible = true;
                }
            }

            lblDisplay.Text = _credentials.getUserName() + ". " + DateTime.Today.ToLongDateString();
            lblDisplay.Visible = true;

            if (_credentials.getImageData() != null)
            {
                Bitmap bmp;
                var bytes = (byte[])_credentials.getImageData();
                MemoryStream ms = new MemoryStream(bytes);
                bmp = new Bitmap(ms);
                pictureBoxActiveUser.Image = bmp;

                ms.Flush();
                ms.Dispose();
            }

            using (SMARTPayExtensionEntities DBContext = new SMARTPayExtensionEntities())
            {
                var _getUserImage = DBContext.SystemUserSettings.Where(x => x.UserName.Trim() == SMARTPayExtConstants._activeUser).FirstOrDefault();

                if (_getUserImage != null)
                {
                    Bitmap bmp2;
                    var bytes2 = (byte[])_getUserImage.MdiParentImage;
                    MemoryStream ms2 = new MemoryStream(bytes2);
                    bmp2 = new Bitmap(ms2);
                    this.BackgroundImage = bmp2;

                    ms2.Flush();
                    ms2.Dispose();
                }     
            }

            FromMenu mnu = new FromMenu(_credentials);
            mnu.MdiParent = this;
            mnu.Show();
            
            if (!BGWTheme.IsBusy)
                BGWTheme.RunWorkerAsync();
        }

        private void MainMenu_Click_1(object sender, EventArgs e)
        {
            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "FromMenu")
                {
                    Application.OpenForms[index].Close();
                }
                else
                {
                    if (Application.OpenForms[index].Name != "MainWindow")
                        Application.OpenForms[index].WindowState = FormWindowState.Normal;
                }
            }

            FromMenu mnu = new FromMenu(_credentials);
            mnu.MdiParent = this;
            mnu.Show();
        }

        private void btnBackgroundImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";

            if (openFileDialog.ShowDialog(this.Parent) == DialogResult.OK)
            {
                byte[] data;
                Bitmap bmp;

                string fileName = openFileDialog.FileName;

                FileStream fs = File.OpenRead(fileName);
                data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);

                MemoryStream ms = new MemoryStream(data);
                bmp = new Bitmap(ms);
                this.BackgroundImage = bmp;

                DialogResult _defaultImage = RadMessageBox.Show("Do you want to continuously use this image as your Wallpaper?", 
                                             Application.ProductName, MessageBoxButtons.YesNo);

                if (_defaultImage == System.Windows.Forms.DialogResult.Yes)
                {
                    using (SMARTPayExtensionEntities dbContext = new SMARTPayExtensionEntities())
                    {
                        var _userImage = dbContext.SystemUserSettings.Where(x => x.UserName.Trim() == SMARTPayExtConstants._activeUser).FirstOrDefault();

                        if (_userImage == null)
                        {
                            SystemUserSetting _saveBackgroundImage = new SystemUserSetting();
                            _saveBackgroundImage.MdiParentImage = data;
                            _saveBackgroundImage.UserName = SMARTPayExtConstants._activeUser;
                            dbContext.SystemUserSettings.Add(_saveBackgroundImage);
                        }
                        else
                        {
                            _userImage.MdiParentImage = data;
                        }

                        dbContext.SaveChanges();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _verifyAction = RadMessageBox.Show("Are you sure you want to close this Application?", Application.ProductName, MessageBoxButtons.YesNo);

            if (_verifyAction == System.Windows.Forms.DialogResult.Yes)
            {
                //using (SMARTPayExtensionEntities DBContext2 = new SMARTPayExtensionEntities())
                //{
                //    if (SMARTPayExtConstants._activeUser != null)
                //    {
                //        var _updateUserLoginStatus = DBContext2.SystemUsers.Where(x => x.UserName == SMARTPayExtConstants._activeUser).FirstOrDefault();

                //        if (_updateUserLoginStatus != null)
                //        {
                //            _updateUserLoginStatus.CurrentlyLoggedIn = false;
                //            DBContext2.SaveChanges();
                //        }
                //    }
                //}

                Application.Exit(); 
            }                                           
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                return;
            }

            using (SMARTPayExtensionEntities DBContext2 = new SMARTPayExtensionEntities())
            {
                if (SMARTPayExtConstants._activeUser != null)
                {
                    var _updateUserLoginStatus = DBContext2.SystemUsers.Where(x => x.UserName == SMARTPayExtConstants._activeUser).FirstOrDefault();

                    if (_updateUserLoginStatus != null)
                    {
                        _updateUserLoginStatus.CurrentlyLoggedIn = false;
                        DBContext2.SaveChanges();
                    }
                }
            }
        }

        private void ddlTheme_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            string strTheme = ddlTheme.Text;
            
            Theme theme = ThemeResolutionService.GetTheme(strTheme);
            
            if (theme != null)
            {
                ThemeResolutionService.ApplicationThemeName = theme.Name;
            }
        }

        private void BGWTheme_DoWork(object sender, DoWorkEventArgs e)
        {
            var themefiles = Directory.GetFiles(System.Windows.Forms.Application.StartupPath, "Telerik.WinControls.Themes.*.dll");

            foreach (var theme in themefiles)
            {
                var themeAssembly = Assembly.LoadFile(theme);

                var themeType = themeAssembly.GetTypes().Where(_themes => typeof(RadThemeComponentBase).IsAssignableFrom(_themes)).FirstOrDefault();

                if (themeType != null)
                {
                    RadThemeComponentBase themeObject = (RadThemeComponentBase)Activator.CreateInstance(themeType);

                    if (themeObject != null)
                    {
                        themeObject.Load();
                    }
                }
            }
        }

        private void BGWTheme_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var themeList = ThemeRepository.AvailableThemeNames.ToList();
            ddlTheme.DataSource = themeList;

            string _defaultThemeName = "Office2010Blue";
            ddlTheme.SelectedIndex = ddlTheme.Items.IndexOf(ddlTheme.Items.First(x => x.Text == _defaultThemeName));
        }

        private void ColPanelUser_Expanded(object sender, EventArgs e)
        {

        }
    }
}