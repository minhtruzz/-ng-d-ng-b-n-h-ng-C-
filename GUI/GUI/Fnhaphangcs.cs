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
    public partial class Fnhaphangcs : Form
    {
        public Fnhaphangcs()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_nhapma.Text == "" || txt_nhapten.Text == "" || txt_nhapmau.Text == "" || txt_nhapgia.Text == "" || txt_nhapsoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhập đầy đủ !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";

                // Tạo kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Tạo câu truy vấn để thêm sản phẩm vào bảng SanPham
                    String query = "INSERT INTO SanPham (MaSanPham, TenSanPham, MauSanPham, GiaBan, SoLuong) VALUES (@ma, @ten, @mau, @gia, @soluong)";

                    // Tạo đối tượng SqlCommand để thực thi câu truy vấn
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào câu truy vấn

                        command.Parameters.AddWithValue("@ma", txt_nhapma.Text);
                        command.Parameters.AddWithValue("@ten", txt_nhapten.Text);
                        command.Parameters.AddWithValue("@mau", txt_nhapmau.Text);
                        command.Parameters.AddWithValue("@gia", txt_nhapgia.Text);
                        command.Parameters.AddWithValue("@soluong", txt_nhapsoluong.Text);

                        // Mở kết nối đến cơ sở dữ liệu
                        connection.Open();

                        // Thực thi câu truy vấn và trả về số bản ghi được thêm vào bảng SanPham
                        command.ExecuteNonQuery();

                        // Đóng kết nối đến cơ sở dữ liệu
                        connection.Close();
                    }
                }
                Close();
                MessageBox.Show("Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
    
}
