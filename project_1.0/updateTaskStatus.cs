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
    public partial class updateTaskStatus : Form
    {
        private Member loggedInMember;

        public updateTaskStatus(Member member)
        {
            InitializeComponent();
            loggedInMember = member;
           
            pictureBox2.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;




            //loading data assignTask from db to show in our combo box
            taskCombo.Items.Clear();
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT TaskTitle FROM assigntask WHERE toEmployee = @toEmployee", conn);
                cmd.Parameters.AddWithValue("@toEmployee", loggedInMember.FullName);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    taskCombo.Items.Add(reader.GetString(0));
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            _11_MemberDashboard dashboard = new _11_MemberDashboard(loggedInMember);
            dashboard.FormClosed += (s, arg) => this.Close();
            dashboard.Show();
            this.Hide();

        }

        private void taskCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        //this is setState button 
        //its name viewDepartment is by mistake 
        private void viewDepartments_Click(object sender, EventArgs e)
        {
            string selectedTask = taskCombo.SelectedItem?.ToString();
            string selectedState = stateCombo.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedTask) && !string.IsNullOrEmpty(selectedState))
            {
                using (var conn = dbConnection.GetConnection())
                {
                    conn.Open();

                    // Update the task state
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand("UPDATE assigntask SET state = @state WHERE TaskTitle = @taskTitle", conn);
                    cmd.Parameters.AddWithValue("@state", selectedState);
                    cmd.Parameters.AddWithValue("@taskTitle", selectedTask);
                    cmd.ExecuteNonQuery();

                    // If completed, update department stats
                    if (selectedState == "Completed")
                    {
                        var deptCmd = new MySql.Data.MySqlClient.MySqlCommand(
                            "UPDATE department SET pending_task = pending_task - 1, task_done = task_done + 1 WHERE name = @deptName", conn);
                        deptCmd.Parameters.AddWithValue("@deptName", loggedInMember.Department);
                        deptCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Task state updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select both Task and State.");
            }
        }


    }
}
