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
    public partial class AddBranch : Form
    {
        public AddBranch()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";

        private void butSumit1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("BeanchAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Braddress", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Brnum", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Brcode", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Aid", textBox4.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Adding is successfull");
                    Clear();
                }
            }
        }

        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void AddBranch_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignupEmp form = new SignupEmp();
            form.Show();
            this.Hide();
        }
    }
}
