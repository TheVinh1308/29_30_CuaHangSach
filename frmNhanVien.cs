using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _29_30_CuaHangSach
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        int flag = 0;

        Boolean load;

        clsWebBanSach nhanvien = new clsWebBanSach();

        int index = 0;

        DataSet ds = new DataSet();

        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = nhanvien.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        // FORM LOAD
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            danhsach_datagridview(dgvDanhSach, "select * from NhanVien where trangthai = 0");
            load = true;
        }
        // HÀM XỮ LÝ NÚT

        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;

        }

        // NÚT THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            txtMaNhanVien.Text = phatSinhMa();
            cboTrangThai.SelectedIndex = 0;
            cboPhai.SelectedIndex = 0;
            xuLyTextBox(false);
            flag = 1;

        }
        // NÚT XOÁ
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            flag = 3;
        }

        // NÚT SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            flag = 2;
        }

        // NÚT LƯU
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuLyTextBox(false);
            string sql = "";
            string tennv = "";
            string sdt = "";
            if (flag == 1)
            {
                string trung = "select sdt from NhanVien where sdt = '" + txtSDT.Text + "'";
                DataSet dstencd = nhanvien.layDuLieu(trung);
                if (dstencd.Tables[0].Rows.Count > 0)
                {

                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtSDT.Focus();
                    return;
                }
                if(txtSDT.Text.Length > 10)
                {
                    MessageBox.Show("Số điện thoại có tối đa 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtSDT.Focus();
                    return;
                }
                if (txtTenNhanVien.Text == "" || txtSDT.Text =="" || cboPhai.SelectedIndex == -1 || cboTrangThai.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    return;
                }
                else
                {
                    foreach (char tu in txtTenNhanVien.Text)
                    {
                        if (char.IsDigit(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập tên nhân viên bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyChucNang(false);
                            txtTenNhanVien.Focus();
                            return;
                        }
                        else
                        {
                            tennv = txtTenNhanVien.Text;

                           
                        }
                    }
                    foreach (char tu in txtSDT.Text)
                    {
                        if (char.IsLetter(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập sdt bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyChucNang(false);
                            txtSDT.Focus();
                            return;
                        }
                        else
                        {
                            sdt = txtSDT.Text;
                            
                        }
                    }
                }
                sql = "insert into NhanVien values('" + txtMaNhanVien.Text + "',N'" + tennv + "',N'" + cboPhai.Text + "','" + dateNgSinh.Value + "','" + sdt + "',0)";
            }
            if (flag == 2)
            {
                string trung = "select sdt from NhanVien where sdt = '" + txtSDT.Text + "'";
                DataSet dstencd = nhanvien.layDuLieu(trung);
                if (dstencd.Tables[0].Rows.Count > 0)
                {

                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtSDT.Focus();
                    return;
                }
                if (txtSDT.Text.Length > 10)
                {
                    MessageBox.Show("Số điện thoại có tối đa 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    txtSDT.Focus();
                    return;
                }
                if (txtTenNhanVien.Text == "" || txtSDT.Text == "" || cboPhai.SelectedIndex == -1 || cboTrangThai.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyChucNang(false);
                    return;
                }
                else
                {
                    foreach (char tu in txtTenNhanVien.Text)
                    {
                        if (char.IsDigit(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập tên nhân viên bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyChucNang(false);
                            txtTenNhanVien.Focus();
                            return;
                        }
                        else
                        {
                            tennv = txtTenNhanVien.Text;


                        }
                    }
                    foreach (char tu in txtSDT.Text)
                    {
                        if (char.IsLetter(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập sdt bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyChucNang(false);
                            txtSDT.Focus();
                            return;
                        }
                        else
                        {
                            sdt = txtSDT.Text;

                        }
                    }
                }
                sql = "update NhanVien set tennv = N'" + tennv + "',phai=N'" + cboPhai.Text + "',sdt='" + sdt + "',ngsinh = '" + dateNgSinh.Value + "'where manv ='" + txtMaNhanVien.Text + "'";
            }
            if (flag == 3)
            {
                sql = "update NhanVien set trangthai = 1 where manv ='" + txtMaNhanVien.Text + "'";
            }
            if (nhanvien.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cap nhat thanh cong!");
                frmNhanVien_Load(sender, e);
            }

        }

        // NÚT THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // BẪY LỖI HỌ NHÂN VIÊN
        private void txtHoNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        // BẪY LỖI TÊN NHÂN VIÊN
        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        // BẪY LỖI SỐ ĐIỆN THOẠI
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        // FORM CLOSING 

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
                txtMaNhanVien.Text = ds.Tables[0].Rows[vt]["manv"].ToString();
                txtTenNhanVien.Text = ds.Tables[0].Rows[vt]["tennv"].ToString();
                txtSDT.Text = ds.Tables[0].Rows[vt]["sdt"].ToString();
                cboPhai.Text = ds.Tables[0].Rows[vt]["phai"].ToString();
                dateNgSinh.Text = ds.Tables[0].Rows[vt]["ngsinh"].ToString();
                cboTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
            }
            
        }

        // CHỌN DÒNG
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
        }

        // HÀM XỬ LÝ TEXTBOX
        void xuLyTextBox(Boolean t)
        {
            txtTenNhanVien.ReadOnly = t;
            txtSDT.ReadOnly = t;
            
        }

        // HÀM PHÁT SINH MÃ
        string phatSinhMa()
        {
            string ma = "";
            DataSet ds = nhanvien.layDuLieu("select manv from NhanVien");
            if (ds.Tables[0].Rows.Count >= 9)
            {
                ma = "N" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                ma = "N0" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            return ma;
        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvDanhSach.CurrentRow.Index;
                    string manv = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tennv = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    string phai = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                    string ngsinh = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
                    string sdt = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
                    string sql = "update NhanVien set tennv = N'" +tennv+"', phai = '"+phai+"',ngsinh = '"+ngsinh+"',sdt='"+sdt+"' where manv = '" + manv + "'";
                    if (nhanvien.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        frmNhanVien_Load(sender, e);
                    }
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
        }

        private void grpNhapNhanVien2_Enter(object sender, EventArgs e)
        {

        }
    }
}
