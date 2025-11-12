namespace QuanLyThuVien
{
    partial class LoaiBoSach
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
            this.txtNhapSachLoaiBo = new System.Windows.Forms.TextBox();
            this.btnTimKiemLBS = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbNgayLBS = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapSachLoaiBo
            // 
            this.txtNhapSachLoaiBo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapSachLoaiBo.Location = new System.Drawing.Point(24, 39);
            this.txtNhapSachLoaiBo.Name = "txtNhapSachLoaiBo";
            this.txtNhapSachLoaiBo.Size = new System.Drawing.Size(427, 34);
            this.txtNhapSachLoaiBo.TabIndex = 10;
            this.txtNhapSachLoaiBo.Text = "Nhập tên sách hoặc mã sách";
            this.txtNhapSachLoaiBo.TextChanged += new System.EventHandler(this.txtNhapSachLoaiBo_TextChanged);
            // 
            // btnTimKiemLBS
            // 
            this.btnTimKiemLBS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemLBS.Location = new System.Drawing.Point(473, 39);
            this.btnTimKiemLBS.Name = "btnTimKiemLBS";
            this.btnTimKiemLBS.Size = new System.Drawing.Size(132, 34);
            this.btnTimKiemLBS.TabIndex = 11;
            this.btnTimKiemLBS.Text = "Tìm kiếm";
            this.btnTimKiemLBS.UseVisualStyleBackColor = true;
            this.btnTimKiemLBS.Click += new System.EventHandler(this.btnTimKiemLBS_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.White;
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(24, 93);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(581, 168);
            this.txtKQ.TabIndex = 12;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            this.txtKQ.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 34);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbNgayLBS
            // 
            this.lbNgayLBS.AutoSize = true;
            this.lbNgayLBS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLBS.Location = new System.Drawing.Point(38, 298);
            this.lbNgayLBS.Name = "lbNgayLBS";
            this.lbNgayLBS.Size = new System.Drawing.Size(236, 26);
            this.lbNgayLBS.TabIndex = 14;
            this.lbNgayLBS.Text = "Nhập ngày loại bỏ sách:";
            this.lbNgayLBS.Click += new System.EventHandler(this.lbNgayLBS_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnXacNhan.FlatAppearance.BorderSize = 2;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(207, 348);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(173, 46);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.txtKQ);
            this.groupBox1.Controls.Add(this.lbNgayLBS);
            this.groupBox1.Controls.Add(this.txtNhapSachLoaiBo);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnTimKiemLBS);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 412);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOẠI BỎ SÁCH";
            // 
            // LoaiBoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(637, 411);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoaiBoSach";
            this.Text = "Loại bỏ sách";
            this.Load += new System.EventHandler(this.LoaiBoSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhapSachLoaiBo;
        private System.Windows.Forms.Button btnTimKiemLBS;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbNgayLBS;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}