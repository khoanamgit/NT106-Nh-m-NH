using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamReader sr;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            sr = new StreamReader(fs);
            MessageBox.Show("Đoc file thành công");
        }

        private string bieuThucOut(string line)
        {
            String a = line;
            string[] source = a.Split(' ');
            float result = 0, num1 = 0, num2 = 0;
            char pheptinh = source[1][0];
            num1 = Int32.Parse(source[0]);
            string sothu2 = source[1].Substring(1);
            num2 = Int32.Parse(sothu2);

            switch (pheptinh)
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num1 / num2; break;
            }

            return line + " = " + result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Create);
            string line;
            using (StreamWriter sw = new StreamWriter(fs))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(bieuThucOut(line));
                }
            }
        }
    }
}
