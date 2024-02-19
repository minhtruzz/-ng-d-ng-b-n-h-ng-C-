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
    public partial class Fbanhang : Form
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";
        public Fbanhang()
        {
            InitializeComponent();
            string query = "SELECT * FROM HoaDon";
            DanhSach(query);
        }
        public void DanhSach(string query)
        {
            try
            {
                // Tạo chuỗi kết nối đến cơ sở dữ liệu
                string con = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";

                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ câu truy vấn
                SqlDataAdapter adapter = new SqlDataAdapter(query,con);
                
                    // Tạo đối tượng DataTable để lưu trữ dữ liệu
                    DataTable table = new DataTable();

                    // Lấy dữ liệu từ câu truy vấn và đổ vào DataTable
                    adapter.Fill(table);

                    // Hiển thị dữ liệu từ DataTable lên DataGridView
                    dgv_hoadon.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            string query= "INSERT INTO HoaDon(HoTen, SDT, TenSanPham, MauSanPham, Gia,SoLuong,GiamGia,TongTien,Ngay) VALUES(@HoTen, @SDT, @TenSP, @MauSP, @Gia, @SL,@GG,@TT,@Ngay)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);
            if (txt_tenkh.Text == "" || txt_sdt.Text == "" || txt_tensanpham.Text == "" || txt_mausanpham.Text == "" || txt_giaban.Text == "" || txt_sl.Text == "" || txt_giamgia.Text == "" || txt_tongtien.Text == "")
            {
               
                MessageBox.Show("Vui lòng nhập đầy đủ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command.Parameters.AddWithValue("@HoTen", txt_tenkh.Text);
                command.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                command.Parameters.AddWithValue("@TenSP", txt_tensanpham.Text);
                command.Parameters.AddWithValue("@MauSP", txt_mausanpham.Text);
                command.Parameters.AddWithValue("@Gia", txt_giaban.Text);
                command.Parameters.AddWithValue("@SL", txt_sl.Text);
                command.Parameters.AddWithValue("@GG", txt_giamgia.Text);
                command.Parameters.AddWithValue("@TT", txt_tongtien.Text);
                command.Parameters.AddWithValue("@Ngay", dtp_ngay.Value);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string query1 = "SELECT * FROM HoaDon";
                DanhSach(query1);
            }    
           
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //string con = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";
            //    string query = "DELETE FROM HoaDon WHERE MaHD = @mahd";
            //    SqlCommand command = new SqlCommand(query);
            //    SqlConnection connection = new SqlConnection(con);
            //    command.Parameters.AddWithValue("@mahd", txt_.Text);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //    string query1 = "SELECT * FROM HoaDon";
            //    DanhSach(query1);
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            //float gia = float.Parse(txt_tongtien.Text);
            //int sl= int.Parse(num_soluong.ToString());
            //float giam = float.Parse(txt_giamgia.Text);
            //txt_tongtien.Text = ((gia*sl) - giam).ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_tenkh.Text = "";
            txt_sdt.Text = "";
            txt_tensanpham.Text = "";
            txt_mausanpham.Text = "";
            txt_giaban.Text = "";
            txt_giamgia.Text = "";
            txt_tongtien.Text = "";
            txt_sl.Text = "";
            txtMaHD.Text = "";
            MessageBox.Show("Reset thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "update hoadon set hoten = @hoten, sdt = @sdt, tensanpham = @tensanpham, mausanpham = @mausanpham, gia = @gia, soluong = @soluong, giamgia = @giamgia, tongtien= @tongtien, ngay = @ngay where mahd = @mahd";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@hoten", txt_tenkh.Text);
            cmd.Parameters.AddWithValue("@sdt", Convert.ToInt32(txt_sdt.Text));
            cmd.Parameters.AddWithValue("@tensanpham", txt_tensanpham.Text);
            cmd.Parameters.AddWithValue("@mausanpham", txt_mausanpham.Text);
            cmd.Parameters.AddWithValue("@gia", Convert.ToDouble(txt_giaban.Text));
            cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(txt_sl.Text));
            cmd.Parameters.AddWithValue("@giamgia", Convert.ToDouble(txt_giamgia.Text));
            cmd.Parameters.AddWithValue("@tongtien", Convert.ToDouble(txt_tongtien.Text));
            cmd.Parameters.AddWithValue("@ngay", dtp_ngay.Value);
            cmd.Parameters.AddWithValue("@mahd", Convert.ToInt32(txtMaHD.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            loadData();
           
        }
        private void loadData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from HoaDon";
            SqlCommand cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(result);
            conn.Close();
            dgv_hoadon.DataSource = dt;

        }

        private void Fbanhang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgv_hoadon.Rows[e.RowIndex];
            txtMaHD.Text = row.Cells[0].Value.ToString();
            txt_tenkh.Text = row.Cells[1].Value.ToString();
            txt_sdt.Text = row.Cells[2].Value.ToString();
            txt_tensanpham.Text = row.Cells[3].Value.ToString();
            txt_mausanpham.Text = row.Cells[4].Value.ToString();
            txt_giaban.Text = row.Cells[5].Value.ToString();
            txt_sl.Text = row.Cells[6].Value.ToString();
            txt_giamgia.Text = row.Cells[7].Value.ToString();
            txt_tongtien.Text = row.Cells[8].Value.ToString();
            dtp_ngay.Value = Convert.ToDateTime(row.Cells[9].Value);
        }
    }
}
