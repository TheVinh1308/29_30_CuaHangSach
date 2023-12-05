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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }


        int flag = 0;
        clsWebBanSach khachhang = new clsWebBanSach();
        int index = 0;
        DataSet ds = new DataSet();
        // HÀM LẤY DỮ LIỆU TỪ DATABASE
        Boolean f = false;
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = khachhang.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            danhsach_datagridview(dgvDanhSach, "Select * from KhachHang where trangthai = 0 ");
            txtSDT.MaxLength = 10;
            f = true;
        }
        // NÚT THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            txtMaKH.Text = phatSinhMa();
            txtTenKH.Text = "";
            txtSDT.Text = "";
            cboPhai.SelectedIndex = 0;
            //cboTrangThai.SelectedIndex  = 0;
            lbTrangThai.Text = "0";
            flag = 1;
        }
        // NÚT XOÁ
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            DialogResult kq = new DialogResult();
            kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                flag = 3;
            }
            else
            {
                xuLyChucNang(true);
                xuLyTextBox(true);
            }


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
            if(flag == 1)
            {
                string trung = "select sdt from KhachHang where sdt = '" + txtSDT.Text + "'";
                DataSet dssdt = khachhang.layDuLieu(trung);
                if (dssdt.Tables[0].Rows.Count > 0)
                {

                    MessageBox.Show("Số điện thoại này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtSDT.Focus();
                    return;
                }
                foreach (char c in txtSDT.Text)
                {
                    if (char.IsLetter(c) == true)
                    {
                        MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        return;
                    }
                }
                if ( txtTenKH.Text == "" )
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtTenKH.Focus();
                    return;
                }
                if ( txtSDT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtSDT.Focus();
                    return;
                }
                if (txtSDT.TextLength != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtSDT.Focus();
                    return;
                }

                foreach (char c in txtTenKH.Text)
                    {
                        if (char.IsDigit(c) == true)
                        {
                            MessageBox.Show("Tên khách hàng phải là chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyTextBox(false);
                            return;

                        }
                        else
                        {
                            sql = "insert into KhachHang values ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + cboPhai.Text + "','" + txtSDT.Text + "',0)";
                        }
                    }
            }
            if (flag == 2)
            {
                string trung = "select sdt from KhachHang where sdt = '" + txtSDT.Text + "'";
                DataSet dssdt = khachhang.layDuLieu(trung);
                if (dssdt.Tables[0].Rows.Count > 1)
                {

                    MessageBox.Show("Số điện thoại này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtSDT.Focus();
                    return;
                }
                foreach (char c in txtSDT.Text)
                {
                    if (char.IsLetter(c) == true)
                    {
                        MessageBox.Show("Vui lòng nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        return;
                    }
                }
                if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtTenKH.Focus();
                    return;
                }
                if (txtSDT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtSDT.Focus();
                    return;
                }
                if (txtSDT.TextLength != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtSDT.Focus();
                    return;
                }

                foreach (char c in txtTenKH.Text)
                {
                    if (char.IsDigit(c) == true)
                    {
                        MessageBox.Show("Tên khách hàng phải là chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        return;

                    }
                    else
                    {
                        sql = "update KhachHang set tenkh = N'" + txtTenKH.Text + "',phai=N'" + cboPhai.Text + "',sdt='" + txtSDT.Text + "'where makh ='" + txtMaKH.Text + "'";

                    }
                }
            }
            if (flag == 3)
            {
                sql = "update KhachHang set trangthai = " + 1 + "where makh ='" + txtMaKH.Text + "'";
            }
            if (khachhang.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                
                frmKhachHang_Load(sender, e);
            }
        }
        // NÚT THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // BẪY LỖI SDT
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        // BẪY LỖI HỌ KHÁCH HÀNG
        private void txtHoKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
        // BẪY LỖI TÊN KHÁCH HÀNG
        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // FORMCLOSING
        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = new DialogResult();

            kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        // HÀM XỮ LÝ NÚT
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;

        }

        // HÀM HIỂN THỊ TEXTBOX
        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {
                txtMaKH.Text = ds.Tables[0].Rows[vt]["makh"].ToString();
                txtTenKH.Text = ds.Tables[0].Rows[vt]["tenkh"].ToString();
                cboPhai.Text = ds.Tables[0].Rows[vt]["phai"].ToString();
                txtSDT.Text = ds.Tables[0].Rows[vt]["sdt"].ToString();
                //cboTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
                lbTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
            }

        }
        // HÀM PHÁT SINH MÃ
        string phatSinhMa()
        {
            string ma = "";
            DataSet kh = khachhang.layDuLieu("select makh from KhachHang");
            if (kh.Tables[0].Rows.Count >= 9)
            {
                ma = "K" + (kh.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                ma = "K0" + (kh.Tables[0].Rows.Count + 1).ToString();
            }

            return ma;
        }
        // HÀM XỬ LÝ TEXTBOX
        void xuLyTextBox(Boolean t)
        {
            txtMaKH.ReadOnly = !t;
            txtTenKH.ReadOnly = t;
            txtSDT.ReadOnly= t;
        }

        // HÀM LẤY VỊ TRÍ NGƯỜI DÙNG CHỌN
        private void dgvDanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
        }

        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (f)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vitri = dgvDanhSach.CurrentRow.Index;
                    string makh = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tenkh = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    string phai = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                    string sdt = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
               
                    string sql = "update KhachHang set tenkh = N'" + tenkh  + "',phai=N'" + phai +"',sdt='" + sdt + "'where makh ='" + makh + "'";
                    if (khachhang.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        index = 0;
                        frmKhachHang_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPhai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
