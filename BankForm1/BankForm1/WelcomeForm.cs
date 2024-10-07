using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignupAmin form = new SignupAmin();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignupEmp form = new SignupEmp();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupCus form = new SignupCus();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AllCustomers form = new AllCustomers();
            form.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            query_A form = new query_A();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            query_B form = new query_B();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            query_E form = new query_E();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loanType form = new loanType();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            query_F form = new query_F();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            query_C form = new query_C();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            query_D form = new query_D();
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AllLoans form = new AllLoans();
            form.Show();
        }
    }
}
