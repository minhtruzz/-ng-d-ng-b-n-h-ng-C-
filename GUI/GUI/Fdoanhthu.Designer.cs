namespace GUI
{
    partial class Fdoanhthu
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
            this.btn_thoat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptb_avt
            // 
            this.ptb_avt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_avt.Image = global::GUI.Properties.Resources.Store_T_T;
            this.ptb_avt.Location = new System.Drawing.Point(3, -2);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Size = new System.Drawing.Size(227, 165);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 16;
            this.ptb_avt.TabStop = false;
            this.ptb_avt.Click += new System.EventHandler(this.ptb_avt_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Ivory;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Controls.Add(this.btn_thoat);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Lime;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Ivory;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 169);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(232, 399);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "Thống Kê";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.Image = global::GUI.Properties.Resources.exit_cs;
            this.btn_thoat.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_thoat.ImageRotate = 0F;
            this.btn_thoat.Location = new System.Drawing.Point(75, 159);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.Size = new System.Drawing.Size(64, 89);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Items.AddRange(new object[] {
            "Ngày: 2023-06-02",
            "Doanh Thu : 49.770.000 vnd",
            "--------------------------------------------------------------------"});
            this.listBox1.Location = new System.Drawing.Point(236, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(850, 562);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Fdoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1087, 563);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "Fdoanhthu";
            this.Text = "Fdoanhthu";
            this.Load += new System.EventHandler(this.Fdoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_avt;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_thoat;
        private System.Windows.Forms.ListBox listBox1;
    }
}