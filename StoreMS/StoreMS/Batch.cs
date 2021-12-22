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

namespace StoreMS
{
    public partial class Batch : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");

        public Batch()
        {
            InitializeComponent();
        }

        public void fillCategoryDrop()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT CatName FROM category", con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            categoryComboBox.ValueMember = "CatName";
            categoryComboBox.DataSource = dt;

            con.Close();
        }

        public void fillProductDrop()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            MySqlCommand cmd = new MySqlCommand("SELECT ProdName FROM ProductTbl WHERE ProdCat='"+categoryComboBox.SelectedValue.ToString()+"'", con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProdName", typeof(string));
            dt.Load(rdr);
            productComboBox.ValueMember = "ProdName";
            productComboBox.DataSource = dt;

            con.Close();
        }

        public void fillCompanyDrop()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            MySqlCommand cmd = new MySqlCommand("select company from supplier", con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("company", typeof(string));
            dt.Load(rdr);
            companyComboBox.ValueMember = "company";
            companyComboBox.DataSource = dt;

            con.Close();
        }

        private void clearValues()
        {
            categoryComboBox.Text = "";
            productComboBox.Text = "";
            unitsTxtBox.Text = "";
            companyComboBox.Text = "";
        }
        private void addNewBatch()
        {
            string prodID = "Not assigned";
            string supID = "Not assigned";
            string dateOfArrival;
            int currentQty = 0;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // getting product ID
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "select ProdID from producttbl where ProdName='" + productComboBox.SelectedValue.ToString() + "'";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    prodID = reader.GetString(0);
                }
                reader.Close();

                // getting supplier ID
                MySqlCommand command1 = con.CreateCommand();
                command1.CommandText = "select supID from supplier where company='" + companyComboBox.SelectedValue.ToString() + "'";
                MySqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.Read())
                {
                    supID = reader1.GetString(0);
                }
                reader1.Close();

                // getting date of arrival
                DateTime now = DateTime.Now;
                dateOfArrival = now.ToString("dd-MMM-yy hh:mm:ss");

                // inserting values to product_batch table
                string query = "INSERT INTO product_batch values('" + prodID + "', '" + dateOfArrival + "','" + supID + "'," + unitsTxtBox.Text + ")";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                // updating qty in product table
                MySqlCommand command2 = con.CreateCommand();
                command2.CommandText = "select ProdQty from producttbl where ProdID='" + prodID + "'";
                MySqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read())
                {
                    currentQty = reader2.GetInt32(0);
                }
                reader2.Close();

                int newQty = currentQty + Convert.ToInt32(unitsTxtBox.Text);

                string query1 = "UPDATE producttbl SET ProdQty= '" + newQty + "' WHERE ProdID='" + prodID + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("New batch Added Successfully!!");
                clearValues();
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
        private void NewBatch_Load(object sender, EventArgs e)
        {
            fillCategoryDrop();
            fillCompanyDrop();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            this.Hide();
            p.Show();
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillProductDrop();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addNewBatch();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            this.Hide();
            p.Show();
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
