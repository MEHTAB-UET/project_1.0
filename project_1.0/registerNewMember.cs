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
    public partial class registerNewMember : Form
    {
        public registerNewMember()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            //loading image in image box 
            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits image to box
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registerNewMember_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string query = "SELECT name FROM department";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    departmentCombo.Items.Add(reader.GetString("name"));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }

        }

        private void homeBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            managerDashboard Dashboar = new managerDashboard();
            Dashboar.FormClosed += (s, arg) => this.Close();
            Dashboar.Show();
            this.Hide();
        }

        private void departmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear previous items
            designationCombo.Items.Clear();

            string selectedDept = departmentCombo.Text.Trim();

            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string query = "SELECT designation FROM designationWithDepartments WHERE departmentName = @dept";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dept", selectedDept);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    designationCombo.Items.Add(reader.GetString("designation"));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading designations: " + ex.Message);
            }
        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void CNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void designationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateofBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateofJoining_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnfrmPassword_TextChanged(object sender, EventArgs e)
        {

        }



        //not button2 it is basically Register Button 
        private void button2_Click(object sender, EventArgs e)
        {
            string name = fullName.Text.Trim();
            string email = emailAddress.Text.Trim();
            string phone = phoneNumber.Text.Trim();
            string cnic = CNIC.Text.Trim();
            string dept = departmentCombo.Text.Trim();
            string desg = designationCombo.Text.Trim();
            string gen = gender.Text.Trim();
            string dob = dateofBirth.Value.ToString("yyyy-MM-dd");
            string doj = dateofJoining.Value.ToString("yyyy-MM-dd");
            string uname = userName.Text.Trim();
            string pass = password.Text.Trim();
            string Pay = employeePay.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cnic) || string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }
            if (dateofJoining.Value.Date >= new DateTime(2025, 4, 27))
            {
                MessageBox.Show("Date of joining must be before 27-Apr-2025.");
                return;
            }

            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string checkQuery = "SELECT * FROM members WHERE userName = @uname OR Email = @email OR CNIC = @cnic";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@uname", uname);
                checkCmd.Parameters.AddWithValue("@email", email);
                checkCmd.Parameters.AddWithValue("@cnic", cnic);
                MySqlDataReader reader = checkCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Username, Email or CNIC already exists.");
                    reader.Close(); conn.Close();
                    return;
                }
                reader.Close();

                string insertQuery = "INSERT INTO members (FullName, Email, phoneNo, CNIC, Department, Designation, Gender, DateOfBirth, DateOfJoining, userName, Password,Pay) " +
                                     "VALUES (@name, @mail, @phone, @cnic, @dept, @desg, @gen, @dob, @doj, @uname, @pass ,@Pay)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@dept", dept);
                cmd.Parameters.AddWithValue("@desg", desg);
                cmd.Parameters.AddWithValue("@gen", gen);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@doj", doj);
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@Pay", Pay);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Member registered successfully.");
                // sending email to user 

                string userEmail = emailAddress.Text.Trim();
                string userNamee = userName.Text.Trim();
                string department = departmentCombo.Text.Trim();
                string designation = designationCombo.Text.Trim();
                string dateofJoiningg = dateofJoining.Value.ToString("yyyy-MM-dd");

                Service1Client client = new Service1Client();
                string apiAnswer = client.sendEmailToNewUser(userEmail, userNamee, department, designation, dateofJoiningg);
                if (apiAnswer == "Email sent successfully!")
                {
                    MessageBox.Show("Confirmation Email Sent to " + userName);
                    writeConfirmationCode writeConfirmationCode = new writeConfirmationCode();
                    writeConfirmationCode.FormClosed += (s, args) => this.Close();
                    writeConfirmationCode.Show();
                    this.Hide();
                    MessageBox.Show(apiAnswer);
                }
                else
                {

                    MessageBox.Show(apiAnswer);

                    return;
                }



















                //closing the current form of registration 
                managerDashboard dashboardFrom = new managerDashboard();
                dashboardFrom.FormClosed += (s, arg) => this.Close();
                dashboardFrom.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }


        }



        //this is select button (to select image form yoru system ) not loginAsManger its by mistake
        private void loginAsManager_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void employeePay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
