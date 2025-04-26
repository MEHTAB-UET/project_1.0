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
    public partial class ViewEmployeeProfile : Form
    {
        private Member loggedInMember;
        public ViewEmployeeProfile(Member member)
        {
            InitializeComponent();
            loggedInMember = member;
            string imgPath = member.ImgPath;
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

        private void ViewEmployeeProfile_Load(object sender, EventArgs e)
        {
            nameLabel.Text = loggedInMember.FullName;
            EmailLabel.Text = loggedInMember.Email;
            PhoneNoLabel.Text = loggedInMember.PhoneNo;
            label5.Text = loggedInMember.CNIC; // CNIC
            departmentLabel.Text = loggedInMember.Department;
            designationLabel.Text = loggedInMember.Designation;
            dateOfJoiningLabel.Text = loggedInMember.DateOfJoining.ToShortDateString();
            payLabel.Text = loggedInMember.Pay;



        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.FormClosed += (s, arg) => this.Close();
            newForm.Show();
            this.Hide();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            _11_MemberDashboard dashboard = new _11_MemberDashboard(loggedInMember);
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void departmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void designationLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateOfJoiningLabel_Click(object sender, EventArgs e)
        {

        }

        private void payLabel_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
