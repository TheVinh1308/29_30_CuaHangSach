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
    public partial class frmTimkiemNhanVien : Form
    {
        public frmTimkiemNhanVien()
        {
            InitializeComponent();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from NhanVien where trangthai = 0");
        }

        clsWebBanSach timkiemnhanvien = new clsWebBanSach();
        int index = 0;
        DataSet ds = new DataSet();
        public string tenNhanVien;
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = timkiemnhanvien.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {
                lblMaNhanVien.Text = ds.Tables[0].Rows[vt]["manv"].ToString();
                lblHoTenNhanVien.Text = ds.Tables[0].Rows[vt]["tennv"].ToString();
                lblNgaySinh.Text = ds.Tables[0].Rows[vt]["ngsinh"].ToString();
                lblPhai.Text = ds.Tables[0].Rows[vt]["phai"].ToString();
                lblSoDienThoai.Text = ds.Tables[0].Rows[vt]["sdt"].ToString();
                lblTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
            }
        }

        public void loadFormTimKiem()
        {
            danhsach_datagridview(dgvDanhSach, "select * from NhanVien where tennv like N'%" + txtTimKiemNhanVien.Text + "%'");
            hienthi_textbox(ds, index);
        }


        private void dgvDanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
            tenNhanVien = ds.Tables[0].Rows[index]["tennv"].ToString();
        }

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            loadFormTimKiem();
        }

        private void btnHIenThiTatCa_Click(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from NhanVien where trangthai = 0");
        }

        private void dgvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan();
            frmHoaDonBan.tenNhanVien = tenNhanVien;
            Close();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();
        }
    }
}
