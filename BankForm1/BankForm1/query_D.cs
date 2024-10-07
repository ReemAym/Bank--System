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
    public partial class query_D : Form
    {
        public query_D()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT CUSTOMER.SSN, CUSTOMER.FIRSTNAME,CUSTOMER.SECONDNAME ,CUSTOMER.PHONE,CUSTOMER.ADDRESS FROM CUSTOMER join TAKES on CUSTOMER.SSN = TAKES.SSN GROUP BY CUSTOMER.SSN, CUSTOMER.FIRSTNAME, CUSTOMER.SECONDNAME, CUSTOMER.PHONE, CUSTOMER.ADDRESS HAVING COUNT(CUSTOMER.SSN) = ( SELECT MAX(mycount) FROM( SELECT CUSTOMER.SSN, COUNT(CUSTOMER.SSN) mycount FROM CUSTOMER join TAKES on CUSTOMER.SSN = TAKES.SSN GROUP BY CUSTOMER.SSN, CUSTOMER.FIRSTNAME, CUSTOMER.SECONDNAME, CUSTOMER.PHONE, CUSTOMER.ADDRESS) as MaxNumLoans )", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dgv1.DataSource = dtb1;
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
