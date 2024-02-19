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
    public partial class Fnhacungcapcs : Form
    {
        public Fnhacungcapcs()
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
                string con = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlycuahang;Integrated Security=True";

                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ câu truy vấn
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // Tạo đối tượng DataTable để lưu trữ dữ liệu
                DataTable table = new DataTable();

                // Lấy dữ liệu từ câu truy vấn và đổ vào DataTable
                adapter.Fill(table);

                // Hiển thị dữ liệu từ DataTable lên DataGridView
                dgv_ncc.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
        }
        private void btn_goi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call : 0909999999", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void Fnhacungcapcs_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NhaCungCap";
            DanhSach(query);
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email : applevn@gamil.com", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
