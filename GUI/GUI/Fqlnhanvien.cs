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
    public partial class Fqlnhanvien : Form
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";
        public Fqlnhanvien()
        {
            InitializeComponent();
        }
        public void DanhSach(string query)
        {
            try
            {
                // Tạo chuỗi kết nối đến cơ sở dữ liệu
                string con = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";

                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ câu truy vấn
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // Tạo đối tượng DataTable để lưu trữ dữ liệu
                DataTable table = new DataTable();

                // Lấy dữ liệu từ câu truy vấn và đổ vào DataTable
                adapter.Fill(table);

                // Hiển thị dữ liệu từ DataTable lên DataGridView
                dgv_nhanvien.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TaiKhoan(Ten,TenTk,MatKhau,Quyen) VALUES(@Ten, @TenTK, @MatKhau, @Quyen)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            if (txt_ten.Text == "" || txt_tentk.Text == "" || txt_mk.Text == "" || txt_quyen.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command.Parameters.AddWithValue("@Ten", txt_ten.Text);
                command.Parameters.AddWithValue("@TenTK", txt_tentk.Text);
                command.Parameters.AddWithValue("@MatKhau", txt_mk.Text);
                command.Parameters.AddWithValue("@Quyen", txt_quyen.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string query1 = "SELECT * FROM TaiKhoan where quyen=1";
                DanhSach(query1);
                
            }
        }

        private void Fqlnhanvien_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TaiKhoan WHERE Quyen= 1";
            DanhSach(query);
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgv_nhanvien.Rows[e.RowIndex];
            txt_ten.Text = row.Cells[0].Value.ToString();
            txt_tentk.Text = row.Cells[1].Value.ToString();
            txt_mk.Text = row.Cells[2].Value.ToString();
            txt_quyen.Text = row.Cells[3].Value.ToString();
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "delete from TaiKhoan where tenTK = @tentk";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@TenTK", txt_tentk.Text);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            loadData();
        }
        private void loadData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from TaiKhoan where quyen=1";
            SqlCommand cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(result);
            conn.Close();
            dgv_nhanvien.DataSource = dt;

        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "update TaiKhoan set Ten = @Ten, TenTk = @TenTK, MatKhau= @MatKhau, Quyen = @Quyen where tenTK = @tentk";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Ten", txt_ten.Text);
            command.Parameters.AddWithValue("@TenTK", txt_tentk.Text);
            command.Parameters.AddWithValue("@MatKhau", txt_mk.Text);
            command.Parameters.AddWithValue("@Quyen", txt_quyen.Text); 
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            loadData();
        }
    }
}
