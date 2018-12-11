using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            grpBoxCashiersView.Hide();
        }

        //private void Registration_Load(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void btnEnter(object sender, EventArgs e)
        {
            if (rbtnAdminView.Checked)
            {
                Hide();
                Administrator administrator = new Administrator();
                administrator.ShowDialog();
                Close();
            }
            if (rbtnCashierView.Checked)
            {
                Hide();
                Cashier cashier = new Cashier();
                cashier.ShowDialog();
                Close();
            }
        }

        private void rbtnAdmin(object sender, EventArgs e)
        {
            grpBoxCashiersView.Hide();
        }

        private void rbtnCashier(object sender, EventArgs e)
        {
            grpBoxCashiersView.Show();
        }

        private void grpBoxCashiers(object sender, EventArgs e)
        {

        }

        private void grpBoxRoles(object sender, EventArgs e)
        {
            
        }


        private void rbtnCashier1(object sender, EventArgs e)
        {

        }

        private void rbtnCashier2(object sender, EventArgs e)
        {

        }

        private void rbtnCashier3(object sender, EventArgs e)
        {

        }

        private void rbtnCashier4(object sender, EventArgs e)
        {

        }

        private void rbtnCashier5(object sender, EventArgs e)
        {

        }
    }
}
