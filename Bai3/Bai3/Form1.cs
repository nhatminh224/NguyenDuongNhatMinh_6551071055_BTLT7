using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bai3.Models;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private int? _selectedMaPhong = null;
        private string? _selectedHinhAnhFileName = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnsureImagesFolder();
            LoadLoaiPhongCombos();
            if (cboTinhTrang.Items.Count > 0)
            {
                cboTinhTrang.SelectedIndex = 0; // "Trống"
            }
            if (cboLocTinhTrang.Items.Count > 0)
            {
                cboLocTinhTrang.SelectedIndex = 0; // "Lọc theo tình trạng"
            }
            LoadDanhSachPhong();
        }

        #region Quản lý thư mục & Xử lý Ảnh an toàn

        private string GetImagesDirectory()
        {
            string imagesDir = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(imagesDir))
            {
                Directory.CreateDirectory(imagesDir);
            }
            return imagesDir;
        }

        private void EnsureImagesFolder()
        {
            GetImagesDirectory();
        }

        private Image? LoadImageSafely(string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return null;

            string targetPath = Path.Combine(GetImagesDirectory(), fileName);

            // Kiểm tra thư mục output hoặc project nếu chạy trong Visual Studio
            if (!File.Exists(targetPath))
            {
                string projectDirImages = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images", fileName);
                if (File.Exists(projectDirImages))
                {
                    targetPath = projectDirImages;
                }
            }

            if (!File.Exists(targetPath))
                return null;

            try
            {
                // Đọc vào MemoryStream để không khóa file ảnh trên đĩa
                byte[] bytes = File.ReadAllBytes(targetPath);
                using var ms = new MemoryStream(bytes);
                return new Bitmap(ms);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Nạp dữ liệu Combobox & DataGridView

        private void LoadLoaiPhongCombos()
        {
            try
            {
                using var db = new SunriseHomestayContext();
                var danhSachLoai = db.LoaiPhongs.OrderBy(lp => lp.MaLoai).ToList();

                // 1. Nạp cho cboLoaiPhong (Form nhập liệu)
                cboLoaiPhong.DataSource = null;
                cboLoaiPhong.DisplayMember = "TenLoai";
                cboLoaiPhong.ValueMember = "MaLoai";
                cboLoaiPhong.DataSource = danhSachLoai;

                // 2. Nạp cho cboLocLoaiPhong (Bộ lọc tìm kiếm)
                var danhSachLoc = danhSachLoai.Select(lp => new
                {
                    lp.MaLoai,
                    lp.TenLoai
                }).ToList();

                danhSachLoc.Insert(0, new { MaLoai = 0, TenLoai = "Lọc theo loại phòng" });

                cboLocLoaiPhong.DataSource = null;
                cboLocLoaiPhong.DisplayMember = "TenLoai";
                cboLocLoaiPhong.ValueMember = "MaLoai";
                cboLocLoaiPhong.DataSource = danhSachLoc;
                cboLocLoaiPhong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachPhong(int? maLoaiFilter = null, string? tinhTrangFilter = null)
        {
            try
            {
                using var db = new SunriseHomestayContext();

                // Dùng Include(x => x.MaLoaiNavigation) để Eager Loading loại phòng
                var query = db.Phongs
                    .Include(p => p.MaLoaiNavigation)
                    .AsQueryable();

                // Lọc theo Loại phòng
                if (maLoaiFilter.HasValue && maLoaiFilter.Value > 0)
                {
                    query = query.Where(p => p.MaLoai == maLoaiFilter.Value);
                }

                // Lọc theo Tình trạng
                if (!string.IsNullOrWhiteSpace(tinhTrangFilter) &&
                    tinhTrangFilter != "Lọc theo tình trạng" &&
                    tinhTrangFilter != "Tất cả")
                {
                    query = query.Where(p => p.TinhTrang == tinhTrangFilter);
                }

                var listRaw = query.OrderBy(p => p.MaPhong).ToList();

                var listDisplay = listRaw.Select(p => new
                {
                    p.MaPhong,
                    HinhAnhThumb = LoadImageSafely(p.HinhAnh),
                    p.SoPhong,
                    p.TangSo,
                    TenLoai = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.TenLoai : "",
                    GiaMoiDemFormatted = p.MaLoaiNavigation?.GiaMoiDem.HasValue == true
                        ? p.MaLoaiNavigation.GiaMoiDem.Value.ToString("#,##0")
                        : "0",
                    p.TinhTrang,
                    p.HinhAnh,
                    p.MaLoai
                }).ToList();

                dgvPhong.DataSource = listDisplay;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Xử lý chọn dòng DataGridView & Upload ảnh

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhong.Rows.Count)
            {
                var row = dgvPhong.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["colMaPhong"].Value?.ToString(), out int maPhong))
                {
                    _selectedMaPhong = maPhong;
                }

                txtSoPhong.Text = row.Cells["colSoPhong"].Value?.ToString() ?? "";

                if (int.TryParse(row.Cells["colTang"].Value?.ToString(), out int tangSo))
                {
                    nudTangSo.Value = Math.Clamp(tangSo, nudTangSo.Minimum, nudTangSo.Maximum);
                }
                else
                {
                    nudTangSo.Value = 0;
                }

                // Chọn Loại phòng tương ứng trong ComboBox
                string tenLoai = row.Cells["colLoaiPhong"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(tenLoai))
                {
                    cboLoaiPhong.SelectedIndex = cboLoaiPhong.FindStringExact(tenLoai);
                }

                // Chọn Tình trạng phòng
                string tinhTrang = row.Cells["colTinhTrang"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(tinhTrang))
                {
                    cboTinhTrang.SelectedItem = tinhTrang;
                }

                // Hiển thị ảnh lên PictureBox
                // Lấy tên file ảnh từ object dữ liệu của dòng
                dynamic? dataItem = row.DataBoundItem;
                string? hinhAnh = null;
                if (dataItem != null)
                {
                    hinhAnh = dataItem.HinhAnh as string;
                }

                _selectedHinhAnhFileName = hinhAnh;
                if (!string.IsNullOrEmpty(_selectedHinhAnhFileName))
                {
                    picHinhAnh.Image = LoadImageSafely(_selectedHinhAnhFileName);
                }
                else
                {
                    picHinhAnh.Image = null;
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh phòng";
            ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.webp|Tất cả tệp (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFilePath = ofd.FileName;
                    string fileExtension = Path.GetExtension(sourceFilePath);
                    // Đặt tên file duy nhất hoặc giữ tên gốc
                    string originalFileName = Path.GetFileName(sourceFilePath);
                    string destFileName = $"{DateTime.Now:yyyyMMddHHmmss}_{originalFileName}";

                    string imagesDir = GetImagesDirectory();
                    string destPath = Path.Combine(imagesDir, destFileName);

                    // Copy file ảnh vào thư mục Images của ứng dụng
                    File.Copy(sourceFilePath, destPath, true);

                    // Nếu có thư mục Images trong source dự án, sao chép thêm để bảo toàn khi rebuild
                    string projectDirImages = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images");
                    if (Directory.Exists(projectDirImages))
                    {
                        try
                        {
                            File.Copy(sourceFilePath, Path.Combine(projectDirImages, destFileName), true);
                        }
                        catch { }
                    }

                    // Chỉ lưu TÊN FILE vào biến đại diện
                    _selectedHinhAnhFileName = destFileName;

                    // Hiển thị ảnh lên PictureBox
                    picHinhAnh.Image = LoadImageSafely(_selectedHinhAnhFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sao chép và tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Các chức năng CRUD (Thêm, Sửa, Xóa, Làm mới)

        private void btnThem_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(soPhong))
            {
                MessageBox.Show("Vui lòng nhập Số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return;
            }

            if (cboLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiPhong.Focus();
                return;
            }

            if (cboTinhTrang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Tình trạng phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTinhTrang.Focus();
                return;
            }

            int maLoai = (int)cboLoaiPhong.SelectedValue;
            string tinhTrang = cboTinhTrang.SelectedItem.ToString()!;
            int tangSo = (int)nudTangSo.Value;

            try
            {
                using var db = new SunriseHomestayContext();

                // Kiểm tra trùng số phòng
                if (db.Phongs.Any(p => p.SoPhong == soPhong))
                {
                    MessageBox.Show($"Số phòng '{soPhong}' đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoPhong.Focus();
                    return;
                }

                var phong = new Phong
                {
                    SoPhong = soPhong,
                    TangSo = tangSo,
                    TinhTrang = tinhTrang,
                    HinhAnh = _selectedHinhAnhFileName,
                    MaLoai = maLoai
                };

                db.Phongs.Add(phong);
                db.SaveChanges();

                MessageBox.Show("Thêm phòng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhong();
                ResetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedMaPhong.HasValue)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(soPhong))
            {
                MessageBox.Show("Số phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return;
            }

            if (cboLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTinhTrang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Tình trạng phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maLoai = (int)cboLoaiPhong.SelectedValue;
            string tinhTrang = cboTinhTrang.SelectedItem.ToString()!;
            int tangSo = (int)nudTangSo.Value;

            try
            {
                using var db = new SunriseHomestayContext();
                var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == _selectedMaPhong.Value);
                if (phong == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin phòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng số phòng với phòng khác
                if (db.Phongs.Any(p => p.SoPhong == soPhong && p.MaPhong != _selectedMaPhong.Value))
                {
                    MessageBox.Show($"Số phòng '{soPhong}' đã được sử dụng bởi phòng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoPhong.Focus();
                    return;
                }

                phong.SoPhong = soPhong;
                phong.TangSo = tangSo;
                phong.TinhTrang = tinhTrang;
                phong.MaLoai = maLoai;
                phong.HinhAnh = _selectedHinhAnhFileName;

                db.SaveChanges();

                MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhong();
                ResetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedMaPhong.HasValue)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phòng '{txtSoPhong.Text}' (Mã { _selectedMaPhong.Value }) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var db = new SunriseHomestayContext();
                var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == _selectedMaPhong.Value);
                if (phong == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.Phongs.Remove(phong);
                db.SaveChanges();

                MessageBox.Show("Đã xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhong();
                ResetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetInputs();
            cboLocLoaiPhong.SelectedIndex = 0;
            cboLocTinhTrang.SelectedIndex = 0;
            LoadDanhSachPhong();
        }

        private void ResetInputs()
        {
            _selectedMaPhong = null;
            _selectedHinhAnhFileName = null;
            txtSoPhong.Clear();
            nudTangSo.Value = 0;
            if (cboLoaiPhong.Items.Count > 0)
                cboLoaiPhong.SelectedIndex = 0;
            if (cboTinhTrang.Items.Count > 0)
                cboTinhTrang.SelectedIndex = 0;
            picHinhAnh.Image = null;
            dgvPhong.ClearSelection();
            txtSoPhong.Focus();
        }

        #endregion

        #region Tìm kiếm kết hợp (Loại phòng + Tình trạng)

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int? maLoaiFilter = null;
            if (cboLocLoaiPhong.SelectedValue != null && int.TryParse(cboLocLoaiPhong.SelectedValue.ToString(), out int maLoai) && maLoai > 0)
            {
                maLoaiFilter = maLoai;
            }

            string? tinhTrangFilter = null;
            if (cboLocTinhTrang.SelectedItem != null)
            {
                string selected = cboLocTinhTrang.SelectedItem.ToString()!;
                if (selected != "Lọc theo tình trạng" && selected != "Tất cả")
                {
                    tinhTrangFilter = selected;
                }
            }

            LoadDanhSachPhong(maLoaiFilter, tinhTrangFilter);
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            cboLocLoaiPhong.SelectedIndex = 0;
            cboLocTinhTrang.SelectedIndex = 0;
            LoadDanhSachPhong();
        }

        #endregion

        #region Mở Form Loại Phòng

        private void btnQLoaiPhong_Click(object sender, EventArgs e)
        {
            using var f = new FormLoaiPhong();
            f.ShowDialog(this);

            // Nếu có thay đổi dữ liệu loại phòng, cập nhật lại cả hai ComboBox và danh sách phòng
            if (f.IsDataChanged)
            {
                LoadLoaiPhongCombos();
                LoadDanhSachPhong();
            }
        }

        #endregion
    }
}
