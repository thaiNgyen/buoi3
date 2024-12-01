using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public delegate void delPassData(TextBox text);


        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {

            string hoTen = txtTen.Text;
            string ngaySinh = dtpNgaySinh.Text; // Hoặc dateTimePicker1.Value.ToString()
            string gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            string soThich = "";
            if (checkBoxTheThao.Checked) soThich += "Thể thao ";
            if (checkBoxPhimAnh.Checked) soThich += "Phim ảnh ";
            if (checkBoxDuLich.Checked) soThich += "Du lịch";

            // Hiển thị thông tin
            string thongTin = $"Họ tên: {hoTen}\n" +
                              $"Ngày sinh: {ngaySinh}\n" +
                              $"Giới tính: {gioiTinh}\n" +
                              $"Sở thích: {soThich}";
            MessageBox.Show(thongTin, "Thông tin cá nhân");
        }

        private void buttonform2_Click(object sender, EventArgs e)
        {
            string hoTen = txtTen.Text;
            string ngaySinh = dtpNgaySinh.Text; // Hoặc dateTimePicker1.Value.ToString()
            string gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            string soThich = "";
            if (checkBoxTheThao.Checked) soThich += "Thể thao ";
            if (checkBoxPhimAnh.Checked) soThich += "Phim ảnh ";
            if (checkBoxDuLich.Checked) soThich += "Du lịch";

            // Hiển thị thông tin
            string thongTin = $"Họ tên: {hoTen}\n" +
                              $"Ngày sinh: {ngaySinh}\n" +
                              $"Giới tính: {gioiTinh}\n" +
                              $"Sở thích: {soThich}";
            Form2 form2 = new Form2(thongTin);
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonform2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
