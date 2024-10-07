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
    public partial class SignupCus : Form
    {
        public SignupCus()
        {
            InitializeComponent();
        }
        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";


        private void butSumit1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("CustomerSignUp", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ssn", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Cusername", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Cpassword", textBox3.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up is successfull");
                    Clear();
                }
            }
        }

        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("password do not match");
            else
            {
                SqlConnection sqlCon = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCon.Open();
                sqlCmd.CommandText = "UPDATE CUSTOMER SET UserName = ' " + textBox2.Text + "', Password = '" + textBox3.Text + "' WHERE SSN = '" + textBox1.Text + "'";
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updating is successfull");
                sqlCon.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loanRequest form = new loanRequest();
            form.Show();
            this.Hide();
        }
    }
}
