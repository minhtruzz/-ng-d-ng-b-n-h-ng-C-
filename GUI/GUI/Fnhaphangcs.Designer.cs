namespace GUI
{
    partial class Fnhaphangcs
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_them = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_nhapanh = new System.Windows.Forms.PictureBox();
            this.txt_nhapsoluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nhapgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nhapmau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nhapten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nhapma = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_brownse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_nhapanh)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Store_T_T;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_them
            // 
            this.btn_them.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_them.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_them.Image = global::GUI.Properties.Resources.cong_cs;
            this.btn_them.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_them.ImageRotate = 0F;
            this.btn_them.Location = new System.Drawing.Point(83, 119);
            this.btn_them.Name = "btn_them";
            this.btn_them.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_them.Size = new System.Drawing.Size(64, 64);
            this.btn_them.TabIndex = 9;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2GroupBox1.Controls.Add(this.btn_them);
            this.guna2GroupBox1.Controls.Add(this.btn_back);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Lime;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Ivory;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(-3, 173);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(227, 363);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "Chức Năng";
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.Image = global::GUI.Properties.Resources.exit_cs;
            this.btn_back.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_back.ImageRotate = 0F;
            this.btn_back.Location = new System.Drawing.Point(83, 243);
            this.btn_back.Name = "btn_back";
            this.btn_back.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.Size = new System.Drawing.Size(64, 73);
            this.btn_back.TabIndex = 8;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 536);
            this.panel1.TabIndex = 20;
            // 
            // ptb_nhapanh
            // 
            this.ptb_nhapanh.Location = new System.Drawing.Point(457, 45);
            this.ptb_nhapanh.Name = "ptb_nhapanh";
            this.ptb_nhapanh.Size = new System.Drawing.Size(139, 125);
            this.ptb_nhapanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_nhapanh.TabIndex = 19;
            this.ptb_nhapanh.TabStop = false;
            // 
            // txt_nhapsoluong
            // 
            this.txt_nhapsoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nhapsoluong.DefaultText = "";
            this.txt_nhapsoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nhapsoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nhapsoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapsoluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapsoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapsoluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nhapsoluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapsoluong.Location = new System.Drawing.Point(457, 453);
            this.txt_nhapsoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nhapsoluong.Name = "txt_nhapsoluong";
            this.txt_nhapsoluong.PasswordChar = '\0';
            this.txt_nhapsoluong.PlaceholderText = "";
            this.txt_nhapsoluong.SelectedText = "";
            this.txt_nhapsoluong.Size = new System.Drawing.Size(229, 35);
            this.txt_nhapsoluong.TabIndex = 14;
            // 
            // txt_nhapgia
            // 
            this.txt_nhapgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nhapgia.DefaultText = "";
            this.txt_nhapgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nhapgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nhapgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nhapgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapgia.Location = new System.Drawing.Point(457, 398);
            this.txt_nhapgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nhapgia.Name = "txt_nhapgia";
            this.txt_nhapgia.PasswordChar = '\0';
            this.txt_nhapgia.PlaceholderText = "";
            this.txt_nhapgia.SelectedText = "";
            this.txt_nhapgia.Size = new System.Drawing.Size(229, 35);
            this.txt_nhapgia.TabIndex = 15;
            // 
            // txt_nhapmau
            // 
            this.txt_nhapmau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nhapmau.DefaultText = "";
            this.txt_nhapmau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nhapmau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nhapmau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapmau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapmau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapmau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nhapmau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapmau.Location = new System.Drawing.Point(457, 346);
            this.txt_nhapmau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nhapmau.Name = "txt_nhapmau";
            this.txt_nhapmau.PasswordChar = '\0';
            this.txt_nhapmau.PlaceholderText = "";
            this.txt_nhapmau.SelectedText = "";
            this.txt_nhapmau.Size = new System.Drawing.Size(229, 35);
            this.txt_nhapmau.TabIndex = 16;
            // 
            // txt_nhapten
            // 
            this.txt_nhapten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nhapten.DefaultText = "";
            this.txt_nhapten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nhapten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nhapten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nhapten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapten.Location = new System.Drawing.Point(457, 291);
            this.txt_nhapten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nhapten.Name = "txt_nhapten";
            this.txt_nhapten.PasswordChar = '\0';
            this.txt_nhapten.PlaceholderText = "";
            this.txt_nhapten.SelectedText = "";
            this.txt_nhapten.Size = new System.Drawing.Size(229, 35);
            this.txt_nhapten.TabIndex = 17;
            // 
            // txt_nhapma
            // 
            this.txt_nhapma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nhapma.DefaultText = "";
            this.txt_nhapma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nhapma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nhapma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nhapma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nhapma.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nhapma.Location = new System.Drawing.Point(457, 230);
            this.txt_nhapma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nhapma.Name = "txt_nhapma";
            this.txt_nhapma.PasswordChar = '\0';
            this.txt_nhapma.PlaceholderText = "";
            this.txt_nhapma.SelectedText = "";
            this.txt_nhapma.Size = new System.Drawing.Size(229, 35);
            this.txt_nhapma.TabIndex = 18;
            // 
            // btn_brownse
            // 
            this.btn_brownse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brownse.Location = new System.Drawing.Point(474, 176);
            this.btn_brownse.Name = "btn_brownse";
            this.btn_brownse.Size = new System.Drawing.Size(99, 29);
            this.btn_brownse.TabIndex = 13;
            this.btn_brownse.Text = "Brownse...";
            this.btn_brownse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Ivory;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá Bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Màu Sản Phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ảnh:";
            // 
            // Fnhaphangcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(743, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptb_nhapanh);
            this.Controls.Add(this.txt_nhapsoluong);
            this.Controls.Add(this.txt_nhapgia);
            this.Controls.Add(this.txt_nhapmau);
            this.Controls.Add(this.txt_nhapten);
            this.Controls.Add(this.txt_nhapma);
            this.Controls.Add(this.btn_brownse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Fnhaphangcs";
            this.Text = "Fnhaphangcs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_nhapanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_them;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptb_nhapanh;
        private Guna.UI2.WinForms.Guna2TextBox txt_nhapsoluong;
        private Guna.UI2.WinForms.Guna2TextBox txt_nhapgia;
        private Guna.UI2.WinForms.Guna2TextBox txt_nhapmau;
        private Guna.UI2.WinForms.Guna2TextBox txt_nhapten;
        private Guna.UI2.WinForms.Guna2TextBox txt_nhapma;
        private System.Windows.Forms.Button btn_brownse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}