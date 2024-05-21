using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SmartAppraisal
{
    public partial class MainWindow : Telerik.WinControls.UI.RadForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            FromMenu mnu = new FromMenu();
            mnu.Show();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            FromMenu mnu = new FromMenu();
            mnu.Show();
        }
    }
}
