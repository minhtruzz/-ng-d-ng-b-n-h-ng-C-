using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Fnhanvien : Form
    {
        public Fnhanvien()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();

        }
        public void DanhSach(string query)
        {
            try
            {
                // Tạo chuỗi kết nối đến cơ sở dữ liệu
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";

                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ câu truy vấn
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
                {
                    // Tạo đối tượng DataTable để lưu trữ dữ liệu
                    DataTable table = new DataTable();

                    // Lấy dữ liệu từ câu truy vấn và đổ vào DataTable
                    adapter.Fill(table);

                    // Hiển thị dữ liệu từ DataTable lên DataGridView
                    dgv_danhsach.DataSource = table;
                    dgv_danhsach.Columns[0].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }
            private void Fnhanvien_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SanPham";
            DanhSach(query);
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            Fbanhang fbanhang = new Fbanhang();
            fbanhang.ShowDialog();
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            Fnhaphangcs fnhaphangcs = new Fnhaphangcs();
            fnhaphangcs.ShowDialog();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            Fthanhtoan fthanhtoan = new Fthanhtoan();   
            fthanhtoan.ShowDialog();    
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string timtensp = txt_timtheoten.Text;
            string timgiasp = txt_timtheogia.Text;

            string query = "SELECT MaSanPham,TenSanPham,MauSanPham,GiaBan,SoLuong FROM SanPham WHERE TenSanPham like '%" + timtensp + "%'";
            DanhSach(query);
            if (timgiasp != "")
            {
                string query1 = "SELECT MaSanPham,TenSanPham,MauSanPham,GiaBan,SoLuong FROM SanPham WHERE GiaBan <= " + timgiasp + "";
                DanhSach(query1);
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";
            string query = "SELECT  MaSanPham,TenSanPham,MauSanPham,GiaBan,SoLuong FROM SanPham";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Cập nhật dữ liệu trên giao diện
                dgv_danhsach.DataSource = table;
            }
        }

        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_danhsach.Rows.Count)
            {
                DataGridViewRow row = dgv_danhsach.Rows[e.RowIndex];
                string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                string tenSanPham = row.Cells["TenSanPham"].Value.ToString();
                string mau = row.Cells["MauSanPham"].Value.ToString(); // Lấy giá trị của cột màu
                decimal giaBan = Convert.ToDecimal(row.Cells["GiaBan"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                // Hiển thị thông tin của đối tượng
                lbl_maSanPham.Text = maSanPham;
                lbl_tenSanPham.Text = tenSanPham;
                lbl_mau.Text = mau;
                lbl_giaBan.Text = giaBan.ToString("N0");
                lbl_soLuong.Text = soLuong.ToString();
                pnl_thongtin.Visible = true;
                ptb_anh.ImageLocation = row.Cells["Anh"].Value.ToString();
            }
        }

        private void dgv_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
