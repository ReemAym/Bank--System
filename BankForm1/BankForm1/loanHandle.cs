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
    public partial class loanHandle : Form
    {
        public loanHandle()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butSumit1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else
            {
                SqlConnection sqlCon = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCon.Open();
                sqlCmd.CommandText = "UPDATE LOAN SET EID = ' " + textBox2.Text + "', BRANCHNUM = '" + textBox3.Text + "' WHERE LOANNUMBER = '" + textBox1.Text + "' insert into SERVES (BRANCHNUM,SSN) values('" + textBox3.Text + "', '" + textBox4.Text + "')";
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Accepting is successfull");
                sqlCon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else
            {
                SqlConnection sqlCon = new SqlConnection(conString);
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCon.Open();
                sqlCmd.CommandText = "Delete FROM TAKES WHERE LOANNUMBER = '" + textBox1.Text + "' Delete FROM LOAN WHERE LOANNUMBER = '" + textBox1.Text + "'";
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Rejecting is successfull");
                sqlCon.Close();
            }
        }
    }
}
