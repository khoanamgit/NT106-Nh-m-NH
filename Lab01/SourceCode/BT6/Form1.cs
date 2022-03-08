using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        string[] arr = new string[1000];
        double [] arr2 = new double[1000];
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text; //Lấy input từ textbox

            //Tách bỏ dấu ',' trong input
            arr = textBox1.Text.Split(',');

            arr2 = arr.Select(double.Parse).ToArray();

            listBox1.Text = string.Empty;

            

            for(int i = 0; i < arr2.Length; i++)
            {
                int j = i + 1;
               listBox1.Items.Add("Môn " + j + ": " + arr2[i]) ;
            }    

              

        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            double sum = 0;
            double result = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                sum = sum  + arr2[i];
            }
            result = sum / arr2.Length;

            textBox2.Text = result.ToString();

            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            listBox1.Items.Clear();
            textBox3.Text = String.Empty;   
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double max_item = arr2[0];
            for(int i = 0; i < arr2.Length; i++)
            {
                if(arr2[i] > max_item)
                {
                    max_item = arr2[i];
                }
            }
            textBox3.Text = max_item.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double min_item = arr2[0];
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < min_item)
                {
                    min_item = arr2[i];
                }
            }
            textBox4.Text = min_item.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double result = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                sum = sum + arr2[i];
            }
            result = sum / arr2.Length;
                
            for(int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] >= 6.5)
                {
                    if (result >= 8)
                    {
                        textBox5.Text = "Giỏi";
                    }
                    
                }
                else if(arr2[i] >= 5)
                {
                    if (result >= 6.5)
                    {
                        textBox5.Text = "Khá";
                    }
                    
                }
                else if(arr2[i] >=3.5)
                {
                    if (result >= 5)
                    {
                        textBox5.Text = "TB";
                    }
                    
                }
                else if (arr2[i] >= 2)
                {
                    if (result >= 3.5)
                    {
                        textBox5.Text = "Yếu"; 
                    }
                    
                }
                else
                {
                    textBox5.Text = "Kém";
                }
            }
        }

            
        
    }
}
