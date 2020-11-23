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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
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

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            DateTime datetime1 = new DateTime(2020, 12, 11);
            TimeSpan datetime2 = datetime1 - datetime;
            label1.Text = String.Format($"WORLD SKILLS {datetime.Year}");
            label3.Text = String.Format($"{datetime2.Days} days {datetime2.Hours} hours {datetime2.Minutes} minutes {datetime2.Seconds} seconds");
        }
    }
}
