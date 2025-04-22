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
    public partial class writeConfirmationCode : Form
    {
        public writeConfirmationCode()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits image to box
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void verificationCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void authenticate_Click(object sender, EventArgs e)
        {
            int confimationCode = Convert.ToInt32(verificationCode.Text.Trim());
            if(confimationCode == 584379) 
            {
                MessageBox.Show("Code verified successfully!");
                resetPassword_2 resetPasswordForm = new resetPassword_2();
                resetPasswordForm.FormClosed += (s, args) => this.Close();
                resetPasswordForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid code. Please try again.");
            }
        }
    }
}
