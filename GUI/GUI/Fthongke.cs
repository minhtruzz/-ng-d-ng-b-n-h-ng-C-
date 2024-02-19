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
    public partial class Fthongke : Form
    {
        public Fthongke()
        {
            InitializeComponent();
        }

        private void Fthongke_Load(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            Fdoanhthu fdoanhthu = new Fdoanhthu();
            fdoanhthu.ShowDialog();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            Fbanchay fbanchay = new Fbanchay();
            fbanchay.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Fspton fspton = new Fspton();
            fspton.ShowDialog();
        }
    }
}
