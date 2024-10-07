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

    public partial class SignupAmin : Form
    {
        public SignupAmin()
        {
            InitializeComponent();
        }
        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (textBox5.Text != textBox6.Text)
                MessageBox.Show("password does not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AdmainSignUp", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Aid", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Afirstname", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Alastname", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Ausername", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Apassword", textBox5.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up is successfull");
                    Clear();
                }
            }
        }

        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (textBox5.Text != textBox6.Text)
                MessageBox.Show("password does not match");
            else
            {
                SqlConnection sqlCon = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCon.Open();
                sqlCmd.CommandText = "UPDATE ADMIN SET AFIRSTNAME = ' " + textBox2.Text + "', ALASTNAME = '" + textBox3.Text + "', AUserName = '" + textBox4.Text + "', APassword = '" + textBox5.Text + "' WHERE AID = '" + textBox1.Text + "'";
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updating is successfull");
                sqlCon.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddBank form = new AddBank();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddBranch form = new AddBranch();
            form.Show();
            this.Hide();
        }
    }
}
