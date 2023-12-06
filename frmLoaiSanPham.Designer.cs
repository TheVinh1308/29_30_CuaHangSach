namespace _29_30_CuaHangSach
{
    partial class frmLoaiSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpLoaiSanPham = new System.Windows.Forms.GroupBox();
            this.cbbTrangThaiLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpChucNangTacGia = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpDanhSachTacGia = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.maloaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLoaiSanPham.SuspendLayout();
            this.grpChucNangTacGia.SuspendLayout();
            this.grpDanhSachTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoaiSanPham
            // 
            this.grpLoaiSanPham.BackColor = System.Drawing.Color.Transparent;
            this.grpLoaiSanPham.Controls.Add(this.cbbTrangThaiLoaiSP);
            this.grpLoaiSanPham.Controls.Add(this.txtTenLoaiSP);
            this.grpLoaiSanPham.Controls.Add(this.txtMaLoaiSP);
            this.grpLoaiSanPham.Controls.Add(this.label4);
            this.grpLoaiSanPham.Controls.Add(this.label3);
            this.grpLoaiSanPham.Controls.Add(this.label2);
            this.grpLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.grpLoaiSanPham.Location = new System.Drawing.Point(232, 126);
            this.grpLoaiSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLoaiSanPham.Name = "grpLoaiSanPham";
            this.grpLoaiSanPham.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpLoaiSanPham.Size = new System.Drawing.Size(325, 173);
            this.grpLoaiSanPham.TabIndex = 1;
            this.grpLoaiSanPham.TabStop = false;
            this.grpLoaiSanPham.Text = "Loại sản phẩm";
            this.grpLoaiSanPham.Enter += new System.EventHandler(this.grpLoaiSanPham_Enter);
            // 
            // cbbTrangThaiLoaiSP
            // 
            this.cbbTrangThaiLoaiSP.Enabled = false;
            this.cbbTrangThaiLoaiSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTrangThaiLoaiSP.FormattingEnabled = true;
            this.cbbTrangThaiLoaiSP.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbTrangThaiLoaiSP.Location = new System.Drawing.Point(116, 114);
            this.cbbTrangThaiLoaiSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTrangThaiLoaiSP.Name = "cbbTrangThaiLoaiSP";
            this.cbbTrangThaiLoaiSP.Size = new System.Drawing.Size(188, 27);
            this.cbbTrangThaiLoaiSP.TabIndex = 3;
            this.cbbTrangThaiLoaiSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbTrangThaiLoaiSP_KeyPress);
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiSP.Location = new System.Drawing.Point(116, 73);
            this.txtTenLoaiSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.ReadOnly = true;
            this.txtTenLoaiSP.Size = new System.Drawing.Size(188, 27);
            this.txtTenLoaiSP.TabIndex = 1;
            this.txtTenLoaiSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenLoaiSP_KeyPress);
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLoaiSP.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiSP.Location = new System.Drawing.Point(116, 28);
            this.txtMaLoaiSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.ReadOnly = true;
            this.txtMaLoaiSP.Size = new System.Drawing.Size(188, 27);
            this.txtMaLoaiSP.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Loại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã loại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.grpChucNangTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNangTacGia.ForeColor = System.Drawing.Color.White;
            this.grpChucNangTacGia.Location = new System.Drawing.Point(232, 357);
            this.grpChucNangTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChucNangTacGia.Name = "grpChucNangTacGia";
            this.grpChucNangTacGia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChucNangTacGia.Size = new System.Drawing.Size(325, 120);
            this.grpChucNangTacGia.TabIndex = 2;
            this.grpChucNangTacGia.TabStop = false;
            this.grpChucNangTacGia.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(235, 72);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 33);
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
            this.btnHuy.Location = new System.Drawing.Point(16, 72);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(69, 33);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(125, 72);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(69, 33);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(235, 24);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(125, 24);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 33);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(16, 24);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 33);
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
            this.grpDanhSachTacGia.Location = new System.Drawing.Point(591, 126);
            this.grpDanhSachTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDanhSachTacGia.Name = "grpDanhSachTacGia";
            this.grpDanhSachTacGia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDanhSachTacGia.Size = new System.Drawing.Size(530, 351);
            this.grpDanhSachTacGia.TabIndex = 3;
            this.grpDanhSachTacGia.TabStop = false;
            this.grpDanhSachTacGia.Text = "Danh sách tác giả";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dgvDanhSach.ColumnHeadersHeight = 29;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaisp,
            this.tenloai,
            this.trangthai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSach.Location = new System.Drawing.Point(11, 28);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(499, 308);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellValueChanged);
            // 
            // maloaisp
            // 
            this.maloaisp.DataPropertyName = "maloai";
            this.maloaisp.HeaderText = "Mã loại";
            this.maloaisp.MinimumWidth = 6;
            this.maloaisp.Name = "maloaisp";
            this.maloaisp.ReadOnly = true;
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Tên loại";
            this.tenloai.MinimumWidth = 6;
            this.tenloai.Name = "tenloai";
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
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 652);
            this.Controls.Add(this.grpDanhSachTacGia);
            this.Controls.Add(this.grpChucNangTacGia);
            this.Controls.Add(this.grpLoaiSanPham);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLoaiSanPham";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.grpLoaiSanPham.ResumeLayout(false);
            this.grpLoaiSanPham.PerformLayout();
            this.grpChucNangTacGia.ResumeLayout(false);
            this.grpDanhSachTacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpLoaiSanPham;
        private System.Windows.Forms.ComboBox cbbTrangThaiLoaiSP;
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}

