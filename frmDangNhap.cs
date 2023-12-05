using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace _29_30_CuaHangSach
{
    public partial class frmDangNhap : Form
    {


        public frmDangNhap()
        {
            InitializeComponent();
        }
       
        clsWebBanSach taikhoan = new clsWebBanSach();
        DataSet ds = new DataSet();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaikhoan.Text;
            string mk = txtMatKhau.Text;

            if (tk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                string sql = "select * from TaiKhoan where taikhoan ='" + tk + "' and matkhau ='" + mk + "'";
                ds = taikhoan.layDuLieu(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmTrangChu frmTrangChu = new frmTrangChu();
                    frmTrangChu.Show();
                  
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác");
                }
               
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
