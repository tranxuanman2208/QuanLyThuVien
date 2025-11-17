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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDSMuon = new System.Windows.Forms.RadioButton();
            this.btnDSTra = new System.Windows.Forms.RadioButton();
            this.BangHienThi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BangHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDSMuon
            // 
            this.btnDSMuon.AutoSize = true;
            this.btnDSMuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSMuon.Location = new System.Drawing.Point(12, 5);
            this.btnDSMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnDSMuon.Name = "btnDSMuon";
            this.btnDSMuon.Size = new System.Drawing.Size(170, 27);
            this.btnDSMuon.TabIndex = 5;
            this.btnDSMuon.Text = "Danh sách mượn";
            this.btnDSMuon.UseVisualStyleBackColor = true;
            this.btnDSMuon.CheckedChanged += new System.EventHandler(this.btnDSMuon_CheckedChanged);
            // 
            // btnDSTra
            // 
            this.btnDSTra.AutoSize = true;
            this.btnDSTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSTra.Location = new System.Drawing.Point(201, 5);
            this.btnDSTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnDSTra.Name = "btnDSTra";
            this.btnDSTra.Size = new System.Drawing.Size(147, 27);
            this.btnDSTra.TabIndex = 6;
            this.btnDSTra.Text = "Danh sách trả";
            this.btnDSTra.UseVisualStyleBackColor = true;
            this.btnDSTra.CheckedChanged += new System.EventHandler(this.btnDSTra_CheckedChanged);
            // 
            // BangHienThi
            // 
            this.BangHienThi.AllowUserToOrderColumns = true;
            this.BangHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangHienThi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.BangHienThi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BangHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangHienThi.DefaultCellStyle = dataGridViewCellStyle4;
            this.BangHienThi.EnableHeadersVisualStyles = false;
            this.BangHienThi.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BangHienThi.Location = new System.Drawing.Point(0, 38);
            this.BangHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.BangHienThi.Name = "BangHienThi";
            this.BangHienThi.RowHeadersWidth = 51;
            this.BangHienThi.RowTemplate.Height = 24;
            this.BangHienThi.Size = new System.Drawing.Size(1070, 411);
            this.BangHienThi.TabIndex = 7;
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LichSuMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỊCH SỬ MƯỢN TRẢ";
            this.Load += new System.EventHandler(this.LichSuMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton btnDSMuon;
        private System.Windows.Forms.RadioButton btnDSTra;
        private System.Windows.Forms.DataGridView BangHienThi;
    }
}