namespace Bai1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblMaTheLoai = new Label();
            txtMaTL = new TextBox();
            lblTenTheLoai = new Label();
            txtTenTL = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            lblNgayTaoTitle = new Label();
            lblNgayTao = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvTheLoai = new DataGridView();
            colMaTL = new DataGridViewTextBoxColumn();
            colTenTheLoai = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            colSoLuongSach = new DataGridViewTextBoxColumn();
            colNgayTao = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMaTheLoai
            // 
            lblMaTheLoai.AutoSize = true;
            lblMaTheLoai.Font = new Font("Segoe UI", 10F);
            lblMaTheLoai.Location = new Point(30, 30);
            lblMaTheLoai.Name = "lblMaTheLoai";
            lblMaTheLoai.Size = new Size(96, 23);
            lblMaTheLoai.TabIndex = 0;
            lblMaTheLoai.Text = "Mã thể loại";
            // 
            // txtMaTL
            // 
            txtMaTL.Font = new Font("Segoe UI", 10F);
            txtMaTL.Location = new Point(145, 27);
            txtMaTL.Name = "txtMaTL";
            txtMaTL.PlaceholderText = "ReadOnly";
            txtMaTL.Size = new Size(270, 30);
            txtMaTL.TabIndex = 1;
            // 
            // lblTenTheLoai
            // 
            lblTenTheLoai.AutoSize = true;
            lblTenTheLoai.Font = new Font("Segoe UI", 10F);
            lblTenTheLoai.Location = new Point(30, 75);
            lblTenTheLoai.Name = "lblTenTheLoai";
            lblTenTheLoai.Size = new Size(98, 23);
            lblTenTheLoai.TabIndex = 2;
            lblTenTheLoai.Text = "Tên thể loại";
            // 
            // txtTenTL
            // 
            txtTenTL.Font = new Font("Segoe UI", 10F);
            txtTenTL.Location = new Point(145, 72);
            txtTenTL.Name = "txtTenTL";
            txtTenTL.Size = new Size(270, 30);
            txtTenTL.TabIndex = 3;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 10F);
            lblMoTa.Location = new Point(30, 120);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(55, 23);
            lblMoTa.TabIndex = 4;
            lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 10F);
            txtMoTa.Location = new Point(145, 117);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(270, 90);
            txtMoTa.TabIndex = 5;
            // 
            // lblNgayTaoTitle
            // 
            lblNgayTaoTitle.AutoSize = true;
            lblNgayTaoTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblNgayTaoTitle.ForeColor = Color.DimGray;
            lblNgayTaoTitle.Location = new Point(30, 218);
            lblNgayTaoTitle.Name = "lblNgayTaoTitle";
            lblNgayTaoTitle.Size = new Size(78, 21);
            lblNgayTaoTitle.TabIndex = 6;
            lblNgayTaoTitle.Text = "Ngày tạo:";
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Font = new Font("Segoe UI", 9.5F);
            lblNgayTao.ForeColor = Color.DimGray;
            lblNgayTao.Location = new Point(145, 218);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(28, 21);
            lblNgayTao.TabIndex = 7;
            lblNgayTao.Text = "---";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(530, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 36);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(635, 24);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 36);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(740, 24);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 36);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 10F);
            btnLamMoi.Location = new Point(845, 24);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(95, 36);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(30, 255);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên thể loại cần tìm...";
            txtTimKiem.Size = new Size(385, 30);
            txtTimKiem.TabIndex = 12;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10F);
            btnTimKiem.Location = new Point(425, 252);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 36);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AllowUserToDeleteRows = false;
            dgvTheLoai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoai.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Columns.AddRange(new DataGridViewColumn[] { colMaTL, colTenTheLoai, colMoTa, colSoLuongSach, colNgayTao });
            dgvTheLoai.Location = new Point(30, 305);
            dgvTheLoai.MultiSelect = false;
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.RowHeadersWidth = 51;
            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.Size = new Size(910, 240);
            dgvTheLoai.TabIndex = 14;
            dgvTheLoai.SelectionChanged += dgvTheLoai_SelectionChanged;
            // 
            // colMaTL
            // 
            colMaTL.DataPropertyName = "MaTl";
            colMaTL.FillWeight = 50F;
            colMaTL.HeaderText = "Mã TL";
            colMaTL.MinimumWidth = 60;
            colMaTL.Name = "colMaTL";
            colMaTL.ReadOnly = true;
            // 
            // colTenTheLoai
            // 
            colTenTheLoai.DataPropertyName = "TenTheLoai";
            colTenTheLoai.FillWeight = 110F;
            colTenTheLoai.HeaderText = "Tên thể loại";
            colTenTheLoai.MinimumWidth = 100;
            colTenTheLoai.Name = "colTenTheLoai";
            colTenTheLoai.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.DataPropertyName = "MoTa";
            colMoTa.FillWeight = 160F;
            colMoTa.HeaderText = "Mô tả";
            colMoTa.MinimumWidth = 120;
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // colSoLuongSach
            // 
            colSoLuongSach.DataPropertyName = "SoLuongSach";
            colSoLuongSach.FillWeight = 70F;
            colSoLuongSach.HeaderText = "Số lượng sách";
            colSoLuongSach.MinimumWidth = 80;
            colSoLuongSach.Name = "colSoLuongSach";
            colSoLuongSach.ReadOnly = true;
            // 
            // colNgayTao
            // 
            colNgayTao.DataPropertyName = "NgayTao";
            dataGridViewCellStyle2.Format = "yyyy/MM/dd HH:mm:ss";
            dataGridViewCellStyle2.NullValue = null;
            colNgayTao.DefaultCellStyle = dataGridViewCellStyle2;
            colNgayTao.FillWeight = 90F;
            colNgayTao.HeaderText = "Ngày tạo";
            colNgayTao.MinimumWidth = 100;
            colNgayTao.Name = "colNgayTao";
            colNgayTao.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 570);
            Controls.Add(dgvTheLoai);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblNgayTao);
            Controls.Add(lblNgayTaoTitle);
            Controls.Add(txtMoTa);
            Controls.Add(lblMoTa);
            Controls.Add(txtTenTL);
            Controls.Add(lblTenTheLoai);
            Controls.Add(txtMaTL);
            Controls.Add(lblMaTheLoai);
            MinimumSize = new Size(850, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thể Loại Sách - Tri Thức Books";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaTheLoai;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label lblTenTheLoai;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblNgayTaoTitle;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTao;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
