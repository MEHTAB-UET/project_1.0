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
    public partial class memberOTP : Form
    {
        public memberOTP()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            teamLogin loginPage = new teamLogin();
            loginPage.FormClosed += (s, arg) => this.Close();
            loginPage.Show();
            this.Hide();
        }

        private void verificationCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void authenticate_Click(object sender, EventArgs e)
        {

        }
    }
}
