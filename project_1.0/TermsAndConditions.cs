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
    public partial class TermsAndConditions : Form
    {
        public TermsAndConditions()
        {
            InitializeComponent();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close();
            this.Hide();
            form1.Show();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close();
            this.Hide();
            form1.Show();


        }
    }
}
