namespace Bai4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            lblTenBenhNhan = new System.Windows.Forms.Label();
            txtTenBenhNhan = new System.Windows.Forms.TextBox();
            lblSDT = new System.Windows.Forms.Label();
            txtSDT = new System.Windows.Forms.TextBox();
            lblNgayKham = new System.Windows.Forms.Label();
            dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            lblGioKham = new System.Windows.Forms.Label();
            dtpGioKham = new System.Windows.Forms.DateTimePicker();
            lblBacSi = new System.Windows.Forms.Label();
            cboBacSi = new System.Windows.Forms.ComboBox();
            lblTrangThai = new System.Windows.Forms.Label();
            cboTrangThai = new System.Windows.Forms.ComboBox();
            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            lblTuNgay = new System.Windows.Forms.Label();
            dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            lblDenNgay = new System.Windows.Forms.Label();
            dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            cboTimKiemBacSi = new System.Windows.Forms.ComboBox();
            btnTimKiem = new System.Windows.Forms.Button();
            btnQuanLyBacSi = new System.Windows.Forms.Button();
            dgvLichKham = new System.Windows.Forms.DataGridView();
            colMaLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTenBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGioKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtMaLich = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTenBenhNhan
            // 
            lblTenBenhNhan.AutoSize = true;
            lblTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTenBenhNhan.Location = new System.Drawing.Point(25, 25);
            lblTenBenhNhan.Name = "lblTenBenhNhan";
            lblTenBenhNhan.Size = new System.Drawing.Size(128, 23);
            lblTenBenhNhan.TabIndex = 0;
            lblTenBenhNhan.Text = "Tên bệnh nhân:";
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTenBenhNhan.Location = new System.Drawing.Point(155, 22);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new System.Drawing.Size(240, 30);
            txtTenBenhNhan.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSDT.Location = new System.Drawing.Point(25, 68);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new System.Drawing.Size(115, 23);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSDT.Location = new System.Drawing.Point(155, 65);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(240, 30);
            txtSDT.TabIndex = 3;
            // 
            // lblNgayKham
            // 
            lblNgayKham.AutoSize = true;
            lblNgayKham.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblNgayKham.Location = new System.Drawing.Point(25, 112);
            lblNgayKham.Name = "lblNgayKham";
            lblNgayKham.Size = new System.Drawing.Size(102, 23);
            lblNgayKham.TabIndex = 4;
            lblNgayKham.Text = "Ngày khám:";
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            dtpNgayKham.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpNgayKham.Location = new System.Drawing.Point(155, 107);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new System.Drawing.Size(240, 30);
            dtpNgayKham.TabIndex = 5;
            // 
            // lblGioKham
            // 
            lblGioKham.AutoSize = true;
            lblGioKham.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblGioKham.Location = new System.Drawing.Point(415, 68);
            lblGioKham.Name = "lblGioKham";
            lblGioKham.Size = new System.Drawing.Size(87, 23);
            lblGioKham.TabIndex = 6;
            lblGioKham.Text = "Giờ khám:";
            // 
            // dtpGioKham
            // 
            dtpGioKham.CustomFormat = "HH:mm";
            dtpGioKham.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpGioKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpGioKham.Location = new System.Drawing.Point(415, 107);
            dtpGioKham.Name = "dtpGioKham";
            dtpGioKham.ShowUpDown = true;
            dtpGioKham.Size = new System.Drawing.Size(120, 30);
            dtpGioKham.TabIndex = 7;
            // 
            // lblBacSi
            // 
            lblBacSi.AutoSize = true;
            lblBacSi.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblBacSi.Location = new System.Drawing.Point(555, 68);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new System.Drawing.Size(61, 23);
            lblBacSi.TabIndex = 8;
            lblBacSi.Text = "Bác sĩ:";
            // 
            // cboBacSi
            // 
            cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboBacSi.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboBacSi.FormattingEnabled = true;
            cboBacSi.Location = new System.Drawing.Point(555, 106);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new System.Drawing.Size(280, 29);
            cboBacSi.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTrangThai.Location = new System.Drawing.Point(855, 68);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new System.Drawing.Size(91, 23);
            lblTrangThai.TabIndex = 10;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "Đã khám", "Đã hủy" });
            cboTrangThai.Location = new System.Drawing.Point(855, 106);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new System.Drawing.Size(165, 29);
            cboTrangThai.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnThem.Location = new System.Drawing.Point(680, 19);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(80, 36);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnSua.Location = new System.Drawing.Point(768, 19);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(80, 36);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnXoa.Location = new System.Drawing.Point(856, 19);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(80, 36);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnLamMoi.Location = new System.Drawing.Point(944, 19);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(85, 36);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTuNgay.Location = new System.Drawing.Point(25, 162);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new System.Drawing.Size(75, 23);
            lblTuNgay.TabIndex = 16;
            lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new System.Drawing.Point(105, 158);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new System.Drawing.Size(130, 30);
            dtpTuNgay.TabIndex = 17;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblDenNgay.Location = new System.Drawing.Point(245, 162);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new System.Drawing.Size(87, 23);
            lblDenNgay.TabIndex = 18;
            lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new System.Drawing.Point(335, 158);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new System.Drawing.Size(130, 30);
            dtpDenNgay.TabIndex = 19;
            // 
            // cboTimKiemBacSi
            // 
            cboTimKiemBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTimKiemBacSi.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboTimKiemBacSi.FormattingEnabled = true;
            cboTimKiemBacSi.Location = new System.Drawing.Point(480, 158);
            cboTimKiemBacSi.Name = "cboTimKiemBacSi";
            cboTimKiemBacSi.Size = new System.Drawing.Size(260, 29);
            cboTimKiemBacSi.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnTimKiem.Location = new System.Drawing.Point(755, 154);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(110, 36);
            btnTimKiem.TabIndex = 21;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnQuanLyBacSi
            // 
            btnQuanLyBacSi.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnQuanLyBacSi.Location = new System.Drawing.Point(895, 154);
            btnQuanLyBacSi.Name = "btnQuanLyBacSi";
            btnQuanLyBacSi.Size = new System.Drawing.Size(135, 36);
            btnQuanLyBacSi.TabIndex = 22;
            btnQuanLyBacSi.Text = "QL Bác sĩ";
            btnQuanLyBacSi.UseVisualStyleBackColor = true;
            btnQuanLyBacSi.Click += btnQuanLyBacSi_Click;
            // 
            // dgvLichKham
            // 
            dgvLichKham.AllowUserToAddRows = false;
            dgvLichKham.AllowUserToDeleteRows = false;
            dgvLichKham.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvLichKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichKham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvLichKham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLichKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaLich, colTenBenhNhan, colSDT, colNgayKham, colGioKham, colBacSi, colChuyenKhoa, colTrangThai });
            dgvLichKham.Location = new System.Drawing.Point(25, 210);
            dgvLichKham.MultiSelect = false;
            dgvLichKham.Name = "dgvLichKham";
            dgvLichKham.ReadOnly = true;
            dgvLichKham.RowHeadersWidth = 45;
            dgvLichKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLichKham.Size = new System.Drawing.Size(1005, 340);
            dgvLichKham.TabIndex = 23;
            dgvLichKham.SelectionChanged += dgvLichKham_SelectionChanged;
            // 
            // colMaLich
            // 
            colMaLich.DataPropertyName = "MaLich";
            colMaLich.FillWeight = 50F;
            colMaLich.HeaderText = "Mã lịch";
            colMaLich.MinimumWidth = 60;
            colMaLich.Name = "colMaLich";
            colMaLich.ReadOnly = true;
            // 
            // colTenBenhNhan
            // 
            colTenBenhNhan.DataPropertyName = "TenBenhNhan";
            colTenBenhNhan.FillWeight = 110F;
            colTenBenhNhan.HeaderText = "Tên bệnh nhân";
            colTenBenhNhan.MinimumWidth = 100;
            colTenBenhNhan.Name = "colTenBenhNhan";
            colTenBenhNhan.ReadOnly = true;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "Sdt";
            colSDT.FillWeight = 85F;
            colSDT.HeaderText = "SĐT";
            colSDT.MinimumWidth = 80;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            // 
            // colNgayKham
            // 
            colNgayKham.DataPropertyName = "NgayKhamFormatted";
            colNgayKham.FillWeight = 85F;
            colNgayKham.HeaderText = "Ngày khám";
            colNgayKham.MinimumWidth = 80;
            colNgayKham.Name = "colNgayKham";
            colNgayKham.ReadOnly = true;
            // 
            // colGioKham
            // 
            colGioKham.DataPropertyName = "GioKham";
            colGioKham.FillWeight = 65F;
            colGioKham.HeaderText = "Giờ khám";
            colGioKham.MinimumWidth = 60;
            colGioKham.Name = "colGioKham";
            colGioKham.ReadOnly = true;
            // 
            // colBacSi
            // 
            colBacSi.DataPropertyName = "TenBacSiHienThi";
            colBacSi.FillWeight = 140F;
            colBacSi.HeaderText = "Bác sĩ";
            colBacSi.MinimumWidth = 120;
            colBacSi.Name = "colBacSi";
            colBacSi.ReadOnly = true;
            // 
            // colChuyenKhoa
            // 
            colChuyenKhoa.DataPropertyName = "ChuyenKhoa";
            colChuyenKhoa.FillWeight = 90F;
            colChuyenKhoa.HeaderText = "Chuyên khoa";
            colChuyenKhoa.MinimumWidth = 80;
            colChuyenKhoa.Name = "colChuyenKhoa";
            colBacSi.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.FillWeight = 80F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 70;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // txtMaLich
            // 
            txtMaLich.Location = new System.Drawing.Point(25, 2);
            txtMaLich.Name = "txtMaLich";
            txtMaLich.Size = new System.Drawing.Size(50, 27);
            txtMaLich.TabIndex = 24;
            txtMaLich.Visible = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1055, 570);
            Controls.Add(txtMaLich);
            Controls.Add(dgvLichKham);
            Controls.Add(btnQuanLyBacSi);
            Controls.Add(btnTimKiem);
            Controls.Add(cboTimKiemBacSi);
            Controls.Add(dtpDenNgay);
            Controls.Add(lblDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(lblTuNgay);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboTrangThai);
            Controls.Add(lblTrangThai);
            Controls.Add(cboBacSi);
            Controls.Add(lblBacSi);
            Controls.Add(dtpGioKham);
            Controls.Add(lblGioKham);
            Controls.Add(dtpNgayKham);
            Controls.Add(lblNgayKham);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(lblTenBenhNhan);
            MinimumSize = new System.Drawing.Size(950, 520);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản Lý Lịch Khám Bệnh - An Khang Clinic";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTenBenhNhan;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label lblGioKham;
        private System.Windows.Forms.DateTimePicker dtpGioKham;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.ComboBox cboTimKiemBacSi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnQuanLyBacSi;
        private System.Windows.Forms.DataGridView dgvLichKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.TextBox txtMaLich;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
