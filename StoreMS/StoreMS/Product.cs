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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            CatDrop.ValueMember = "CatName";
            CatDrop.DataSource = dt;

            con.Close();
        }

        private void viewProduct()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "select ProdID as ID, ProdName as Name, ProdQty as Available_Quantity, ProdCat as Category, Price from ProductTbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdTbl.DataSource = ds.Tables[0];
            con.Close();
        }

        private void addProduct()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "insert into ProductTbl (ProdID, ProdName, ProdQty, ProdCat, Price) values('" + ProdID.Text + "','" + ProdName.Text + "', 0, '"+ CatDrop.SelectedValue.ToString()+ "', " + ProdPrice.Text + ")";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Succsessfully!!");
                con.Close();
                viewProduct();
                ProdID.Text = "";
                ProdName.Text = "";
                CatDrop.Text = "";
                ProdPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateProduct()
        {
            try
            {
                if (ProdName.Text == "" || ProdID.Text == "")
                {
                    MessageBox.Show("Information Not Selected");
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    String query = "update ProductTbl set ProdName= '" + ProdName.Text + "', ProdCat= '" + CatDrop.Text + "', Price= " + ProdPrice.Text + " where ProdID = '" + ProdID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    con.Close();
                    viewProduct();
                    ProdID.Text = "";
                    ProdName.Text = "";
                    CatDrop.Text = "";
                    ProdPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteProduct()
        {
            try
            {
                if (ProdID.Text == "")
                {
                    MessageBox.Show("Select the category");
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    string query = "delete from ProductTbl where ProdID='" + ProdID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Sucessfully!!");
                    con.Close();
                    viewProduct();
                    ProdID.Text = "";
                    ProdName.Text = "";
                    CatDrop.Text = "";
                    ProdPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            fillDropCategory();
            viewProduct();
            buttonpanel.Height = button2.Height;
            buttonpanel.Top = button2.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MngEmp emp = new MngEmp();
            this.Hide();
            emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            this.Hide();
            sup.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        private void ProdTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdID.Text = ProdTbl.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdTbl.SelectedRows[0].Cells[1].Value.ToString();
            //ProdQ.Text = ProdTbl.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdTbl.SelectedRows[0].Cells[4].Value.ToString();
            CatDrop.Text = ProdTbl.SelectedRows[0].Cells[3].Value.ToString();
            //supplierDrop.Text = ProdTbl.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateProduct();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void newBatchButton_Click(object sender, EventArgs e)
        {
            Batch nb = new Batch();
            this.Hide();
            nb.Show();
        }

        private void viewHistoryButton_Click(object sender, EventArgs e)
        {
            BatchHistory bh = new BatchHistory();
            this.Hide();
            bh.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            this.Hide();
            s.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void supplierDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangeAdminPassword cap = new ChangeAdminPassword();
            this.Hide();
            cap.Show();
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
