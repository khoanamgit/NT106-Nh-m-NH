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


namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Đọc File
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            richTextBox1.Text = content;

            fs.Close();

            //Lấy tên File
            string namefile = ofd.SafeFileName.ToString();
            textBox1.Text = namefile;

            //Lấy URL
            string URL = fs.Name.ToString();
            textBox2.Text = URL;

            //Số dòng
            content = content.Replace("\r\n", "\n");
            int LineCount = richTextBox1.Lines.Count();
            content = content.Replace('\r',' ');
            textBox3.Text = LineCount.ToString();

            //Số ký tự
            int CharacterCount = content.Length;
            textBox5.Text = CharacterCount.ToString();

            //Số từ
            string[] Source = content.Split(new char[] {'.','?','!',' ',';',':',','},StringSplitOptions.RemoveEmptyEntries);
            int WordCount = Source.Length;
            textBox4.Text = WordCount.ToString();
        }
    }
}
