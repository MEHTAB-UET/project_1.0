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
    }
}
