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
using System.Data.SqlClient;

namespace Marathon
{
    public partial class Login : Form
    {
        public Login()
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

        private void Login_Load(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "select [Email], [Password],[RoleId] from [dbo].[User] where [Email]=@login";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);
                cmd.Parameters.AddWithValue("@login", textBox_email.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    if ((string)reader[1] == textBox_password.Text)
                    {
                        Connection.userLogin = textBox_email.Text;

                        switch ((string)reader[2])
                        {
                            case "R":
                                RunnerMenu mr = new RunnerMenu();
                                mr.Show();
                                this.Close();
                                break;

                            case "C":
                                CoordinatorMenu mc = new CoordinatorMenu();
                                mc.Show();
                                this.Close();
                                break;

                            case "A":
                                AdminMenu ma = new AdminMenu();
                                ma.Show();
                                this.Close();
                                break;

                            default:
                                MessageBox.Show("Нет такой роли");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин");
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.connection.Close();
        }
                    }
                }
            
        
    

