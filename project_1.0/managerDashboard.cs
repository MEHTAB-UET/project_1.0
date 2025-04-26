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
    public partial class managerDashboard : Form
    {
        public managerDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits image to box

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //adding code to go back to home page 
            managerDashboard dashboard = new managerDashboard();
            dashboard.FormClosed += (s, arg) => this.Close();
            dashboard.Show();
            this.Hide();
        }

        private void registerNewMember_Click(object sender, EventArgs e)
        {
            registerNewMember registrationForm = new registerNewMember();
            registrationForm.FormClosed += (s, arg) => this.Close();
            registrationForm.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, arg) => this.Close();
            form1.Show();
            this.Hide();
        }

        private void homePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            managerDashboard Dashboar = new managerDashboard();
            Dashboar.FormClosed += (s, arg) => this.Close();
            Dashboar.Show();
            this.Hide();
        }

        private void createNewProject_Click(object sender, EventArgs e)
        {
            createNewProject createProject = new createNewProject();
            createProject.FormClosed += (s, arg) => this.Close();
            createProject.Show();
            this.Hide();
        }

        private void addNewDept_Click(object sender, EventArgs e)
        {
            addNewDept createDept = new addNewDept();
            createDept.FormClosed += (s, arg) => this.Close();
            createDept.Show();
            this.Hide();
        }

        private void assignNewTask_Click(object sender, EventArgs e)
        {
            AssignNewTask assigNewTaskForm = new AssignNewTask();
            assigNewTaskForm.FormClosed += (s, arg) => this.Close();
            assigNewTaskForm.Show();
            this.Hide();
        }

        private void projectWithDeadlineAndClientName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void managerDashboard_Load(object sender, EventArgs e)
        {
            // Load project data with client name and deadline
            List<currentProjectsForDashboard> projectList = new List<currentProjectsForDashboard>();
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT projectName, clientName, deadline FROM projects", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        projectList.Add(new currentProjectsForDashboard
                        {
                            ProjectName = reader.GetString("projectName"),
                            ClientName = reader.GetString("clientName"),
                            Deadline = reader.GetDateTime("deadline")
                        });
                    }
                }
            }

            // Set project data to the first DataGridView
            projectWithDeadlineAndClientName.AutoGenerateColumns = true;
            projectWithDeadlineAndClientName.DataSource = projectList;

            // Load project budget data
            List<ProjectBudgetData> budgetList = new List<ProjectBudgetData>();
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT projectName, totalBudget, paidBudget FROM projects", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        budgetList.Add(new ProjectBudgetData
                        {
                            ProjectName = reader.GetString("projectName"),
                            TotalBudget = reader.GetDecimal("totalBudget"),
                            PaidBudget = reader.GetDecimal("paidBudget")
                        });
                    }
                }
            }


            //now loading department data 

            List<DepartmentData> departmentList = new List<DepartmentData>();

            // Query the database to get the department data
            using (MySqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT name, total_task_assign, pending_task, task_done FROM department", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        departmentList.Add(new DepartmentData
                        {
                            Department_Name = reader.GetString("name"),
                            TotalTaskAssign = reader.GetInt32("total_task_assign"),
                            PendingTask = reader.GetInt32("pending_task"),
                            TaskDone = reader.GetInt32("task_done")
                        });
                    }
                }
            }


            projectWithDeadlineAndClientName.AutoGenerateColumns = true;
            projectWithDeadlineAndClientName.DataSource = projectList;
            //CSS
            projectWithDeadlineAndClientName.Columns["ProjectName"].Width = 200;
            projectWithDeadlineAndClientName.Columns["ClientName"].Width = 200;
            projectWithDeadlineAndClientName.Columns["Deadline"].Width = 200;

            // now setting data source of all our grids 
            projectNameTotalBudgetandPaidBudget.AutoGenerateColumns = true;
            projectNameTotalBudgetandPaidBudget.DataSource = budgetList;
            //CSS
            projectNameTotalBudgetandPaidBudget.Columns["ProjectName"].Width = 200;
            projectNameTotalBudgetandPaidBudget.Columns["TotalBudget"].Width = 200;
            projectNameTotalBudgetandPaidBudget.Columns["PaidBudget"].Width = 200;

            //
            departmentData.AutoGenerateColumns = true;
            departmentData.DataSource = departmentList;


            //setting some CSS manually 
            departmentData.Columns["Department_Name"].Width = 400;
            departmentData.Columns["TotalTaskAssign"].Width = 280;
            departmentData.Columns["PendingTask"].Width = 270;
            departmentData.Columns["TaskDone"].Width = 270;
        }

        private void projectNameTotalBudgetandPaidBudget_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departmentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void trackProgress_Click(object sender, EventArgs e)
        {
            overAllProgress overAllProgress = new overAllProgress();
            overAllProgress.FormClosed += (s, arg) => this.Close();
            overAllProgress.Show();
            this.Hide();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            resetPassword_2 resetPassword_2 = new resetPassword_2();
            resetPassword_2.FormClosed += (s, arg) => this.Close();
            resetPassword_2.Show();
            this.Hide();
        }
    }
}
