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
    public partial class frmTimKiemSanPham : Form
    {
        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from SanPham where trangthai = 0");
            
        }

        clsWebBanSach timkiemsanpham = new clsWebBanSach();
        int index = 0;
        DataSet ds = new DataSet();
        DataSet dsloai = new DataSet();
        DataSet dsnxb = new DataSet();
        DataSet dstg = new DataSet();
        DataSet dscd = new DataSet();
        int cFlag = 0;
        Boolean f = false;
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = timkiemsanpham.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {
                lblMaSP.Text = ds.Tables[0].Rows[vt]["masp"].ToString();
                lblTenSp.Text = ds.Tables[0].Rows[vt]["tensp"].ToString();
                lblSoLuong.Text = ds.Tables[0].Rows[vt]["soluong"].ToString();
                lblHinhAnh.Text = ds.Tables[0].Rows[vt]["hinhanh"].ToString();
                lblGiaNhap.Text = ds.Tables[0].Rows[vt]["gianhap"].ToString();
                lblGiaBan.Text = ds.Tables[0].Rows[vt]["giaban"].ToString();
                lblMoTa.Text = ds.Tables[0].Rows[vt]["mota"].ToString();
                lblLoai.Text = ds.Tables[0].Rows[vt]["maloai"].ToString();
                lblNXB.Text = ds.Tables[0].Rows[vt]["manxb"].ToString();
                lblChuDe.Text = ds.Tables[0].Rows[vt]["macd"].ToString();
                lblTacGia.Text = ds.Tables[0].Rows[vt]["matg"].ToString();
                lblTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();

                string tenhinh = ds.Tables[0].Rows[vt]["hinhanh"].ToString();
                string tenfile = Path.GetFullPath("img_WebBanSach") + @"\" + tenhinh;
                taoanh_tufileanh(picHinhAnh, tenfile);

                
            }
        }
        void hienthi_combobox(ComboBox cbo, DataSet ds, string ten, string ma)
        {
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
            cbo.SelectedIndex = -1;

        }
        
        private void btnTimKiemTheoTen_Click(object sender, EventArgs e)
        {
            loadFormTimKiem();
        }

        public void loadFormTimKiem()
        {
            danhsach_datagridview(dgvDanhSach, "select * from SanPham where tensp like N'%"+txtTimKiemSanPham.Text+"%'");
            hienthi_textbox(ds, index);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        void taoanh_tufileanh(PictureBox p, string filename)
        {
            Bitmap a = new Bitmap(filename);
            p.Image = a;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        void locdl_theodataview(DataSet ds, ComboBox cbo, string ma, string ten, string giatrima)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = ma + "= '" + giatrima + "'";
            cbo.DataSource = dv;
            cbo.DisplayMember = ten;
            cbo.ValueMember = ma;
        }

        private void dgvDanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
        }

        private void txtTimKiemSanPham_TextChanged(object sender, EventArgs e)
        {

            loadFormTimKiem();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from SanPham where trangthai = 0");
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.ShowDialog();
        }
    }
}
