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
            
            //Sử dụng mảng arr2 để lưu những phần tử nhập vào chuyển từ kiểu string -> double
            arr2 = arr.Select(double.Parse).ToArray();
            
            //Xoá listBox
            listBox1.Text = string.Empty;

            
            // Xuất mảng theo yêu cầu
            for(int i = 0; i < arr2.Length; i++)
            {
                int j = i + 1;
               listBox1.Items.Add("Môn " + j + ": " + arr2[i]) ;
            }    

              

        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            // Tính trung bình cộng của mảng
            double sum = 0; // Biến lưu tổng
            double result = 0; //Lưu trung bình cộng
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
            // Nút xoá
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            listBox1.Items.Clear();
            textBox3.Text = String.Empty;   
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Tìm phần tử lớn nhất
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
            //Tìm phần tử nhỏ nhất
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
            // Kiểm tra loại giỏi, khá, trung bình, yếu, kém
            double sum = 0;
            double result = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                sum = sum + arr2[i];
            }
            result = sum / arr2.Length;
                
            for(int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] >= 6.5 && result >= 8)
                {
                    textBox5.Text = "Giỏi";
                }
                else if(arr2[i] >= 5 && result >= 6.5)
                {
                    textBox5.Text = "Khá";
                }
                else if(arr2[i] >=3.5 && result >= 5)
                {
                    textBox5.Text = "TB";
                }
                else if (arr2[i] >= 2 && result >= 3.5)
                {
                    textBox5.Text = "Yếu";
                }
                else
                {
                    textBox5.Text = "Kém";
                }
            }
        }

            
        
    }
}
