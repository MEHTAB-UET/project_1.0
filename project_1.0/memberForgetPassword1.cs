using ServiceReference1;
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
    public partial class memberForgetPassword1 : Form
    {
        public memberForgetPassword1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits image to box
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            teamLogin loginpage = new teamLogin();
            loginpage.FormClosed += (s, arg) => this.Close();
            loginpage.Show();
            this.Hide();
        }

        private void getCode_Click(object sender, EventArgs e)
        {
            string email = memberEmailForOTP.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.");
                return;
            }
            Service1Client client = new Service1Client();
            string ApiAnswer = client.sendEmail(email);
            if (ApiAnswer == "Email sent successfully!")
            {
                MessageBox.Show("OTP has been sent to your email.");
                memberOTP memberOTP = new memberOTP(email);
                memberOTP.FormClosed += (s, arg) => this.Close();
                memberOTP.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Failed to send OTP. Please try again.");
            }
        }

        private void memberEmailForOTP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
