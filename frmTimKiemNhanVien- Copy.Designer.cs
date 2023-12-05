namespace _29_30_CuaHangSach
{
    partial class frmTimkiemNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.grbThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHoTenNhanVien = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHIenThiTatCa = new System.Windows.Forms.Button();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.grbThongTinSanPham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(955, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Nhân Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm theo tên";
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(178, 102);
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(284, 27);
            this.txtTimKiemNhanVien.TabIndex = 6;
            this.txtTimKiemNhanVien.TextChanged += new System.EventHandler(this.txtTimKiemNhanVien_TextChanged);
            // 
            // grbThongTinSanPham
            // 
            this.grbThongTinSanPham.Controls.Add(this.label10);
            this.grbThongTinSanPham.Controls.Add(this.lblHoTenNhanVien);
            this.grbThongTinSanPham.Controls.Add(this.label16);
            this.grbThongTinSanPham.Controls.Add(this.label9);
            this.grbThongTinSanPham.Controls.Add(this.lblTrangThai);
            this.grbThongTinSanPham.Controls.Add(this.lblPhai);
            this.grbThongTinSanPham.Controls.Add(this.label14);
            this.grbThongTinSanPham.Controls.Add(this.label13);
            this.grbThongTinSanPham.Controls.Add(this.label8);
            this.grbThongTinSanPham.Controls.Add(this.lblSoDienThoai);
            this.grbThongTinSanPham.Controls.Add(this.lblNgaySinh);
            this.grbThongTinSanPham.Controls.Add(this.lblMaNhanVien);
            this.grbThongTinSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinSanPham.ForeColor = System.Drawing.Color.White;
            this.grbThongTinSanPham.Location = new System.Drawing.Point(27, 154);
            this.grbThongTinSanPham.Name = "grbThongTinSanPham";
            this.grbThongTinSanPham.Size = new System.Drawing.Size(902, 223);
            this.grbThongTinSanPham.TabIndex = 8;
            this.grbThongTinSanPham.TabStop = false;
            this.grbThongTinSanPham.Text = "Thông tin nhân viên";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 33);
            this.label10.TabIndex = 1;
            this.label10.Text = "Họ và tên ";
            // 
            // lblHoTenNhanVien
            // 
            this.lblHoTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoTenNhanVien.Location = new System.Drawing.Point(151, 101);
            this.lblHoTenNhanVien.Name = "lblHoTenNhanVien";
            this.lblHoTenNhanVien.Size = new System.Drawing.Size(232, 33);
            this.lblHoTenNhanVien.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(488, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 33);
            this.label16.TabIndex = 1;
            this.label16.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Phái";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrangThai.Location = new System.Drawing.Point(600, 163);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(223, 33);
            this.lblTrangThai.TabIndex = 1;
            // 
            // lblPhai
            // 
            this.lblPhai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhai.Location = new System.Drawing.Point(151, 165);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(232, 33);
            this.lblPhai.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(488, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 33);
            this.label14.TabIndex = 1;
            this.label14.Text = "Số điện thoại";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(488, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 33);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã nhân viên";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoDienThoai.Location = new System.Drawing.Point(600, 100);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(223, 33);
            this.lblSoDienThoai.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNgaySinh.Location = new System.Drawing.Point(600, 35);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(223, 33);
            this.lblNgaySinh.TabIndex = 1;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaNhanVien.Location = new System.Drawing.Point(151, 37);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(232, 33);
            this.lblMaNhanVien.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSach);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 186);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.phai,
            this.ngsinh,
            this.sdt,
            this.trangthai});
            this.dgvDanhSach.Location = new System.Drawing.Point(23, 39);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(861, 129);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick_1);
            this.dgvDanhSach.DoubleClick += new System.EventHandler(this.dgvDanhSach_DoubleClick);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã NV";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên NV";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            // 
            // phai
            // 
            this.phai.DataPropertyName = "phai";
            this.phai.HeaderText = "Phái";
            this.phai.MinimumWidth = 6;
            this.phai.Name = "phai";
            // 
            // ngsinh
            // 
            this.ngsinh.DataPropertyName = "ngsinh";
            this.ngsinh.HeaderText = "Ngày Sinh";
            this.ngsinh.MinimumWidth = 6;
            this.ngsinh.Name = "ngsinh";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            // 
            // btnHIenThiTatCa
            // 
            this.btnHIenThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnHIenThiTatCa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHIenThiTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHIenThiTatCa.Location = new System.Drawing.Point(27, 405);
            this.btnHIenThiTatCa.Name = "btnHIenThiTatCa";
            this.btnHIenThiTatCa.Size = new System.Drawing.Size(220, 43);
            this.btnHIenThiTatCa.TabIndex = 10;
            this.btnHIenThiTatCa.Text = "Hiển thị tất cả";
            this.btnHIenThiTatCa.UseVisualStyleBackColor = false;
            this.btnHIenThiTatCa.Click += new System.EventHandler(this.btnHIenThiTatCa_Click);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnThemNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.Location = new System.Drawing.Point(854, 23);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(75, 40);
            this.btnThemNhanVien.TabIndex = 11;
            this.btnThemNhanVien.Text = "Thêm";
            this.btnThemNhanVien.UseVisualStyleBackColor = false;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // frmTimkiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(955, 686);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.btnHIenThiTatCa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongTinSanPham);
            this.Controls.Add(this.txtTimKiemNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmTimkiemNhanVien";
            this.Text = "frmTimKiemSanPham";
            this.Load += new System.EventHandler(this.frmTimKiemSanPham_Load);
            this.grbThongTinSanPham.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
        private System.Windows.Forms.GroupBox grbThongTinSanPham;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHoTenNhanVien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnHIenThiTatCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Button btnThemNhanVien;
    }
}