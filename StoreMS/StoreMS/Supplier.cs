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
    public partial class Supplier : Form
    {
        
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");


        public Supplier()
        {
            InitializeComponent();
        }

        public void viewSuppliers()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "SELECT supID as ID, company as Company, agent as Agent, supContact as Contact FROM supplier";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SupplierDataGridView.DataSource = dt;
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

        public void addSupplier()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "INSERT INTO supplier VALUES('" + supIDTxtbox.Text + "','" + companyTxtbox.Text + "','" + agentTxtbox.Text + "','"+ supContactTxtbox.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Supplier Added Successfully!!");
                con.Close();

                viewSuppliers();
                
                supIDTxtbox.Text = "";
                companyTxtbox.Text = "";
                agentTxtbox.Text = "";
                supContactTxtbox.Text = "";
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

        public void deleteSupplier()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "DELETE FROM supplier where supID='" + supIDTxtbox.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Removed Sucessfully!!");
                con.Close();

                viewSuppliers();

                supIDTxtbox.Text = "";
                companyTxtbox.Text = "";
                agentTxtbox.Text = "";
                supContactTxtbox.Text = "";
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

        public void updateSupplier()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                String query = "UPDATE supplier SET supID= '" + supIDTxtbox.Text + "', company= '" + companyTxtbox.Text + "', agent= '" + agentTxtbox.Text + "', supContact= '" + supContactTxtbox.Text +"' WHERE supID='"+supIDTxtbox.Text+"'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Updated Successfully");
                con.Close();

                viewSuppliers();

                supIDTxtbox.Text = "";
                companyTxtbox.Text = "";
                agentTxtbox.Text = "";
                supContactTxtbox.Text = "";
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

        // click events
        private void Supplier_Load(object sender, EventArgs e)
        {
            viewSuppliers();
            buttonpanel.Height = supplierButton.Height;
            buttonpanel.Top = supplierButton.Top;
        }

        private void addSupButton_Click(object sender, EventArgs e)
        {
            addSupplier();
        }

        private void EditSupButton_Click(object sender, EventArgs e)
        {
            updateSupplier();
        }

        private void deleteSupButton_Click(object sender, EventArgs e)
        {
            deleteSupplier();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            MngEmp mngemp = new MngEmp();
            this.Hide();
            mngemp.Show();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.Show();
        }

        private void SupplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SupplierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supIDTxtbox.Text = SupplierDataGridView.CurrentRow.Cells[0].Value.ToString();
            companyTxtbox.Text = SupplierDataGridView.CurrentRow.Cells[1].Value.ToString();
            agentTxtbox.Text = SupplierDataGridView.CurrentRow.Cells[2].Value.ToString();
            supContactTxtbox.Text = SupplierDataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            this.Hide();
            prod.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            this.Hide();
            s.Show();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void companyTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplierButton_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangeAdminPassword cap = new ChangeAdminPassword();
            this.Hide();
            cap.Show();
        }

        public void viewSuppliesButton_Click(object sender, EventArgs e)
        {
            if(SupplierDataGridView.SelectedRows.Count > 0)
            {
                string selectedSupplierID = supIDTxtbox.Text.ToString();
                string selectedCompany = companyTxtbox.Text.ToString();
                ViewSupplies vs = new ViewSupplies(selectedSupplierID, selectedCompany);
                this.Hide();
                vs.Show();
            }
            else
            {
                MessageBox.Show("Please select a supplier.");
            }
        }
    }
}
