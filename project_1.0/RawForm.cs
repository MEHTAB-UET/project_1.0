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
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace project_1._0
{
    public partial class RawForm : Form
    {
        public RawForm()
        {
            InitializeComponent();
            InitializeChart();
        }

        private Chart pieChart;

        private void InitializeChart()
        {
            pieChart = new Chart();
            pieChart.Dock = DockStyle.Bottom;
            pieChart.Height = 300;

            ChartArea chartArea = new ChartArea();
            pieChart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Tasks",
                ChartType = SeriesChartType.Pie
            };

            series.Points.AddXY("Completed", 10);
            series.Points.AddXY("In Progress", 5);
            series.Points.AddXY("Pending", 3);

            pieChart.Series.Add(series);

            pieChart.Legends.Add(new Legend("Legend"));

            this.Controls.Add(pieChart);
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


        private void SendWelcomeEmail(string toEmail, string username)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("mehtabatkips@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = "Welcome to WorkZen!";
                mail.Body = $"Hi {username},\n\nYour account has been created successfully.\n\nThanks,\nWorkZen Team";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("mehtabatkips@gmail.com", "zxgu snig wass wyjm"); // App password
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email failed: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string email = "mehtabatkips@gmail.com"; // or from a TextBox: txtEmail.Text
            string username = "Mehtab";            // or from a TextBox: txtUsername.Text

            SendWelcomeEmail(email, username);

        }

        private void RawForm_Load(object sender, EventArgs e)
        {

        }
    }
}
