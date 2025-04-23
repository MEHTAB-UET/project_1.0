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
    public partial class createNewProject : Form
    {
        public createNewProject()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits image to box
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backToDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            managerDashboard managerDashboard = new managerDashboard();
            managerDashboard.FormClosed += (s, arg) => this.Close();
            managerDashboard.ShowDialog();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            managerDashboard managerDashboard = new managerDashboard();
            managerDashboard.FormClosed += (s, arg) => this.Close();
            managerDashboard.ShowDialog();
            this.Hide();
        }

        private void projectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void deadlineOfProject_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addNewProject_Click(object sender, EventArgs e)
        {
            string projectNamee = projectName.Text.Trim();
            string clientNamee = ClientName.Text.Trim();
            string description = ProjectDescription.Text.Trim();
            string deadline = deadlineOfProject.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(projectNamee) || string.IsNullOrEmpty(clientNamee) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                MySqlConnection conn = dbConnection.GetConnection();
                conn.Open();

                string query = "INSERT INTO Projects (projectName, clientName, description, deadline) VALUES (@pName, @cName, @desc, @deadline)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pName", projectNamee);
                cmd.Parameters.AddWithValue("@cName", clientNamee);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.Parameters.AddWithValue("@deadline", deadline);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Project added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }


        }
    }
}
