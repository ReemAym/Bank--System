using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankForm1
{
    public partial class AddCus : Form
    {
        public AddCus()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";


        private void butSumit1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddCustomer", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ssn", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Cfirstname", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Clastname", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Caddress", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Cphone", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@employeenum", textBox6.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@branchnum", textBox7.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Adding is successfull");
                    Clear();
                }
            }
        }

        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
        }

        private void AddCus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.DEALS_WITH' table. You can move, or remove it, as needed.
            this.dEALS_WITHTableAdapter.Fill(this.bankSystemDataSet.DEALS_WITH);
            // TODO: This line of code loads data into the 'bankSystemDataSet.CUSTOMER' table. You can move, or remove it, as needed.


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.bankSystemDataSet.CUSTOMER);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else
            {
                SqlConnection sqlCon = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCon.Open();
                sqlCmd.CommandText = "UPDATE CUSTOMER SET FIRSTNAME = ' " + textBox2.Text + "', SECONDNAME = '" + textBox3.Text + "', ADDRESS = '" + textBox4.Text + "', PHONE = '" + textBox5.Text + "' WHERE SSN = '" + textBox1.Text + "' insert into DEALS_WITH (EID,SSN) values('"+ textBox6.Text + "','" + textBox1.Text + "')";
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updating is successfull");
                sqlCon.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddAccount form = new AddAccount();
            form.Show();
            this.Hide();
        }
    }
}
