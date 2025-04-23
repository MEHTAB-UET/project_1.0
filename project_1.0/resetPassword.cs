using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1._0
{
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits image to box
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void getCode_Click(object sender, EventArgs e)
        {
            string userEmail = managerUserId.Text.Trim();
            Service1Client client = new Service1Client();
            string apiAnswer = client.sendEmail(userEmail);
            if (apiAnswer == "Email sent successfully!")
            {
                MessageBox.Show("Confirmation code has been sent to your email.");
                writeConfirmationCode writeConfirmationCode = new writeConfirmationCode();
                writeConfirmationCode.FormClosed += (s, args) => this.Close();
                writeConfirmationCode.Show();
                this.Hide();
                MessageBox.Show(apiAnswer);
            }
            else
            {
                MessageBox.Show("Failed to send confirmation code. Please check your email address.");
                MessageBox.Show(apiAnswer);

                return;
            }
            MessageBox.Show(apiAnswer);




        }

        private void managerUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerLogin managerLoginPage = new ManagerLogin();
            managerLoginPage.FormClosed += (s, arg) => this.Close();
            managerLoginPage.ShowDialog();
            this.Hide();
        }
    }
}
