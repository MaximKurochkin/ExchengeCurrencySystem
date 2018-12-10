using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
            groupBox3.Hide();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            Regex regex = new Regex("[А-я]");
            Regex regexNum = new Regex("[0-9]");
            if (regex.IsMatch(textBox1.Text) && !regexNum.IsMatch(textBox1.Text) &&
                regex.IsMatch(textBox2.Text) && !regexNum.IsMatch(textBox2.Text))
            {
                groupBox3.Show();
            }
            else
            {
                textBox8.Text = "Внимание! Некоректный ввод данных клиента";
                groupBox3.Show();
                groupBox3.Hide();
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox8.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[А-я]");
            Regex regexNum = new Regex("[0-9]");
            if (regex.IsMatch(textBox6.Text))
            {
                textBox8.Text = "Внимание! Некоректный ввод суммы продажи";
                button1.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                textBox8.Clear();
                button1.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Restrictions restrictions = new Restrictions();
            restrictions.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExchangeRates exchangeRates = new ExchangeRates();
            exchangeRates.Show();
        }
    }
}
