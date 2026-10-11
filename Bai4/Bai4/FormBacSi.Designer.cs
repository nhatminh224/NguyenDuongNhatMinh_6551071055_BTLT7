namespace Bai4
{
    partial class FormBacSi
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            lblMaBS = new System.Windows.Forms.Label();
            txtMaBS = new System.Windows.Forms.TextBox();
            lblHoTen = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            lblChuyenKhoa = new System.Windows.Forms.Label();
            txtChuyenKhoa = new System.Windows.Forms.TextBox();
            lblSDT = new System.Windows.Forms.Label();
            txtSDT = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            dgvBacSi = new System.Windows.Forms.DataGridView();
            colMaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvBacSi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMaBS
            // 
            lblMaBS.AutoSize = true;
            lblMaBS.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblMaBS.Location = new System.Drawing.Point(30, 25);
            lblMaBS.Name = "lblMaBS";
            lblMaBS.Size = new System.Drawing.Size(86, 23);
            lblMaBS.TabIndex = 0;
            lblMaBS.Text = "Mã bác sĩ:";
            // 
            // txtMaBS
            // 
            txtMaBS.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtMaBS.Location = new System.Drawing.Point(140, 22);
            txtMaBS.Name = "txtMaBS";
            txtMaBS.PlaceholderText = "Tự động tăng";
            txtMaBS.ReadOnly = true;
            txtMaBS.Size = new System.Drawing.Size(250, 30);
            txtMaBS.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblHoTen.Location = new System.Drawing.Point(30, 68);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(88, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên BS:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtHoTen.Location = new System.Drawing.Point(140, 65);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(250, 30);
            txtHoTen.TabIndex = 3;
            // 
            // lblChuyenKhoa
            // 
            lblChuyenKhoa.AutoSize = true;
            lblChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblChuyenKhoa.Location = new System.Drawing.Point(30, 111);
            lblChuyenKhoa.Name = "lblChuyenKhoa";
            lblChuyenKhoa.Size = new System.Drawing.Size(115, 23);
            lblChuyenKhoa.TabIndex = 4;
            lblChuyenKhoa.Text = "Chuyên khoa:";
            // 
            // txtChuyenKhoa
            // 
            txtChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtChuyenKhoa.Location = new System.Drawing.Point(140, 108);
            txtChuyenKhoa.Name = "txtChuyenKhoa";
            txtChuyenKhoa.Size = new System.Drawing.Size(250, 30);
            txtChuyenKhoa.TabIndex = 5;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSDT.Location = new System.Drawing.Point(30, 154);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new System.Drawing.Size(115, 23);
            lblSDT.TabIndex = 6;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSDT.Location = new System.Drawing.Point(140, 151);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(250, 30);
            txtSDT.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnThem.Location = new System.Drawing.Point(440, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(100, 35);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnSua.Location = new System.Drawing.Point(440, 63);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(100, 35);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnXoa.Location = new System.Drawing.Point(440, 106);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(100, 35);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnLamMoi.Location = new System.Drawing.Point(440, 149);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(100, 35);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvBacSi
            // 
            dgvBacSi.AllowUserToAddRows = false;
            dgvBacSi.AllowUserToDeleteRows = false;
            dgvBacSi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvBacSi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvBacSi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colMaBS, colHoTen, colChuyenKhoa, colSDT });
            dgvBacSi.Location = new System.Drawing.Point(30, 205);
            dgvBacSi.MultiSelect = false;
            dgvBacSi.Name = "dgvBacSi";
            dgvBacSi.ReadOnly = true;
            dgvBacSi.RowHeadersWidth = 45;
            dgvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBacSi.Size = new System.Drawing.Size(530, 220);
            dgvBacSi.TabIndex = 12;
            dgvBacSi.SelectionChanged += dgvBacSi_SelectionChanged;
            // 
            // colMaBS
            // 
            colMaBS.DataPropertyName = "MaBs";
            colMaBS.FillWeight = 50F;
            colMaBS.HeaderText = "Mã BS";
            colMaBS.MinimumWidth = 60;
            colMaBS.Name = "colMaBS";
            colMaBS.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.FillWeight = 110F;
            colHoTen.HeaderText = "Họ tên";
            colHoTen.MinimumWidth = 100;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colChuyenKhoa
            // 
            colChuyenKhoa.DataPropertyName = "ChuyenKhoa";
            colChuyenKhoa.FillWeight = 100F;
            colChuyenKhoa.HeaderText = "Chuyên khoa";
            colChuyenKhoa.MinimumWidth = 90;
            colChuyenKhoa.Name = "colChuyenKhoa";
            colChuyenKhoa.ReadOnly = true;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "Sdt";
            colSDT.FillWeight = 80F;
            colSDT.HeaderText = "SĐT";
            colSDT.MinimumWidth = 70;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormBacSi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(590, 450);
            Controls.Add(dgvBacSi);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtChuyenKhoa);
            Controls.Add(lblChuyenKhoa);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(txtMaBS);
            Controls.Add(lblMaBS);
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(600, 480);
            Name = "FormBacSi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Quản Lý Bác Sĩ - An Khang Clinic";
            Load += FormBacSi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBacSi).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblChuyenKhoa;
        private System.Windows.Forms.TextBox txtChuyenKhoa;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
