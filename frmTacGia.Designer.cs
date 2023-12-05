namespace _29_30_CuaHangSach
{
    partial class frmTacGia
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
            this.grpNhapTacGia = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.matg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNhapTacGia.SuspendLayout();
            this.grpChucNangTacGia.SuspendLayout();
            this.grpDanhSachTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNhapTacGia
            // 
            this.grpNhapTacGia.BackColor = System.Drawing.Color.Transparent;
            this.grpNhapTacGia.Controls.Add(this.cboTrangThai);
            this.grpNhapTacGia.Controls.Add(this.txtTenTG);
            this.grpNhapTacGia.Controls.Add(this.txtMaTG);
            this.grpNhapTacGia.Controls.Add(this.label4);
            this.grpNhapTacGia.Controls.Add(this.label5);
            this.grpNhapTacGia.Controls.Add(this.label2);
            this.grpNhapTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapTacGia.ForeColor = System.Drawing.Color.White;
            this.grpNhapTacGia.Location = new System.Drawing.Point(212, 87);
            this.grpNhapTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNhapTacGia.Name = "grpNhapTacGia";
            this.grpNhapTacGia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNhapTacGia.Size = new System.Drawing.Size(342, 216);
            this.grpNhapTacGia.TabIndex = 1;
            this.grpNhapTacGia.TabStop = false;
            this.grpNhapTacGia.Text = "Tác Giả";
            this.grpNhapTacGia.Enter += new System.EventHandler(this.grpNhapTacGia_Enter);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Ngưng hoạt động"});
            this.cboTrangThai.Location = new System.Drawing.Point(116, 158);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(176, 27);
            this.cboTrangThai.TabIndex = 3;
            // 
            // txtTenTG
            // 
            this.txtTenTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTG.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(116, 99);
            this.txtTenTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.ReadOnly = true;
            this.txtTenTG.Size = new System.Drawing.Size(175, 27);
            this.txtTenTG.TabIndex = 2;
            this.txtTenTG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenTG_KeyPress);
            // 
            // txtMaTG
            // 
            this.txtMaTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaTG.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(116, 33);
            this.txtMaTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.ReadOnly = true;
            this.txtMaTG.Size = new System.Drawing.Size(175, 27);
            this.txtMaTG.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên tác giả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tác giả";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.grpChucNangTacGia.Location = new System.Drawing.Point(212, 317);
            this.grpChucNangTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChucNangTacGia.Name = "grpChucNangTacGia";
            this.grpChucNangTacGia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpChucNangTacGia.Size = new System.Drawing.Size(342, 125);
            this.grpChucNangTacGia.TabIndex = 2;
            this.grpChucNangTacGia.TabStop = false;
            this.grpChucNangTacGia.Text = "Chức năng";
            this.grpChucNangTacGia.Enter += new System.EventHandler(this.grpChucNangTacGia_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(232, 78);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 33);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(131, 78);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(69, 33);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(232, 32);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(69, 33);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(50, 78);
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
            this.btnSua.Location = new System.Drawing.Point(131, 32);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 33);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(50, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 33);
            this.btnThem.TabIndex = 1;
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
            this.grpDanhSachTacGia.Location = new System.Drawing.Point(578, 87);
            this.grpDanhSachTacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDanhSachTacGia.Name = "grpDanhSachTacGia";
            this.grpDanhSachTacGia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDanhSachTacGia.Size = new System.Drawing.Size(485, 355);
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
            this.matg,
            this.tentg,
            this.trangthai});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSach.Location = new System.Drawing.Point(16, 29);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDanhSach.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(452, 302);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellValueChanged);
            // 
            // matg
            // 
            this.matg.DataPropertyName = "matg";
            this.matg.HeaderText = "Mã tác giả";
            this.matg.MinimumWidth = 6;
            this.matg.Name = "matg";
            this.matg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tentg
            // 
            this.tentg.DataPropertyName = "tentg";
            this.tentg.HeaderText = "Tên tác giả";
            this.tentg.MinimumWidth = 6;
            this.tentg.Name = "tentg";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 652);
            this.Controls.Add(this.grpDanhSachTacGia);
            this.Controls.Add(this.grpChucNangTacGia);
            this.Controls.Add(this.grpNhapTacGia);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTacGia_FormClosing);
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            this.grpNhapTacGia.ResumeLayout(false);
            this.grpNhapTacGia.PerformLayout();
            this.grpChucNangTacGia.ResumeLayout(false);
            this.grpDanhSachTacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpNhapTacGia;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtMaTG;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn matg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentg;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}

