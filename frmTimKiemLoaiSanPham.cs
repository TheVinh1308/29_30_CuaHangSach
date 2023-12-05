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
    public partial class frmTimKiemLoaiSanPham : Form
    {
        public frmTimKiemLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from LoaiSanPham where trangthai = 0");
        }

        clsWebBanSach timkiemloaisanpham = new clsWebBanSach();
        int index = 0;
        DataSet ds = new DataSet();
        public string tenLoai;
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = timkiemloaisanpham.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {
                lblMaLoai.Text = ds.Tables[0].Rows[vt]["maloai"].ToString();
                lblTenLoai.Text = ds.Tables[0].Rows[vt]["tenloai"].ToString();
                lblTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
            }
        }

        public void loadFormTimKiem()
        {
            danhsach_datagridview(dgvDanhSach, "select * from LoaiSanPham where tenloai like N'%" + txtTimKiemLoaiSanPham.Text + "%'");
            hienthi_textbox(ds, index);
        }


        

        
        private void btnHIenThiTatCa_Click(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from LoaiSanPham where trangthai = 0");
        }

        private void dgvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            frmNhaXuatBan frmNhaXuatBan = new frmNhaXuatBan();
            frmNhaXuatBan.tenLoai = tenLoai;
            Close();
        }

        private void txtTimKiemLoaiSanPham_TextChanged(object sender, EventArgs e)
        {
            loadFormTimKiem();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
            tenLoai = ds.Tables[0].Rows[index]["tenloai"].ToString();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frmLoaiSanPham = new frmLoaiSanPham();
            frmLoaiSanPham.ShowDialog();
        }
    }
}
