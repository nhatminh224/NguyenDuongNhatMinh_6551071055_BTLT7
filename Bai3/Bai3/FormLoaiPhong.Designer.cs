namespace Bai3
{
    partial class FormLoaiPhong
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
            gbThongTin = new GroupBox();
            txtMoTa = new TextBox();
            lblMoTa = new Label();
            txtGiaMoiDem = new TextBox();
            lblGiaMoiDem = new Label();
            txtTenLoai = new TextBox();
            lblTenLoai = new Label();
            txtMaLoai = new TextBox();
            lblMaLoai = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnDong = new Button();
            dgvLoaiPhong = new DataGridView();
            colMaLoai = new DataGridViewTextBoxColumn();
            colTenLoai = new DataGridViewTextBoxColumn();
            colGiaMoiDem = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(txtMoTa);
            gbThongTin.Controls.Add(lblMoTa);
            gbThongTin.Controls.Add(txtGiaMoiDem);
            gbThongTin.Controls.Add(lblGiaMoiDem);
            gbThongTin.Controls.Add(txtTenLoai);
            gbThongTin.Controls.Add(lblTenLoai);
            gbThongTin.Controls.Add(txtMaLoai);
            gbThongTin.Controls.Add(lblMaLoai);
            gbThongTin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbThongTin.Location = new Point(16, 14);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Size = new Size(682, 136);
            gbThongTin.TabIndex = 0;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin loại phòng";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(410, 68);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(256, 54);
            txtMoTa.TabIndex = 7;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(358, 71);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(46, 17);
            lblMoTa.TabIndex = 6;
            lblMoTa.Text = "Mô tả:";
            // 
            // txtGiaMoiDem
            // 
            txtGiaMoiDem.Location = new Point(410, 29);
            txtGiaMoiDem.Name = "txtGiaMoiDem";
            txtGiaMoiDem.Size = new Size(256, 25);
            txtGiaMoiDem.TabIndex = 5;
            // 
            // lblGiaMoiDem
            // 
            lblGiaMoiDem.AutoSize = true;
            lblGiaMoiDem.Location = new Point(320, 32);
            lblGiaMoiDem.Name = "lblGiaMoiDem";
            lblGiaMoiDem.Size = new Size(84, 17);
            lblGiaMoiDem.TabIndex = 4;
            lblGiaMoiDem.Text = "Giá mỗi đêm:";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(88, 71);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(210, 25);
            txtTenLoai.TabIndex = 3;
            // 
            // lblTenLoai
            // 
            lblTenLoai.AutoSize = true;
            lblTenLoai.Location = new Point(22, 74);
            lblTenLoai.Name = "lblTenLoai";
            lblTenLoai.Size = new Size(56, 17);
            lblTenLoai.TabIndex = 2;
            lblTenLoai.Text = "Tên loại:";
            // 
            // txtMaLoai
            // 
            txtMaLoai.BackColor = SystemColors.ControlLight;
            txtMaLoai.Location = new Point(88, 29);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.ReadOnly = true;
            txtMaLoai.Size = new Size(210, 25);
            txtMaLoai.TabIndex = 1;
            // 
            // lblMaLoai
            // 
            lblMaLoai.AutoSize = true;
            lblMaLoai.Location = new Point(22, 32);
            lblMaLoai.Name = "lblMaLoai";
            lblMaLoai.Size = new Size(55, 17);
            lblMaLoai.TabIndex = 0;
            lblMaLoai.Text = "Mã loại:";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9.75F);
            btnThem.Location = new Point(136, 160);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 32);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9.75F);
            btnSua.Location = new Point(238, 160);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 32);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9.75F);
            btnXoa.Location = new Point(340, 160);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 32);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 9.75F);
            btnLamMoi.Location = new Point(442, 160);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(85, 32);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 9.75F);
            btnDong.Location = new Point(544, 160);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(85, 32);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AllowUserToAddRows = false;
            dgvLoaiPhong.AllowUserToDeleteRows = false;
            dgvLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { colMaLoai, colTenLoai, colGiaMoiDem, colMoTa });
            dgvLoaiPhong.Location = new Point(16, 206);
            dgvLoaiPhong.MultiSelect = false;
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.RowHeadersVisible = false;
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.Size = new Size(682, 235);
            dgvLoaiPhong.TabIndex = 6;
            dgvLoaiPhong.CellClick += dgvLoaiPhong_CellClick;
            // 
            // colMaLoai
            // 
            colMaLoai.DataPropertyName = "MaLoai";
            colMaLoai.FillWeight = 50F;
            colMaLoai.HeaderText = "Mã loại";
            colMaLoai.Name = "colMaLoai";
            colMaLoai.ReadOnly = true;
            // 
            // colTenLoai
            // 
            colTenLoai.DataPropertyName = "TenLoai";
            colTenLoai.FillWeight = 110F;
            colTenLoai.HeaderText = "Tên loại phòng";
            colTenLoai.Name = "colTenLoai";
            colTenLoai.ReadOnly = true;
            // 
            // colGiaMoiDem
            // 
            colGiaMoiDem.DataPropertyName = "GiaMoiDemFormatted";
            colGiaMoiDem.FillWeight = 90F;
            colGiaMoiDem.HeaderText = "Giá mỗi đêm (VNĐ)";
            colGiaMoiDem.Name = "colGiaMoiDem";
            colGiaMoiDem.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.DataPropertyName = "MoTa";
            colMoTa.FillWeight = 150F;
            colMoTa.HeaderText = "Mô tả";
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // FormLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 456);
            Controls.Add(dgvLoaiPhong);
            Controls.Add(btnDong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(gbThongTin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLoaiPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý Loại Phòng";
            Load += FormLoaiPhong_Load;
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbThongTin;
        private Label lblMaLoai;
        private TextBox txtMaLoai;
        private Label lblTenLoai;
        private TextBox txtTenLoai;
        private Label lblGiaMoiDem;
        private TextBox txtGiaMoiDem;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnDong;
        private DataGridView dgvLoaiPhong;
        private DataGridViewTextBoxColumn colMaLoai;
        private DataGridViewTextBoxColumn colTenLoai;
        private DataGridViewTextBoxColumn colGiaMoiDem;
        private DataGridViewTextBoxColumn colMoTa;
    }
}
