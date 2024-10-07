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
    public partial class AllCustomers : Form
    {
        public AllCustomers()
        {
            InitializeComponent();
        }

        public string conString = @"Data Source=DESKTOP-7F642R3\MSSQLSERVER1;Initial Catalog=BankSystem;Integrated Security=True";


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.bankSystemDataSet.CUSTOMER);

        }

        private void sECONDNAMELabel_Click(object sender, EventArgs e)
        {

        }
    }
}
