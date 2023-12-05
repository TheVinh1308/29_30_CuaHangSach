namespace _29_30_CuaHangSach
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpNhapNhanVien1 = new System.Windows.Forms.GroupBox();
            this.cboPhai = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpChucNangTacGia = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpDanhSachTacGia = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNgSinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.grpNhapNhanVien2 = new System.Windows.Forms.GroupBox();
            this.grpNhapNhanVien1.SuspendLayout();
            this.grpChucNangTacGia.SuspendLayout();
            this.grpDanhSachTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grpNhapNhanVien2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhapNhanVien1
            // 
            this.grpNhapNhanVien1.BackColor = System.Drawing.Color.Transparent;
            this.grpNhapNhanVien1.Controls.Add(this.cboPhai);
            this.grpNhapNhanVien1.Controls.Add(this.txtTenNhanVien);
            this.grpNhapNhanVien1.Controls.Add(this.txtMaNhanVien);
            this.grpNhapNhanVien1.Controls.Add(this.label6);
            this.grpNhapNhanVien1.Controls.Add(this.label5);
            this.grpNhapNhanVien1.Controls.Add(this.label2);
            this.grpNhapNhanVien1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapNhanVien1.ForeColor = System.Drawing.Color.White;
            this.grpNhapNhanVien1.Location = new System.Drawing.Point(271, 107);
            this.grpNhapNhanVien1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNhapNhanVien1.Name = "grpNhapNhanVien1";
            this.grpNhapNhanVien1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNhapNhanVien1.Size = new System.Drawing.Size(527, 262);
            this.grpNhapNhanVien1.TabIndex = 1;
            this.grpNhapNhanVien1.TabStop = false;
            this.grpNhapNhanVien1.Text = "Nhân viên";
            // 
            // cboPhai
            // 
            this.cboPhai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboPhai.Location = new System.Drawing.Point(199, 184);
            this.cboPhai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(299, 33);
            this.cboPhai.TabIndex = 3;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BackColor = System.Drawing.Color.White;
            this.txtTenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(201, 110);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(298, 31);
            this.txtTenNhanVien.TabIndex = 2;
            //this.txtTenNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNhanVien_KeyPress);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BackColor = System.Drawing.Color.White;
            this.txtMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(200, 36);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(298, 31);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nhân viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoạt Động",
            "Ngưng Hoạt Động"});
            this.cboTrangThai.Location = new System.Drawing.Point(183, 183);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(279, 33);
            this.cboTrangThai.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpChucNangTacGia
            // 
            this.grpChucNangTacGia.BackColor = System.Drawing.Color.Transparent;
            this.grpChucNangTacGia.Controls.Add(this.btnThoat);
            this.grpChucNangTacGia.Controls.Add(this.btnHuy);
            this.grpChucNangTacGia.Controls.Add(this.btnLuu);
            this.grpChucNangTacGia.Controls.Add(this.btnXoa);
            this.grpChucNangTacGia.Controls.Add(this.btnSua);
            this.grpChucNangTacGia.Controls.Add(this.btnThem);
            this.grpChucNangTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNangTacGia.ForeColor = System.Drawing.Color.White;
            this.grpChucNangTacGia.Location = new System.Drawing.Point(1365, 107);
            this.grpChucNangTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChucNangTacGia.Name = "grpChucNangTacGia";
            this.grpChucNangTacGia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChucNangTacGia.Size = new System.Drawing.Size(264, 262);
            this.grpChucNangTacGia.TabIndex = 3;
            this.grpChucNangTacGia.TabStop = false;
            this.grpChucNangTacGia.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(147, 190);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(35, 190);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 41);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(147, 116);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 41);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(35, 116);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 41);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(147, 43);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 41);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(35, 42);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 41);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpDanhSachTacGia
            // 
            this.grpDanhSachTacGia.BackColor = System.Drawing.Color.Transparent;
            this.grpDanhSachTacGia.Controls.Add(this.dgvDanhSach);
            this.grpDanhSachTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachTacGia.ForeColor = System.Drawing.Color.White;
            this.grpDanhSachTacGia.Location = new System.Drawing.Point(271, 399);
            this.grpDanhSachTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDanhSachTacGia.Name = "grpDanhSachTacGia";
            this.grpDanhSachTacGia.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDanhSachTacGia.Size = new System.Drawing.Size(1358, 268);
            this.grpDanhSachTacGia.TabIndex = 4;
            this.grpDanhSachTacGia.TabStop = false;
            this.grpDanhSachTacGia.Text = "Danh sách tác giả";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dgvDanhSach.ColumnHeadersHeight = 29;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.phai,
            this.ngsinh,
            this.sdt,
            this.trangthai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.Location = new System.Drawing.Point(13, 39);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(1320, 207);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellValueChanged);
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            // 
            // phai
            // 
            this.phai.DataPropertyName = "phai";
            this.phai.HeaderText = "Phái";
            this.phai.MinimumWidth = 6;
            this.phai.Name = "phai";
            this.phai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ngsinh
            // 
            this.ngsinh.DataPropertyName = "ngsinh";
            this.ngsinh.HeaderText = "Ngày sinh";
            this.ngsinh.MinimumWidth = 6;
            this.ngsinh.Name = "ngsinh";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangthai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateNgSinh
            // 
            this.dateNgSinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgSinh.Location = new System.Drawing.Point(183, 33);
            this.dateNgSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgSinh.Name = "dateNgSinh";
            this.dateNgSinh.Size = new System.Drawing.Size(279, 31);
            this.dateNgSinh.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "NgSinh";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số điện thoại";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(183, 108);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(279, 31);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // grpNhapNhanVien2
            // 
            this.grpNhapNhanVien2.BackColor = System.Drawing.Color.Transparent;
            this.grpNhapNhanVien2.Controls.Add(this.dateNgSinh);
            this.grpNhapNhanVien2.Controls.Add(this.label8);
            this.grpNhapNhanVien2.Controls.Add(this.label4);
            this.grpNhapNhanVien2.Controls.Add(this.cboTrangThai);
            this.grpNhapNhanVien2.Controls.Add(this.label7);
            this.grpNhapNhanVien2.Controls.Add(this.txtSDT);
            this.grpNhapNhanVien2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapNhanVien2.ForeColor = System.Drawing.Color.White;
            this.grpNhapNhanVien2.Location = new System.Drawing.Point(833, 108);
            this.grpNhapNhanVien2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNhapNhanVien2.Name = "grpNhapNhanVien2";
            this.grpNhapNhanVien2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNhapNhanVien2.Size = new System.Drawing.Size(489, 261);
            this.grpNhapNhanVien2.TabIndex = 2;
            this.grpNhapNhanVien2.TabStop = false;
            this.grpNhapNhanVien2.Text = "Nhân Viên";
            this.grpNhapNhanVien2.Enter += new System.EventHandler(this.grpNhapNhanVien2_Enter);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1768, 802);
            this.Controls.Add(this.grpNhapNhanVien2);
            this.Controls.Add(this.grpDanhSachTacGia);
            this.Controls.Add(this.grpChucNangTacGia);
            this.Controls.Add(this.grpNhapNhanVien1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanVien";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.grpNhapNhanVien1.ResumeLayout(false);
            this.grpNhapNhanVien1.PerformLayout();
            this.grpChucNangTacGia.ResumeLayout(false);
            this.grpDanhSachTacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grpNhapNhanVien2.ResumeLayout(false);
            this.grpNhapNhanVien2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpNhapNhanVien1;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpChucNangTacGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grpDanhSachTacGia;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPhai;
        private System.Windows.Forms.DateTimePicker dateNgSinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpNhapNhanVien2;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}

