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
    }
}
