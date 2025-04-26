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
    public partial class overAllProgress : Form
    {
        public overAllProgress()
        {
            InitializeComponent();
            pictureBox2.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void viewDepartments_Click(object sender, EventArgs e)
        {
            managerDashboard managerDashboard = new managerDashboard();
            managerDashboard.FormClosed += (s, arg) => this.Close();
            managerDashboard.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            managerDashboard managerDashboard = new managerDashboard();
            managerDashboard.FormClosed += (s, arg) => this.Close();
            managerDashboard.Show();
            this.Hide();

        }

        private void activeProjectsLabel_Click(object sender, EventArgs e)
        {

        }

        private void activeClientsLabel_Click(object sender, EventArgs e)
        {

        }

        private void noOfEmployeesLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void taskInProgressLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalTaskCompletedLabel_Click(object sender, EventArgs e)
        {

        }

        private void reciveablePayment_Click(object sender, EventArgs e)
        {

        }

        private void paymentRecivedLabel_Click(object sender, EventArgs e)
        {

        }

        private void overAllProgress_Load(object sender, EventArgs e)
        {
            int activeProjects = 0, activeClients = 0, noOfEmployees = 0, totalTasks = 0, tasksInProgress = 0, tasksCompleted = 0;
            double totalBudget = 0, paidBudget = 0;
            HashSet<string> clients = new HashSet<string>();

            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();

                // Projects
                var cmd1 = new MySql.Data.MySqlClient.MySqlCommand("SELECT clientName, totalBudget, paidBudget FROM projects", conn);
                var reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    activeProjects++;
                    clients.Add(reader1.GetString("clientName"));
                    totalBudget += reader1.IsDBNull(reader1.GetOrdinal("totalBudget")) ? 0 : reader1.GetDouble("totalBudget");
                    paidBudget += reader1.IsDBNull(reader1.GetOrdinal("paidBudget")) ? 0 : reader1.GetDouble("paidBudget");
                }
                reader1.Close();

                // Members
                var cmd2 = new MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) FROM members", conn);
                noOfEmployees = Convert.ToInt32(cmd2.ExecuteScalar());

                // Tasks
                var cmd3 = new MySql.Data.MySqlClient.MySqlCommand("SELECT state FROM assigntask", conn);
                var reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    totalTasks++;
                    string state = reader3.GetString("state");
                    if (state == "InProgress") tasksInProgress++;
                    else if (state == "Completed") tasksCompleted++;
                }
                reader3.Close();
            }

            activeProjectsLabel.Text = activeProjects.ToString();
            activeClientsLabel.Text = clients.Count.ToString();
            noOfEmployeesLabel.Text = noOfEmployees.ToString();
            totalTaskLabel.Text = totalTasks.ToString();
            taskInProgressLabel.Text = tasksInProgress.ToString();
            totalTaskCompletedLabel.Text = tasksCompleted.ToString();
            reciveablePayment.Text = totalBudget.ToString("F2") + " USD";
            paymentRecivedLabel.Text = paidBudget.ToString("F2") + " USD";
        }

    }
}
