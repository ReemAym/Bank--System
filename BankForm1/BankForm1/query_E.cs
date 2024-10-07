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
    public partial class query_E : Form
    {
        public query_E()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select SSN,FIRSTNAME,SECONDNAME,ADDRESS,PHONE from Customer where Customer.SSN not in (Select takes.SSN from takes);", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dgv1.DataSource = dtb1;
            }
        }
    }
}
