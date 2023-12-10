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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        Boolean load = false;

        int flag = 0;

        clsWebBanSach tacgia = new clsWebBanSach();

        int index = 0;

        DataSet ds = new DataSet();

        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = tacgia.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        // FORM LOAD 
        private void frmTacGia_Load(object sender, EventArgs e)
        {

            xuLyChucNang(true);
            danhsach_datagridview(dgvDanhSach, "select * from TacGia where trangthai = 0");
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
            txtMaTG.Text = phatSinhMa();
            cboTrangThai.SelectedIndex = 0;
            xuLyTextBox(false);
            txtTenTG.Text = "";
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
            if (flag == 1)
            {
                if(txtTenTG.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtTenTG.Focus();
                    return;
                }
                else
                {
                    foreach (char tu in txtTenTG.Text)
                    {
                        if (char.IsDigit(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập tên tác giả bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyTextBox(false);
                            txtTenTG.Focus();
                            return;
                        }
                        else
                        {
                            sql = "insert into TacGia values('" + txtMaTG.Text + "',N'" + txtTenTG.Text + "',0)";
                        }
                    }
                }
               
            }
            if(flag == 2)
            {
                if (txtTenTG.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtTenTG.Focus();
                    return;
                }
                else
                {
                    foreach (char tu in txtTenTG.Text)
                    {
                        if (char.IsDigit(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập tên tác giả bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnThem.PerformClick();
                            xuLyTextBox(false);
                            txtTenTG.Focus();
                            return;
                        }
                        else
                        {
                            sql = "update TacGia set tentg = N'" + txtTenTG.Text + "', trangthai = 0 where matg = '" + txtMaTG.Text + "'";

                        }
                    }
                }
            }
            if (flag == 3)
            {
                sql = "update TacGia set trangthai = 1 where matg = '" + txtMaTG.Text + "'";
            }
            if (tacgia.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                frmTacGia_Load(sender, e);
            }
        }

        // NÚT THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // NÚT HUỶ
        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true)
;
        }

        // FORM CLOSING
        private void frmTacGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = new DialogResult();

            kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // HÀM HIỂN THỊ TEXTBOX
        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {
                txtMaTG.Text = ds.Tables[0].Rows[vt]["matg"].ToString();
                txtTenTG.Text = ds.Tables[0].Rows[vt]["tentg"].ToString();
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
            txtTenTG.ReadOnly = t;
        }

        // HÀM PHÁT SINH MÃ
        string phatSinhMa()
        {
            string ma = "";
            DataSet ds = tacgia.layDuLieu("select matg from TacGia");
            if (ds.Tables[0].Rows.Count >= 9)
            {
                ma = "T" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                ma = "T0" + (ds.Tables[0].Rows.Count + 1).ToString();
            }

            return ma;

        }

        // SỬA DỮ LIỆU BẰNG CÁCH NHẤN TRỰC TIẾP
        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vt = dgvDanhSach.CurrentRow.Index;
                    string matg = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tentg = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    string sql = "update TacGia set tentg = N'" + tentg + "' where matg = '" + matg + "'";
                    if (tacgia.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        frmTacGia_Load(sender, e);
                    }
                }

            }
        }

        private void grpNhapTacGia_Enter(object sender, EventArgs e)
        {

        }

        private void txtTenTG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void grpChucNangTacGia_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}
