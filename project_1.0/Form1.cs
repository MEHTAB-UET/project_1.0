using Microsoft.VisualBasic.Logging;

namespace project_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\1_UNIVERSITY\\4th Semester\\Semesters Prjects\\SDA\\logo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // optional: fits image to box

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void termAndCondition_Click(object sender, EventArgs e)
        {
            TermsAndConditions termsForm = new TermsAndConditions();
            termsForm.FormClosed += (s, args) => this.Close();
            termsForm.Show();
            this.Hide();
        }

        private void loginAsManager_Click(object sender, EventArgs e)
        {
            //ManagerLogin.cs
            ManagerLogin log_in = new ManagerLogin();
            log_in.FormClosed += (s, args) => this.Close();
            log_in.Show();
            this.Hide();

        }

        private void loginAsMember_Click(object sender, EventArgs e)
        {
            teamLogin teamLogin = new teamLogin();
            teamLogin.FormClosed += (s, args) => this.Close();
            teamLogin.Show();
            this.Hide();
        }
    }
}
