using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace _29_30_CuaHangSach
{
    public partial class frmNhaXuatBan : Form
    {
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }
        clsWebBanSach nxb = new clsWebBanSach();
        int index = 0;
        DataSet ds = new DataSet();
        DataSet dsloai = new DataSet();
        int flag = 0;
        public string mnxb;
        public string tnxb;
        public string dienthoai;
        public string tenLoai;
        
        // HÀM LẤY DỮ LIỆU TỪ DATABASE
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = nxb.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        Boolean load = false;
        // FORM LOAD
        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        
        {
            xuLyChucNang(true);
            danhsach_datagridview(dgvDanhSach, "Select * from NhaXuatBan where trangthai = 0");
            load = true;
            txtSDTNXB.MaxLength = 10;
            dsloai = nxb.layDuLieu("select * from LoaiSanPham where trangthai = '0'");
            hienthi_combobox(cboLoaiSanPham, dsloai, "tenloai", "maloai");
            
            
        }

        // HÀM XỬ LÝ NÚT
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;

        }
        // HÀM XỬ LÝ TEXTBOX
        void xuLyTextBox(Boolean t)
        {
            txtMaNXB.ReadOnly = t;
            txtTenNXB.ReadOnly = t;
            txtEmailNXB.ReadOnly = t;
            txtDCHiNXB.ReadOnly = t;
            txtSDTNXB.ReadOnly = t;
        }
        // HÀM PHÁT SINH MÃ
        string phatSinhMa()
        {
            string ma = "";
            DataSet ds = nxb.layDuLieu("select manxb from NhaXuatBan");
            if (ds.Tables[0].Rows.Count >= 9)
            {
                ma = "X" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                ma = "X0" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            return ma;
        }
        // NÚT THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            txtMaNXB.Text = phatSinhMa();
            cbbTTNXB.SelectedIndex = 0;
            flag = 1;
            txtTenNXB.Text = "";
            txtEmailNXB.Text = "";
            txtSDTNXB.Text = "";
            txtDCHiNXB.Text = "";
            hienthi_combobox(cboLoaiSanPham, dsloai, "tenloai", "maloai");
        }
        // NÚT XOÁ
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            flag = 3;
        }
        // NÚT SỮA
        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            cbbTTNXB.Enabled = false;
            flag = 2;
            hienthi_combobox(cboLoaiSanPham, dsloai, "tenloai", "maloai");
        }
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        // NÚT LƯU
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string kt_ten = "select tennxb from NhaXuatBan where tennxb = '" + txtTenNXB.Text + "'";
            string kt_email = "select email from NhaXuatBan where email = '" + txtEmailNXB.Text + "'";
            string kt_diachi = "select diachi from NhaXuatBan where diachi = '" + txtDCHiNXB.Text + "'";
            string kt_sdt = "select sdt from NhaXuatBan where sdt = '" + txtSDTNXB.Text + "'";
            DataSet dstennxb = nxb.layDuLieu(kt_ten);
            DataSet dsemail = nxb.layDuLieu(kt_email);
            DataSet dsdiachi = nxb.layDuLieu(kt_diachi);
            DataSet dssdt = nxb.layDuLieu(kt_sdt);
            string tennxb = "";
            string sdtnxb = "";
            string emailnxb = "";
           
            xuLyChucNang(true);
            xuLyTextBox(false);
            string sql = "";
            if (flag == 1)
            {

                if (dstennxb.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Tên nhà xuất bản bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtTenNXB.Focus();
                    return;
                }
                if (dsemail.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Email này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtEmailNXB.Focus();
                    return;
                }
                if (dsdiachi.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Địa chỉ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtDCHiNXB.Focus();
                    return;
                }
                if (dssdt.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();

                    txtSDTNXB.Focus();
                    return;
                }
                if (txtTenNXB.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtTenNXB.Focus();
                    return;
                }
                if (txtEmailNXB.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập email nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtEmailNXB.Focus();
                    return;
                }
                if (txtDCHiNXB.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtDCHiNXB.Focus();
                    return;
                }
                if (txtSDTNXB.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtSDTNXB.Focus();
                    return;
                }
                if (txtSDTNXB.TextLength != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtSDTNXB.Focus();
                    return;
                }
                if (cboLoaiSanPham.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    cboLoaiSanPham.Focus();
                    return;
                }
                foreach (char tu in txtTenNXB.Text)
                {
                    if (char.IsDigit(tu) == true)
                    {
                        MessageBox.Show("Vui lòng nhập tên nhà xuất bản bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyChucNang(false);
                        txtTenNXB.Focus();
                        return;
                    }
                    else
                    {
                        tennxb = txtTenNXB.Text;
                    }
                }
                foreach (char tu in txtSDTNXB.Text)
                {
                    if (char.IsLetter(tu) == true)
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyChucNang(false);
                        txtTenNXB.Focus();
                        return;
                    }
                    else
                    {
                        sdtnxb = txtSDTNXB.Text;
                    }
                }
                if (isValidEmail(txtEmailNXB.Text) == false)
                {
                    MessageBox.Show("Email khonng6 hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtEmailNXB.Focus();
                    return;
                }
                else
                {
                    emailnxb = txtEmailNXB.Text;
                }

                sql = "insert into NhaXuatBan values('" + txtMaNXB.Text + "',N'" + tennxb + "',N'" + txtDCHiNXB.Text + "','" + emailnxb + "','" + sdtnxb + "','" + cboLoaiSanPham.SelectedValue + "','0')";
            }
            if(flag == 2)
            {
              
                if (dstennxb.Tables[0].Rows.Count > 1)
                {
                    MessageBox.Show("Tên nhà xuất bản bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtTenNXB.Focus();
                    return;
                }
                if (dsemail.Tables[0].Rows.Count > 1)
                {
                    MessageBox.Show("Email này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtEmailNXB.Focus();
                    return;
                }
                if (dsdiachi.Tables[0].Rows.Count > 1)
                {
                    MessageBox.Show("Địa chỉ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtDCHiNXB.Focus();
                    return;
                }
                if (dssdt.Tables[0].Rows.Count > 1)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();

                    txtSDTNXB.Focus();
                    return;
                }
                if (txtTenNXB.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtTenNXB.Focus();
                    return;
                }
                if (txtEmailNXB.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập email nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtEmailNXB.Focus();
                    return;
                }
                if (txtDCHiNXB.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtDCHiNXB.Focus();
                    return;
                }
                if (txtSDTNXB.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    txtSDTNXB.Focus();
                    return;
                }
                if (cboLoaiSanPham.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    cboLoaiSanPham.Focus();
                    return;
                }
                foreach (char tu in txtTenNXB.Text)
                {
                    if (char.IsDigit(tu) == true)
                    {
                        MessageBox.Show("Vui lòng nhập tên nhà xuất bản bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyChucNang(false);
                        txtTenNXB.Focus();
                        return;
                    }
                    else
                    {
                        tennxb = txtTenNXB.Text;
                    }
                }
                foreach (char tu in txtSDTNXB.Text)
                {
                    if (char.IsLetter(tu) == true)
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyChucNang(false);
                        txtTenNXB.Focus();
                        return;
                    }
                    else
                    {
                        sdtnxb = txtSDTNXB.Text;
                    }
                }
                if (isValidEmail(txtEmailNXB.Text) == false)
                {
                    MessageBox.Show("Email khonng6 hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtEmailNXB.Focus();
                    return;
                }
                else
                {
                    emailnxb = txtEmailNXB.Text;
                }
                sql = "update NhaXuatBan set tennxb = N'" + tennxb + "', diachi = N'" + txtDCHiNXB.Text + "', sdt = '" + sdtnxb + "',email = '" + emailnxb + "',loaisp = '" + cboLoaiSanPham.SelectedValue + "' where manxb = '" + txtMaNXB.Text + "'";
            }
            if(flag == 3)
            {
                sql = "update NhaXuatBan set trangthai = 1 where manxb = '" + txtMaNXB.Text + "'";
            }
            if (nxb.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                frmNhaXuatBan_Load(sender, e);
            }
        }
        // NÚT THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            tnxb = txtTenNXB.Text;
            dienthoai = txtSDTNXB.Text;
        }
        // BẪY LỖI SDT NXB
        private void txtSDTNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        // BẪY LỖI TÊN NHÀ XUẤT BẢN
        private void txtTenNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        // FORMCLOSING
        private void frmNhaXuatBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgHoiThoat;
            dlgHoiThoat = MessageBox.Show("Bạn có chắc thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiThoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        // HÀM HIỂN THỊ TEXTBOX
        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {
                txtMaNXB.Text = ds.Tables[0].Rows[vt]["manxb"].ToString();
                txtTenNXB.Text = ds.Tables[0].Rows[vt]["tennxb"].ToString();
                txtEmailNXB.Text = ds.Tables[0].Rows[vt]["email"].ToString();
                txtDCHiNXB.Text = ds.Tables[0].Rows[vt]["diachi"].ToString();
                txtSDTNXB.Text = ds.Tables[0].Rows[vt]["sdt"].ToString();
                cbbTTNXB.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
                cboLoaiSanPham.Text = ds.Tables[0].Rows[vt]["loaisp"].ToString();


                string loaisp = ds.Tables[0].Rows[vt]["loaisp"].ToString();
                locdl_theodataview(dsloai, cboLoaiSanPham, "maloai", "tentg", loaisp);
            }
        }
        // HÀM HIỂN THỊ CBO
        void hienthi_combobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;

        }
        // HÀM LỌC DATAVIEW
        void locdl_theodataview(DataSet ds, ComboBox cbo, string ma, string ten, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "= '" + giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }
        // HÀM LẤY VỊ TRÍ NGƯỜI DỦNG CHỌN
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvDanhSach.CurrentRow.Index;
                    string manxb = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tennxb = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    string diachi = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                    string email = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
                    string sdt = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
                    string sql = "update NhaXuatBan set tennxb = N'" + tennxb + "', diachi = N'" + diachi + "', sdt = '" +sdt + "',email = '" + email + "' where manxb = '" + manxb + "'";
                    if (nxb.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        frmNhaXuatBan_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
        }

        private void btnTimKiemLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmTimKiemLoaiSanPham frmTimKiemLoaiSanPham = new frmTimKiemLoaiSanPham();
            frmTimKiemLoaiSanPham.ShowDialog();
            cboLoaiSanPham.Text = frmTimKiemLoaiSanPham.tenLoai;
        }

        private void cbbTTNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}
