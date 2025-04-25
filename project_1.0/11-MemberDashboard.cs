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
    public partial class _11_MemberDashboard : Form
    {
        private Member loggedInMember;
        public _11_MemberDashboard(Member member)
        {
            InitializeComponent();
            loggedInMember = member;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
