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
using System.Security.Cryptography;

namespace StoreMS
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");

        public Login()
        {
            InitializeComponent();
        }

        private void login()
        {
            string retrievedPassword = "Not assigned";

            if (Uname.Text == "" || Pwd.Text == "")
            {
                MessageBox.Show("Enter valid Username or Password");
            }
            else
            {

                if (RoleDrop.SelectedItem.ToString() == "Admin")
                {
                    if (Uname.Text == "admin")
                    {
                        try
                        {
                            if (con.State != ConnectionState.Open)
                            {
                                con.Open();
                            }

                            // get the psw from db
                            MySqlCommand command = con.CreateCommand();
                            command.CommandText = "select Pwd from adminpwd";
                            MySqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                retrievedPassword = reader.GetString(0);
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }

                        if (retrievedPassword == "admin" || retrievedPassword == hashPassword())
                        {
                            Sales sale = new Sales();
                            this.Hide();
                            sale.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Type, User Name or Password");
                            RoleDrop.Text = "";
                            Uname.Text = "";
                            Pwd.Text = "";
                        }

                    }
                }
                else if (RoleDrop.SelectedItem.ToString() == "Employee")
                {
                    if (Uname.Text == "user" && Pwd.Text == "user")
                    {
                        Emp emp = new Emp();
                        emp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Type, User Name or Password");
                        clearValues();
                    }
                }
                else
                {
                    MessageBox.Show("Please select your role.");
                }
            }
        }

        private string hashPassword()
        {
            String inputAdminPassword = Pwd.Text.ToString();

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] passwordByte = Encoding.ASCII.GetBytes(inputAdminPassword);
            byte[] encryptedByte = sha1.ComputeHash(passwordByte);

            return Convert.ToBase64String(encryptedByte);
        }

        private void clearValues()
        {
            RoleDrop.Text = "";
            Uname.Text = "";
            Pwd.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             uiPropertise();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CatDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Uname_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void uiPropertise()
        {
            Uname.Multiline = true;
            Uname.MinimumSize = new Size(260, 25);
            Uname.Size = new Size(260, 25);
            Uname.Multiline = false;

            Pwd.Multiline = true;
            Pwd.MinimumSize = new Size(260, 25);
            Pwd.Size = new Size(260, 25);
            Pwd.Multiline = false;


        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
