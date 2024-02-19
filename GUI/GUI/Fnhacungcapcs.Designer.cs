namespace GUI
{
    partial class Fnhacungcapcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_goi = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_email = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_thoat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgv_ncc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ptb_avt = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Ivory;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Controls.Add(this.btn_goi);
            this.guna2GroupBox1.Controls.Add(this.btn_email);
            this.guna2GroupBox1.Controls.Add(this.btn_thoat);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Lime;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Ivory;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 168);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(232, 311);
            this.guna2GroupBox1.TabIndex = 26;
            this.guna2GroupBox1.Text = "Quản Lí";
            // 
            // btn_goi
            // 
            this.btn_goi.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_goi.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_goi.Image = global::GUI.Properties.Resources.call_cspng;
            this.btn_goi.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_goi.ImageRotate = 0F;
            this.btn_goi.Location = new System.Drawing.Point(32, 103);
            this.btn_goi.Name = "btn_goi";
            this.btn_goi.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_goi.Size = new System.Drawing.Size(64, 64);
            this.btn_goi.TabIndex = 7;
            this.btn_goi.Click += new System.EventHandler(this.btn_goi_Click);
            // 
            // btn_email
            // 
            this.btn_email.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_email.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_email.Image = global::GUI.Properties.Resources.email_cs;
            this.btn_email.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_email.ImageRotate = 0F;
            this.btn_email.Location = new System.Drawing.Point(141, 103);
            this.btn_email.Name = "btn_email";
            this.btn_email.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_email.Size = new System.Drawing.Size(64, 64);
            this.btn_email.TabIndex = 7;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.Image = global::GUI.Properties.Resources.exit_cs;
            this.btn_thoat.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_thoat.ImageRotate = 0F;
            this.btn_thoat.Location = new System.Drawing.Point(82, 217);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_thoat.Size = new System.Drawing.Size(64, 70);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_ncc
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_ncc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ncc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ncc.ColumnHeadersHeight = 20;
            this.dgv_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ncc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ncc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ncc.Location = new System.Drawing.Point(238, 4);
            this.dgv_ncc.Name = "dgv_ncc";
            this.dgv_ncc.RowHeadersVisible = false;
            this.dgv_ncc.RowHeadersWidth = 51;
            this.dgv_ncc.RowTemplate.Height = 24;
            this.dgv_ncc.Size = new System.Drawing.Size(1060, 475);
            this.dgv_ncc.TabIndex = 28;
            this.dgv_ncc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ncc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_ncc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_ncc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_ncc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_ncc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ncc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ncc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_ncc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ncc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ncc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_ncc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_ncc.ThemeStyle.HeaderStyle.Height = 20;
            this.dgv_ncc.ThemeStyle.ReadOnly = false;
            this.dgv_ncc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_ncc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ncc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ncc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_ncc.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_ncc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_ncc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ptb_avt
            // 
            this.ptb_avt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_avt.Image = global::GUI.Properties.Resources.Store_T_T;
            this.ptb_avt.Location = new System.Drawing.Point(5, -3);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Size = new System.Drawing.Size(227, 171);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 27;
            this.ptb_avt.TabStop = false;
            // 
            // Fnhacungcapcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 483);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgv_ncc);
            this.Controls.Add(this.ptb_avt);
            this.Name = "Fnhacungcapcs";
            this.Text = "Fnhacungcapcs";
            this.Load += new System.EventHandler(this.Fnhacungcapcs_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_goi;
        private Guna.UI2.WinForms.Guna2ImageButton btn_email;
        private Guna.UI2.WinForms.Guna2ImageButton btn_thoat;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_ncc;
        private System.Windows.Forms.PictureBox ptb_avt;
    }
}