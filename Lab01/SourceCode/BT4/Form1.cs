using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string money = textBox1.Text;

            float a = float.Parse(money);

            
            float USD = 22722;
            float EUR = 28132;
            float GBP = 31538;
            float SGD = 17286;
            float JPY = 214;

            if (comboBox1.SelectedIndex == 0)
            {
                double result = a * USD;
                textBox2.Text = result.ToString();
                textBox3.Text = "1 USD = " + USD.ToString() + "VNĐ";
                //textBox3.Text = "1 USD = 22,722 VNĐ";
                
            }    
            if (comboBox1.SelectedIndex == 1)
            {
                double result = a * EUR;
                textBox2.Text = result.ToString();
                textBox3.Text= "1 EUR =" + EUR.ToString() + "VNĐ";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                double result = a * GBP;
                textBox2.Text = result.ToString();
                textBox3.Text ="1 GBP =" + GBP.ToString() + "VNĐ";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                double result = a * SGD;
                textBox2.Text = result.ToString();
                textBox3.Text = "1 SGP ="+ SGD.ToString() + "VNĐ";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                double result = a * JPY;
                textBox2.Text = result.ToString();
                textBox3.Text = "1 JPY =" + JPY.ToString() + "VNĐ";
            }

        }
    }
}
