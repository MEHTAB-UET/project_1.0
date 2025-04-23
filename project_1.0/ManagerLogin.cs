using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace project_1._0
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void managerUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void managerPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginAsManager_Click(object sender, EventArgs e)
        {
            string username = managerUserId.Text.Trim();
            string password = managerPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string query = "SELECT * FROM Manager WHERE UserName = @username AND Password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Login success
                    reader.Close();
                    conn.Close();

                    managerDashboard dashboard = new managerDashboard();
                    dashboard.FormClosed += (s, args) => this.Close();
                    dashboard.ShowDialog();
                    this.Hide();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void forgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetPassword resetPasswordForm = new resetPassword();
            resetPasswordForm.FormClosed += (s, arg) => this.Close();
            resetPasswordForm.ShowDialog();
            this.Hide();
        }
    }
}
