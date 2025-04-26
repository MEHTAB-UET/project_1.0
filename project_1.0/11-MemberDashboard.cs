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
        public _11_MemberDashboard(Member member)
        {
            InitializeComponent();
            loggedInMember = member;
            this.WindowState = FormWindowState.Maximized;


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
    }
}
