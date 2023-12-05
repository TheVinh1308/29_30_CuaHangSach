using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_30_CuaHangSach
{
    public partial class frmChuDe : Form
    {
        public frmChuDe()
        {
            InitializeComponent();
        }
        int index = 0;
        DataSet ds = new DataSet();
        clsWebBanSach chude = new clsWebBanSach();
        int flag = 0;
        Boolean f = false;
    // HÀM LẤY DỮ LIỆU TỪ DATABASE
        void danhsach_datagridview(DataGridView d,string sql)
        {
            ds = chude.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
    // LOAD FORM
        private void frmChuDe_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            danhsach_datagridview(dgvDanhSach, "select * from ChuDe where trangthai = 0");
            hienthi_textbox(ds, index);
            f= true;
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
            txtTenChuDe.ReadOnly = t;
        }
    // NÚT THOÁT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    // FORM CLOSING
        private void frmChuDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgHoiThoat;
            dlgHoiThoat = MessageBox.Show("Bạn có chắc thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiThoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    // HIỂN THỊ DỮ LIỆU TRONG DATARIDVIEW LÊN TEXTBOX
        void hienthi_textbox(DataSet ds, int vt)
        {
            if(index > -1 && index< ds.Tables[0].Rows.Count) 
            { 
                txtMaChuDe.Text = ds.Tables[0].Rows[vt]["macd"].ToString();
                txtTenChuDe.Text = ds.Tables[0].Rows[vt]["tencd"].ToString();
                cbbTrangThaiChuDe.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
            }

        }
    // LẤY VỊ TRÍ ĐƯỢC CHỌN TRONG DATARIDVIEW
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
        }
    // NÚT LƯU
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuLyTextBox(false);
            string sql = "";
            string trung = "select tencd from ChuDe where tencd = N'" + txtTenChuDe.Text + "'";
            DataSet dstencd = chude.layDuLieu(trung);
            if (flag ==1)
            {
                    if (dstencd.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Chủ đề đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        txtTenChuDe.Focus();
                        return;
                    }
                    if (txtTenChuDe.Text == "" )
                    {
                        MessageBox.Show("Bạn chưa nhập tên chủ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        txtTenChuDe.Focus();
                        return;
                    }
                    else
                    {
                        foreach(char tu in txtTenChuDe.Text)
                        {
                            if (char.IsDigit(tu) == true)
                            {
                                MessageBox.Show("Vui lòng nhập bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                btnThem.PerformClick();
                                xuLyTextBox(false);
                                txtTenChuDe.Focus();
                                return;
                            }
                            else
                            {
                                sql = "insert into ChuDe values('" + txtMaChuDe.Text + "',N'" + txtTenChuDe.Text + "',0)";
                            }
                        }
                    }
              
                
            }
            if(flag == 2)
            {
                if (dstencd.Tables[0].Rows.Count > 1)
                {

                    MessageBox.Show("Chủ đề đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSua.PerformClick();
                    xuLyTextBox(false);
                    txtTenChuDe.Focus();
                    return;
                }
                if (txtTenChuDe.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên chủ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    btnSua.PerformClick();
                    xuLyTextBox(false);
                    txtTenChuDe.Focus();
                    return;
                }
                else
                {
                    foreach (char tu in txtTenChuDe.Text)
                    {
                        if (char.IsDigit(tu) == true)
                        {
                            MessageBox.Show("Vui lòng nhập bằng chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnSua.PerformClick();
                            xuLyTextBox(false);
                            txtTenChuDe.Focus();
                            return;
                        }
                        else
                        {
                            sql = "update ChuDe set tencd = N'" + txtTenChuDe.Text + "'where macd ='" + txtMaChuDe.Text + "'";
                        }
                    }
                }
                
            }
            if(flag == 3)
            {
                sql = "update ChuDe set trangthai = " + 1 + "where macd ='" + txtMaChuDe.Text + "'";
            }
            if (chude.capNhatDuLieu(sql)> 0) 
            {
                MessageBox.Show("Cập nhật thành công!");
                frmChuDe_Load(sender,e);

            }
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
    // NÚT THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            txtMaChuDe.Text = phatSinhMa();
            cbbTrangThaiChuDe.SelectedIndex = 0;
            flag = 1;
            txtTenChuDe.Text = "";
        }
    // NÚT SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyChucNang(false);
            xuLyTextBox(false);
            flag = 2;
        }
    // HÀM PHÁT SINH MÃ
        string phatSinhMa()
        {
            string ma = "";
            DataSet cd = chude.layDuLieu("select macd from Chude");
            if (cd.Tables[0].Rows.Count >= 9)
            {
                ma = "C" + (cd.Tables[0].Rows.Count + 1).ToString();
            }
            else
            {
                ma = "C0" + (cd.Tables[0].Rows.Count + 1).ToString();
            }
            return ma;
        }
    // UPDATE NỘI DUNG TRONG Ô DATARIDVIEW
        private void dgvDanhSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (f)
            {
                if (e.ColumnIndex >= 1)
                {
                    int vitri = dgvDanhSach.CurrentRow.Index;
                    string macd = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tencd = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    string sql = "update ChuDe set tencd = N'" + tencd + "'where macd ='" + macd + "'";
                    if (chude.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        index = 0;
                        frmChuDe_Load(sender, e);
                    }
                }
            }
        }
    // BẪY LỖI TÊN CHỦ ĐỀ
        private void txtTenChuDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtTenChuDe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
        }
    }
}
