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
    public partial class ChangeAdminPassword : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");

        public ChangeAdminPassword()
        {
            InitializeComponent();
        }

        private Boolean validateCurrentPassword()
        {
            // encrypting user input password
            string inputPassword = currentPasswordTxtbox.Text.ToString();
            string inputHashedPasswword = "admin";

            if (inputPassword != "admin")
            {
                inputHashedPasswword = hashPassword(inputPassword);
            }
            
            string retrievedPassword = "empty";
            Boolean validity = false;

            // getting current password from db
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

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

            if(inputHashedPasswword == retrievedPassword)
            {
                validity = true;
            }

            return validity;
        }

        private string hashPassword(string currentPassword)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] passwordByte = Encoding.ASCII.GetBytes(currentPassword);
            byte[] encryptedByte = sha1.ComputeHash(passwordByte);

            return Convert.ToBase64String(encryptedByte);
        }

        private void updatePassword()
        {
            string newPassword = newPasswordTxtBox.Text;
            string newHashedPassword = hashPassword(newPassword);

            // updating password in db
            try
            {
                if(con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                String query = "update adminpwd set Pwd='" + newHashedPassword + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You password has been updated succsesfully! Please login again.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ChangeAdminPassword_Load(object sender, EventArgs e)
        {
            currentPasswordTxtbox.UseSystemPasswordChar = true;
            newPasswordTxtBox.UseSystemPasswordChar = true;
            retypePasswordTxtBox.UseSystemPasswordChar = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(!validateCurrentPassword())
            {
                MessageBox.Show("Your current password is incorrect.");
            }
            else
            {
                MessageBox.Show("Click OK to enter a new password.");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if(newPasswordTxtBox.Text == retypePasswordTxtBox.Text) {
                
                updatePassword();

                Login log = new Login();
                this.Hide();
                log.Show();
            }
            
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MngEmp me = new MngEmp();
            this.Hide();
            me.Show();
        }

        private void newPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void currentPasswordTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
