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
    public partial class FromMenu : Telerik.WinControls.UI.RadForm
    {
        public FromMenu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Configuration.ConfigureAppQuestionsForm questions = new Forms.Configuration.ConfigureAppQuestionsForm();
            questions.ShowDialog();
        }
    }
}
