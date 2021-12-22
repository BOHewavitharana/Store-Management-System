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
    public partial class MngEmp : Form
    {
        public MngEmp()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=storedb;sslMode=none");

        private void viewEmployees()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string query = "select EmpID as ID, EmpName as Name, EmpAge as Age, EmpPhone as Contact from emp";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpTbl.DataSource = ds.Tables[0];
            con.Close();
        }

        private void addEmployee()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string query = "insert into emp values('" + EmpID.Text + "','" + EmpName.Text + "'," + EmpAge.Text + ",'" + PhnNo.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added Succsessfully!!");
                con.Close();
                viewEmployees();
                EmpID.Text = "";
                EmpName.Text = "";
                EmpAge.Text = "";
                PhnNo.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateEmployee()
        {
            try
            {
                if (EmpName.Text == "" || EmpID.Text == "")
                {
                    MessageBox.Show("Information Not Selected");
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    String query = "update emp set EmpName= '" + EmpName.Text + "', EmpAge= " + EmpAge.Text + ", EmpPhone= '" + PhnNo.Text + "' where EmpID = '" + EmpID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Succsesfully");
                    con.Close();
                    viewEmployees();
                    EmpID.Text = "";
                    EmpName.Text = "";
                    EmpAge.Text = "";
                    PhnNo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteEmployee() {
            try
            {
                if (EmpID.Text == "")
                {
                    MessageBox.Show("Select the category");
                }
                else
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    string query = "delete from emp where EmpID='" + EmpID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Sucessfully!!");
                    con.Close();
                    viewEmployees();
                    EmpID.Text = "";
                    EmpName.Text = "";
                    EmpAge.Text = "";
                    PhnNo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            this.Hide();
            pro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            this.Hide();
            sup.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Emp_Load(object sender, EventArgs e)
        {
            viewEmployees();
            buttonpanel.Height = button1.Height;
            buttonpanel.Top = button1.Top;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            addEmployee();
        }

        private void EmpTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID.Text = EmpTbl.SelectedRows[0].Cells[0].Value.ToString();
            EmpName.Text = EmpTbl.SelectedRows[0].Cells[1].Value.ToString();
            EmpAge.Text = EmpTbl.SelectedRows[0].Cells[2].Value.ToString();
            PhnNo.Text = EmpTbl.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateEmployee();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deleteEmployee();
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

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangeAdminPassword cap = new ChangeAdminPassword();
            this.Hide();
            cap.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
