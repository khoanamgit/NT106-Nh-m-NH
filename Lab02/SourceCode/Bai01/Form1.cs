using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            richTextBox1.Text = content;

            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter wrt = new StreamWriter(@"F:\NT.106.TH\Lab02\Bai01\ReadFile\output.txt")) 
            {
                string data = richTextBox1.Text;
                wrt.WriteLine(data.ToUpper());
                richTextBox1.Text = string.Empty;
            }
        }
    }
}
