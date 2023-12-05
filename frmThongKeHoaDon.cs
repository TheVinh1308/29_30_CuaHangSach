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
    public partial class frmThongKeHoaDon : Form
    {
        public frmThongKeHoaDon()
        {
            InitializeComponent();
        }

        clsWebBanSach c = new clsWebBanSach();
        DataSet ds = new DataSet();
        Boolean f = false;

        private void frmThongKeHoaDon_Load(object sender, EventArgs e)
        {
            f = true;
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            if (f)
            {
                if (cboLoaiHoaDon.SelectedIndex == 0)
                {
                    string NgayLap = dtpNgayLap.Text;
                    ds = c.layDuLieu("select mahdb, makh, manv, thanhtien as 'Thành tiền' from HoaDonBan where CAST(ngaylap as DATE) = '" + NgayLap + "' and trangthai = 0");
                    dgvDanhSach.DataSource = ds.Tables[0];
                    double tongTien = 0;
                    for (int i = 0; i < dgvDanhSach.Rows.Count - 1; i++)
                    {
                        tongTien += double.Parse(dgvDanhSach.Rows[i].Cells[3].Value.ToString());
                    }
                    lblTongTien.Text = "Tổng doanh thu: " + tongTien;
                }
                if (cboLoaiHoaDon.SelectedIndex == 1)
                {
                    string NgayLap = dtpNgayLap.Text;
                    ds = c.layDuLieu("select mahdn, manxb, manv, thanhtien as 'Thành tiền' from HoaDonNhap where CAST(ngaylap as DATE) = '" + NgayLap + "' and trangthai = 0");
                    dgvDanhSach.DataSource = ds.Tables[0];
                    double tongTien = 0;
                    for (int i = 0; i < dgvDanhSach.Rows.Count - 1; i++)
                    {
                        tongTien += double.Parse(dgvDanhSach.Rows[i].Cells[3].Value.ToString());
                    }
                    lblTongTien.Text = "Tổng tiền chi trả: " + tongTien;                
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboLoaiHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f)
            {
                if (cboLoaiHoaDon.SelectedIndex == 0)
                {
                    string NgayLap = dtpNgayLap.Text;
                    ds = c.layDuLieu("select mahdb, makh, manv, thanhtien as 'Thành tiền' from HoaDonBan where CAST(ngaylap as DATE) = '" + NgayLap + "' and trangthai = 0");
                    dgvDanhSach.DataSource = ds.Tables[0];
                    double tongTien = 0;
                    for (int i = 0; i < dgvDanhSach.Rows.Count - 1; i++)
                    {
                        tongTien += double.Parse(dgvDanhSach.Rows[i].Cells[3].Value.ToString());
                    }
                    lblTongTien.Text = "Tổng doanh thu: " + tongTien;
                }
                if (cboLoaiHoaDon.SelectedIndex == 1)
                {
                    string NgayLap = dtpNgayLap.Text;
                    ds = c.layDuLieu("select mahdn, manxb, manv, thanhtien as 'Thành tiền' from HoaDonNhap where CAST(ngaylap as DATE) = '" + NgayLap + "' and trangthai = 0");
                    dgvDanhSach.DataSource = ds.Tables[0];
                    double tongTien = 0;
                    for (int i = 0; i < dgvDanhSach.Rows.Count - 1; i++)
                    {
                        tongTien += double.Parse(dgvDanhSach.Rows[i].Cells[3].Value.ToString());
                    }
                    lblTongTien.Text = "Tổng tiền chi trả: " + tongTien;
                }
            }
        }
    }
}
