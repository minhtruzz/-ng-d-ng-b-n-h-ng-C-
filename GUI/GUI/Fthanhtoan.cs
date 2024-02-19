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
    public partial class Fthanhtoan : Form
    {
        public Fthanhtoan()
        {
            InitializeComponent();
        }
        public void An()
        {
            txt_tiendua.Visible = false;
            txt_tienthua.Visible = false;
            txt_tientra.Visible = false;
            lb_tiendua.Visible=false;
            lb_tienthua.Visible=false;
            lb_tientra.Visible=false;
            btn_tinhtien.Visible=false;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_momo_Click(object sender, EventArgs e)
        {
            ptb_momo.Visible = true;
            An();

        }

        private void btn_the_Click(object sender, EventArgs e)
        {
            ptb_vtb.Visible = true;
            lb_stk.Visible = true;
            ptb_momo.Visible=false;
            An();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
