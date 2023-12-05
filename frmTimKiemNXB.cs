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
    public partial class frmTimKiemNXB : Form
    {
        public frmTimKiemNXB()
        {
            InitializeComponent();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from NhaXuatBan where trangthai = 0");
            
        }

        clsWebBanSach timkiemsanpham = new clsWebBanSach();
        int index = 0;
        DataSet ds = new DataSet();
        public string tenNhaXuatBan;
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = timkiemsanpham.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {
                lblMaNXB.Text = ds.Tables[0].Rows[vt]["manxb"].ToString();
                lblTenNXB.Text = ds.Tables[0].Rows[vt]["tennxb"].ToString();
                lblDiaChi.Text = ds.Tables[0].Rows[vt]["diachi"].ToString();
                lblSoDienThoai.Text = ds.Tables[0].Rows[vt]["sdt"].ToString();
                lbTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
                lblEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();

                
            }
        }
        
        
        

        public void loadFormTimKiem()
        {
            danhsach_datagridview(dgvDanhSach, "select * from NhaXuatBan where sdt like '%"+lblSoDienThoai.Text+"%'");
            hienthi_textbox(ds, index);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void dgvDanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
            tenNhaXuatBan = ds.Tables[0].Rows[index]["sdt"].ToString();
        }

        private void txtTimKiemSanPham_TextChanged(object sender, EventArgs e)
        {

            loadFormTimKiem();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from NhaXuatBan where trangthai = 0");
        }

        private void dgvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.tenNhaXuatBan = tenNhaXuatBan;
            Close();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan frmNhaXuatBan = new frmNhaXuatBan();
            frmNhaXuatBan.ShowDialog();
        }
    }
}
