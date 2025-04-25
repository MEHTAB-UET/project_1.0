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
    public partial class AssignNewTask : Form
    {
        public AssignNewTask()
        {
            InitializeComponent();
            
            this.Load += new System.EventHandler(this.AssignNewTask_Load);

            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits
        }
        private void AssignNewTask_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string projectQuery = "SELECT projectName FROM projects";
                MySqlCommand projectCmd = new MySqlCommand(projectQuery, conn);
                MySqlDataReader projectReader = projectCmd.ExecuteReader();

                while (projectReader.Read())
                {
                    RelatedProjects.Items.Add(projectReader.GetString("projectName"));
                }

                projectReader.Close();

                string deptQuery = "SELECT name FROM department";
                MySqlCommand deptCmd = new MySqlCommand(deptQuery, conn);
                MySqlDataReader deptReader = deptCmd.ExecuteReader();

                while (deptReader.Read())
                {
                    Department.Items.Add(deptReader.GetString("name"));
                }

                deptReader.Close(); // <- Add this
                conn.Close();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }



      



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void taskTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void taskDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void priority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RelatedProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Employee.Items.Clear();
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string query = "SELECT FullName FROM members WHERE Department = @dept";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dept", Department.SelectedItem?.ToString() ?? "");


                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee.Items.Add(reader.GetString("FullName"));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }

        }

        private void Employee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void assignTaskBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();
                if (priority.SelectedItem == null || Employee.SelectedItem==null || RelatedProjects.SelectedItem == null || Department.SelectedItem == null)
                {
                    MessageBox.Show("Please make sure all dropdowns are selected.");
                    return;
                }


                string query = @"INSERT INTO assignTask (toEmployee, TaskTitle, TaskDescription, startDate, dueDate, priority, relatedToProject, relatedToDepartment)
                         VALUES (@emp, @title, @desc, @start, @due, @priority, @project, @dept)";

                string updateDept = @"UPDATE department 
                      SET total_task_assign = total_task_assign + 1, 
                          pending_task = pending_task + 1 
                      WHERE name = @dept";

                MySqlCommand updateCmd = new MySqlCommand(updateDept, conn);
                updateCmd.Parameters.AddWithValue("@dept", Department.SelectedItem.ToString());
                updateCmd.ExecuteNonQuery();


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@emp", Employee.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@title", taskTitle.Text);
                cmd.Parameters.AddWithValue("@desc", taskDescription.Text);
                cmd.Parameters.AddWithValue("@start", startDate.Value.Date);
                cmd.Parameters.AddWithValue("@due", dueDate.Value.Date);
                cmd.Parameters.AddWithValue("@priority", priority.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@project", RelatedProjects.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@dept", Department.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Task Assigned Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning task: " + ex.Message);
            }



            //sending email 
            string userNAME = Employee.SelectedItem.ToString();
            string taskTitleText = taskTitle.Text;
            string taskDescriptionText = taskDescription.Text;
            string deadline = dueDate.Value.ToShortDateString();

            string userEmail = "";
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Email FROM members WHERE FullName = @name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", userNAME);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    userEmail = reader.GetString("Email");
                conn.Close();
            }


            ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
           string taskEmailApiAnswer =  service1Client.sendTaskEmail(userEmail,userNAME,taskTitleText, taskDescriptionText, deadline);

            if(taskEmailApiAnswer == "Email sent successfully!")
            {
                MessageBox.Show("Email sent successfully.");
                managerDashboard dashboardForm = new managerDashboard();
                dashboardForm.FormClosed += (s, args) => this.Close();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to send email.");
            }




        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            managerDashboard board = new managerDashboard();
            board.FormClosed += (s, args) => this.Close();
            board.Show();
            this.Hide();
        }
    }
}
