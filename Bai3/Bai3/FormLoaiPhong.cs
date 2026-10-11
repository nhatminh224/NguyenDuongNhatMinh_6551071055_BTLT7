using System;
using System.Linq;
using System.Windows.Forms;
using Bai3.Models;

namespace Bai3
{
    public partial class FormLoaiPhong : Form
    {
        public bool IsDataChanged { get; private set; } = false;

        public FormLoaiPhong()
        {
            InitializeComponent();
        }

        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using var db = new SunriseHomestayContext();
                var list = db.LoaiPhongs
                    .OrderBy(lp => lp.MaLoai)
                    .Select(lp => new
                    {
                        lp.MaLoai,
                        lp.TenLoai,
                        GiaMoiDemRaw = lp.GiaMoiDem,
                        GiaMoiDemFormatted = lp.GiaMoiDem.HasValue ? lp.GiaMoiDem.Value.ToString("#,##0") : "0",
                        lp.MoTa
                    })
                    .ToList();

                dgvLoaiPhong.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtGiaMoiDem.Clear();
            txtMoTa.Clear();
            dgvLoaiPhong.ClearSelection();
            txtTenLoai.Focus();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoaiPhong.Rows.Count)
            {
                var row = dgvLoaiPhong.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["colMaLoai"].Value?.ToString() ?? "";
                txtTenLoai.Text = row.Cells["colTenLoai"].Value?.ToString() ?? "";

                // Get raw value if available
                object? valGia = row.Cells["colGiaMoiDem"].Value;
                if (valGia != null)
                {
                    string giaStr = valGia.ToString()!.Replace(",", "").Replace(".", "").Trim();
                    txtGiaMoiDem.Text = giaStr;
                }
                else
                {
                    txtGiaMoiDem.Text = "";
                }

                txtMoTa.Text = row.Cells["colMoTa"].Value?.ToString() ?? "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLoai = txtTenLoai.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }

            decimal gia = 0;
            if (!string.IsNullOrWhiteSpace(txtGiaMoiDem.Text))
            {
                if (!decimal.TryParse(txtGiaMoiDem.Text.Trim().Replace(",", ""), out gia) || gia < 0)
                {
                    MessageBox.Show("Giá mỗi đêm phải là số hợp lệ không âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaMoiDem.Focus();
                    return;
                }
            }

            try
            {
                using var db = new SunriseHomestayContext();
                var loaiPhong = new LoaiPhong
                {
                    TenLoai = tenLoai,
                    GiaMoiDem = gia,
                    MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim()
                };

                db.LoaiPhongs.Add(loaiPhong);
                db.SaveChanges();

                IsDataChanged = true;
                MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || !int.TryParse(txtMaLoai.Text, out int maLoai))
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenLoai = txtTenLoai.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenLoai))
            {
                MessageBox.Show("Tên loại phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }

            decimal gia = 0;
            if (!string.IsNullOrWhiteSpace(txtGiaMoiDem.Text))
            {
                if (!decimal.TryParse(txtGiaMoiDem.Text.Trim().Replace(",", ""), out gia) || gia < 0)
                {
                    MessageBox.Show("Giá mỗi đêm phải là số hợp lệ không âm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiaMoiDem.Focus();
                    return;
                }
            }

            try
            {
                using var db = new SunriseHomestayContext();
                var loaiPhong = db.LoaiPhongs.FirstOrDefault(lp => lp.MaLoai == maLoai);
                if (loaiPhong == null)
                {
                    MessageBox.Show("Không tìm thấy loại phòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                loaiPhong.TenLoai = tenLoai;
                loaiPhong.GiaMoiDem = gia;
                loaiPhong.MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim();

                db.SaveChanges();

                IsDataChanged = true;
                MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || !int.TryParse(txtMaLoai.Text, out int maLoai))
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa loại phòng [{txtTenLoai.Text}] (Mã {maLoai}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var db = new SunriseHomestayContext();
                var loaiPhong = db.LoaiPhongs.FirstOrDefault(lp => lp.MaLoai == maLoai);
                if (loaiPhong == null)
                {
                    MessageBox.Show("Không tìm thấy loại phòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem có phòng nào đang thuộc loại phòng này không
                int countPhong = db.Phongs.Count(p => p.MaLoai == maLoai);
                if (countPhong > 0)
                {
                    var confirmFK = MessageBox.Show(
                        $"Đang có {countPhong} phòng thuộc loại này. Nếu xóa, các phòng này sẽ không còn loại phòng. Bạn có muốn tiếp tục?",
                        "Cảnh báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (confirmFK != DialogResult.Yes) return;
                }

                db.LoaiPhongs.Remove(loaiPhong);
                db.SaveChanges();

                IsDataChanged = true;
                MessageBox.Show("Đã xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
