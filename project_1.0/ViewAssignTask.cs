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
    public partial class ViewAssignTask : Form
    {
        private Member loggedInMember;
        string FullName;
        public ViewAssignTask(Member loggedInMember)
        {
            InitializeComponent();
            FullName = loggedInMember.FullName;
            LoadAssignedTasks(FullName);



            pictureBox2.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.loggedInMember = loggedInMember;
            string imgPath = loggedInMember.ImgPath;

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


        //loading data 
        private void LoadAssignedTasks(string FullName)
        {
            try
            {
                MySqlConnection conn = dbConnection.GetConnection(); // Your DB connection method
                conn.Open();

                string query = "SELECT TaskTitle, TaskDescription, startDate, dueDate, priority, relatedToProject , state FROM assigntask WHERE toEmployee = @toEmployee";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@toEmployee", FullName);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                viewAssignedTaskData.DataSource = dt;
                viewAssignedTaskData.Columns["TaskTitle"].Width = 250;
                viewAssignedTaskData.Columns["TaskDescription"].Width = 450;
                viewAssignedTaskData.Columns["startDate"].Width = 200;
                viewAssignedTaskData.Columns["dueDate"].Width = 200;
                viewAssignedTaskData.Columns["priority"].Width = 200;
                viewAssignedTaskData.Columns["relatedToProject"].Width = 250;
                viewAssignedTaskData.Columns["state"].Width = 200;
                viewAssignedTaskData.RowTemplate.Height = 80;


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void viewAssignedTaskData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void done_Click(object sender, EventArgs e)
        {
            _11_MemberDashboard dashboard = new _11_MemberDashboard(loggedInMember);
            dashboard.FormClosed += (s, arg) => this.Close();
            dashboard.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.FormClosed += (s, arg) => this.Close();
            loginForm.Show();
            this.Hide();
        }
    }
}
