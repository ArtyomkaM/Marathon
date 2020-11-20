using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Marathon
{
    public partial class Runner : Form
    {
        public Runner()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DateTime datetime1 = new DateTime(2020, 12, 11);
            TimeSpan datetime2 = datetime1 - datetime;
            label1.Text = String.Format($"WORLD SKILLS {datetime.Year}");
            label3.Text = String.Format($"{datetime2.Days} days {datetime2.Hours} hours {datetime2.Minutes} minutes {datetime2.Seconds} seconds");
            //label4.Text = String.Format($"{datetime.DayOfWeek} {datetime.Day} {datetime.Month} {datetime.Year} ");
            DateTime dateTime = DateTime.Now;
            String strMonthname = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(datetime.Month);
            String strMonthname2 = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(datetime.DayOfWeek);
            label4.Text = String.Format($"{strMonthname2} {datetime.Day} {strMonthname} {datetime.Year} ");
        }

        private void Runner_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            DialogResult result = menu.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
             Registration registration = new Registration();
            DialogResult result = registration.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
