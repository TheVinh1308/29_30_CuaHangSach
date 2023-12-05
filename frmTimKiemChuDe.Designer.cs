namespace _29_30_CuaHangSach
{
    partial class frmTimKiemChuDe
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
            this.txtTimKiemChuDe = new System.Windows.Forms.TextBox();
            this.grbThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTenChuDe = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMaChuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHIenThiTatCa = new System.Windows.Forms.Button();
            this.btnThemChuDe = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(991, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Chủ Đề";
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
            // txtTimKiemChuDe
            // 
            this.txtTimKiemChuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemChuDe.Location = new System.Drawing.Point(178, 102);
            this.txtTimKiemChuDe.Name = "txtTimKiemChuDe";
            this.txtTimKiemChuDe.Size = new System.Drawing.Size(284, 27);
            this.txtTimKiemChuDe.TabIndex = 6;
            this.txtTimKiemChuDe.TextChanged += new System.EventHandler(this.txtTimKiemChuDe_TextChanged);
            // 
            // grbThongTinSanPham
            // 
            this.grbThongTinSanPham.Controls.Add(this.label10);
            this.grbThongTinSanPham.Controls.Add(this.lblTenChuDe);
            this.grbThongTinSanPham.Controls.Add(this.label9);
            this.grbThongTinSanPham.Controls.Add(this.lblTrangThai);
            this.grbThongTinSanPham.Controls.Add(this.label8);
            this.grbThongTinSanPham.Controls.Add(this.lblMaChuDe);
            this.grbThongTinSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinSanPham.ForeColor = System.Drawing.Color.White;
            this.grbThongTinSanPham.Location = new System.Drawing.Point(27, 154);
            this.grbThongTinSanPham.Name = "grbThongTinSanPham";
            this.grbThongTinSanPham.Size = new System.Drawing.Size(379, 223);
            this.grbThongTinSanPham.TabIndex = 8;
            this.grbThongTinSanPham.TabStop = false;
            this.grbThongTinSanPham.Text = "Thông tin chủ đề";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 33);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên chủ đề";
            // 
            // lblTenChuDe
            // 
            this.lblTenChuDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTenChuDe.Location = new System.Drawing.Point(151, 101);
            this.lblTenChuDe.Name = "lblTenChuDe";
            this.lblTenChuDe.Size = new System.Drawing.Size(200, 33);
            this.lblTenChuDe.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 33);
            this.label9.TabIndex = 1;
            this.label9.Text = "Trạng Thái";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrangThai.Location = new System.Drawing.Point(151, 165);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(200, 33);
            this.lblTrangThai.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã chủ đề";
            // 
            // lblMaChuDe
            // 
            this.lblMaChuDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaChuDe.Location = new System.Drawing.Point(151, 37);
            this.lblMaChuDe.Name = "lblMaChuDe";
            this.lblMaChuDe.Size = new System.Drawing.Size(200, 33);
            this.lblMaChuDe.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSach);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(428, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 223);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chủ đề";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloai,
            this.tennv,
            this.trangthai});
            this.dgvDanhSach.Location = new System.Drawing.Point(23, 39);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(492, 159);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.DoubleClick += new System.EventHandler(this.dgvDanhSach_DoubleClick);
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "macd";
            this.maloai.HeaderText = "Mã Chủ Đề";
            this.maloai.MinimumWidth = 6;
            this.maloai.Name = "maloai";
            this.maloai.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tencd";
            this.tennv.HeaderText = "Tên Chủ Đề";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
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
            this.btnHIenThiTatCa.Location = new System.Drawing.Point(735, 105);
            this.btnHIenThiTatCa.Name = "btnHIenThiTatCa";
            this.btnHIenThiTatCa.Size = new System.Drawing.Size(220, 43);
            this.btnHIenThiTatCa.TabIndex = 10;
            this.btnHIenThiTatCa.Text = "Hiển thị tất cả";
            this.btnHIenThiTatCa.UseVisualStyleBackColor = false;
            this.btnHIenThiTatCa.Click += new System.EventHandler(this.btnHIenThiTatCa_Click);
            // 
            // btnThemChuDe
            // 
            this.btnThemChuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnThemChuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChuDe.ForeColor = System.Drawing.Color.White;
            this.btnThemChuDe.Location = new System.Drawing.Point(879, 12);
            this.btnThemChuDe.Name = "btnThemChuDe";
            this.btnThemChuDe.Size = new System.Drawing.Size(76, 38);
            this.btnThemChuDe.TabIndex = 11;
            this.btnThemChuDe.Text = "Thêm";
            this.btnThemChuDe.UseVisualStyleBackColor = false;
            this.btnThemChuDe.Click += new System.EventHandler(this.btnThemChuDe_Click);
            // 
            // frmTimKiemChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(991, 444);
            this.Controls.Add(this.btnThemChuDe);
            this.Controls.Add(this.btnHIenThiTatCa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongTinSanPham);
            this.Controls.Add(this.txtTimKiemChuDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiemChuDe";
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
        private System.Windows.Forms.TextBox txtTimKiemChuDe;
        private System.Windows.Forms.GroupBox grbThongTinSanPham;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTenChuDe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaChuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnHIenThiTatCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Button btnThemChuDe;
    }
}