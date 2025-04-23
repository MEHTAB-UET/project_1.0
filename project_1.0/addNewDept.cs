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
    public partial class addNewDept : Form
    {
        public addNewDept()
        {
            InitializeComponent();
            this.Load += addNewDept_Load;
            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits image to box
        }

        private void addNewDept_Load(object sender, EventArgs e)
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void newDeptName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addDeptBtn_Click(object sender, EventArgs e)
        {
            string deptName = newDeptName.Text.Trim();

            if (string.IsNullOrEmpty(deptName))
            {
                MessageBox.Show("Please enter department name.");
                return;
            }

            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string query = "INSERT INTO department (name, total_task_assign, pending_task, task_done, no_of_employees) VALUES (@name, 0, 0, 0, 0)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", deptName);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Department added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }


        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void departmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void designation_TextChanged(object sender, EventArgs e)
        {

        }

        private void addDesignation_Click(object sender, EventArgs e)
        {
            string? dept = departmentCombo.SelectedItem?.ToString();

            string desig = designation.Text.Trim();

            if (string.IsNullOrEmpty(dept) || string.IsNullOrEmpty(desig))
            {
                MessageBox.Show("Select department and enter designation.");
                return;
            }

            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string query = "INSERT INTO designationWithDepartments (designation, departmentName) VALUES (@desig, @dept)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@desig", desig);
                cmd.Parameters.AddWithValue("@dept", dept);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Designation added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
