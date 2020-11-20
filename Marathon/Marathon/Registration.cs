using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class Registration : Form
    {
        public Registration()
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
        }

        private void Registration_Load(object sender, EventArgs e)
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




    }
}
