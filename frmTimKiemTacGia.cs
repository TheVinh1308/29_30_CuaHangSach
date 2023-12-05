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
    public partial class frmTimKiemTacGia : Form
    {
        public frmTimKiemTacGia()
        {
            InitializeComponent();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from TacGia where trangthai = 0");
        }

        clsWebBanSach timkiemchude = new clsWebBanSach();
        int index = 0;
        DataSet ds = new DataSet();
        public string tenTacGia;
        void danhsach_datagridview(DataGridView d, string sql)
        {
            ds = timkiemchude.layDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        void hienthi_textbox(DataSet ds, int vt)
        {
            if (index > -1 && index < ds.Tables[0].Rows.Count)
            {
                lblMaTacGia.Text = ds.Tables[0].Rows[vt]["matg"].ToString();
                txtTenTacGia.Text = ds.Tables[0].Rows[vt]["tentg"].ToString();
                lblTrangThai.Text = ds.Tables[0].Rows[vt]["trangthai"].ToString();
            }
        }

        public void loadFormTimKiem()
        {
            danhsach_datagridview(dgvDanhSach, "select * from TacGia where tentg like N'%" + txtTimKiemTacGia.Text + "%'");
            hienthi_textbox(ds, index);
        }


        

        
        private void btnHIenThiTatCa_Click(object sender, EventArgs e)
        {
            danhsach_datagridview(dgvDanhSach, "select * from TacGia where trangthai = 0");
        }

        private void dgvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.tenTacGia = tenTacGia;
            Close();
        }

        

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            hienthi_textbox(ds, index);
            tenTacGia = ds.Tables[0].Rows[index]["tentg"].ToString();
        }

        private void txtTimKiemTacGia_TextChanged(object sender, EventArgs e)
        {
            loadFormTimKiem();
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia frmTacGia = new frmTacGia();
            frmTacGia.ShowDialog();
        }
    }
}
