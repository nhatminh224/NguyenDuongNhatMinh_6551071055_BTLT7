namespace Bai3
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
            lblSoPhong = new Label();
            txtSoPhong = new TextBox();
            lblTangSo = new Label();
            nudTangSo = new NumericUpDown();
            lblLoaiPhong = new Label();
            cboLoaiPhong = new ComboBox();
            lblTinhTrang = new Label();
            cboTinhTrang = new ComboBox();
            picHinhAnh = new PictureBox();
            btnChonAnh = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnQLoaiPhong = new Button();
            cboLocLoaiPhong = new ComboBox();
            cboLocTinhTrang = new ComboBox();
            btnTimKiem = new Button();
            btnHienTatCa = new Button();
            dgvPhong = new DataGridView();
            colMaPhong = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            colSoPhong = new DataGridViewTextBoxColumn();
            colTang = new DataGridViewTextBoxColumn();
            colLoaiPhong = new DataGridViewTextBoxColumn();
            colGiaMoiDem = new DataGridViewTextBoxColumn();
            colTinhTrang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudTangSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            SuspendLayout();
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoPhong.Location = new Point(24, 16);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(65, 17);
            lblSoPhong.TabIndex = 0;
            lblSoPhong.Text = "Số phòng";
            // 
            // txtSoPhong
            // 
            txtSoPhong.Font = new Font("Segoe UI", 9.75F);
            txtSoPhong.Location = new Point(24, 38);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(110, 25);
            txtSoPhong.TabIndex = 1;
            // 
            // lblTangSo
            // 
            lblTangSo.AutoSize = true;
            lblTangSo.Font = new Font("Segoe UI", 9.75F);
            lblTangSo.Location = new Point(148, 16);
            lblTangSo.Name = "lblTangSo";
            lblTangSo.Size = new Size(54, 17);
            lblTangSo.TabIndex = 2;
            lblTangSo.Text = "Tầng số";
            // 
            // nudTangSo
            // 
            nudTangSo.Font = new Font("Segoe UI", 9.75F);
            nudTangSo.Location = new Point(148, 38);
            nudTangSo.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudTangSo.Name = "nudTangSo";
            nudTangSo.Size = new Size(80, 25);
            nudTangSo.TabIndex = 3;
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Font = new Font("Segoe UI", 9.75F);
            lblLoaiPhong.Location = new Point(242, 16);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(74, 17);
            lblLoaiPhong.TabIndex = 4;
            lblLoaiPhong.Text = "Loại phòng";
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhong.Font = new Font("Segoe UI", 9.75F);
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Location = new Point(242, 38);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(130, 25);
            cboLoaiPhong.TabIndex = 5;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Font = new Font("Segoe UI", 9.75F);
            lblTinhTrang.Location = new Point(386, 16);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(67, 17);
            lblTinhTrang.TabIndex = 6;
            lblTinhTrang.Text = "Tình trạng";
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.Font = new Font("Segoe UI", 9.75F);
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Items.AddRange(new object[] { "Trống", "Đang ở", "Đang dọn" });
            cboTinhTrang.Location = new Point(386, 38);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(115, 25);
            cboTinhTrang.TabIndex = 7;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(515, 14);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(80, 56);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 8;
            picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Segoe UI", 9F);
            btnChonAnh.Location = new Point(515, 75);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(80, 26);
            btnChonAnh.TabIndex = 9;
            btnChonAnh.Text = "Chọn ảnh...";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9.75F);
            btnThem.Location = new Point(615, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(68, 30);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9.75F);
            btnSua.Location = new Point(689, 34);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(68, 30);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9.75F);
            btnXoa.Location = new Point(763, 34);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(68, 30);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 9.75F);
            btnLamMoi.Location = new Point(837, 34);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 30);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnQLoaiPhong
            // 
            btnQLoaiPhong.Font = new Font("Segoe UI", 9F);
            btnQLoaiPhong.Location = new Point(763, 73);
            btnQLoaiPhong.Name = "btnQLoaiPhong";
            btnQLoaiPhong.Size = new Size(149, 28);
            btnQLoaiPhong.TabIndex = 14;
            btnQLoaiPhong.Text = "QL Loại phòng...";
            btnQLoaiPhong.UseVisualStyleBackColor = true;
            btnQLoaiPhong.Click += btnQLoaiPhong_Click;
            // 
            // cboLocLoaiPhong
            // 
            cboLocLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoaiPhong.Font = new Font("Segoe UI", 9.75F);
            cboLocLoaiPhong.FormattingEnabled = true;
            cboLocLoaiPhong.Location = new Point(24, 114);
            cboLocLoaiPhong.Name = "cboLocLoaiPhong";
            cboLocLoaiPhong.Size = new Size(185, 25);
            cboLocLoaiPhong.TabIndex = 15;
            // 
            // cboLocTinhTrang
            // 
            cboLocTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTinhTrang.Font = new Font("Segoe UI", 9.75F);
            cboLocTinhTrang.FormattingEnabled = true;
            cboLocTinhTrang.Items.AddRange(new object[] { "Lọc theo tình trạng", "Trống", "Đang ở", "Đang dọn" });
            cboLocTinhTrang.Location = new Point(220, 114);
            cboLocTinhTrang.Name = "cboLocTinhTrang";
            cboLocTinhTrang.Size = new Size(160, 25);
            cboLocTinhTrang.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9.75F);
            btnTimKiem.Location = new Point(390, 112);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(85, 28);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Font = new Font("Segoe UI", 9.75F);
            btnHienTatCa.Location = new Point(485, 112);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(85, 28);
            btnHienTatCa.TabIndex = 18;
            btnHienTatCa.Text = "Tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // dgvPhong
            // 
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToDeleteRows = false;
            dgvPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Columns.AddRange(new DataGridViewColumn[] { colMaPhong, colHinhAnh, colSoPhong, colTang, colLoaiPhong, colGiaMoiDem, colTinhTrang });
            dgvPhong.Location = new Point(24, 150);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowTemplate.Height = 50;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(888, 385);
            dgvPhong.TabIndex = 19;
            dgvPhong.CellClick += dgvPhong_CellClick;
            // 
            // colMaPhong
            // 
            colMaPhong.DataPropertyName = "MaPhong";
            colMaPhong.FillWeight = 60F;
            colMaPhong.HeaderText = "Mã phòng";
            colMaPhong.Name = "colMaPhong";
            colMaPhong.ReadOnly = true;
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnhThumb";
            colHinhAnh.FillWeight = 70F;
            colHinhAnh.HeaderText = "Ảnh";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.ReadOnly = true;
            // 
            // colSoPhong
            // 
            colSoPhong.DataPropertyName = "SoPhong";
            colSoPhong.FillWeight = 80F;
            colSoPhong.HeaderText = "Số phòng";
            colSoPhong.Name = "colSoPhong";
            colSoPhong.ReadOnly = true;
            // 
            // colTang
            // 
            colTang.DataPropertyName = "TangSo";
            colTang.FillWeight = 60F;
            colTang.HeaderText = "Tầng";
            colTang.Name = "colTang";
            colTang.ReadOnly = true;
            // 
            // colLoaiPhong
            // 
            colLoaiPhong.DataPropertyName = "TenLoai";
            colLoaiPhong.FillWeight = 110F;
            colLoaiPhong.HeaderText = "Loại phòng";
            colLoaiPhong.Name = "colLoaiPhong";
            colLoaiPhong.ReadOnly = true;
            // 
            // colGiaMoiDem
            // 
            colGiaMoiDem.DataPropertyName = "GiaMoiDemFormatted";
            colGiaMoiDem.FillWeight = 90F;
            colGiaMoiDem.HeaderText = "Giá/đêm";
            colGiaMoiDem.Name = "colGiaMoiDem";
            colGiaMoiDem.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            colTinhTrang.DataPropertyName = "TinhTrang";
            colTinhTrang.FillWeight = 80F;
            colTinhTrang.HeaderText = "Tình trạng";
            colTinhTrang.Name = "colTinhTrang";
            colTinhTrang.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 551);
            Controls.Add(dgvPhong);
            Controls.Add(btnHienTatCa);
            Controls.Add(btnTimKiem);
            Controls.Add(cboLocTinhTrang);
            Controls.Add(cboLocLoaiPhong);
            Controls.Add(btnQLoaiPhong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnChonAnh);
            Controls.Add(picHinhAnh);
            Controls.Add(cboTinhTrang);
            Controls.Add(lblTinhTrang);
            Controls.Add(cboLoaiPhong);
            Controls.Add(lblLoaiPhong);
            Controls.Add(nudTangSo);
            Controls.Add(lblTangSo);
            Controls.Add(txtSoPhong);
            Controls.Add(lblSoPhong);
            MinimumSize = new Size(920, 550);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phòng - Sunrise Homestay";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudTangSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoPhong;
        private TextBox txtSoPhong;
        private Label lblTangSo;
        private NumericUpDown nudTangSo;
        private Label lblLoaiPhong;
        private ComboBox cboLoaiPhong;
        private Label lblTinhTrang;
        private ComboBox cboTinhTrang;
        private PictureBox picHinhAnh;
        private Button btnChonAnh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnQLoaiPhong;
        private ComboBox cboLocLoaiPhong;
        private ComboBox cboLocTinhTrang;
        private Button btnTimKiem;
        private Button btnHienTatCa;
        private DataGridView dgvPhong;
        private DataGridViewTextBoxColumn colMaPhong;
        private DataGridViewImageColumn colHinhAnh;
        private DataGridViewTextBoxColumn colSoPhong;
        private DataGridViewTextBoxColumn colTang;
        private DataGridViewTextBoxColumn colLoaiPhong;
        private DataGridViewTextBoxColumn colGiaMoiDem;
        private DataGridViewTextBoxColumn colTinhTrang;
    }
}
