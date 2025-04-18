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
            termsForm.ShowDialog();
            this.Hide();
        }
    }
}
