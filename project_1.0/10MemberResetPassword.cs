using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._0
{
    public partial class _10MemberResetPassword : Form
    {
        public _10MemberResetPassword()
        {
            InitializeComponent();
        }

        private void backToLoginPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            teamLogin loginPage = new teamLogin();
            loginPage.FormClosed += (s, arg) => this.Close();
            loginPage.Show();
            this.Hide();
        }
    }
}
