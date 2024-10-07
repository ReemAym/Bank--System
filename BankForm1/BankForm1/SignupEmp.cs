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
    public partial class SignupEmp : Form
    {
        public SignupEmp()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (textBox6.Text != textBox7.Text)
                MessageBox.Show("password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("EmployeeSignUp", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Eid", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Efirstname", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Elastname", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Ebranchnum", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Eusername", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Epassword", textBox6.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up is successfull");
                    Clear();
                }
            }
        }

        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (textBox6.Text != textBox7.Text)
                MessageBox.Show("password do not match");
            else
            {
                SqlConnection sqlCon = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCon.Open();
                sqlCmd.CommandText = "UPDATE EMPLOYEE SET EFIRSTNAME = ' " + textBox2.Text + "', ELASTNAME = '" + textBox3.Text + "', BRANCHNUM = '" + textBox4.Text + "', EUserName = '" + textBox5.Text + "', EPassword = '" + textBox6.Text + "' WHERE EID = '" + textBox1.Text + "'";
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updating is successfull");
                sqlCon.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCus form = new AddCus();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loanHandle form = new loanHandle();
            form.Show();
            this.Hide();
        }
    }
}
