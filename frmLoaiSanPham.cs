using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _29_30_CuaHangSach
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        clsWebBanSach loaisanpham = new clsWebBanSach();
        int index = 0;
        DataSet ds = new DataSet();
        Boolean f = false;
        int flag = 0;
        // FORN LOADING
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            danhsach_datagridview(dgvDanhSach, "Select * from LoaiSanPham where trangthai = 0");
            f = true;
        }

        // HÀM XỬ LÝ NÚT
        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;

        }
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = loaisanpham.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        // NÚT THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            txtMaLoaiSP.Text = phatSinhMa();
            cbbTrangThaiLoaiSP.SelectedIndex = 0;
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

        // NÚT SỪA
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
            if (flag == 1)
            {
                string trung = "select tenloai from LoaiSanPham where tenloai = N'" + txtTenLoaiSP.Text + "'";
                DataSet dstenloai = loaisanpham.layDuLieu(trung);
                if (dstenloai.Tables[0].Rows.Count > 0)
                {

                    MessageBox.Show("Loại sàn phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    return;
                }
                if (txtTenLoaiSP.Text == "" || cbbTrangThaiLoaiSP.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    return;
                }
                else
                {
                    foreach (char tu in txtTenLoaiSP.Text)
                    {
                        if (char.IsDigit(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyTextBox(false);
                            return;
                        }
                        else
                        {
                            sql = "insert into LoaiSanPham values('" + txtMaLoaiSP.Text + "',N'" + txtTenLoaiSP.Text + "',0)";
                        }
                    }
                }
                
            }
            if (flag == 2)
            {
                string trung = "select tenloai from LoaiSanPham where tenloai = N'" + txtTenLoaiSP.Text + "'";
                DataSet dstenloai = loaisanpham.layDuLieu(trung);
                if (dstenloai.Tables[0].Rows.Count > 0)
                {

                    MessageBox.Show("Loại sàn phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    return;
                }
                if (txtTenLoaiSP.Text == "" || cbbTrangThaiLoaiSP.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    return;
                }
                else
                {
                    foreach (char tu in txtTenLoaiSP.Text)
                    {
                        if (char.IsDigit(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyTextBox(false);
                            return;
                        }
                        else
                        {
                            sql = "update LoaiSanPham set tenloai=N'" + txtTenLoaiSP.Text + "'where maloai ='" + txtMaLoaiSP.Text + "'";

                        }
                    }
                }
            }
            if (flag == 3)
            {
                sql = "update LoaiSanPham set trangthai = " + 1 + "where maloai ='" + txtMaLoaiSP.Text + "'";
            }
            if (loaisanpham.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                frmLoaiSanPham_Load(sender, e);
            }
        }
        // BẪY LỖI SỐ LƯỢNG LOẠI SẢN PHẨM
        private void txtSoluongLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        // BẪY LỖI TÊN LOẠI SẢN PHẨM
        private void txtTenLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        // NÚT THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        // FORM CLOSING
        private void frmLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
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
                txtMaLoaiSP.Text = ds.Tables[0].Rows[vt]["maloai"].ToString();
                txtTenLoaiSP.Text = ds.Tables[0].Rows[vt]["tenloai"].ToString();
                cbbTrangThaiLoaiSP.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
            }
            
        }
        
        
        // HÀM PHÁT SINH MÃ
        string phatSinhMa()
        {
            string ma = "";
            DataSet lsp = loaisanpham.layDuLieu("select maloai from LoaiSanPham");
            if (ds.Tables[0].Rows.Count >= 9)
            {
                ma = "L" + (lsp.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                ma = "L0" + (lsp.Tables[0].Rows.Count + 1).ToString();
            }

            return ma;
        }
        // HÀM XỬ LÝ TEXTBOX
        void xuLyTextBox(Boolean t)
        {
            txtMaLoaiSP.ReadOnly = t;
            txtTenLoaiSP.ReadOnly = t;
        }

        // HÀM LẤY VỊ TRÍ NGƯỜI DỤNG CHỌN
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    string maloai = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tenloai = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    string sql = "update LoaiSanPham set tenloai = N'" + tenloai + "'where maloai ='" + maloai + "'";
                    if (loaisanpham.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        index = 0;
                        frmLoaiSanPham_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
        }

        private void grpLoaiSanPham_Enter(object sender, EventArgs e)
        {

        }

        private void cbbTrangThaiLoaiSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
