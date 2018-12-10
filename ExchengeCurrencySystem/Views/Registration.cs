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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            groupBox2.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Hide();
                Administrator administrator = new Administrator();
                administrator.ShowDialog();
                Close();
            }
            if (radioButton2.Checked )
            {
                Hide();
                Cashier cashier = new Cashier();
                cashier.ShowDialog();
                Close();
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
