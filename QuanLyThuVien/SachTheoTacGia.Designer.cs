namespace QuanLyThuVien
{
    partial class SachTheoTenTacGia
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
            this.components = new System.ComponentModel.Container();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imagelistBox = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listviewSach = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenTG
            // 
            this.txtTenTG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.ForeColor = System.Drawing.Color.Gray;
            this.txtTenTG.Location = new System.Drawing.Point(12, 29);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(423, 34);
            this.txtTenTG.TabIndex = 2;
            this.txtTenTG.Text = "Nhập tên tác giả";
            this.txtTenTG.Enter += new System.EventHandler(this.txtTenTG_Enter);
            this.txtTenTG.Leave += new System.EventHandler(this.txtTenTG_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::QuanLyThuVien.Properties.Resources.Magnifier;
            this.btnSearch.Location = new System.Drawing.Point(464, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 37);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imagelistBox
            // 
            this.imagelistBox.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagelistBox.ImageSize = new System.Drawing.Size(100, 150);
            this.imagelistBox.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listviewSach);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTenTG);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SÁCH THEO TÁC GIẢ";
            // 
            // listviewSach
            // 
            this.listviewSach.BackColor = System.Drawing.SystemColors.Control;
            this.listviewSach.HideSelection = false;
            this.listviewSach.LargeImageList = this.imagelistBox;
            this.listviewSach.Location = new System.Drawing.Point(12, 91);
            this.listviewSach.Name = "listviewSach";
            this.listviewSach.Size = new System.Drawing.Size(600, 300);
            this.listviewSach.TabIndex = 1;
            this.listviewSach.UseCompatibleStateImageBehavior = false;
            this.listviewSach.ItemActivate += new System.EventHandler(this.listviewSach_ItemActivate);
            // 
            // SachTheoTenTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(626, 413);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SachTheoTenTacGia";
            this.Text = "Sách theo tên tác giả";
            this.Load += new System.EventHandler(this.SachTheoTenTacGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList imagelistBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listviewSach;
    }
}