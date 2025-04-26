using MySql.Data.MySqlClient;
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
                    if (reader.Read())
                    {
                        Member member = new Member
                        {
                            // destructuring the object of class 
                            Id = reader.GetInt32("Id"),
                            UserName = reader.GetString("userName"),
                            Email = reader.GetString("Email"),
                            FullName = reader.GetString("FullName"),
                            PhoneNo = reader.GetString("phoneNo"),
                            CNIC = reader.GetString("CNIC"),
                            Department = reader.GetString("Department"),
                            Designation = reader.GetString("Designation"),
                            Gender = reader.GetString("Gender"),
                            Password = reader.GetString("Password"),
                            Pay = reader.GetString("Pay"),
                            ImgPath = reader.GetString("imgPath")


                        };





                        MessageBox.Show("Login Successfully!");
                        Service1Client client = new Service1Client();
                        string ApiAnswer = client.sendLoginMailToEmployee(member.Email);
                        if (ApiAnswer == "Email sent successfully!")
                        {
                            MessageBox.Show("Login confirmation email has been sent to your email.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to send login confirmation email.");
                            MessageBox.Show(ApiAnswer);
                        }

                        _11_MemberDashboard dashboard = new _11_MemberDashboard(member);
                        dashboard.FormClosed += (s, arg) => this.Close();
                        dashboard.Show();
                        this.Hide();
                    }
                    else { MessageBox.Show("Invalid username or password."); }
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

        private void teamLogin_Load(object sender, EventArgs e)
        {

        }
    }
}



