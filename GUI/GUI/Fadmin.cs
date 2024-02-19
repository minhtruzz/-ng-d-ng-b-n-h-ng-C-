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
    public partial class Fadmin : Form
    {
        public Fadmin()
        {
            InitializeComponent();
        }

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            Fqlnhanvien fqlnhanvien = new Fqlnhanvien();    
            fqlnhanvien.ShowDialog();
        }

        private void btn_cthd_Click(object sender, EventArgs e)
        {
            Fthongke fthongke = new Fthongke(); 
            fthongke.ShowDialog();
        }

        private void btn_ncc_Click(object sender, EventArgs e)
        {
            Fnhacungcapcs fnhacungcapcs = new Fnhacungcapcs();
            fnhacungcapcs.ShowDialog();
        }

        private void btn_tkhd_Click(object sender, EventArgs e)
        {
            Fcthdcs fcthdcs = new Fcthdcs();
            fcthdcs.ShowDialog();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
