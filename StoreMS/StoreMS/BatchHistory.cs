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
    public partial class BatchHistory : Form
    {
        public string prodID = "Not assigned";

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");

        public BatchHistory()
        {
            InitializeComponent();
        }

        public void fillCategoryDrop()
        {
            try
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

        public void fillProductDrop()
        {
            try
            {
                if(con.State != ConnectionState.Open)
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

        public void fillCompanyDrop()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                MySqlCommand cmd = new MySqlCommand("select distinct supplier.company from product_batch, supplier where prodID = '"+prodID+"' AND product_batch.supID = supplier.supID", con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("company", typeof(string));
                dt.Load(rdr);
                companyComboBox.ValueMember = "company";
                companyComboBox.DataSource = dt;
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

        private void viewBatchHistory()
        {
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

                // displaying in data grid view
                string query = "select product_batch.dateOfArrival as Date_of_Arrival, product_batch.qty as Units, supplier.company as Supplier from product_batch, supplier where prodID = '" + prodID + "' AND product_batch.supID = supplier.supID";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                BatchDataGridView.DataSource = dt;
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

        private void filterByCompany()
        {
            string supID = "Not assigned";

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // getting supplier ID
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "select supID from supplier where company='" + companyComboBox.SelectedValue.ToString() + "'";
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    supID = reader.GetString(0);
                }
                reader.Close();

                // displaying in data grid view
                string query = "select dateOfArrival as Date_of_Arrival, qty as Units from product_batch where prodID = '" + prodID + "' AND supID='"+supID+"'";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                BatchDataGridView.DataSource = dt;
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

            
            try {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // displaying in data grid view
                string query = "select product_batch.dateOfArrival as Date_Of_Arrival, product_batch.qty as Units from product_batch where prodID = '"+prodID+"' AND dateOfArrival LIKE '%"+Trimmedmonth+"%'";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                BatchDataGridView.DataSource = dt;
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


        // events
        private void BatchHistory_Load(object sender, EventArgs e)
        {
            fillCategoryDrop();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            this.Hide();
            p.Show();
        }

        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillProductDrop();
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewBatchHistory();
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterByCompany();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            filterByMonth();
            companyComboBox.Text = "";
        }

        private void filterLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void companyComboBox_Click(object sender, EventArgs e)
        {
            fillCompanyDrop();
        }
    }
}
