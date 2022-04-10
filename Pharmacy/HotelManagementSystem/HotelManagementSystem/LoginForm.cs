using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public partial class LoginForm : Form
    {
        DBConnect connect = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox_User_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_User.ForeColor = Color.Black;
               
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_Login.ForeColor = Color.Black;
              
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox_User_Click(object sender, EventArgs e)
        {
            textBox_User.SelectAll();
        }

        private void textBox_Login_Click(object sender, EventArgs e)
        {
            textBox_Login.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor= Color.Green;
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_User.Clear();
            textBox_Login.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Load Db

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (textBox_User.Text.Trim().Equals("") || textBox_Login.Text == "")
            {
                MessageBox.Show("Enter your username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string selectquery = "SELECT * FROM `users` WHERE `username` = @usn AND `password`=@pass";
                MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox_User.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox_Login.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);


                //if the user name and the password exists
                if (table.Rows.Count > 0)
                {
                    // Show the main form
                    this.Hide();
                    //MainForm mainForm = new MainForm();
                    //mainForm.Show();
                }
                else
                {
                    MessageBox.Show("your username and Password doen's exists", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
