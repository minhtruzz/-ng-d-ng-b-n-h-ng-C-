using BUS;
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
using DTO;
namespace GUI
{
    public partial class Fdangnhap : Form
    {
        BUSLogin BUSLogin = new BUSLogin();

        public Fdangnhap()
        {
            InitializeComponent();
            txt_matkhau.UseSystemPasswordChar = true;
            //txt_taikhoan.Text = "0963651899";
            //txt_matkhau.Text = "truong1899";
            //cbo_quyen.Text = "Quản Lí";
            txt_taikhoan.Text = "0923616634";
            txt_matkhau.Text = "Tung6634";
            cbo_quyen.Text = "Nhân Viên";
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
           DataTable dt = new DataTable();
           dt = BUSLogin.CheckLogin(txt_taikhoan.Text,txt_matkhau.Text);
            DataRow r = dt.Rows[0];
            DTOLogin DTOLogin = new DTOLogin(r);
            //MessageBox.Show(DTOLogin.Quyen.ToString());
            MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.None);
            if (DTOLogin.Quyen == 1)
            {
                Fnhanvien fnhanvien = new Fnhanvien();
                this.Hide();
                fnhanvien.ShowDialog();
                this.Show();
            }
            else
            {
                Fadmin fnhanvien = new Fadmin();
                this.Hide();
                fnhanvien.ShowDialog();
                this.Show();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Equals(DialogResult.No);
            }
        }

        private void cb_hienpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienpass.Checked == true)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }
    }
}
