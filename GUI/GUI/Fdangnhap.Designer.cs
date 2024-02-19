namespace GUI
{
    partial class Fdangnhap
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
            this.cbo_quyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_matkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_taikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_dangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.btn_thoat = new Guna.UI2.WinForms.Guna2Button();
            this.cb_hienpass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_quyen
            // 
            this.cbo_quyen.BackColor = System.Drawing.Color.Transparent;
            this.cbo_quyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_quyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_quyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_quyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_quyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbo_quyen.ItemHeight = 30;
            this.cbo_quyen.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lí"});
            this.cbo_quyen.Location = new System.Drawing.Point(120, 459);
            this.cbo_quyen.Name = "cbo_quyen";
            this.cbo_quyen.Size = new System.Drawing.Size(236, 36);
            this.cbo_quyen.TabIndex = 19;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.DefaultText = "";
            this.txt_matkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_matkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_matkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_matkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.Location = new System.Drawing.Point(120, 372);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '\0';
            this.txt_matkhau.PlaceholderText = "Mật Khẩu";
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(236, 31);
            this.txt_matkhau.TabIndex = 17;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_taikhoan.DefaultText = "";
            this.txt_taikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_taikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_taikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_taikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.Location = new System.Drawing.Point(120, 291);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.PasswordChar = '\0';
            this.txt_taikhoan.PlaceholderText = "Tài Khoản";
            this.txt_taikhoan.SelectedText = "";
            this.txt_taikhoan.Size = new System.Drawing.Size(230, 31);
            this.txt_taikhoan.TabIndex = 18;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dangnhap.BorderColor = System.Drawing.Color.Empty;
            this.btn_dangnhap.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_dangnhap.BorderThickness = 1;
            this.btn_dangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dangnhap.FillColor = System.Drawing.Color.Lime;
            this.btn_dangnhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.Black;
            this.btn_dangnhap.Location = new System.Drawing.Point(44, 602);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(153, 42);
            this.btn_dangnhap.TabIndex = 16;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_thoat.BorderColor = System.Drawing.Color.Empty;
            this.btn_thoat.BorderThickness = 1;
            this.btn_thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thoat.FillColor = System.Drawing.Color.Red;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_thoat.Location = new System.Drawing.Point(228, 602);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(148, 42);
            this.btn_thoat.TabIndex = 20;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cb_hienpass
            // 
            this.cb_hienpass.AutoSize = true;
            this.cb_hienpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cb_hienpass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cb_hienpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_hienpass.CheckedState.BorderRadius = 0;
            this.cb_hienpass.CheckedState.BorderThickness = 0;
            this.cb_hienpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_hienpass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cb_hienpass.Location = new System.Drawing.Point(164, 527);
            this.cb_hienpass.Name = "cb_hienpass";
            this.cb_hienpass.Size = new System.Drawing.Size(119, 20);
            this.cb_hienpass.TabIndex = 21;
            this.cb_hienpass.Text = "Hiện Passwork";
            this.cb_hienpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_hienpass.UncheckedState.BorderRadius = 0;
            this.cb_hienpass.UncheckedState.BorderThickness = 0;
            this.cb_hienpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_hienpass.CheckedChanged += new System.EventHandler(this.cb_hienpass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::GUI.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 690);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Fdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 690);
            this.Controls.Add(this.cb_hienpass);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.cbo_quyen);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fdangnhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_quyen;
        private Guna.UI2.WinForms.Guna2TextBox txt_matkhau;
        private Guna.UI2.WinForms.Guna2TextBox txt_taikhoan;
        private Guna.UI2.WinForms.Guna2Button btn_dangnhap;
        private Guna.UI2.WinForms.Guna2Button btn_thoat;
        private Guna.UI2.WinForms.Guna2CheckBox cb_hienpass;
    }
}