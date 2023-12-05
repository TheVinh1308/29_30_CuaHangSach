using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_30_CuaHangSach
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        int index = 0;
        DataSet ds = new DataSet();
        DataSet dsloai = new DataSet();
        DataSet dsnxb = new DataSet();
        DataSet dstg = new DataSet();
        DataSet dscd = new DataSet();
        clsWebBanSach sp = new clsWebBanSach();
        int flag = 0;
        Boolean f = false;
        public string msp;
        public string tsp;
        public string gnhap;
        public string tenChuDe;
        public string tenTacGia;
        public string tenLoai;
        public string tenNhaXuatBan;
        // HÀM LẤY DỮ LIỆU TỪ DATABASE
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = sp.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            danhsach_datagridview(dgvDanhSach, "select * from SanPham where trangthai = 0");
            txtGiaBan.ReadOnly= true;
           
            dsloai = sp.layDuLieu("select * from LoaiSanPham where trangthai = '0'");
            hienthi_combobox(cboMaLoai, dsloai, "tenloai", "maloai");
            dsnxb = sp.layDuLieu("select * from NhaXuatBan where trangthai = '0'");
            hienthi_combobox(cboMaNXB, dsnxb, "tennxb", "manxb");
            dscd = sp.layDuLieu("select * from ChuDe where trangthai = '0'");
            hienthi_combobox(cboMaCD, dscd, "tencd", "macd");
            dstg = sp.layDuLieu("select * from TacGia where trangthai = '0'");
            hienthi_combobox(cboMaTG, dstg, "tentg", "matg");
            //hienthi_textbox(ds, index);
            f = true;
        }

        void xuLyChucNang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        void xuLyTextBox(Boolean t)
        {
            txtTenSP.ReadOnly = t;
            txtMoTa.ReadOnly = t;
            txtGiaNhap.ReadOnly = t;
            
        }
       

        
        // hiển thị dữ liệu trong datagridview lên textbox
        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {

                
                txtTenSP.Text = ds.Tables[0].Rows[vt]["tensp"].ToString();
                txtSoLuong.Text = ds.Tables[0].Rows[vt]["soluong"].ToString();
                txtHinhAnh.Text = ds.Tables[0].Rows[vt]["hinhanh"].ToString();
                txtGiaNhap.Text = ds.Tables[0].Rows[vt]["gianhap"].ToString();
                txtGiaBan.Text = ds.Tables[0].Rows[vt]["giaban"].ToString();
                txtMoTa.Text = ds.Tables[0].Rows[vt]["mota"].ToString();
                cboMaLoai.Text = ds.Tables[0].Rows[vt]["maloai"].ToString();
                cboMaNXB.Text = ds.Tables[0].Rows[vt]["manxb"].ToString();
                cboMaCD.Text = ds.Tables[0].Rows[vt]["macd"].ToString();
                cboMaTG.Text = ds.Tables[0].Rows[vt]["matg"].ToString();
                cboTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
               
                string tenhinh = ds.Tables[0].Rows[vt]["hinhanh"].ToString();
                string tenfile = Path.GetFullPath("img_WebBanSach") + @"\" + tenhinh;
                taoanh_tufileanh(picHinhAnh, tenfile);
                    string maloai = ds.Tables[0].Rows[vt]["maloai"].ToString();
                    string manxb = ds.Tables[0].Rows[vt]["manxb"].ToString();
                    string macd = ds.Tables[0].Rows[vt]["macd"].ToString();
                    string matg = ds.Tables[0].Rows[vt]["matg"].ToString();
                    locdl_theodataview(dsloai, cboMaLoai, "maloai", "tenloai", maloai);
                    locdl_theodataview(dsnxb, cboMaNXB, "manxb", "tennxb", manxb);
                    locdl_theodataview(dscd, cboMaCD, "macd", "tencd", macd);
                    locdl_theodataview(dstg, cboMaTG, "matg", "tentg", matg);
                   
                txtMaSP.Text = ds.Tables[0].Rows[vt]["masp"].ToString();
            }

        }
        // hàm lấy vị trí được chọn trong datagridview
       
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

        // update nội dung trong ô datagridview
        private void dgvDanhSach_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (f)
            {
                if (e.ColumnIndex >= 1)
                {
                    string masp = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                    string tensp = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                    string soluong = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                    string hinhanh = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
                    string gianhap = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
                    string giaban = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
                    string  mota = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
                    string maloai = dgvDanhSach.CurrentRow.Cells[7].Value.ToString();
                    string  manxb = dgvDanhSach.CurrentRow.Cells[8].Value.ToString();
                    string macd = dgvDanhSach.CurrentRow.Cells[9].Value.ToString();
                    string matg = dgvDanhSach.CurrentRow.Cells[10].Value.ToString();
                    string sql = "update SanPham set tensp = N'" + tensp + "',soluong='" + soluong + "',hinhanh ='" + hinhanh + "',gianhap ='" + gianhap + "',giaban='" + giaban + "',mota='" + mota + "',maloai='" + maloai + "',manxb=N'" + manxb + "',macd ='" + macd + "' ,matg ='" + matg + "'where masp ='" + masp + "'";
                    if (sp.capNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        index = 0;
                        frmSanPham_Load(sender, e);
                    }
                }
            }
        }
    // NÚT THÊM
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
            xuLyChucNang(false);
            xuLyTextBox(false);
            //txtMaSP.Text = phatSinhMa();
            cboTrangThai.SelectedIndex = 0;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtMoTa.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtHinhAnh.Text = "";
            cboMaCD.Text = "";
            cboMaLoai.Text = "";
            cboMaNXB.Text = "";
            cboMaTG.Text = "";
            picHinhAnh.Image = null;
            hienthi_combobox(cboMaLoai, dsloai, "tenloai", "maloai");
            hienthi_combobox(cboMaNXB, dsnxb, "tennxb", "manxb");
            hienthi_combobox(cboMaCD, dscd, "tencd", "macd");
            hienthi_combobox(cboMaTG, dstg, "tentg", "matg");
           
            flag = 1;

        }

        string layTenTheoMaNXB()
        {
            string masp;

                string manxb = cboMaNXB.SelectedValue.ToString();
                string sql = "select tennxb from SanPham, NhaXuatBan where SanPham.manxb = '" + manxb + "' and SanPham.manxb = NhaXuatBan.manxb ";
                masp = sp.layDuLieu(sql).ToString();
            return masp;

        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DataSet suacd = new DataSet();
            DataSet suatg = new DataSet();
            suacd = sp.layDuLieu("select * from ChuDe where macd = '" + cboMaCD.SelectedValue.ToString() + "'");
            suatg = sp.layDuLieu("select * from TacGia where matg = '" + cboMaTG.SelectedValue.ToString() + "'");
            xuLyChucNang(false);
            flag = 2;
            hienthi_textbox(ds, index);
            hienthi_combobox(cboMaTG, dstg, "tentg", "matg");
            hienthi_combobox(cboMaCD, dscd, "tencd", "macd");
            cboMaCD.Text = suacd.Tables[0].Rows[0]["tencd"].ToString();
            cboMaTG.Text = suatg.Tables[0].Rows[0]["tentg"].ToString();



        }

        private void btnXoa_Click_1(object sender, EventArgs e)
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

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            xuLyTextBox(false);
            
            string sql = "";
            string gianhap = "";
            string soluongsp = "";
            if (flag == 1)
            {
                if(cboMaLoai.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    cboMaLoai.Focus();
                    return;
                }
                if (cboMaNXB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    cboMaNXB.Focus();
                    return;
                }
                if (txtTenSP.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtTenSP.Focus();
                    return;
                }
                if (cboMaCD.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn chủ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    cboMaCD.Focus();
                    return;
                }
                if (cboMaTG.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    cboMaTG.Focus();
                    return;
                }
                if (txtGiaNhap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtGiaNhap.Focus();
                    return;
                }
                if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Bạn nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtSoLuong.Focus();
                    return;
                }
                if (txtHinhAnh.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtGiaNhap.Focus();
                    return;
                }
                foreach (char tu in txtGiaNhap.Text)
                {
                    if (char.IsLetter(tu) == true)
                    {
                        MessageBox.Show("Vui lòng nhập giá tiền bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        txtGiaNhap.Focus();
                        return;
                    }
                    else
                    {
                        gianhap = txtGiaNhap.Text;
                    }
                }
                foreach (char tu in txtSoLuong.Text)
                {
                    if (char.IsLetter(tu) == true)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        txtSoLuong.Focus();
                        return;
                    }
                    else
                    {
                        soluongsp = txtSoLuong.Text;
                    }
                }
                sql = "insert into SanPham values('"+txtMaSP.Text+"', N'" + txtTenSP.Text + "','" + soluongsp + "','" + txtHinhAnh.Text + "','" + gianhap + "','" + txtGiaBan.Text + "',N'" + txtMoTa.Text + "','" + cboMaLoai.SelectedValue + "','" + cboMaNXB.SelectedValue + "','" + cboMaCD.SelectedValue + "','" + cboMaTG.SelectedValue + "',0)";
               
            }
            if (flag == 2)
            {
                if (cboMaLoai.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    cboMaLoai.Focus();
                    return;
                }
                if (cboMaNXB.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    cboMaNXB.Focus();
                    return;
                }
                if (txtTenSP.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtTenSP.Focus();
                    return;
                }
                if (cboMaCD.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn chủ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    cboMaCD.Focus();
                    return;
                }
                if (cboMaTG.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    cboMaTG.Focus();
                    return;
                }
                if (txtGiaNhap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtGiaNhap.Focus();
                    return;
                }
                if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Bạn nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtSoLuong.Focus();
                    return;
                }
                if (txtHinhAnh.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnThem.PerformClick();
                    xuLyTextBox(false);
                    txtGiaNhap.Focus();
                    return;
                }
                foreach (char tu in txtGiaNhap.Text)
                {
                    if (char.IsLetter(tu) == true)
                    {
                        MessageBox.Show("Vui lòng nhập giá tiền bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        txtGiaNhap.Focus();
                        return;
                    }
                    else
                    {
                        gianhap = txtGiaNhap.Text;
                    }
                }
                foreach (char tu in txtSoLuong.Text)
                {
                    if (char.IsLetter(tu) == true)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng bằng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnThem.PerformClick();
                        xuLyTextBox(false);
                        txtSoLuong.Focus();
                        return;
                    }
                    else
                    {
                        soluongsp = txtSoLuong.Text;
                    }
                }
                sql = "update SanPham set tensp = N'" + txtTenSP.Text + "',soluong='" + txtSoLuong.Text + "',hinhanh ='" + txtHinhAnh.Text + "',gianhap ='" + txtGiaNhap.Text + "',giaban='" + txtGiaBan.Text + "',mota=N'" + txtMoTa.Text + "',maloai='" + cboMaLoai.SelectedValue + "',manxb='" + cboMaNXB.SelectedValue + "',macd ='" + cboMaCD.SelectedValue + "' ,matg ='" + cboMaTG.SelectedValue + "'where masp ='" + txtMaSP.Text + "'";
            }
            if (flag == 3)
            {
                sql = "update SanPham set trangthai = " + 1 + "where masp ='" + txtMaSP.Text + "'";
            }
            if (sp.capNhatDuLieu(sql) > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                frmSanPham_Load(sender, e);

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xuLyChucNang(true);
            flag = 4;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
            msp = txtMaSP.Text;
            tsp = txtTenSP.Text;
            gnhap = txtGiaNhap.Text;
        }

        void taoanh_tufileanh(PictureBox p, string filename)
        {
            Bitmap a = new Bitmap(filename);
            p.Image = a;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // HAM LOAD ANH
        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFullPath("img_WebBanSach") + @"\";
            o.ShowDialog();
            string tenfile = o.FileName;

            string thumucCon = Path.GetFileName(Path.GetDirectoryName(tenfile));
            txtHinhAnh.Text = thumucCon + "/" + Path.GetFileName(tenfile);
            taoanh_tufileanh(picHinhAnh, tenfile);
        }
        // HÀM HIỂN THỊ CBO
        void hienthi_combobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;

        }

        private void dgvDanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgHoiThoat;
            dlgHoiThoat = MessageBox.Show("Bạn có chắc thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiThoat == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemSanPham frmTimKiemSanPham = new frmTimKiemSanPham();
            frmTimKiemSanPham.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(f)
                if (cboMaLoai.SelectedIndex !=-1)
                {
                    string maloai = cboMaLoai.SelectedValue.ToString();
                    dsnxb = sp.layDuLieu("select * from NhaXuatBan where loaisp = '" + maloai+"'");
                    hienthi_combobox(cboMaNXB, dsnxb, "tennxb", "manxb");
                }
        }

        private void cboMaNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f)
            {
                if (cboMaNXB.SelectedIndex != -1)
                {

                        string manxb = cboMaNXB.SelectedValue.ToString();
                        string sql = "select masp from SanPham where manxb = '" + manxb + "'";
                        DataSet ds = sp.layDuLieu(sql);
                        string masp = "";
                        if (ds.Tables[0].Rows.Count <= 9)
                        {
                            masp = manxb + "S0" + (ds.Tables[0].Rows.Count + 1);
                        }
                        else
                        {
                            masp = manxb + "S" + (ds.Tables[0].Rows.Count + 1);
                        }
                        txtMaSP.Text = masp;
                  
                }

            }
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
           
                if(flag == 1 || flag == 2)
                {
                    if (txtGiaNhap.Text == "")
                    {
                        txtGiaBan.Text = "";
                    }
                    else
                    {
                        txtGiaBan.Text = (Convert.ToInt32(txtGiaNhap.Text) * 1.5).ToString();
                    }
                }
            
        }

       

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemChuDe_Click(object sender, EventArgs e)
        {
            frmTimKiemChuDe frmTimkiemChuDe = new frmTimKiemChuDe();
            frmTimkiemChuDe.ShowDialog();
            cboMaCD.Text = frmTimkiemChuDe.tenChuDe;
        }

        private void btnTimKiemTacGia_Click(object sender, EventArgs e)
        {
            frmTimKiemTacGia frmTimKiemTacGia = new frmTimKiemTacGia();
            frmTimKiemTacGia.ShowDialog();
            cboMaTG.Text = frmTimKiemTacGia.tenTacGia;
        }

        private void btnTimKiemLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmTimKiemLoaiSanPham frmTimKiemLoaiSanPham = new frmTimKiemLoaiSanPham();
            frmTimKiemLoaiSanPham.ShowDialog();
            cboMaLoai.Text = frmTimKiemLoaiSanPham.tenLoai;
        }

        private void btnTimKiemNXB_Click(object sender, EventArgs e)
        {
            frmTimKiemNXB frmTimKiemNXB = new frmTimKiemNXB();
            frmTimKiemNXB.ShowDialog();
            cboMaNXB.Text = frmTimKiemNXB.tenNhaXuatBan;
        }
    }
}
