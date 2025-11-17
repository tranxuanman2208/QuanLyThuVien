using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{

    public partial class TrangChu : Form
    {
        public string MaNV { get; set; }
        public bool IsLoggedIn = false;
        public bool IsAdmin { get; set; } = false;
        public TrangChu()
        {
            InitializeComponent();
        }


        private void mnuTRANGCHU_Click(object sender, EventArgs e)
        {

        }

        private void mnuTAIKHOAN_Click(object sender, EventArgs e)
        {

        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            

        }


        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            ThayDoiMatKhau f = new ThayDoiMatKhau(this);
            f.ShowDialog();
        }

        private void tsbtnBANSACH_Click(object sender, EventArgs e)
        {
            BanSach f = new BanSach();
            f.ShowDialog();
        }

        private void tsbtnTHEMSACH_Click(object sender, EventArgs e)
        {
            NhapSach f = new NhapSach();
            f.ShowDialog();
            HienThiSach();
        }

        private void btnmuonsach_Click(object sender, EventArgs e)
        {
            MuonSach f = new MuonSach();
            f.ShowDialog();
        }

        private void btntrasach_Click(object sender, EventArgs e)
        {
            TraSach f = new TraSach();
            f.ShowDialog();
        }

        private void btnloaibosach_Click(object sender, EventArgs e)
        {
            LoaiBoSach f = new LoaiBoSach();
            f.ShowDialog();
        }

        private void btntimsach_Click(object sender, EventArgs e)
        {
            
        }

        private void btntimtacgia_Click(object sender, EventArgs e)
        {
            SachTheoTenTacGia f = new SachTheoTenTacGia(this);
            f.ShowDialog();
        }

        private void btntimnxb_Click(object sender, EventArgs e)
        {
            SachTheoNXB f = new SachTheoNXB(this);
            f.ShowDialog();
        }

        private void btnsoluongsach_Click(object sender, EventArgs e)
        {
            SoLuongSach f = new SoLuongSach();
            f.ShowDialog();
        }

        private void btncanhan_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan f = new ThongTinCaNhan(this);
            f.ShowDialog();
        }



        private void btnan_Click(object sender, EventArgs e)
        {
            if (BTNTIMKIEM.Visible)
            {
                BTNTIMKIEM.Visible = false;
                btnan.Text = "HIỆN THANH CÔNG CỤ";
            }
            else
            {
                BTNTIMKIEM.Visible = true;
            }
        }



        int giaoDienMode = 0;

        private void btngiaodien_Click(object sender, EventArgs e)
        {
            giaoDienMode++;

            if (giaoDienMode > 2)
                giaoDienMode = 0;

            switch (giaoDienMode)
            {
                case 0:
                    // GIAO DIỆN BÌNH THƯỜNG
                    this.BackColor = Color.Silver;
                    this.ForeColor = Color.Black;
                    menuStrip.BackColor = Color.White;
                    menuStrip.ForeColor = Color.Black;

                    BTNTIMKIEM.BackColor = Color.White;
                    BTNTIMKIEM.ForeColor = Color.Black;
                    break;

                case 1:
                    // GIAO DIỆN TỐI
                    this.BackColor = Color.DimGray;
                    this.ForeColor = Color.White;
                    menuStrip.BackColor = Color.Gray;
                    menuStrip.ForeColor = Color.White;

                    BTNTIMKIEM.BackColor = Color.Gray;
                    BTNTIMKIEM.ForeColor = Color.White;
                    break;

                case 2:
                    // GIAO DIỆN SÁNG
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    menuStrip.BackColor = Color.White;
                    menuStrip.ForeColor = Color.Black;

                    BTNTIMKIEM.BackColor = Color.White;
                    BTNTIMKIEM.ForeColor = Color.Black;
                    break;
            }
        }





        private void trangchu_Load(object sender, EventArgs e)
        {
            HienThiSach();
            CapNhatTrangThaiDangNhap();
            GoiY();
            DangNhap f = new DangNhap(this);
            f.ShowDialog();

        }
        public void CapNhatTrangThaiDangNhap()
        {
            if (IsLoggedIn)
            {
                btndangki.Visible = true;
                btndoimatkhau.Visible = true;
                btncanhan.Visible = true;
                btnKhachHang.Visible = true;
                btnNhanVien.Visible = true;

                if (!IsAdmin)
                {
                    btnDangKyNhanVien.Enabled = false;
                    btnNhanVien.Visible = false;
                    tsbtnTHEMSACH.Visible = false;
                    tsThayDoiThongTinSach.Visible = false;
                    tsBangHoaDon.Visible = false;
                }
                tssbtnSACH.Enabled = true;
                tssbtnTACGIA.Enabled = true;
                tssbtnNXB.Enabled = true;
                tssbtnMUONTRA.Enabled = true;
                tsbtnTHEMSACH.Enabled = true;
                tsbtnBANSACH.Enabled = true;
                tsTheLoai.Enabled = true;
                tsBangHoaDon.Enabled = true;
                tsThayDoiThongTinSach.Enabled = true;

                btnDangNhap_DangXuat.Text = "ĐĂNG XUẤT";
                BTNTIMKIEM.BackColor = Color.White;
            }
            else
            {
                btnKhachHang.Visible = false;
                btnNhanVien.Visible = false;
                btndangki.Visible = false;
                btndoimatkhau.Visible = false;
                btncanhan.Visible = false;
                btnDangNhap_DangXuat.Text = "ĐĂNG NHẬP";


                tssbtnSACH.Enabled = false;
                tssbtnTACGIA.Enabled = false;
                tssbtnNXB.Enabled = false;
                tssbtnMUONTRA.Enabled = false;
                tsbtnTHEMSACH.Enabled = false;
                tsbtnBANSACH.Enabled = false;
                tsTheLoai.Enabled = false;
                tsBangHoaDon.Enabled = false;
                tsThayDoiThongTinSach.Enabled = false;

                BTNTIMKIEM.BackColor = Color.LightGray;

            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            if (!IsLoggedIn)
            {
                DangNhap dn = new DangNhap(this);
                dn.ShowDialog();
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.Yes)
                {

                    IsLoggedIn = false;
                    CapNhatTrangThaiDangNhap();
                    MessageBox.Show("Đã đăng xuất!", "Thông báo");
                }
            }
        }

        private void tssbtnMUONTRA_ButtonClick(object sender, EventArgs e)
        {

        }

        private void tsbtnKIEMTRASACH_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaoDuc_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Giáo dục",this);
            f.ShowDialog();
        }

        private void btnKiemHiep_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Kiếm hiệp",this);
            f.ShowDialog();
        }

        private void btnKinhDi_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Kinh dị",this);
            f.ShowDialog();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Lịch sử",this);
            f.ShowDialog();
        }

        private void btnNgonTinh_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Ngôn tình",this);
            f.ShowDialog();
        }

        private void btnPhieuLuu_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Phiêu lưu", this);
            f.ShowDialog();
        }

        private void btnTrietHoc_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Triết học", this);
            f.ShowDialog();
        }

        private void btnTrinhTham_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Trinh thám", this);
            f.ShowDialog();
        }

        private void btnVienTuong_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Viễn tưởng", this);
            f.ShowDialog();
        }

        private void btnYHoc_Click(object sender, EventArgs e)
        {
            SachTheoTheLoai f = new SachTheoTheLoai("Y học", this);
            f.ShowDialog();
        }

        private void btnBangHoaDon_Click(object sender, EventArgs e)
        {
            BangHoaDon f = new BangHoaDon();
            f.ShowDialog();
        }

        private void txtMaSach_TenSach_Enter(object sender, EventArgs e)
        {
            if(txtMaSach_TenSach.Text == "Nhập mã sách hoặc tên sách")
            {
                txtMaSach_TenSach.Clear();
                txtMaSach_TenSach.ForeColor = Color.Black;
            }
        }

        private void txtMaSach_TenSach_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaSach_TenSach.Text))
            {
                txtMaSach_TenSach.Text = "Nhập mã sách hoặc tên sách";
                txtMaSach_TenSach.ForeColor = Color.Gray;
            }
        }
        private void GoiY()
        {
            using(DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.Saches.Where(s => s.DaXoa == false).Select(s => s.TenSach).ToArray();
                var ms = db.Saches.Where(s => s.DaXoa == false).Select(s => s.MaSach).ToArray();
                AutoCompleteStringCollection goiy = new AutoCompleteStringCollection();
                goiy.AddRange(data);
                goiy.AddRange(ms);
                txtMaSach_TenSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaSach_TenSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaSach_TenSach.AutoCompleteCustomSource = goiy;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMaSach_TenSach.Text != "Nhập mã sách hoặc tên sách")
            {
                try
                {
                    using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                    {
                        Sach data = db.Saches.FirstOrDefault(s => s.MaSach == txtMaSach_TenSach.Text.Trim() || s.TenSach == txtMaSach_TenSach.Text.Trim());
                        if(data == null)
                        {
                            MessageBox.Show("Không tìm thấy sách!", "Thông báo");
                            return;
                        }
                        Sach f = new Sach(data.MaSach, this);
                        f.ShowDialog(this);
                        txtMaSach_TenSach.Clear();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Có lỗi: {ex.Message}");
                }
            }
        }

        private void btndangki_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKyNhanVien_Click(object sender, EventArgs e)
        {
            DangKyNhanVien f = new DangKyNhanVien();
            f.ShowDialog(this);
        }

        private void btnDangKyKhachHang_Click(object sender, EventArgs e)
        {
            DangKyKhachHang f = new DangKyKhachHang();
            f.ShowDialog(this);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien f = new DanhSachNhanVien();
            f.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang f = new DanhSachKhachHang();
            f.ShowDialog();
        }

        private void tsCapNhatGiamGia_Click(object sender, EventArgs e)
        {
            CapNhatGiamGia f = new CapNhatGiamGia();
            f.ShowDialog();
        }

        private void tsThayDoiTenSach_Click(object sender, EventArgs e)
        {
            ThayDoiTenSach f = new ThayDoiTenSach();
            f.ShowDialog();
        }

        private void tsThayDoiNXB_Click(object sender, EventArgs e)
        {
            ThayDoiNXB f = new ThayDoiNXB();
            f.ShowDialog();
        }

        private void tsThayDoiThongTinSach_Click(object sender, EventArgs e)
        {

        }

        private void tsThayDoiTacGia_Click(object sender, EventArgs e)
        {
            ThayDoiTacGia f = new ThayDoiTacGia();
            f.ShowDialog();
        }

        private void tsThayDoiTheLoai_Click(object sender, EventArgs e)
        {
            ThayDoiTheLoai f = new ThayDoiTheLoai();
            f.ShowDialog();
        }
        private void HienThiSach()
        {
            listviewSach.Items.Clear();
            imgBox.Images.Clear();
            using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
            {
                var data = db.Saches.Where(p => p.DaXoa == false).Select(p => new
                {
                    MaSach = p.MaSach,
                    TenSach = p.TenSach,
                    HinhAnh = p.Img
                }).ToList();
                foreach (var sach in data)
                {
                    Image anhSach = null;
                    if (sach.HinhAnh != null && sach.HinhAnh.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(sach.HinhAnh.ToArray()))
                        {
                            anhSach = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        anhSach = new Bitmap(imgBox.ImageSize.Width, imgBox.ImageSize.Height);
                    }
                    imgBox.Images.Add(sach.MaSach, anhSach);
                    ListViewItem item = new ListViewItem();
                    item.Text = sach.TenSach;
                    item.Tag = sach.MaSach;
                    item.ImageKey = sach.MaSach;
                    listviewSach.Items.Add(item);
                }
            }
        }
        private void listviewSach_ItemActivate(object sender, EventArgs e)
        {
            if (listviewSach.Items.Count > 0)
            {
                ListViewItem item = listviewSach.Items[0];
                string masach = item.Tag.ToString();
                using (DataBaseForLibraryDataContext db = new DataBaseForLibraryDataContext())
                {
                    var data = db.Saches.Where(s => s.MaSach == masach).Select(s => s.MaSach).FirstOrDefault().ToString();
                    if (data != null)
                    {
                        Sach sach = new Sach(data, this);
                        this.Hide();
                        DialogResult rs = sach.ShowDialog(this);
                        if (rs == DialogResult.OK || rs == DialogResult.Cancel) this.Close();
                    }
                    else MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo");
                }
            }
        }
    }
}
