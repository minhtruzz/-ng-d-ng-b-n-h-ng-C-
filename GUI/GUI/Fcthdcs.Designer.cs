namespace GUI
{
    partial class Fcthdcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptb_avt = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_capnhat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_them = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_thoat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lb_cthd = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptb_avt
            // 
            this.ptb_avt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_avt.Image = global::GUI.Properties.Resources.Store_T_T;
            this.ptb_avt.Location = new System.Drawing.Point(2, 0);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Size = new System.Drawing.Size(227, 167);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 16;
            this.ptb_avt.TabStop = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Ivory;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Controls.Add(this.btn_xoa);
            this.guna2GroupBox1.Controls.Add(this.btn_capnhat);
            this.guna2GroupBox1.Controls.Add(this.btn_them);
            this.guna2GroupBox1.Controls.Add(this.btn_thoat);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Lime;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Ivory;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(-3, 167);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(232, 383);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "Chức Năng";
            // 
            // btn_xoa
            // 
            this.btn_xoa.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_xoa.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_xoa.Image = global::GUI.Properties.Resources.xoa;
            this.btn_xoa.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_xoa.ImageRotate = 0F;
            this.btn_xoa.Location = new System.Drawing.Point(142, 61);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_xoa.Size = new System.Drawing.Size(64, 67);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_capnhat.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_capnhat.Image = global::GUI.Properties.Resources.update;
            this.btn_capnhat.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_capnhat.ImageRotate = 0F;
            this.btn_capnhat.Location = new System.Drawing.Point(25, 197);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_capnhat.Size = new System.Drawing.Size(64, 65);
            this.btn_capnhat.TabIndex = 8;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_them.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_them.Image = global::GUI.Properties.Resources.cong_cs;
            this.btn_them.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_them.ImageRotate = 0F;
            this.btn_them.Location = new System.Drawing.Point(25, 61);
            this.btn_them.Name = "btn_them";
            this.btn_them.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_them.Size = new System.Drawing.Size(64, 65);
            this.btn_them.TabIndex = 7;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.Image = global::GUI.Properties.Resources.exit_cs;
            this.btn_thoat.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_thoat.ImageRotate = 0F;
            this.btn_thoat.Location = new System.Drawing.Point(142, 183);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.Size = new System.Drawing.Size(64, 89);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lb_cthd
            // 
            this.lb_cthd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cthd.FormattingEnabled = true;
            this.lb_cthd.ItemHeight = 25;
            this.lb_cthd.Items.AddRange(new object[] {
            "MaHD: HD1",
            "NV: Hồ Ngọc Tùng",
            "TenKh: Tô Khải Hiên",
            "DiaChi: Gò Vấp",
            "TenSP: IPhone 14",
            "Mau: Black",
            "SL: 1",
            "NgayMua: 2023-05-05",
            "ThanhTien: 25.590.000 vnd",
            "------------------------------------------------------------------",
            "MaHD: HD2",
            "NV: Hồ Ngọc Tùng",
            "TenKh: Đoàn Văn Quốc",
            "DiaChi: Thủ Đức",
            "TenSP: IPhone 13",
            "Mau: Black",
            "SL: 1",
            "NgayMua: 2023-06-02",
            "ThanhTien: 20.590.000 vnd",
            "------------------------------------------------------------------",
            "MaHD: HD3",
            "NV: Hồ Ngọc Tùng",
            "TenKh: Phạm Nhật Trường",
            "DiaChi: Thủ Đức",
            "TenSP: IPhone 12",
            "Mau: White",
            "SL: 1",
            "NgayMua: 2023-06-02",
            "ThanhTien: 18.590.000 vnd",
            "------------------------------------------------------------------",
            "MaHD: HD4",
            "NV: Hồ Ngọc Tùng",
            "TenKh: Phạm Hữu Tài",
            "DiaChi: Quận 7",
            "TenSP: IPhone 111",
            "Mau: White",
            "SL: 1",
            "NgayMua: 2023-06-02",
            "ThanhTien: 10590.000 vnd"});
            this.lb_cthd.Location = new System.Drawing.Point(235, 2);
            this.lb_cthd.Name = "lb_cthd";
            this.lb_cthd.Size = new System.Drawing.Size(776, 529);
            this.lb_cthd.TabIndex = 17;
            // 
            // Fcthdcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1014, 548);
            this.Controls.Add(this.lb_cthd);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "Fcthdcs";
            this.Text = "Fcthdcs";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_avt;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_xoa;
        private Guna.UI2.WinForms.Guna2ImageButton btn_capnhat;
        private Guna.UI2.WinForms.Guna2ImageButton btn_them;
        private Guna.UI2.WinForms.Guna2ImageButton btn_thoat;
        private System.Windows.Forms.ListBox lb_cthd;
    }
}