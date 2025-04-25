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
    public partial class teamLogin : Form
    {
        public teamLogin()
        {
            InitializeComponent();
        }

        private void employeeUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginAsEmployee_Click(object sender, EventArgs e)
        {
            string username = employeeUserId.Text;
            string password = employeePassword.Text;


            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM members WHERE UserName COLLATE utf8mb4_general_ci = @user AND Password COLLATE utf8mb4_general_ci = @pass";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        MessageBox.Show("Login Successfully!");
                        _11_MemberDashboard dashboard = new _11_MemberDashboard();
                        dashboard.FormClosed += (s, arg) => this.Close();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials");
                    }
                }
            }


        }

        private void employeeForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            memberForgetPassword1 forgetPasswordPage = new memberForgetPassword1();
            forgetPasswordPage.FormClosed += (s, arg) => this.Close();
            forgetPasswordPage.Show();
            this.Hide();
        }
    }
}
