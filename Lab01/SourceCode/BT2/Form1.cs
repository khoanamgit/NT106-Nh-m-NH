using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first_num = textBox1.Text;
            string second_num = textBox2.Text;
            string third_num = textBox3.Text;


            float a = float.Parse(first_num);
            float b = float.Parse(second_num);
            float c = float.Parse(third_num);


            //Tìm Max
            float max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c) 
            {
                max = c;
            }
            // Tìm Min
            float min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min=c;
            }

            textBox4.Text = max.ToString();
            textBox5.Text = min.ToString();   





























            /*
            if (a > b && a > c && b > c)
            {
                textBox4.Text = a.ToString();
                textBox5.Text = c.ToString();
            }
            else if (a > b && a > c && b < c)
            {
                textBox4.Text = a.ToString();
                textBox5.Text = b.ToString();
            }
            else if ( b > a  && b > c && a > c)
            {
                textBox4.Text =  b.ToString();
                textBox5.Text = c.ToString();
            }
            else if (b > a && b > c && a < c)
            {
                textBox4.Text = b.ToString();
                textBox5.Text = a.ToString();
            }
            else if (c > a && c > b && a > b)
            {
                textBox4.Text = c.ToString();
                textBox5.Text = b.ToString();
            }
            else if (c > a && c > b && a < b)
            {
                textBox4.Text = c.ToString();
                textBox5.Text = a.ToString();
            }
            */

        }
    }
}
