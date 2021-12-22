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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");
        
        private void addCategory()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string query = "insert into category values('" + CatIDTb.Text + "','" + CatNameTb.Text + "','" + CatDiscTb.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Succsessfully!!");
                con.Close();
                viewCategory();
                CatIDTb.Text = "";
                CatNameTb.Text = "";
                CatDiscTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addCategory();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewCategory()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "select CatID as ID, CatName Name, CatDis Description from category";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatTbl.DataSource = ds.Tables[0];
            con.Close();
        }

        private void deleteCategory()
        {
            try
            {
                if (CatIDTb.Text == "")
                {
                    MessageBox.Show("Select the category");
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    string query = "delete from category where CatID='" + CatIDTb.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Sucessfully!!");
                    con.Close();
                    viewCategory();
                    CatIDTb.Text = "";
                    CatNameTb.Text = "";
                    CatDiscTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateCategory()
        {
            try
            {
                if (CatIDTb.Text == "" || CatNameTb.Text == "")
                {
                    MessageBox.Show("Information Not Selected");
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    String query = "update category set CatName='" + CatNameTb.Text + "', CatDis='" + CatDiscTb.Text + "' where CatID='" + CatIDTb.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Succsesfully");
                    con.Close();
                    viewCategory();
                    CatIDTb.Text = "";
                    CatNameTb.Text = "";
                    CatDiscTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            viewCategory();
            buttonpanel.Height = button3.Height;
            buttonpanel.Top = button3.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MngEmp emp = new MngEmp();
            this.Hide();
            emp.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            this.Hide();
            pro.Show();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            this.Hide();
            sup.Show();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deleteCategory();
        }

        private void CatTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIDTb.Text = CatTbl.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatTbl.SelectedRows[0].Cells[1].Value.ToString();
            CatDiscTb.Text = CatTbl.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateCategory();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            this.Hide();
            s.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangeAdminPassword cap = new ChangeAdminPassword();
            this.Hide();
            cap.Show();
        }
    }
}
