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
    public partial class AllLoans : Form
    {
        public AllLoans()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT LOAN.LOANNUMBER ,CUSTOMER.SSN ,CUSTOMER.FIRSTNAME,CUSTOMER.SECONDNAME,EMPLOYEE.EID,EMPLOYEE.EFIRSTNAME,EMPLOYEE.ELASTNAME FROM LOAN JOIN TAKES ON LOAN.LOANNUMBER=TAKES.LOANNUMBER JOIN CUSTOMER ON TAKES.SSN=CUSTOMER.SSN JOIN EMPLOYEE ON LOAN.EID=EMPLOYEE.EID", sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dgv1.DataSource = dtb1;
            }
        }
    }
}
