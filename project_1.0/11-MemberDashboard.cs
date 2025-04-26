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




        private void _11_MemberDashboard_Load(object sender, EventArgs e)
        {

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
