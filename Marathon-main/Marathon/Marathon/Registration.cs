using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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
            Loads();
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
        private void Loads()
        {
            try
            {
                Connection.connection.Open();
                string slqSel = "select [CountryName] from [dbo].[Country] order by CountryName asc";
                SqlCommand cmd = new SqlCommand(slqSel, Connection.connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader[0]);
                    }
                }
                reader.Close();
                string slqSel1 = "select Gender from Gender";
                SqlCommand cmd1 = new SqlCommand(slqSel1, Connection.connection);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read()) 
                    {
                        comboBox1.Items.Add(reader1[0]);
                    }
                }
                reader1.Close();
                Connection.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Выбор фото
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp; *.png; *.jpg)|*.bmp;*.jpg;*.png|All files (*_*)| *_*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    textBox6.Text = string.Format($"(ofd.FileName)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите пароль";
                textBox2.PasswordChar = '*';
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Введите пароль";
                textBox4.PasswordChar = '*';
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите пароль")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Введите пароль")
            {
                textBox4.Text = "";
                textBox4.PasswordChar = '*';
            }
        }
    }
}
