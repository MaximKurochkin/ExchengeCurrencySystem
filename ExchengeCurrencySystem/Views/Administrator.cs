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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
            groupBox2.Hide();
            groupBox5.Hide();
            groupBox3.Hide();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Hide(); 
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox5.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            groupBox4.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Show();
            groupBox4.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox4.Hide();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox4.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
