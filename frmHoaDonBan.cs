using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
namespace _29_30_CuaHangSach
{
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        // ------------------------------------------------- KHAI BÁO  ------------------------------------------------------
        clsWebBanSach hdb = new clsWebBanSach();
        DataSet ds = new DataSet();
        DataSet dsnv = new DataSet();
        DataSet dskh = new DataSet();
        DataSet dssp = new DataSet();
        DataSet dsct = new DataSet();
        DataSet sanpham = new DataSet();
        int flag = 0;
        Boolean f = false;
        int index = 0;
        double tongtienhoadon = 0;
        Boolean hdmoi = false;
        string makhachhang;
        public string tenNhanVien;
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuLyTextBox(true);
            danhsach_datagridview(dgvDanhSach, "select * from HoaDonBan");

            dsnv = hdb.layDuLieu("select * from NhanVien where trangthai = '0'");
            hienthi_combobox(cboMaNhanVien, dsnv, "tennv", "manv");

            dssp = hdb.layDuLieu("select * from SanPham where trangthai = '0'");

            danhsach_datagridview_2(dgvDanhSachChiTiet, "select * from ChiTietBan");
            f = true;

        }

        // ---------------------------------------------  DANH SÁCH CÁC HÀM  ------------------------------------
        // HÀM LẤY DỮ LIỆU
        void danhsach_datagridview(DataGridView d, string sql)
        {
            dgvDanhSach.Columns.Clear();
            ds = hdb.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        // HÀM LẤY DỮ LIỆU CHI TIẾT
        void danhsach_datagridview_2(DataGridView d, string sql)
        {
            dgvDanhSachChiTiet.Columns.Clear();
            dsct = hdb.layDuLieu(sql);
            d.DataSource = dsct.Tables[0];
        }
        // HÀM XỬ LÝ NÚT
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSuaCT.Enabled = !t;
            btnXoaCT.Enabled = !t;
            btnLuu.Enabled = !t;
            btnHuy.Enabled = !t;
            btnThemCT.Enabled = !t;
            btnSuaHoaDon.Enabled = t;
        }
        // HÀM XỬ LÝ TEXTBOX
        void xuLyTextBox(Boolean t)
        {

        }
        // HÀM HIỂN THỊ TEXTBOX
        void hienthi_textbox(DataSet ds, int vt)
        {

            if (index > -1 && index < ds.Tables[0].Rows.Count)

            {
                lblMaHDB.Text = ds.Tables[0].Rows[vt]["mahdb"].ToString();
                if(cboMaNhanVien.SelectedIndex == -1)
                {
                    cboMaNhanVien.Text = tenNhanVien;
                }
                else
                {
                    cboMaNhanVien.Text = ds.Tables[0].Rows[vt]["manv"].ToString();
                }
                
                lblKhachHang.Text = ds.Tables[0].Rows[vt]["makh"].ToString();
                dtpNgayLap.Text = ds.Tables[0].Rows[vt]["ngaylap"].ToString();
                lblThanhTien.Text = ds.Tables[0].Rows[vt]["thanhtien"].ToString();
                dskh = hdb.layDuLieu("select * from KhachHang where makh = '" + lblKhachHang.Text + "'");
                txtSDTKhachHang.Text = dskh.Tables[0].Rows[0]["sdt"].ToString();
                
                string manv = ds.Tables[0].Rows[vt]["manv"].ToString();
                locdl_theodataview(dsnv, cboMaNhanVien, "manv", "tennv", manv);
                if (dskh.Tables[0].Rows.Count > 0)
                {
                    lblKhachHang.Text = dskh.Tables[0].Rows[0]["tenkh"].ToString();
                }
                load_cthdBtheoMaHDB(ds.Tables[0].Rows[vt]["mahdb"].ToString());
                if (ds.Tables[0].Rows[vt]["trangthai"].ToString() == "0")
                {
                    cboTrangThai.Text = "Đã thanh toán";
                }
                if (ds.Tables[0].Rows[vt]["trangthai"].ToString() == "1")
                {
                    cboTrangThai.Text = "Thanh toán khi nhận hàng";
                }
                if(ds.Tables[0].Rows[vt]["trangthai"].ToString() == "2")
                {
                    cboTrangThai.Text = "Đã trả hàng";
                }
            }
        }
        // HÀM HIỂN THỊ TEXTBOX CTHD
        void hienthi_textbox_cthd(DataGridView dsct, int vtct)
        {
            //if (index > -1 && index < dsct.Tables[0].Rows.Count)
            //{
            //    lblMaCTHoaDonBan.Text = dsct.Tables[0].Rows[vtct]["mactban"].ToString();
                
            //    txtSoLuongCT.Text = dsct.Tables[0].Rows[vtct]["soluong"].ToString();
            //    lblGiaTienSanPham.Text = dsct.Tables[0].Rows[vtct]["giaban"].ToString();
            //    lblTongTienSanPham.Text = dsct.Tables[0].Rows[vtct]["thanhtien"].ToString();
            //    string masp = dsct.Tables[0].Rows[vtct]["masp"].ToString();
            //    sanpham = hdb.layDuLieu("select * from SanPham where masp = '"+masp+"'");

            //    string tenhinh = sanpham.Tables[0].Rows[0]["hinhanh"].ToString();
            //    string tenFile = Path.GetFullPath("img_WebBanSach") + @"\" + tenhinh;

            //    taoanh_tufileanh(picHinhAnh, tenFile);
            //}
            if (dsct.Rows.Count == 0 || vtct < 0 || vtct >= dsct.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = dsct.Rows[vtct];
            if (row != null && row.Cells.Count >= 6 && row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null)
            {
                lblMaCTHoaDonBan.Text = row.Cells[0].Value.ToString();
                lblMaHDB.Text = row.Cells[1].Value.ToString();
                txtSanPham.Text = row.Cells[2].Value.ToString();
                txtSoLuongCT.Text = row.Cells[4].Value.ToString();
                lblGiaTienSanPham.Text = row.Cells[3].Value.ToString();
                lblTongTienSanPham.Text = row.Cells[5].Value.ToString();


                DataSet dsSP = new DataSet();
                dsSP = hdb.layDuLieu("select * from SanPham where masp='" + txtSanPham.Text + "'");
                if (dsSP.Tables[0].Rows.Count > 0)
                {
                    lblTenSp.Text = dsSP.Tables[0].Rows[0]["tensp"].ToString();

                    if (dsSP.Tables[0].Rows[0]["hinhanh"] != null)
                    {
                        string tenhinh = dsSP.Tables[0].Rows[0]["hinhanh"].ToString();
                        string tenFile = Path.GetFullPath("img_WebBanSach") + @"\" + tenhinh;
                        taoanh_tufileanh(picHinhAnh, tenFile);
                    }
                }
            }
        }
        // HÀM LỌC TÊN THEO MÃ
        void locdl_theodataview(DataSet ds, ComboBox cbo, string ma, string ten, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "= '" + giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }
        // HÀM HIỂN THỊ COMBOBOX
        void hienthi_combobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;

        }

        // HÀM TÌM KIẾM KHÁCH HÀNG THEO SỐ ĐIỆN THOẠI
        Boolean timKhachHang()
        {
            DataSet dssdt = new DataSet();
            dssdt = hdb.layDuLieu("select * from KhachHang where sdt = '"+ txtSDTKhachHang.Text +"'");
            if (dssdt.Tables[0].Rows.Count > 0)
            {
                makhachhang = dssdt.Tables[0].Rows[0]["makh"].ToString();
                lblKhachHang.Text = dssdt.Tables[0].Rows[0]["tenkh"].ToString();
                return true;
            }
            return false;
        }

        // HÀM TẠO ẢNH
        void taoanh_tufileanh(PictureBox p, string filename)
        {
            Bitmap a = new Bitmap(filename);
            p.Image = a;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // HÀM LOAD CHI TIẾT HOÁ ĐƠN BÁN
        void load_cthdBtheoMaHDB(string mahdb)
        {
            string sql = "select * from ChiTietBan where mahdb ='" + mahdb + "'";
            dsct = hdb.layDuLieu(sql);
            dgvDanhSachChiTiet.DataSource = null;
            dgvDanhSachChiTiet.Columns.Clear();
            dgvDanhSachChiTiet.DataSource = dsct.Tables[0];
        }
        // HÀM TẠO CỘT CTHD BÁN
        void taocotcthdb()
        {
            dgvDanhSachChiTiet.Columns.Clear();
            dgvDanhSachChiTiet.Columns.Add("mactban", "Mã CTHDB");
            dgvDanhSachChiTiet.Columns.Add("mahdb", "Mã HDB");
            dgvDanhSachChiTiet.Columns.Add("masp", "Mã SP");
            dgvDanhSachChiTiet.Columns.Add("giaban", "Giá Bán");

            dgvDanhSachChiTiet.Columns.Add("soluong", "Số Lượng");
            dgvDanhSachChiTiet.Columns.Add("thanhtien", "Giá Tiền");
        }
        // HÀM TẠO HÀM HD NHẬP
        void taocothoadonban()
        {
            //dgvDanhSach.Columns.Clear();
            dgvDanhSach.Columns.Add("mahdb", "Mã HDN");
            dgvDanhSach.Columns.Add("manv", "Mã NV");
            dgvDanhSach.Columns.Add("mankh", "Mã KH");
            dgvDanhSach.Columns.Add("ngaylap", "Ngày Lập");
            dgvDanhSach.Columns.Add("thanhtien", "Tổng tiền");
            dgvDanhSach.Columns.Add("trangthai", "Trạng thái");
        }
        // HÀM PHÁT SINH MÃ HOÁ ĐƠN BÁN
        string phatSinhMa()
        {
            string ma = "";
            DataSet dshdb = hdb.layDuLieu("select mahdb from HoaDonBan");
            if (ds.Tables[0].Rows.Count >= 9)
            {
                ma = "HB" + (dshdb.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                ma = "HB0" + (dshdb.Tables[0].Rows.Count + 1).ToString();
            }
            return ma;
        }
        // HÀM LÀM SẠCH DỮ LIỆU
        void xoadulieu()
        {
            lblThanhTien.Text = "";
            lblMaCTHoaDonBan.Text = "";
            lblMaHDB.Text = "";
            txtSoLuongCT.Text = "";
            lblThanhTien.Text = "";
            lblKhachHang.Text = "";
            cboMaNhanVien.Text = "";
            dtpNgayLap.Text = "";
            lblTongTienSanPham.Text = "";
            cboTrangThai.Text = "";
            txtSDTKhachHang.Text = "";
            lblGiaTienSanPham.Text = "";
            dtpNgayLap.Text = "";
            lblMaCTHoaDonBan.Text = "";
            lblTenSp.Text = "";
        }

        

        
        // ---------------------------------------------------- XỬ LÝ CÁC NÚT  -----------------------------------------
        // NÚT THÊM HOÁN ĐƠN BÁN
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            xoadulieu();
            xuLyChucNang(false);
            xuLyTextBox(false);
            lblMaHDB.Text = phatSinhMa();
            hienthi_combobox(cboMaNhanVien, dsnv, "tennv", "manv");
            dgvDanhSach.DataSource = null;
            dgvDanhSachChiTiet.DataSource = null;
            //hienthi_textbox(ds, index);
            taocotcthdb();
            taocothoadonban();
            hdmoi = true;
            
        }
        // NÚT LƯU HOÁ ĐƠN BÁN
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //xuLyChucNang(true);
            //xuLyTextBox(false);
            if (cboMaNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                cboMaNhanVien.Focus();
                return;
            }
            if (txtSDTKhachHang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập sdt khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtSDTKhachHang.Focus();
                return;
            }
            if (cboTrangThai.SelectedIndex ==  -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                cboTrangThai.Focus();
                return;
            }
            string mahdb = lblMaHDB.Text;
            string manv = cboMaNhanVien.SelectedValue.ToString();
            string ngaylap = dtpNgayLap.Value.ToString();
            string thanhtien = lblThanhTien.Text;
            string trangthai = cboTrangThai.SelectedIndex.ToString();
            //int soluong = int.Parse(txtSoLuongCT.ToString());
            string sql = "";
            if (flag == 1)
            {
                
                sql = "insert into HoaDonBan values('" + mahdb + "','" + manv + "','" + makhachhang + "','" + ngaylap + "','" + thanhtien + "','" + trangthai + "')";
                if (hdb.capNhatDuLieu(sql) > 0)
                {
                    foreach (DataGridViewRow r in dgvDanhSachChiTiet.Rows)
                    {
                        
                        if (r.Cells[0].Value == null)
                        {
                            break;
                        }
                        //string loaiHoaDon = cboTrangThai.SelectedIndex.ToString();
                        string sqlcthdb = "insert into ChiTietBan values('" + r.Cells[0].Value.ToString() + "','" + r.Cells[1].Value.ToString() + "','";
                        sqlcthdb += r.Cells[2].Value.ToString() + "','" + r.Cells[3].Value.ToString() + "','" + r.Cells[4].Value.ToString() + "','" + r.Cells[5].Value.ToString() +"')";
                        if (hdb.capNhatDuLieu(sqlcthdb) > 0)
                        {
                            string masp = r.Cells[2].Value.ToString();
                            string sqlupdateSL;
                            if (cboTrangThai.SelectedIndex == 2 )
                            {
                                sqlupdateSL = "update SanPham set soluong = soluong + " + r.Cells[4].Value.ToString() + "where masp='" + masp + "'";
                                
                            }
                            else
                            {
                                sqlupdateSL = "update SanPham set soluong = soluong - " + r.Cells[4].Value.ToString() + "where masp='" + masp + "'";
                            }
                            hdb.capNhatDuLieu(sqlupdateSL);
                            MessageBox.Show("Cập nhật thành công!");
                            frmHoaDonBan_Load(sender, e);
                        }
                    }
                }
                flag = 0;
            }
            if (flag == 2)
            {
                sql = "insert into HoaDonBan values('" + mahdb + "','" + manv + "','" + makhachhang + "','" + ngaylap + "','" + thanhtien + "','" + trangthai + "')";
                if (hdb.capNhatDuLieu(sql) > 0)
                {
                    foreach (DataGridViewRow r in dgvDanhSachChiTiet.Rows)
                    {
                        if (cboMaNhanVien.SelectedIndex == -1)
                        {
                            MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyChucNang(false);
                            cboMaNhanVien.Focus();
                            return;
                        }
                        if (txtSDTKhachHang.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập sdt khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyChucNang(false);
                            txtSDTKhachHang.Focus();
                            return;
                        }
                        
                        if (r.Cells[0].Value == null)
                        {
                            break;
                        }
                        //string loaiHoaDon = cboTrangThai.SelectedIndex.ToString();
                        string sqlcthdb = "insert into ChiTietBan values('" + r.Cells[0].Value.ToString() + "','" + r.Cells[1].Value.ToString() + "','";
                        sqlcthdb += r.Cells[2].Value.ToString() + "','" + r.Cells[3].Value.ToString() + "','" + r.Cells[4].Value.ToString() + "','" + r.Cells[5].Value.ToString() + "')";
                        if (hdb.capNhatDuLieu(sqlcthdb) > 0)
                        {
                            string masp = r.Cells[2].Value.ToString();
                            string sqlupdateSL;
                            if (cboTrangThai.SelectedIndex == 2)
                            {
                                sqlupdateSL = "update SanPham set soluong = soluong + " + r.Cells[4].Value.ToString() + "where masp='" + masp + "'";

                            }
                            else
                            {
                                sqlupdateSL = "update SanPham set soluong = soluong - " + r.Cells[4].Value.ToString() + "where masp='" + masp + "'";
                            }
                            hdb.capNhatDuLieu(sqlupdateSL);
                            MessageBox.Show("Cập nhật thành công!");
                            frmHoaDonBan_Load(sender, e);
                        }
                    }
                }
                flag = 0;

            }


            if (flag == 3)
            {
                sql = "update HoaDonBan set trangthai = '" + trangthai + "',thanhtien=" + thanhtien + "where mahdb='" + mahdb + "'";
                if (hdb.capNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    string sqltruslcu = "";
                    foreach (DataGridViewRow row in dgvDanhSachChiTiet.Rows)
                    {
                        if (row.Cells[0].Value == null)
                        {
                            return;
                        }
                        if (trangthai == "1")
                        {
                            DataSet ds = new DataSet();
                            ds = hdb.layDuLieu("select * from ChiTietBan where mactban ='" + row.Cells[0].Value + "'");
                            string soluongcu = ds.Tables[0].Rows[0]["soluong"].ToString();
                            sqltruslcu = "update SanPham set soluong = soluong + " + soluongcu + "where masp ='" + row.Cells[2].Value + "'";

                            if (hdb.capNhatDuLieu(sqltruslcu) > 0)
                            {
                                if (row.Cells[0].Value != null && row.Cells[1].Value.ToString() == lblMaHDB.Text) // Kiểm tra giá trị của ô đầu tiên của hàng
                                {

                                    string masp = row.Cells[2].Value.ToString();
                                    string soluong = row.Cells[4].Value.ToString();
                                    string sqlupdateSL = "update SanPham set soluong=soluong - " + soluong + "where masp='" + masp + "'";
                                    hdb.capNhatDuLieu(sqlupdateSL);
                                    MessageBox.Show("Cập nhật thành công!");

                                    string sqlupdatechitiet = "update ChiTietBan set soluong = " + row.Cells[4].Value + ",thanhtien =" + row.Cells[5].Value + " where mactban = '" + row.Cells[0].Value + "'";
                                    hdb.capNhatDuLieu(sqlupdatechitiet);
                                    MessageBox.Show("Cập nhật thành công!");
                                }
                            }
                        }

                        string masp2 = row.Cells[2].Value.ToString();
                        string sqlupdateSL2;
                        if (trangthai == "0")
                        {

                            sqlupdateSL2 = "update SanPham set soluong = soluong + " + row.Cells[4].Value.ToString() + "where masp='" + masp2 + "'";
                            hdb.capNhatDuLieu(sqlupdateSL2);
                            MessageBox.Show("Cập nhật thành công!");
                        }


                    }
                    xuLyChucNang(true);
                    xuLyTextBox(false);
                    frmHoaDonBan_Load(sender, e);

                }
                flag = 0;
            }
        }
        // NÚT SỬA HOÁ ĐƠN BÁN
        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnThemCT.Enabled = false;
            if (txtSanPham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtSanPham.Focus();
                return;
            }
            if (txtSoLuongCT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtSoLuongCT.Focus();
                return;
            }
        }
        // NÚT HUỲ HOÁ ĐƠN BÁN
        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xoadulieu();
            danhsach_datagridview(dgvDanhSach, "select * from HoaDonBan ");

            
            danhsach_datagridview_2(dgvDanhSachChiTiet, "select * from ChiTietBan");
        }
        
        // NÚT THOÁT HOÁ ĐƠN BÁN
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
        // NÚT LỌC DANH SÁCH HOÁN ĐƠN BÁN THEO NGÀY
        private void btnLocTheoNgay_Click(object sender, EventArgs e)
        {

        }
        // NÚT TÌM KIẾM KHÁCH HÀNG THEO SỐ ĐIỆN THOẠI
        private void btnTimKH_Click(object sender, EventArgs e)
        {
                if (txtSDTKhachHang.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtSDTKhachHang.Focus();
                }
                foreach (char c in txtSDTKhachHang.Text)
                {
                    if (char.IsLetter(c) == true)
                    {
                        txtSDTKhachHang.Text = "Nhập dữ liệu sai";
                        MessageBox.Show("Nhập dữ liệu số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                   
                }
                if(txtSDTKhachHang.Text != "")
                {
                    if (!timKhachHang())
                    {
                        MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
           
        }

        // NÚT THÊM CTHD BÁN

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (txtSanPham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtSanPham.Focus();
                return;
            }
            if(txtSoLuongCT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtSoLuongCT.Focus();
                return;
            }
            DataSet dsspct = new DataSet();
            double thanhtien;
            thanhtien = Convert.ToDouble(txtSoLuongCT.Text) * Convert.ToDouble(lblGiaTienSanPham.Text);
            object[] d = new object[7];
            d[0] = lblMaCTHoaDonBan.Text;
            d[1] = lblMaHDB.Text;
            d[2] = txtSanPham.Text;
            d[3] = lblGiaTienSanPham.Text;
            d[4] = txtSoLuongCT.Text;
            d[5] = thanhtien.ToString();
            dsspct = hdb.layDuLieu("select * from SanPham where masp = '" + d[2] + "'");
            int soluongsp = int.Parse(dsspct.Tables[0].Rows[index]["soluong"].ToString());

            int soluongton = soluongsp - int.Parse(txtSoLuongCT.Text);

            if (soluongton >= 0)
            {
                dgvDanhSachChiTiet.Rows.Add(d);
                tongtienhoadon += thanhtien;
                lblThanhTien.Text = tongtienhoadon.ToString();
                if (hdmoi)
                {
                    object[] h = new object[6];
                    h[0] = lblMaHDB.Text;
                    h[1] = cboMaNhanVien.SelectedValue.ToString();
                    h[2] = makhachhang;
                    h[3] = dtpNgayLap.Value;
                    h[4] = lblThanhTien.Text;
                    h[5] = "1";
                    dgvDanhSach.Rows.Add(h);

                    lblMaCTHoaDonBan.Text = "";
                    txtSanPham.Text = "";
                    txtSoLuongCT.Text = "";
                    lblGiaTienSanPham.Text = "";
                    lblTongTienSanPham.Text = "";
                    lblTenSp.Text = "";

                    hdmoi = false;
                }
                else
                {
                    dgvDanhSach.Rows[0].Cells[4].Value = lblThanhTien.Text;
                }
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lẽ. Sản phẩm chỉ còn " + soluongsp + " cuốn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtSoLuongCT.Focus();
            }
            
          
        }
        // NÚT THÊM KHÁCH HÀNG
        private void btnThemKh_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();

            frmKhachHang.ShowDialog();
        }
        // ------------------------------------------------- CÁC SỰ KIỆN   -------------------------------------------
        // 
        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (f)
            //    if (cboMaNhanVien.SelectedIndex != -1)
            //    {
            //        string manv = cboMaNhanVien.SelectedValue.ToString();
            //        dsnv = hdb.layDuLieu("select * from HoaDonBan where manv = '" + manv + "'");
            //        hienthi_combobox(cboMaNhanVien, dsnv, "tennv", "manv");
            //    }
        }
        //
        
        //
        
        // CLICK CELL
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
            if(cboTrangThai.Text == "Đã trả hàng")
            {
                btnSuaHoaDon.Enabled = false;
            }
            else
            {
                btnSuaHoaDon.Enabled = true;
                
            }
            
        }
        // CLICK CELL CTHD
        private void dgvDanhSachChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox_cthd(dgvDanhSachChiTiet, index);
            
        }
        // TỰ ĐỘNG TÍNH TIỀN
        private void txtSoLuongCT_KeyDown(object sender, KeyEventArgs e)
        {
            if(flag == 1)
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        double tongtien = Convert.ToDouble(lblGiaTienSanPham.Text) * Convert.ToDouble(txtSoLuongCT.Text);
                        lblTongTienSanPham.Text = tongtien.ToString();
                        e.SuppressKeyPress = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtSoLuongCT.Focus();
                }
            }

            if(flag == 2 || flag == 3)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        double giaTien = Convert.ToDouble(lblGiaTienSanPham.Text);
                        double soLuong = Convert.ToDouble(txtSoLuongCT.Text);

                        foreach (DataGridViewRow row in dgvDanhSachChiTiet.Rows)
                        {
                            if (row.Index == 0 && row.Cells[0].Value == null) // Kiểm tra hàng đầu tiên có giá trị null không
                            {
                                row.Cells[0].Value = lblMaCTHoaDonBan.Text;
                            }

                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == lblMaCTHoaDonBan.Text) // Kiểm tra giá trị của ô đầu tiên của hàng
                            {
                                double tongtien = giaTien * soLuong;
                                row.Cells[3].Value = giaTien.ToString();
                                row.Cells[4].Value = soLuong.ToString();
                                row.Cells[5].Value = tongtien.ToString();

                                lblTongTienSanPham.Text = tongtien.ToString();
                            }
                        }
                    }
                    catch (FormatException ex)
                    {
                        // Xử lý lỗi khi người dùng nhập vào chuỗi không hợp lệ
                        MessageBox.Show("Vui lòng nhập số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    e.SuppressKeyPress = true;
                }
            }


           
        }
        // ---------------------------------------------------  BẪY LỖI  ----------------------------------------------

        // SỐ ĐIỆN THOẠI
        private void txtSDTKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }

        }
        // SỐ LƯỢNG
        private void txtSoLuongCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }


        // ---------------------------------------------- FORMCLOSSING ---------------------------------------------------
        private void frmHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgHoiThoat;
            dlgHoiThoat = MessageBox.Show("Bạn có chắc thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiThoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            if (dgvDanhSachChiTiet.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow r = dgvDanhSachChiTiet.SelectedRows[0];
                    dgvDanhSachChiTiet.Rows.Remove(r);
                    dgvDanhSachChiTiet.EndEdit();

                    int sum = 0;
                    foreach (DataGridViewRow row in dgvDanhSachChiTiet.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            int quantity = Convert.ToInt32(row.Cells[4].Value); // Lấy giá trị số lượng
                            int price = Convert.ToInt32(row.Cells[3].Value); // Lấy giá trị đơn giá
                            int total = quantity * price; // Tính tổng tiền của sản phẩm
                            row.Cells[5].Value = total; // Cập nhật giá trị tổng tiền vào cột Tổng tiền
                            sum += total; // Cộng tổng tiền của sản phẩm vào tổng tiền hóa đơn
                            if (row.Cells[3].Value != null)
                            {
                                txtSoLuongCT.Text = row.Cells[3].Value.ToString();
                            }
                            lblTongTienSanPham.Text = total.ToString(); // Hiển thị tổng tiền hóa đơn
                        }

                    }
                    lblThanhTien.Text = sum.ToString(); // Hiển thị tổng tiền hóa đơn
                    dgvDanhSach.Rows[0].Cells[4].Value = sum.ToString();
                }
            }
        }

        private void dgvDanhSachChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 1 || flag == 2 || flag == 3)
            {
                if (e.ColumnIndex == 4)
                {
                    int sum = 0;

                    foreach (DataGridViewRow row in dgvDanhSachChiTiet.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            int quantity = Convert.ToInt32(row.Cells[4].Value); // Lấy giá trị số lượng
                            int price = Convert.ToInt32(row.Cells[3].Value); // Lấy giá trị đơn giá
                            int total = quantity * price; // Tính tổng tiền của sản phẩm
                            row.Cells[5].Value = total; // Cập nhật giá trị tổng tiền vào cột Tổng tiền
                            sum += total; // Cộng tổng tiền của sản phẩm vào tổng tiền hóa đơn
                            if (row.Cells[3].Value != null)
                            {
                                txtSoLuongCT.Text = row.Cells[4].Value.ToString();
                            }
                            lblTongTienSanPham.Text = total.ToString(); // Hiển thị tổng tiền hóa đơn
                        }

                    }
                    lblThanhTien.Text = sum.ToString(); // Hiển thị tổng tiền hóa đơn
                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == lblMaHDB.Text)
                            row.Cells[4].Value = sum.ToString();

                    }
                }

            }
        }

        private void txtSanPham_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string masp = txtSanPham.Text;
                    dssp = hdb.layDuLieu("Select * from SanPham where masp ='" + masp + "'");
                    txtSanPham.Text = dssp.Tables[0].Rows[0]["masp"].ToString();
                    lblGiaTienSanPham.Text = dssp.Tables[0].Rows[0]["gianhap"].ToString(); ;
                    lblTenSp.Text = dssp.Tables[0].Rows[0]["tensp"].ToString();
                    string mahdn = lblMaHDB.Text;
                    lblMaCTHoaDonBan.Text = mahdn + masp;

                    string tenhinh = dssp.Tables[0].Rows[0]["hinhanh"].ToString();
                    string tenFile = Path.GetFullPath("img_WebBanSach") + @"\" + tenhinh;
                    taoanh_tufileanh(picHinhAnh, tenFile);

                }
                catch(Exception) {
                    MessageBox.Show("Mã sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbDSHDB_Enter(object sender, EventArgs e)
        {

        }

        private void grpDSCTHDB_Enter(object sender, EventArgs e)
        {

        }

        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            frmTimkiemNhanVien frmTimkiemNhanVien = new frmTimkiemNhanVien();
            frmTimkiemNhanVien.ShowDialog();
            cboMaNhanVien.Text = frmTimkiemNhanVien.tenNhanVien;
        }

        private void dgvDanhSachChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            hienthi_textbox(ds, index);
            if (cboTrangThai.Text == "Đã thanh toán")
            {
                btnXoaCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnThemCT.Enabled = false;
            }
            flag = 3;
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrangThai.SelectedIndex == 2)
            {
                btnXoaCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnThemCT.Enabled = false;
                dtpNgayLap.Enabled = false;
                cboMaNhanVien.Enabled = false;
                txtSoLuongCT.Enabled = false;
                btnThemKh.Enabled = false;
                btnTimNhanVien.Enabled = false;
                lblTenSp.Enabled = false;
                cboTrangThai.Enabled = false;
            }

            //if (cboTrangThai.SelectedIndex == 1)
            //{

            //    btnXoaCT.Enabled = false;
            //    btnSuaCT.Enabled = false;
            //    btnThemCT.Enabled = false;
            //    dtpNgayLap.Enabled = false;
            //    cboMaNhanVien.Enabled = false;
            //    txtSoLuongCT.Enabled = true;
            //    btnThemKh.Enabled = false;
            //    btnTimNhanVien.Enabled = false;
            //    txtSanPham.Enabled = false;
            //    cboTrangThai.Enabled = true;

            //}

        /*    if (cboTrangThai.SelectedIndex == 0)
            {

                btnXoaCT.Enabled = false;
                btnSuaCT.Enabled = false;
                btnThemCT.Enabled = false;
                dtpNgayLap.Enabled = false;
                cboMaNhanVien.Enabled = false;
                txtSoLuongCT.Enabled = true;
                btnThemKh.Enabled = false;
                btnTimNhanVien.Enabled = false;
                lblTenSp.Enabled = false;
                cboTrangThai.Enabled = true;
            }*/
        }

        private void dgvDanhSachChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvDanhSachChiTiet.SelectedCells.Count > 0)
            //{
            //    int rowIndex = dgvDanhSachChiTiet.SelectedCells[0].RowIndex;
            //    dgvDanhSachChiTiet.Rows[rowIndex].Selected = true;
            //}
        }

        private void txtSoLuongCT_TextChanged(object sender, EventArgs e)
        {
            if(txtSoLuongCT.Text == "0")
            {
                MessageBox.Show("Số lượng phải lớn hơn 0","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongCT.Clear();
            }
        }

        private void txtSanPham_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



