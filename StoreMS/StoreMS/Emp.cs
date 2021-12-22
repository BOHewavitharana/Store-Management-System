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
    public partial class Emp : Form
    {
        string prodID = "Unassigned";
        int quantity = 0;
        int total = 0;
        int n = 0;
        int GTot = 0;

        public Emp()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");

        public void addSale()
        {
            DateTime now = DateTime.Now;
            string dateOfSale = now.ToString("dd-MMM-yy hh:mm:ss");

            total = Convert.ToInt32(PPrice.Text) * Convert.ToInt32(PQty.Text);
            DataGridViewRow nr = new DataGridViewRow();
            nr.CreateCells(BillGv);
            nr.Cells[0].Value = n + 1;   // num
            nr.Cells[1].Value = PName.Text;  // item
            nr.Cells[2].Value = PPrice.Text;  // price
            nr.Cells[3].Value = PQty.Text;  // qty
            quantity = Convert.ToInt32(nr.Cells[3].Value);
            nr.Cells[4].Value = Convert.ToInt32(PPrice.Text) * Convert.ToInt32(PQty.Text);  // total
            BillGv.Rows.Add(nr);
            GTot = GTot + total;
            GTotLb.Text = GTot.ToString() + ".00";
            PName.Text = "";
            PPrice.Text = "";
            PQty.Text = "";
            n++;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // getting the product ID
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "select ProdID from producttbl where ProdName='" + nr.Cells[1].Value + "'";
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    prodID = reader.GetString(0);
                }
                reader.Close();

                // deducting product quantity
                int currentQty = 0;

                MySqlCommand command1 = con.CreateCommand();
                command1.CommandText = "select ProdQty from producttbl where ProdID='" + prodID + "'";
                MySqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.Read())
                {
                    currentQty = reader1.GetInt32(0);
                }
                reader1.Close();

                int newQty = currentQty - quantity;

                String query = "UPDATE producttbl SET ProdQty= '" + newQty + "' WHERE ProdID='"+ prodID + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                // adding sale to db 
                string query1 = "insert into sales(dateOfSale, count, ProdID, qty, total) values('"+dateOfSale+"', " + n + ",'" + prodID + "'," + quantity + ", " + total + ")";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewProducts()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string query = "select ProdName as Product, Price from producttbl where ProdCat='" + categoryDrop.SelectedValue.ToString() + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProdGv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || PQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                addSale();
            }
                
        }

        public void fillDropCategory()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            // fill  category drop
            MySqlCommand cmd = new MySqlCommand("select CatName from category", con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            categoryDrop.ValueMember = "CatName";
            categoryDrop.ValueMember = "CatName";
            categoryDrop.DataSource = dt;

            con.Close();
        }

        private void Emp_Load(object sender, EventArgs e)
        {
            Datelb.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            fillDropCategory();
            viewProducts();
            uiPropertise();
        }

        private void ProdGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PName.Text = ProdGv.SelectedRows[0].Cells[0].Value.ToString();
            PPrice.Text = ProdGv.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            viewProducts();
        }

        private void BillGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Sale added successfully!");
            BillGv.Rows.Clear();
            GTotLb.Text = "";
            n = 0;
        }

        private void PName_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiPropertise()
        {
            PName.Multiline = true;
            PName.MinimumSize = new Size(209, 20);
            PName.Size = new Size(209, 20);
            PName.Multiline = false;

            PPrice.Multiline = true;
            PPrice.MinimumSize = new Size(209, 20);
            PPrice.Size = new Size(209, 20);
            PPrice.Multiline = false;

            PQty.Multiline = true;
            PQty.MinimumSize = new Size(209, 20);
            PQty.Size = new Size(209, 20);
            PQty.Multiline = false;


        }
    }
}
