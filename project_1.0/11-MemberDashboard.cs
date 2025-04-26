using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace project_1._0
{
    public partial class _11_MemberDashboard : Form
    {
        private Member loggedInMember;
        string mail;
        public _11_MemberDashboard(Member member)
        {
            InitializeComponent();
            loggedInMember = member;
            mail = member.Email;
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


            string imgPath = member.ImgPath;
            string Cn = member.CNIC;
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                pictureBox1.Image = Image.FromFile(imgPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {


                MessageBox.Show("Profile picture not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(imgPath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        //loading data for Visualizaion 
        private void LoadTaskStats()
        {
            string connStr = "server=localhost;user=root;database=WorkZen;port=3306;password=Mehtab2046;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // Query to get task status counts
                string taskStatusQuery = @"
            SELECT 
                COUNT(*) AS totalTasks,
                SUM(CASE WHEN state = 'Pending' THEN 1 ELSE 0 END) AS pendingTasks,
                SUM(CASE WHEN state = 'InProgress' THEN 1 ELSE 0 END) AS inProgressTasks,
                SUM(CASE WHEN state = 'Completed' THEN 1 ELSE 0 END) AS completedTasks
            FROM assigntask
            WHERE toEmployee = @memberEmail;
        ";

                // Query to get task counts per project
                string taskProjectQuery = @"
            SELECT relatedToProject, COUNT(*) AS projectTasks
            FROM assigntask
            WHERE toEmployee = @memberEmail
            GROUP BY relatedToProject;
        ";

                // Fetching the task status counts
                MySqlCommand cmdStatus = new MySqlCommand(taskStatusQuery, conn);
                cmdStatus.Parameters.AddWithValue("@memberEmail", loggedInMember.FullName);

                using (MySqlDataReader reader = cmdStatus.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int totalTasks = reader.GetInt32("totalTasks");
                        int pendingTasks = reader.GetInt32("pendingTasks");
                        int inProgressTasks = reader.GetInt32("inProgressTasks");
                        int completedTasks = reader.GetInt32("completedTasks");

                        // Create Pie Chart
                        Chart pieChart = new Chart();
                        pieChart.Size = new Size(650, 550);
                        pieChart.Location = new Point(550, 350);

                        ChartArea chartArea = new ChartArea();
                        pieChart.ChartAreas.Add(chartArea);

                        Series series = new Series
                        {
                            Name = "TaskStatus",
                            ChartType = SeriesChartType.Pie
                        };

                        // Add ALL statuses
                        series.Points.AddXY("Pending", pendingTasks);
                        series.Points.AddXY("In Progress", inProgressTasks);
                        series.Points.AddXY("Completed", completedTasks);

                        pieChart.Series.Add(series);

                        // Label and Legend
                        series.Label = "#PERCENT{P0}";
                        series.LegendText = "#VALX";

                        Legend legend = new Legend();
                        pieChart.Legends.Add(legend);

                        this.Controls.Add(pieChart);
                    }
                }

                // Fetching the task counts per project
                MySqlCommand cmdProject = new MySqlCommand(taskProjectQuery, conn);
                cmdProject.Parameters.AddWithValue("@memberEmail", loggedInMember.FullName);

                using (MySqlDataReader reader = cmdProject.ExecuteReader())
                {
                    // Create Bar Chart for project task counts
                    Chart barChart = new Chart();
                    barChart.Size = new Size(650, 550);
                    barChart.Location = new Point(1200, 350);

                    ChartArea chartArea = new ChartArea();
                    barChart.ChartAreas.Add(chartArea);

                    Series series = new Series
                    {
                        Name = "ProjectTasks",
                        ChartType = SeriesChartType.Pie 
                    };

                    while (reader.Read())
                    {
                        string projectName = reader.GetString("relatedToProject");
                        int projectTasks = reader.GetInt32("projectTasks");

                        // Add data to the bar chart
                        series.Points.AddXY(projectName, projectTasks);
                    }

                    barChart.Series.Add(series);

                    // Label and Legend
                    barChart.Titles.Add("Tasks per Project");
                    this.Controls.Add(barChart);
                }
            }
        }


        private void _11_MemberDashboard_Load(object sender, EventArgs e)
        {
            LoadTaskStats();
        }

        private void viewProfileBtn_Click(object sender, EventArgs e)
        {

            ViewEmployeeProfile profilePage = new ViewEmployeeProfile(loggedInMember);
            profilePage.FormClosed += (s, arg) => this.Close();
            profilePage.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        //this button name is ViewAssign task its by mistake appear "createNewProject" at this poitnt
        private void createNewProject_Click(object sender, EventArgs e)
        {
            ViewAssignTask viewAssignTask = new ViewAssignTask(loggedInMember);
            viewAssignTask.FormClosed += (s, arg) => this.Close();
            viewAssignTask.Show();
            this.Hide();

        }

        private void viewDepartments_Click(object sender, EventArgs e)
        {
            _10MemberResetPassword resetPassword = new _10MemberResetPassword(mail);
            resetPassword.FormClosed += (s, arg) => this.Close();
            resetPassword.Show();
            this.Hide();
        }

        private void updateTaskState_Click(object sender, EventArgs e)
        {
            updateTaskStatus updateTaskStatus = new updateTaskStatus(loggedInMember);
            updateTaskStatus.FormClosed += (s, arg) => this.Close();
            updateTaskStatus.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.FormClosed += (s, arg) => this.Close();
            newForm.Show();
            this.Hide();
        }

        private void progressRoute_Click(object sender, EventArgs e)
        {
            employeeProgress progressReport = new employeeProgress(loggedInMember);
            progressReport.FormClosed += (s, arg) => this.Close();
            progressReport.Show();
            this.Hide();
        }
    }
}
