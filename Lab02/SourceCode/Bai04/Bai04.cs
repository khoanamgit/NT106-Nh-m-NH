using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai04 : Form
    {
        [Serializable]    
        struct SinhVien
        {
            public string MSSV;
            public string HoTen;
            public string DienThoai;
            public float DiemToan;
            public float DiemVan;
            public float DiemTrungBinh;
        }
        public Bai04()
        {
            InitializeComponent();
        }

        // Lưu trữ thông tin sinh viên ở file output
        List<SinhVien> outputs = new List<SinhVien>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] lSinhVien = txtNhap.Text.Split("\r\n");
            SinhVien [] infoStudent = new SinhVien[lSinhVien.Length];
            int i = 0;
            foreach (string sinhvien in lSinhVien)
            {
                string[] s = sinhvien.Split(",");
                infoStudent[i].MSSV = s[0].Trim();
                infoStudent[i].HoTen = s[1].Trim();
                infoStudent[i].DienThoai = s[2].Trim();
                infoStudent[i].DiemToan = float.Parse(s[3].Trim());
                infoStudent[i].DiemVan = float.Parse(s[4].Trim());
                i++;
            }    
            save(infoStudent);
        }

        static void save(SinhVien[] info)
        {
            MessageBox.Show("Chọn file để lưu");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            var formater = new BinaryFormatter();
            formater.Serialize(fs, info);
            fs.Close();
        }

        private void btnLInput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn file input.txt");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            var formater = new BinaryFormatter();
            SinhVien[] students = formater.Deserialize(fs) as SinhVien[];

            string s = "";
            int i = 0;
            foreach (SinhVien student in students)
            {
                s = s + student.MSSV + "\r\n" + student.HoTen + "\r\n" + student.DienThoai + "\r\n" + student.DiemToan.ToString() + "\r\n" + student.DiemVan.ToString() + "\r\n\r\n\r\n";
                i++;
                SinhVien sv = new SinhVien();
                sv = student;
                sv.DiemTrungBinh = (student.DiemToan + student.DiemVan) / 2;
                outputs.Add(sv);
            }
            txtInput.Text = s;
            fs.Close();
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            save(outputs.ToArray());
        }

        private void btnLOutput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn file output.txt");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            var formater = new BinaryFormatter();
            SinhVien[] students = formater.Deserialize(fs) as SinhVien[];

            string s = "";
            foreach (SinhVien student in students)
            {
                s = s + student.MSSV + "\r\n" + student.HoTen + "\r\n" + student.DienThoai + "\r\n" + student.DiemToan.ToString() + "\r\n" + student.DiemVan.ToString()+ "\r\n"+
                    student.DiemTrungBinh+ "\r\n\r\n\r\n";
            }
            txtOutput.Text = s;
            fs.Close();
        }
    }
}
