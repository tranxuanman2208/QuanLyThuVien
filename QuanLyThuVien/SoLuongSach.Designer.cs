namespace QuanLyThuVien
{
    partial class SoLuongSach
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
            this.GRTONKHO = new System.Windows.Forms.GroupBox();
            this.dtgvHienThi = new System.Windows.Forms.DataGridView();
            this.GRTONKHO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // GRTONKHO
            // 
            this.GRTONKHO.Controls.Add(this.dtgvHienThi);
            this.GRTONKHO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRTONKHO.Location = new System.Drawing.Point(12, 7);
            this.GRTONKHO.Name = "GRTONKHO";
            this.GRTONKHO.Size = new System.Drawing.Size(936, 442);
            this.GRTONKHO.TabIndex = 0;
            this.GRTONKHO.TabStop = false;
            this.GRTONKHO.Text = "TỒN KHO";
            // 
            // dtgvHienThi
            // 
            this.dtgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHienThi.Location = new System.Drawing.Point(3, 26);
            this.dtgvHienThi.Name = "dtgvHienThi";
            this.dtgvHienThi.RowHeadersWidth = 51;
            this.dtgvHienThi.Size = new System.Drawing.Size(930, 413);
            this.dtgvHienThi.TabIndex = 0;
            // 
            // SoLuongSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.GRTONKHO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoLuongSach";
            this.Text = "SoLuongSach";
            this.Load += new System.EventHandler(this.SoLuongSach_Load);
            this.GRTONKHO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRTONKHO;
        private System.Windows.Forms.DataGridView dtgvHienThi;
    }
}