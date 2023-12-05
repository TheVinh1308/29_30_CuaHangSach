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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _29_30_CuaHangSach
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        int flag = 0;   
        void openChilForm(Form chilform)
        {

            chilform.TopLevel = false;
            chilform.FormBorderStyle = FormBorderStyle.None;
            chilform.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(chilform);
            pnlForm.Tag = chilform;
            chilform.BringToFront();
            chilform.Show();

        }

        //private void btnTrangChu_Click(object sender, EventArgs e)
        //{
        //    flag = 1;
        //    lblTitle.Text = btnTrangChu.Text;
        //}

        
        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSanPham_Click_2(object sender, EventArgs e)
        {
            xuLyBtn();
            btnSanPham.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnSanPham.Text;
            frmSanPham frmSanPham = new frmSanPham();
            openChilForm(frmSanPham);
        }


        private void btnChuDe_Click(object sender, EventArgs e)
        {
            xuLyBtn();
            btnChuDe.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnChuDe.Text;
            frmChuDe frmChuDe = new frmChuDe();
            openChilForm(frmChuDe);
        }

        

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            xuLyBtn();
            btnNhanVien.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnNhanVien.Text;
            frmNhanVien frmNhanVien = new frmNhanVien();
            openChilForm(frmNhanVien);
        }

        private void btnTacGia_Click_1(object sender, EventArgs e)
        {
            xuLyBtn();
            btnTacGia.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnTacGia.Text;
            frmTacGia frmTacGia = new frmTacGia();
            openChilForm(frmTacGia);
            
        }

        

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            xuLyBtn();
            btnLoaiSanPham.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnLoaiSanPham.Text;
            frmLoaiSanPham frmLoaiSanPham= new frmLoaiSanPham();
            openChilForm(frmLoaiSanPham);

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            xuLyBtn();
            btnKhachHang.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnKhachHang.Text;
            frmKhachHang frmKhachHang = new frmKhachHang();
            openChilForm(frmKhachHang);
        }
        //private void lblTitle_Click(object sender, EventArgs e)
        //{

        //}
        void xuLyBtn()
        {
            btnChuDe.BackColor = Color.Transparent;
            btnNhanVien.BackColor = Color.Transparent;
            btnSanPham.BackColor = Color.Transparent;
            btnTacGia.BackColor = Color.Transparent;
            btnLoaiSanPham.BackColor = Color.Transparent;
            btnKhachHang.BackColor = Color.Transparent;
            btnNhaXuatBan.BackColor = Color.Transparent;
            btnHoaDonBan.BackColor = Color.Transparent;
            btnHoaDonNhap.BackColor = Color.Transparent;
            btnThongke.BackColor = Color.Transparent;
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            xuLyBtn();
            btnNhaXuatBan.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnNhaXuatBan.Text;
            frmNhaXuatBan frmNhaXuatBan = new frmNhaXuatBan();
            openChilForm(frmNhaXuatBan);
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            xuLyBtn();
            btnHoaDonBan.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnHoaDonBan.Text;
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan();
            openChilForm(frmHoaDonBan);
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            xuLyBtn();
            btnHoaDonNhap.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnHoaDonNhap.Text;
            frmHoaDonNhap frmHoaDonNhap = new frmHoaDonNhap();
            openChilForm(frmHoaDonNhap);
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            xuLyBtn();
            btnThongke.BackColor = Color.FromArgb(70, 70, 82);
            lblTitle.Text = btnThongke.Text;
            frmThongKeHoaDon frmThongKe = new frmThongKeHoaDon();
            openChilForm(frmThongKe);
        }
    }
}
