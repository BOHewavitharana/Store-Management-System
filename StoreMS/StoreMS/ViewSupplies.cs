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
    public partial class ViewSupplies : Form
    {
        string selectedSupplierID = "none";
        string selectedCompany = "none";

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");


        // parameterized constructor
        public ViewSupplies(string selectedSupplierID, string selectedCompany)
        {
            InitializeComponent();
            this.selectedSupplierID = selectedSupplierID;
            this.selectedCompany = selectedCompany;
        }

        private void viewSupplies()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string query = "SELECT DISTINCT producttbl.ProdCat, producttbl.ProdName, producttbl.Price FROM product_batch, producttbl WHERE supID = '"+selectedSupplierID+ "' AND producttbl.ProdID = product_batch.prodID;";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                SuppliesDataGridView.DataSource = ds.Tables[0];
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


        private void ViewSupplies_Load(object sender, EventArgs e)
        {
            companyLabel.Text = selectedCompany;
            viewSupplies();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            this.Hide();
            s.Show();
        }

        private void SuppliesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void companyLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
