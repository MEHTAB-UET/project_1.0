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
    public partial class employeeProgress : Form
    {
        private Member loggedInMember;
        public employeeProgress(Member loggedInMember)
        {
            InitializeComponent();
            pictureBox2.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.loggedInMember = loggedInMember;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewDepartments_Click(object sender, EventArgs e)
        {
            _11_MemberDashboard _11_MemberDashboard = new _11_MemberDashboard(loggedInMember);
            _11_MemberDashboard.FormClosed += (s, arg) => this.Close();
            _11_MemberDashboard.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            _11_MemberDashboard dashboard = new _11_MemberDashboard(loggedInMember);
            dashboard.FormClosed += (s, arg) => this.Close();
            dashboard.Show();
            this.Hide();

        }

        private void totalAssignTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalTaskCompleted_Click(object sender, EventArgs e)
        {

        }

        private void taskInProgress_Click(object sender, EventArgs e)
        {

        }

        private void progressPercentage_Click(object sender, EventArgs e)
        {

        }

        private void employeeProgress_Load(object sender, EventArgs e)
        {
            int totalAssigned = 0, totalCompleted = 0, totalInProgress = 0;
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand(
                    "SELECT state FROM assigntask WHERE toEmployee = @toEmployee", conn);
                cmd.Parameters.AddWithValue("@toEmployee", loggedInMember.FullName);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    totalAssigned++;
                    string state = reader.GetString("state");
                    if (state == "Completed")
                        totalCompleted++;
                    else if (state == "InProgress")
                        totalInProgress++;
                }
            }

            totalAssignTaskLabel.Text = totalAssigned.ToString();
            TotalTaskCompleted.Text = totalCompleted.ToString();
            taskInProgress.Text = totalInProgress.ToString();

            double progress = totalAssigned > 0 ?
                              (double)(totalCompleted + totalInProgress) / totalAssigned * 100 : 0;
            progressPercentage.Text = progress.ToString("F2") + "%";
        }

    }
}
