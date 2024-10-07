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
    public partial class query_C : Form
    {
        public query_C()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT EMPLOYEE.EID,EMPLOYEE.EFIRSTNAME,EMPLOYEE.ELASTNAME,EMPLOYEE.BRANCHNUM from EMPLOYEE JOIN LOAN ON EMPLOYEE.EID = LOAN.EID GROUP BY EMPLOYEE.EID, EMPLOYEE.EFIRSTNAME, EMPLOYEE.ELASTNAME, EMPLOYEE.BRANCHNUM HAVING COUNT(EMPLOYEE.EID) = ( SELECT MAX(mycount) FROM( SELECT EMPLOYEE.EID, COUNT(EMPLOYEE.EID) mycount from EMPLOYEE JOIN LOAN ON EMPLOYEE.EID = LOAN.EID GROUP BY EMPLOYEE.EID, EMPLOYEE.EFIRSTNAME, EMPLOYEE.ELASTNAME, EMPLOYEE.BRANCHNUM) as MaxNumLoans )", sqlCon);

                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dgv1.DataSource = dtb1;
            }
        }
    }
}
