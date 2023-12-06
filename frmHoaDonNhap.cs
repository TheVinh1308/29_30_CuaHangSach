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

namespace _29_30_CuaHangSach
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        int index = 0;
        clsWebBanSach hoadonnhap = new clsWebBanSach();
        DataSet dsHDN = new DataSet();
        DataSet dsNhanVien = new DataSet();
        DataSet dsCTHD = new DataSet();
        DataSet dsNXB = new DataSet();
        Boolean f = false;
        DataSet dsSP = new DataSet();
        int flag = 0;
        string manxb;
        int index2 = 0;

        // lấy danh sách hóa đơn nhập
        void danhsach_datagridview(DataGridView d, string sql)
        {
            dgvDanhSach.Columns.Clear();
            dsHDN = hoadonnhap.layDuLieu(sql);
            d.DataSource = dsHDN.Tables[0];
        }

        // lấy danh sách chi tiết hóa đơn nhập
        void danhsach_datagridview_2(DataGridView d, string sql)
        {
            dgvDanhSachCTHDN.Columns.Clear();
            dsCTHD = hoadonnhap.layDuLieu(sql);
            d.DataSource = dsCTHD.Tables[0];
        }
        // load dữ liệu
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuLyTextBox(true);
            danhsach_datagridview(dgvDanhSach, "select * from HoaDonNhap");
            dsNhanVien = hoadonnhap.layDuLieu("select * from NhanVien");
            hienThiComboBox(cboMaNV, dsNhanVien, "tennv", "manv");
            //hienthi_textbox(dgvDanhSach, index);
            danhsach_datagridview_2(dgvDanhSachCTHDN, "select * from ChiTietNhap");
            btnThemCTHD.Enabled= false;
            
            f = true;
          
        }
        // hiển thị dữ liệu ra combobox
        void hienThiComboBox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;
        }

        void locDuLieuComboBox(DataSet ds, ComboBox cbo, string ten, string ma, string giatri)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma +" ='" + giatri + "'";
            
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }
        // hiển thị lên textbox hóa đơn nhập
        void hienthi_textbox(DataGridView ds, int vt)
        {
            if (ds.Rows.Count == 0 || vt < 0 || vt >= ds.Rows.Count)
            {

                return;

            }
            DataGridViewRow row = ds.Rows[vt];
            if (row != null && row.Cells.Count >= 6 && row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null)
            {
                txtMaHDN.Text = dgvDanhSach.Rows[vt].Cells[0].Value.ToString();
                cboMaNV.SelectedValue = dgvDanhSach.Rows[vt].Cells[1].Value.ToString();
                dateNgayLap.Text = dgvDanhSach.Rows[vt].Cells[3].Value.ToString();
                txtTongTien.Text = dgvDanhSach.Rows[vt].Cells[4].Value.ToString();
                cboTrangThaiHDN.Text = dgvDanhSach.Rows[vt].Cells[5].Value.ToString();

                load_cthdntheoMaHDN(txtMaHDN.Text);

                DataSet NXB = new DataSet();
                NXB = hoadonnhap.layDuLieu("select * from NhaXuatBan where manxb='" + dgvDanhSach.Rows[vt].Cells[2].Value.ToString() + "'");
                if (NXB.Tables[0].Rows.Count > 0)
                {
                    lblTenNXB.Text = NXB.Tables[0].Rows[0]["tennxb"].ToString();
                   
                }
                
            }

            if (dgvDanhSach.Rows[vt].Cells[5].Value.ToString() == "0")
            {
                cboTrangThaiHDN.Text = "Đã thanh toán";
            }
            if (dgvDanhSach.Rows[vt].Cells[5].Value.ToString() == "1")
            {
                cboTrangThaiHDN.Text = "Thanh toán khi nhận hàng";
            }
            if (dgvDanhSach.Rows[vt].Cells[5].Value.ToString() == "2")
            {
                cboTrangThaiHDN.Text = "Đã trả hàng";
            }
        }
        // hiển thị lên textbox khi ấn vào 1 dòng trong danh sách chi tiết hóa đơn
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(dgvDanhSach, index);

            if(cboTrangThaiHDN.Text == "Đã trả hàng")
            {
                btnSuaHD.Enabled = false;
            }
            else
            {
                btnSuaHD.Enabled = true;
            }
        }
        // hiển thị textbox chi tiết hóa đơn nhập
        void hienthi_textbox2(DataGridView ds, int vt)
        {
            if (ds.Rows.Count == 0 || vt < 0 || vt >= ds.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = ds.Rows[vt];
            if (row != null && row.Cells.Count >= 6 && row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null)
            {
                txtMaCTHDNhap.Text = row.Cells[0].Value.ToString();
                txtMaHDN.Text = row.Cells[1].Value.ToString();
                txtMasp.Text = row.Cells[2].Value.ToString();
                txtSoluong.Text = row.Cells[3].Value.ToString();
                txtGiaNhap.Text = row.Cells[4].Value.ToString();
                lblTongTienSP.Text = row.Cells[5].Value.ToString();

                DataSet dsSP = new DataSet();
                dsSP = hoadonnhap.layDuLieu("select * from SanPham where masp='" + txtMasp.Text + "'");
                if (dsSP.Tables[0].Rows.Count > 0)
                {
                    lblTenSP.Text = dsSP.Tables[0].Rows[0]["tensp"].ToString();

                    if (dsSP.Tables[0].Rows[0]["hinhanh"] != null)
                    {
                        string tenhinh = dsSP.Tables[0].Rows[0]["hinhanh"].ToString();
                        string tenFile = Path.GetFullPath("img_WebBanSach") + @"\" + tenhinh;
                        taoanh_tufileanh(picHinhAnh, tenFile);
                    }
                }
            }
        }
        // hiển thị lên textbox khi chọn dòng trong danh sách chi tiết hóa đơn
        private void dgvDanhSachCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = e.RowIndex;
            hienthi_textbox2(dgvDanhSachCTHDN, index2);
           
        }
        // tạo ảnh từ file
        void taoanh_tufileanh(PictureBox p, string filename)
        {
            Bitmap a = new Bitmap(filename);
            p.Image = a;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // load dữ liệu theo mã hóa đơn nhập
        void load_cthdntheoMaHDN(string mahdn)
        {
            string sql = "select * from ChiTietNhap where mahdn ='" + mahdn + "'";
            dsCTHD = hoadonnhap.layDuLieu(sql);
            dgvDanhSachCTHDN.DataSource = null;
            dgvDanhSachCTHDN.Columns.Clear();
            dgvDanhSachCTHDN.DataSource = dsCTHD.Tables[0];
        }
        // xử lý các button thêm xóa sửa
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSuaCTHD.Enabled = !t;
            btnXoaCTHD.Enabled = !t;
            btnLuu.Enabled = !t;
            btnHuy.Enabled = !t;
            btnThemCTHD.Enabled = !t;
            btnSuaHD.Enabled = t;
        }
        // bật tắt các textbox
        void xuLyTextBox(Boolean t)
        {
            txtTongTien.ReadOnly = t;
            txtGiaNhap.ReadOnly = t;
            //txtSoluong.ReadOnly= t;
            txtMaCTHDNhap.ReadOnly = t;
            cboMaNV.Enabled = !t;
            txtMaHDN.ReadOnly = t;
            cboTrangThaiHDN.Enabled = !t;
           
        }
        // tạo cột cho dgvDanhSachCTHDN
        void taocotcthdn()
        {
          
            dgvDanhSachCTHDN.Columns.Add("macthdn", "Mã cthdn");
            dgvDanhSachCTHDN.Columns.Add("mahdn", "Mã hdn");
            dgvDanhSachCTHDN.Columns.Add("masp", "Mã SP");
            dgvDanhSachCTHDN.Columns.Add("soluong", "Số Lượng");
            dgvDanhSachCTHDN.Columns.Add("gianhap", "Giá nhập");
            dgvDanhSachCTHDN.Columns.Add("thanhtien", "Thành tiền");
        }
        // tạo cột cho dgvDanhSach
        void taocothoadonnhap()
        {
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.Columns.Add("mahdn", "Mã HDN");
            dgvDanhSach.Columns.Add("manv", "Mã NV");
            dgvDanhSach.Columns.Add("manxb", "Mã NXB");
            dgvDanhSach.Columns.Add("ngaylap", "Ngày Lập");
            dgvDanhSach.Columns.Add("thanhtien", "Tổng tiền");
            dgvDanhSach.Columns.Add("trangthai", "Trạng thái");

        }
        // xóa dữ liệu các ô chứa dữ liệu
        void xoadulieu()
        {
            txtGiaNhap.Text = "";
            txtMaCTHDNhap.Text = "";
            txtMaHDN.Text = "";
            txtSoluong.Text = "";
            txtTongTien.Text = "";
            cboMaNV.Text = "";
            lblTenNXB.Text = "";
            //txtSDT.Text = "";
            txtMasp.Text = "";
            dateNgayLap.Text = "";
            lblTongTienSP.Text = "";
            cboTrangThaiHDN.Text = "";
        }
        // kiểm tra các textbox có dữ liệu hay chưa
        void kiemtranoidung()
        {
            if (flag == 1)
            {
                if (dateNgayLap.Text != "" && txtMaHDN.Text != "" && cboMaNV.Text != "" && cboTrangThaiHDN.Text != "")
                {

                    txtMasp.Enabled = true;
                    txtSoluong.Enabled = true;
                    if (txtMaCTHDNhap.Text != "" && txtMasp.Text != "" && txtSoluong.Text != "" && txtGiaNhap.Text != "" )
                    {
                        btnThemCTHD.Enabled = true;
                    }
                    else
                    {
                        btnThemCTHD.Enabled = false;

                    }
                }
            }
        }
        // hủy hóa đơn
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap_Load(sender, e);
        }
        // thêm hóa đơn nhập
        private void btnThem_Click(object sender, EventArgs e)
        {
            xoadulieu();
            xuLyChucNang(false);
            xuLyTextBox(false);
            txtMaHDN.Text = phatSinhMa();
            dgvDanhSach.DataSource = null;
            dgvDanhSachCTHDN.DataSource = null;
            taocotcthdn();
            taocothoadonnhap();
            btnThemCTHD.Enabled = false;
            hdmoi = true;
            txtMaCTHDNhap.Enabled = false;
            txtMasp.Enabled = false;
            //txtSoluong.Enabled = false;
            txtGiaNhap.Enabled = false;
            lblTongTienSP.Enabled = false;
            flag = 1;
        }
        
        // xóa hóa đơn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachCTHDN.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow r = dgvDanhSachCTHDN.SelectedRows[0];
                    dgvDanhSachCTHDN.Rows.Remove(r);
                    dgvDanhSachCTHDN.EndEdit();

                    int sum = 0;
                    foreach (DataGridViewRow row in dgvDanhSachCTHDN.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            int quantity = Convert.ToInt32(row.Cells[3].Value); // Lấy giá trị số lượng
                            int price = Convert.ToInt32(row.Cells[4].Value); // Lấy giá trị đơn giá
                            int total = quantity * price; // Tính tổng tiền của sản phẩm
                            row.Cells[5].Value = total; // Cập nhật giá trị tổng tiền vào cột Tổng tiền
                            sum += total; // Cộng tổng tiền của sản phẩm vào tổng tiền hóa đơn
                            if (row.Cells[3].Value != null)
                            {
                                txtSoluong.Text = row.Cells[3].Value.ToString();
                            }
                            lblTongTienSP.Text = total.ToString(); // Hiển thị tổng tiền hóa đơn
                        }

                    }
                    txtTongTien.Text = sum.ToString(); // Hiển thị tổng tiền hóa đơn
                    dgvDanhSach.Rows[0].Cells[4].Value = sum.ToString();
                }
            }

        }

        // lưu toàn bộ hóa đơn
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                cboMaNV.Focus();
                return;
            }
            
            if (cboTrangThaiHDN.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                cboTrangThaiHDN.Focus();
                return;
            }
            string mahdn = txtMaHDN.Text;
            string manv = cboMaNV.SelectedValue.ToString();
            string ngaylap = dateNgayLap.Value.ToString();
            string thanhtien = txtTongTien.Text;
            string trangthai = cboTrangThaiHDN.SelectedIndex.ToString();
            string sql = "";
            if (flag == 1)
            {
                sql = "insert into HoaDonNhap values('" + mahdn + "','" + manv + "','" + manxb + "','" + ngaylap + "'," + thanhtien + ",1)";
                if (hoadonnhap.capNhatDuLieu(sql) > 0)
                {
                    foreach (DataGridViewRow r in dgvDanhSachCTHDN.Rows)
                    {
                        if (r.Cells[0].Value == null)
                        {
                            return;
                        }
                        string sqlcthdn = "insert into ChiTietNhap values('" + r.Cells[0].Value.ToString() + "','" + r.Cells[1].Value + "','";
                        sqlcthdn += r.Cells[2].Value + "','" + r.Cells[3].Value + "','" + r.Cells[4].Value + "','"+ r.Cells[5].Value +"')";
                        if (hoadonnhap.capNhatDuLieu(sqlcthdn) > 0)
                        {
                             string masp = r.Cells[2].Value.ToString();

                            string sqlupdateSL = "update SanPham set soluong=soluong+" + r.Cells[3].Value.ToString() + "where masp='" + masp + "'";
                            hoadonnhap.capNhatDuLieu(sqlupdateSL);
                            MessageBox.Show("Cập nhật thành công!");
                        }
                    }
                    xuLyChucNang(true);
                    xuLyTextBox(false);
                    frmHoaDonNhap_Load(sender, e);
                }
                flag = 0;
            }

            if (flag == 2)
            {
                sql = "insert into HoaDonNhap values('" + mahdn + "','" + manv + "','" + manxb + "','" + ngaylap + "'," + thanhtien + ",1)";
                if (hoadonnhap.capNhatDuLieu(sql) > 0)
                {
                    foreach (DataGridViewRow r in dgvDanhSachCTHDN.Rows)
                    {
                        if (r.Cells[0].Value == null)
                        {
                            return;
                        }
                        string sqlcthdn = "insert into ChiTietNhap values('" + r.Cells[0].Value.ToString() + "','" + r.Cells[1].Value + "','";
                        sqlcthdn += r.Cells[2].Value + "','" + r.Cells[3].Value + "','" + r.Cells[4].Value + "','" + r.Cells[5].Value + "')";
                        if (hoadonnhap.capNhatDuLieu(sqlcthdn) > 0)
                        {
                            string masp = r.Cells[2].Value.ToString();

                            string sqlupdateSL = "update SanPham set soluong=soluong+" + r.Cells[3].Value.ToString() + "where masp='" + masp + "'";
                            hoadonnhap.capNhatDuLieu(sqlupdateSL);
                            MessageBox.Show("Cập nhật thành công!");
                        }
                    }
                    xuLyChucNang(true);
                    xuLyTextBox(false);
                    frmHoaDonNhap_Load(sender, e);
                }
                flag = 0;
            }

            if (flag == 3)
            {
                sql = "update HoaDonNhap set trangthai = '" + trangthai + "',thanhtien=" + thanhtien +" where mahdn='" + mahdn + "'";
                if (hoadonnhap.capNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    string sqltruslcu = "";
                    foreach (DataGridViewRow row in dgvDanhSachCTHDN.Rows)
                    {
                        if (row.Cells[0].Value == null)
                        {
                            return;
                        }
                        if (trangthai == "1")
                        {
                            DataSet ds = new DataSet();
                            ds = hoadonnhap.layDuLieu("select * from ChiTietNhap where mactnhap ='" + row.Cells[0].Value + "'");
                            string soluongcu = ds.Tables[0].Rows[0]["soluong"].ToString();
                            sqltruslcu = "update SanPham set soluong = soluong - " + soluongcu + "where masp ='" + row.Cells[2].Value + "'";

                            if (hoadonnhap.capNhatDuLieu(sqltruslcu) > 0)
                            {
                                if (row.Cells[0].Value != null && row.Cells[1].Value.ToString() == txtMaHDN.Text) // Kiểm tra giá trị của ô đầu tiên của hàng
                                {

                                    string masp = row.Cells[2].Value.ToString();
                                    string soluong = row.Cells[3].Value.ToString();
                                    string sqlupdateSL = "update SanPham set soluong=soluong+" + soluong + "where masp='" + masp + "'";
                                    hoadonnhap.capNhatDuLieu(sqlupdateSL);
                                    MessageBox.Show("Cập nhật thành công!");

                                    string sqlupdatechitiet = "update ChiTietNhap set soluong = " + row.Cells[3].Value + ",thanhtien =" + row.Cells[5].Value + " where mactnhap = '" + row.Cells[0].Value + "'";
                                    hoadonnhap.capNhatDuLieu(sqlupdatechitiet);
                                    MessageBox.Show("Cập nhật thành công!");
                                }
                            }
                        }

                        if (trangthai == "2")
                        {
                            string masp2 = row.Cells[2].Value.ToString();
                            string sqlupdateSL2;
                            sqlupdateSL2 = "update SanPham set soluong = soluong - " + row.Cells[3].Value.ToString() + "where masp='" + masp2 + "'";
                            hoadonnhap.capNhatDuLieu(sqlupdateSL2);
                            MessageBox.Show("Cập nhật thành công!");
                           
                        }

                    }
                   
                    xuLyChucNang(true);
                    xuLyTextBox(false);

                }
             
                flag = 0;
            }
        }
        // sửa ct hóa đơn
        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            if (txtMasp.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtMasp.Focus();
                return;
            }

            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtSoluong.Focus();
                return;
            }
            btnSuaCTHD.Enabled = false;
            btnThemCTHD.Enabled = false;
            txtTongTien.ReadOnly = false;
            txtGiaNhap.ReadOnly = false;
            txtMaCTHDNhap.ReadOnly = false;
            flag = 2;
        }
        // phát sinh mã hóa đơn
        string phatSinhMa()
        {
            string ma = "";
            if (dsHDN.Tables[0].Rows.Count >= 9)
            {
                ma = "HN" + (dsHDN.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                ma = "HN0" + (dsHDN.Tables[0].Rows.Count + 1).ToString();
            }
            return ma;
        }
       /* // hàm tìm khách hàng
        Boolean timKhachHang()
        {
            DataSet dsNXB= new DataSet();
            dsNXB = hoadonnhap.layDuLieu("select * from NhaXuatBan where sdt='" + txtSDT.Text+"'");
            if (dsNXB.Tables[0].Rows.Count > 0)
            {
                manxb = dsNXB.Tables[0].Rows[0]["manxb"].ToString();
                lblTenNXB.Text = dsNXB.Tables[0].Rows[0]["tennxb"].ToString();
                return true;
            }
            return false;

        }
        // sử dụng hàm tìm khách hàng*/
      
        // thêm nhà xuất bản mới
        private void btnNXB_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan fNXB = new frmNhaXuatBan();
            fNXB.ShowDialog();
            manxb = fNXB.mnxb;
            lblTenNXB.Text = fNXB.tnxb;
            //txtSDT.Text = fNXB.dienthoai;

        }
        double tongtienhoadon = 0;
        Boolean hdmoi = false;
        // thêm chi tiết hóa đơn
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            if (txtMasp.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtMasp.Focus();
                return;
            }
            
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnThem.PerformClick();
                txtSoluong.Focus();
                return;
            }
            double thanhtien;
            thanhtien = Convert.ToDouble(txtSoluong.Text) * Convert.ToDouble(txtGiaNhap.Text);
            object[] d = new object[6];
            d[0] = txtMaCTHDNhap.Text;
            d[1] = txtMaHDN.Text;
            d[2] = txtMasp.Text;
            d[3] = txtSoluong.Text;
            d[4] = txtGiaNhap.Text;
            d[5] = thanhtien.ToString();
            dgvDanhSachCTHDN.Rows.Add(d);
            tongtienhoadon += thanhtien;
            txtTongTien.Text = tongtienhoadon.ToString();
            
            if(hdmoi)
            {
                object[] h = new object[6];
                h[0] = txtMaHDN.Text;
                h[1] = cboMaNV.SelectedValue.ToString();
                h[2] = manxb;
                h[3] = dateNgayLap.Value;
                h[4] = txtTongTien.Text;
                h[5] = "1";
                dgvDanhSach.Rows.Add(h);
                hdmoi = false;

                txtMaCTHDNhap.Text = "";
                txtMasp.Text = "";
                txtSoluong.Text = "";
                txtGiaNhap.Text = "";
                lblTongTienSP.Text = "";
                lblTenSP.Text = "";
            }
            else
            {
                dgvDanhSach.Rows[0].Cells[4].Value = txtTongTien.Text;
            }
        }
        // frm sản phẩm
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham fSP = new frmSanPham();
            fSP.ShowDialog();
            txtMasp.Text = fSP.msp;
            lblTenSP.Text = fSP.tsp;
            txtGiaNhap.Text = fSP.gnhap;
        }

        private void txtMaHDN_TextChanged(object sender, EventArgs e)
        {
            kiemtranoidung();
        }

        private void dateNgayLap_ValueChanged(object sender, EventArgs e)
        {
            kiemtranoidung();
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiemtranoidung();
        }

        private void cboTrangThaiHDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiemtranoidung();

            if (cboTrangThaiHDN.SelectedIndex == 2)
            {
                btnXoaCTHD.Enabled = false;
                btnSuaCTHD.Enabled = false;
                btnThemCTHD.Enabled = false;
                txtMaHDN.Enabled = false;
                dateNgayLap.Enabled = false;
                cboMaNV.Enabled = false;
                txtMaCTHDNhap.Enabled = false;
                txtMasp.Enabled = false;
                txtSoluong.Enabled = false;
                txtGiaNhap.Enabled = false;
                btnNXB.Enabled = false;
                btnSanPham.Enabled = false;
                cboTrangThaiHDN.Enabled = false;
            }

           /* if (cboTrangThaiHDN.Text == "Thanh toán khi nhận hàng")
            {

                btnXoaCTHD.Enabled = false;
                btnSuaCTHD.Enabled = false;
                btnThemCTHD.Enabled = false;
                txtMaHDN.Enabled = false;
                dateNgayLap.Enabled = false;
                cboMaNV.Enabled = false;
                txtMaCTHDNhap.Enabled = false;
                txtMasp.Enabled = false;
                txtSoluong.Enabled = true;
                txtGiaNhap.Enabled = false;
                btnNXB.Enabled = false;
                btnSanPham.Enabled = false;
                cboTrangThaiHDN.Enabled = true;

            }
*/
          /*  if (cboTrangThaiHDN.SelectedIndex == 0)
            {

                btnXoaCTHD.Enabled = false;
                btnSuaCTHD.Enabled = false;
                btnThemCTHD.Enabled = false;
                txtMaHDN.Enabled = false;
                dateNgayLap.Enabled = false;
                cboMaNV.Enabled = false;
                txtMaCTHDNhap.Enabled = false;
                txtMasp.Enabled = false;
                txtSoluong.Enabled = false;
                txtGiaNhap.Enabled = false;
                btnNXB.Enabled = false;
                btnSanPham.Enabled = false;
                cboTrangThaiHDN.Enabled = true;
            }*/
        }
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            kiemtranoidung();
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            kiemtranoidung();
        }


        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            kiemtranoidung();
        }



        private void dgvDanhSachCTHDN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (flag == 1 || flag == 2 || flag == 3)
            {
                if (e.ColumnIndex == 3)
                {
                    int sum = 0;
                    
                    foreach (DataGridViewRow row in dgvDanhSachCTHDN.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            int quantity = Convert.ToInt32(row.Cells[3].Value); // Lấy giá trị số lượng
                            int price = Convert.ToInt32(row.Cells[4].Value); // Lấy giá trị đơn giá
                            int total = quantity * price; // Tính tổng tiền của sản phẩm
                            row.Cells[5].Value = total; // Cập nhật giá trị tổng tiền vào cột Tổng tiền
                            sum += total; // Cộng tổng tiền của sản phẩm vào tổng tiền hóa đơn
                            if (row.Cells[3].Value != null)
                            {
                                txtSoluong.Text = row.Cells[3].Value.ToString();
                            }
                            lblTongTienSP.Text = total.ToString(); // Hiển thị tổng tiền hóa đơn
                        }
                       
                    }
                    txtTongTien.Text = sum.ToString(); // Hiển thị tổng tiền hóa đơn
                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtMaHDN.Text)
                            row.Cells[4].Value = sum.ToString();

                    }
                }

            }
        }

        private void txtMasp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string masp = txtMasp.Text;
                dsSP = hoadonnhap.layDuLieu("Select * from SanPham where masp ='" + masp + "'");
                txtMasp.Text = dsSP.Tables[0].Rows[0]["masp"].ToString();
                manxb = dsSP.Tables[0].Rows[0]["manxb"].ToString();
                dsNXB = hoadonnhap.layDuLieu("select * from NhaXuatBan where manxb ='" + manxb + "'");
                lblTenNXB.Text = dsNXB.Tables[0].Rows[0]["tennxb"].ToString();
                txtGiaNhap.Text = dsSP.Tables[0].Rows[0]["gianhap"].ToString();
                lblTenSP.Text = dsSP.Tables[0].Rows[0]["tensp"].ToString();
                string mahdn = txtMaHDN.Text;
                txtMaCTHDNhap.Text = mahdn + masp;

                string tenhinh = dsSP.Tables[0].Rows[0]["hinhanh"].ToString();
                string tenFile = Path.GetFullPath("img_WebBanSach") + @"\" + tenhinh;
                taoanh_tufileanh(picHinhAnh, tenFile);
            }
        }




        private void txtSoluong_KeyDown(object sender, KeyEventArgs e)

        {
            if (flag == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        double giaTien = Convert.ToDouble(txtGiaNhap.Text);
                        double soLuong = Convert.ToDouble(txtSoluong.Text);

                        double tongtien = giaTien * soLuong;
                        lblTongTienSP.Text = tongtien.ToString();
                    }
                    catch (FormatException)
                    {
                        // Xử lý lỗi khi người dùng nhập vào chuỗi không hợp lệ
                        MessageBox.Show("Vui lòng nhập số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    e.SuppressKeyPress = true;
                }
            }

            if (flag == 2 || flag == 3)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        double giaTien = Convert.ToDouble(txtGiaNhap.Text);
                        double soLuong = Convert.ToDouble(txtSoluong.Text);

                        foreach (DataGridViewRow row in dgvDanhSachCTHDN.Rows)
                        {
                            if (row.Index == 0 && row.Cells[0].Value == null) // Kiểm tra hàng đầu tiên có giá trị null không
                            {
                                row.Cells[0].Value = txtMaCTHDNhap.Text;
                            }

                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtMaCTHDNhap.Text) // Kiểm tra giá trị của ô đầu tiên của hàng
                            {
                                double tongtien = giaTien * soLuong;
                                row.Cells[3].Value = soLuong.ToString();
                                row.Cells[4].Value = giaTien.ToString();
                                row.Cells[5].Value = tongtien.ToString();

                                lblTongTienSP.Text = tongtien.ToString();


                            }
                        }

                      
                    }
                    catch (FormatException)
                    {
                        // Xử lý lỗi khi người dùng nhập vào chuỗi không hợp lệ
                        MessageBox.Show("Vui lòng nhập số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            if(cboTrangThaiHDN.Text == "Đã thanh toán")
            {
                btnXoaCTHD.Enabled = false;
                btnSuaCTHD.Enabled = false;
            }
            flag = 3;
        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grpNhapChuDe_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
