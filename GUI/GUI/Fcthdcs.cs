using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Fcthdcs : Form
    {
        public Fcthdcs()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
