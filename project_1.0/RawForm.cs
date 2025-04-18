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
    public partial class RawForm : Form
    {
        public RawForm()
        {
            InitializeComponent();
        }

        private void sqlConnector_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=SDA_SEMESTER_PROJECT;port=3306;password=Mehtab2046;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MessageBox.Show("Connection successful!");
                // Your DB operations here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
