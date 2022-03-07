using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first_num = textBox1.Text;
            string second_num = textBox2.Text;

            double a = float.Parse(first_num);
            double b = float.Parse(second_num);

            double result = 1;
            

            //Tính giai thừa A và B
            for (int i = 1;i <= a; i++)
            {
                result = result * i;
            }

            
            double result1 = 1;
            for(int i = 1;i <= b; i++)
            {
                result1 = result1 * i;
            }
            label3.Text = "A! = " + result.ToString() ;
            label4.Text = "B! = " + result1.ToString() ;

            //Tính tổng S1 và S2
            double sum = 0;
            double sum1 = 0;

            for (int i = 1;i <=a; i++)
            {
                sum = sum + i;
            }

            for (int i = 1;i <=b; i++)
            {
                sum1 = sum1 + i;
            }    

            label5.Text = "S1 = 1 + 2 + 3 + 4 + ... + A = " + sum.ToString() ;
            label6.Text = "S2 = 1 + 2 + 3 + 4 + ... + B = " + sum1.ToString();

            //Tìm S3
            double sum2 = 0;
            for(int i = 1;i <=b; i++)
            {
                sum2 = sum2 + Math.Pow(a,i);
            }    

            label7.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + sum2.ToString() ;   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty ;
            textBox2.Text  = String.Empty ;
            label3.Text = String.Empty ;
            label4.Text = String.Empty;
            label5.Text = String.Empty;
            label6.Text = String.Empty;
            label7.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát");
            Application.Exit(); 
        }
    }
}
