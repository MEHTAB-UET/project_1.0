using MySql.Data.MySqlClient;
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
        private string userEmail;
        public _10MemberResetPassword(string mail)
        {
            InitializeComponent();
            userEmail = mail;
        }

        private void backToLoginPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            teamLogin loginPage = new teamLogin();
            loginPage.FormClosed += (s, arg) => this.Close();
            loginPage.Show();
            this.Hide();
        }

        private void _10MemberResetPassword_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Page route successfully completed");
            MessageBox.Show(userEmail);

        }

        private void employeeNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnfrmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            string passwordd = employeeNewPassword.Text.Trim();
            string confirmPassword = cnfrmPassword.Text.Trim();

            if (string.IsNullOrEmpty(passwordd) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordd != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection conn = dbConnection.GetConnection(); // Assumes this method exists
                conn.Open();

                string query = "UPDATE members SET Password = @password WHERE Email = @userEmail";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@password", passwordd);
                cmd.Parameters.AddWithValue("@userEmail", userEmail);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    teamLogin loginpage = new teamLogin();
                    loginpage.FormClosed += (s, arg) => this.Close();
                    loginpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to reset password. Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
