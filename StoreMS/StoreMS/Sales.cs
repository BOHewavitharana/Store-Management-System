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
    public partial class Sales : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");

        public Sales()
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

            MySqlCommand cmd = new MySqlCommand("SELECT ProdName FROM ProductTbl WHERE ProdCat='" + categoryComboBox.SelectedValue.ToString() + "'", con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProdName", typeof(string));
            dt.Load(rdr);
            productComboBox.ValueMember = "ProdName";
            productComboBox.DataSource = dt;

            con.Close();
        }

        private void filterByProduct()
        {
            string prodID = "Not assigned";

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // getting prod ID
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "select ProdID from ProductTbl where ProdName='" + productComboBox.SelectedValue.ToString() + "'";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    prodID = reader.GetString(0);
                }
                reader.Close();

                // displaying in data grid view
                string query = "select dateOfSale as Date_of_Sale, qty as Quantity, total as Total from sales where prodID = '" + prodID + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salesDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void filterByMonth()
        {
            // getting the month
            DateTime selectedMonth = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("dd-MMM-yy hh:mm:ss"));
            string Trimmedmonth = selectedMonth.ToString("MMM-yy");

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // displaying in data grid view
                string query = "select sales.dateOfSale as Date_of_Sale, ProductTbl.ProdName as Product, sales.qty as Quantity, sales.total as Total from ProductTbl, sales where dateOfSale LIKE '%" + Trimmedmonth + "%'  AND ProductTbl.ProdID = sales.prodID;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                salesDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            fillCategoryDrop();
            buttonpanel.Height = salesButton.Height;
            buttonpanel.Top = salesButton.Top;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            this.Hide();
            p.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillProductDrop();
        }

        private void productComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByProduct();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            filterByMonth();
        }

        private void monthLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            MngEmp mngemp = new MngEmp();
            this.Hide();
            mngemp.Show();
        }

        private void suppliersButton_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            this.Hide();
            s.Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            this.Hide();
            prod.Show();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangeAdminPassword cap = new ChangeAdminPassword();
            this.Hide();
            cap.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
