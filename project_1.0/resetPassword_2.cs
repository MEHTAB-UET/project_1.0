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
    public partial class resetPassword_2 : Form
    {
        public resetPassword_2()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {

            string passwordd = managerNewPassword.Text.Trim(); // Assuming you have a TextBox named passwordTextBox
            string confirmPassword = cnfrmPassword.Text.Trim(); // Assuming you have a TextBox named cnfrmPasswordTextBox
            string username = "mehtab2046"; // Hardcoded username for this example

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
                MySqlConnection conn = dbConnection.GetConnection(); // Assuming dbConnection.GetConnection() is defined
                conn.Open();

                string query = "UPDATE manager SET password = @password WHERE UserName = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@password", passwordd);
                cmd.Parameters.AddWithValue("@username", username);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to reset password. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnfrmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void managerNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
