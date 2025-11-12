namespace QuanLyThuVien
{
    partial class LichSuMuonTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDSMuon = new System.Windows.Forms.RadioButton();
            this.btnDSTra = new System.Windows.Forms.RadioButton();
            this.BangHienThi = new System.Windows.Forms.DataGridView();
            this.MASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHENTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BangHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDSMuon
            // 
            this.btnDSMuon.AutoSize = true;
            this.btnDSMuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSMuon.Location = new System.Drawing.Point(12, 5);
            this.btnDSMuon.Name = "btnDSMuon";
            this.btnDSMuon.Size = new System.Drawing.Size(170, 27);
            this.btnDSMuon.TabIndex = 5;
            this.btnDSMuon.Text = "Danh sách mượn";
            this.btnDSMuon.UseVisualStyleBackColor = true;
            this.btnDSMuon.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnDSTra
            // 
            this.btnDSTra.AutoSize = true;
            this.btnDSTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSTra.Location = new System.Drawing.Point(201, 5);
            this.btnDSTra.Name = "btnDSTra";
            this.btnDSTra.Size = new System.Drawing.Size(147, 27);
            this.btnDSTra.TabIndex = 6;
            this.btnDSTra.Text = "Danh sách trả";
            this.btnDSTra.UseVisualStyleBackColor = true;
            // 
            // BangHienThi
            // 
            this.BangHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangHienThi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.BangHienThi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BangHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASACH,
            this.TENSACH,
            this.MAKH,
            this.NGAYMUON,
            this.NGAYHENTRA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangHienThi.DefaultCellStyle = dataGridViewCellStyle2;
            this.BangHienThi.EnableHeadersVisualStyles = false;
            this.BangHienThi.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BangHienThi.Location = new System.Drawing.Point(0, 38);
            this.BangHienThi.Name = "BangHienThi";
            this.BangHienThi.ReadOnly = true;
            this.BangHienThi.RowHeadersWidth = 51;
            this.BangHienThi.RowTemplate.Height = 24;
            this.BangHienThi.Size = new System.Drawing.Size(1070, 411);
            this.BangHienThi.TabIndex = 7;
            // 
            // MASACH
            // 
            this.MASACH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MASACH.HeaderText = "Mã sách";
            this.MASACH.MinimumWidth = 6;
            this.MASACH.Name = "MASACH";
            this.MASACH.ReadOnly = true;
            this.MASACH.Width = 125;
            // 
            // TENSACH
            // 
            this.TENSACH.HeaderText = "Tên sách";
            this.TENSACH.MinimumWidth = 6;
            this.TENSACH.Name = "TENSACH";
            this.TENSACH.ReadOnly = true;
            // 
            // MAKH
            // 
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // NGAYMUON
            // 
            this.NGAYMUON.HeaderText = "Ngày mượn";
            this.NGAYMUON.MinimumWidth = 6;
            this.NGAYMUON.Name = "NGAYMUON";
            this.NGAYMUON.ReadOnly = true;
            // 
            // NGAYHENTRA
            // 
            this.NGAYHENTRA.HeaderText = "Ngày hẹn trả";
            this.NGAYHENTRA.MinimumWidth = 6;
            this.NGAYHENTRA.Name = "NGAYHENTRA";
            this.NGAYHENTRA.ReadOnly = true;
            // 
            // LichSuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.BangHienThi);
            this.Controls.Add(this.btnDSTra);
            this.Controls.Add(this.btnDSMuon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LichSuMuonTra";
            this.Text = "LichSuMuonTra";
            this.Load += new System.EventHandler(this.LichSuMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton btnDSMuon;
        private System.Windows.Forms.RadioButton btnDSTra;
        private System.Windows.Forms.DataGridView BangHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYMUON;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHENTRA;
    }
}