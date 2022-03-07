namespace WinFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {

            // Kiểm tra đầu vào
            try
            {
                // Lấy dữ liệu từ 2 textbox
                string first_num = textBox1.Text;
                string second_num = textBox2.Text;


                // Ép kiểu dữ liệu vừa mới lấy
                int a = Int32.Parse(first_num);
                int b = Int32.Parse(second_num);


                // Tính tổng 2 số lưu vào biến kết quả
                long result = a + b;

                textBox3.Text = result.ToString();  
                
               
            }

            catch 
            {
                MessageBox.Show("Vui lòng nhập số nguyên");

            }   
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}