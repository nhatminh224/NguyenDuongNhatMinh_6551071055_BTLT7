using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai4.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho DateTimePicker
            dtpNgayKham.Value = DateTime.Today;
            dtpTuNgay.Value = DateTime.Today.AddDays(-30);
            dtpDenNgay.Value = DateTime.Today.AddDays(30);
            cboTrangThai.SelectedIndex = 0; // "Chờ khám"

            await LoadComboBoxBacSiAsync();
            await LoadDataLichKhamAsync();
        }

        /// <summary>
        /// Nạp dữ liệu Bác sĩ vào 2 ComboBox: ComboBox nhập liệu và ComboBox tìm kiếm
        /// </summary>
        private async Task LoadComboBoxBacSiAsync()
        {
            try
            {
                using var context = new AnKhangClinicContext();
                var danhSachBS = await context.BacSis
                    .AsNoTracking()
                    .OrderBy(b => b.HoTen)
                    .ToListAsync();

                var comboItems = danhSachBS.Select(b => new BacSiComboItem
                {
                    MaBs = b.MaBs,
                    DisplayText = $"BS. {b.HoTen} - {b.ChuyenKhoa}"
                }).ToList();

                // Nạp cho ComboBox nhập liệu Form chính
                cboBacSi.DataSource = new List<BacSiComboItem>(comboItems);
                cboBacSi.DisplayMember = "DisplayText";
                cboBacSi.ValueMember = "MaBs";
                if (comboItems.Count > 0)
                {
                    cboBacSi.SelectedIndex = 0;
                }

                // Nạp cho ComboBox tìm kiếm (thêm mục Tất cả bác sĩ)
                var timKiemItems = new List<BacSiComboItem>
                {
                    new BacSiComboItem { MaBs = 0, DisplayText = "--- Tất cả bác sĩ ---" }
                };
                timKiemItems.AddRange(comboItems);

                cboTimKiemBacSi.DataSource = timKiemItems;
                cboTimKiemBacSi.DisplayMember = "DisplayText";
                cboTimKiemBacSi.ValueMember = "MaBs";
                cboTimKiemBacSi.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải toàn bộ danh sách Lịch khám dùng LINQ Include(x => x.MaBsNavigation)
        /// </summary>
        private async Task LoadDataLichKhamAsync()
        {
            try
            {
                using var context = new AnKhangClinicContext();

                // Sử dụng LINQ Include(x => x.MaBsNavigation) theo đúng yêu cầu đề bài
                var danhSach = await context.LichKhams
                    .AsNoTracking()
                    .Include(lk => lk.MaBsNavigation)
                    .OrderByDescending(lk => lk.NgayKham)
                    .ThenBy(lk => lk.GioKham)
                    .Select(lk => new LichKhamViewModel
                    {
                        MaLich = lk.MaLich,
                        TenBenhNhan = lk.TenBenhNhan,
                        Sdt = lk.Sdt,
                        NgayKham = lk.NgayKham,
                        GioKham = lk.GioKham,
                        MaBs = lk.MaBs,
                        TenBacSiHienThi = $"BS. {lk.MaBsNavigation.HoTen} - {lk.MaBsNavigation.ChuyenKhoa}",
                        ChuyenKhoa = lk.MaBsNavigation.ChuyenKhoa,
                        TrangThai = lk.TrangThai
                    })
                    .ToListAsync();

                dgvLichKham.DataSource = danhSach;
                dgvLichKham.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lịch khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện chọn dòng trên DataGridView: tự động đổ dữ liệu lên controls
        /// </summary>
        private void dgvLichKham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLichKham.CurrentRow != null && dgvLichKham.CurrentRow.Index >= 0)
            {
                if (dgvLichKham.CurrentRow.DataBoundItem is LichKhamViewModel item)
                {
                    txtMaLich.Text = item.MaLich.ToString();
                    txtTenBenhNhan.Text = item.TenBenhNhan;
                    txtSDT.Text = item.Sdt ?? string.Empty;

                    // Gán Ngày khám
                    dtpNgayKham.Value = item.NgayKham.ToDateTime(TimeOnly.MinValue);

                    // Gán Giờ khám
                    if (TimeOnly.TryParse(item.GioKham, out TimeOnly gioKham))
                    {
                        dtpGioKham.Value = DateTime.Today.Add(gioKham.ToTimeSpan());
                    }

                    // Gán Bác sĩ và Trạng thái
                    cboBacSi.SelectedValue = item.MaBs;
                    cboTrangThai.SelectedItem = item.TrangThai ?? "Chờ khám";

                    errorProvider1.Clear();
                }
            }
        }

        /// <summary>
        /// Thêm mới lịch khám với Validate ngày quá khứ, rỗng tên bệnh nhân, chọn bác sĩ
        /// </summary>
        private async void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tenBenhNhan = txtTenBenhNhan.Text.Trim();

            // 1. Validate: Không được bỏ trống Tên bệnh nhân
            if (string.IsNullOrEmpty(tenBenhNhan))
            {
                errorProvider1.SetError(txtTenBenhNhan, "Tên bệnh nhân không được để trống!");
                MessageBox.Show("Vui lòng nhập Tên bệnh nhân!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBenhNhan.Focus();
                return;
            }

            // 2. Validate: Phải chọn Bác sĩ
            if (cboBacSi.SelectedValue == null || (int)cboBacSi.SelectedValue <= 0)
            {
                errorProvider1.SetError(cboBacSi, "Vui lòng chọn Bác sĩ phụ trách!");
                MessageBox.Show("Vui lòng chọn Bác sĩ phụ trách!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBacSi.Focus();
                return;
            }

            // 3. Validate: Không cho đặt lịch khám vào ngày trong quá khứ
            DateOnly ngayKham = DateOnly.FromDateTime(dtpNgayKham.Value.Date);
            DateOnly homNay = DateOnly.FromDateTime(DateTime.Today);
            if (ngayKham < homNay)
            {
                errorProvider1.SetError(dtpNgayKham, "Không được đặt lịch khám vào ngày trong quá khứ!");
                MessageBox.Show("Không được đặt lịch khám vào ngày trong quá khứ!", "Ngày khám không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKham.Focus();
                return;
            }

            try
            {
                using var context = new AnKhangClinicContext();

                var lichMoi = new LichKham
                {
                    TenBenhNhan = tenBenhNhan,
                    Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim(),
                    NgayKham = ngayKham,
                    GioKham = dtpGioKham.Value.ToString("HH:mm"),
                    MaBs = (int)cboBacSi.SelectedValue,
                    TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám"
                };

                context.LichKhams.Add(lichMoi);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                await LoadDataLichKhamAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật lịch khám bệnh
        /// </summary>
        private async void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!int.TryParse(txtMaLich.Text, out int maLich) || maLich <= 0)
            {
                MessageBox.Show("Vui lòng chọn lịch khám cần sửa từ danh sách!", "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenBenhNhan = txtTenBenhNhan.Text.Trim();
            if (string.IsNullOrEmpty(tenBenhNhan))
            {
                errorProvider1.SetError(txtTenBenhNhan, "Tên bệnh nhân không được để trống!");
                MessageBox.Show("Vui lòng nhập Tên bệnh nhân!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBenhNhan.Focus();
                return;
            }

            if (cboBacSi.SelectedValue == null || (int)cboBacSi.SelectedValue <= 0)
            {
                errorProvider1.SetError(cboBacSi, "Vui lòng chọn Bác sĩ phụ trách!");
                MessageBox.Show("Vui lòng chọn Bác sĩ phụ trách!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBacSi.Focus();
                return;
            }

            try
            {
                using var context = new AnKhangClinicContext();
                var lich = await context.LichKhams.FindAsync(maLich);

                if (lich == null)
                {
                    MessageBox.Show("Không tìm thấy lịch khám cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lich.TenBenhNhan = tenBenhNhan;
                lich.Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim();
                lich.NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value.Date);
                lich.GioKham = dtpGioKham.Value.ToString("HH:mm");
                lich.MaBs = (int)cboBacSi.SelectedValue;
                lich.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám";

                await context.SaveChangesAsync();

                MessageBox.Show("Cập nhật lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataLichKhamAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lịch khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa lịch khám bệnh với hộp thoại xác nhận YesNo
        /// </summary>
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!int.TryParse(txtMaLich.Text, out int maLich) || maLich <= 0)
            {
                MessageBox.Show("Vui lòng chọn lịch khám cần xóa từ danh sách!", "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa lịch khám của bệnh nhân '{txtTenBenhNhan.Text.Trim()}' (Mã: {maLich}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog != DialogResult.Yes) return;

            try
            {
                using var context = new AnKhangClinicContext();
                var lich = await context.LichKhams.FindAsync(maLich);

                if (lich == null)
                {
                    MessageBox.Show("Không tìm thấy lịch khám cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.LichKhams.Remove(lich);
                await context.SaveChangesAsync();

                MessageBox.Show("Xóa lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                await LoadDataLichKhamAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lịch khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tìm kiếm kết hợp: Lọc theo khoảng ngày (>=, <=) VÀ theo Bác sĩ (==) dùng LINQ
        /// </summary>
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateOnly tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
            DateOnly denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("'Từ ngày' không được lớn hơn 'Đến ngày'!", "Khoảng ngày không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var context = new AnKhangClinicContext();

                // Truy vấn cơ sở có Include bác sĩ
                var query = context.LichKhams
                    .AsNoTracking()
                    .Include(lk => lk.MaBsNavigation)
                    // Điều kiện khoảng ngày: >= Từ ngày VÀ <= Đến ngày
                    .Where(lk => lk.NgayKham >= tuNgay && lk.NgayKham <= denNgay);

                // Nếu có chọn Bác sĩ cụ thể (khác Tất cả bác sĩ)
                if (cboTimKiemBacSi.SelectedValue is int maBsChon && maBsChon > 0)
                {
                    // Điều kiện bằng bác sĩ
                    query = query.Where(lk => lk.MaBs == maBsChon);
                }

                var ketQua = await query
                    .OrderBy(lk => lk.NgayKham)
                    .ThenBy(lk => lk.GioKham)
                    .Select(lk => new LichKhamViewModel
                    {
                        MaLich = lk.MaLich,
                        TenBenhNhan = lk.TenBenhNhan,
                        Sdt = lk.Sdt,
                        NgayKham = lk.NgayKham,
                        GioKham = lk.GioKham,
                        MaBs = lk.MaBs,
                        TenBacSiHienThi = $"BS. {lk.MaBsNavigation.HoTen} - {lk.MaBsNavigation.ChuyenKhoa}",
                        ChuyenKhoa = lk.MaBsNavigation.ChuyenKhoa,
                        TrangThai = lk.TrangThai
                    })
                    .ToListAsync();

                dgvLichKham.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy lịch khám nào trong khoảng thời gian và bác sĩ đã chọn!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mở Form phụ Quản lý Bác sĩ
        /// </summary>
        private async void btnQuanLyBacSi_Click(object sender, EventArgs e)
        {
            using var formBS = new FormBacSi();
            formBS.ShowDialog(this);

            // Cập nhật lại danh sách bác sĩ trên combobox sau khi thao tác ở form phụ
            await LoadComboBoxBacSiAsync();
            await LoadDataLichKhamAsync();
        }

        /// <summary>
        /// Làm mới form nhập liệu và tải lại danh sách
        /// </summary>
        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            await LoadDataLichKhamAsync();
        }

        private void LamMoiForm()
        {
            txtMaLich.Clear();
            txtTenBenhNhan.Clear();
            txtSDT.Clear();
            dtpNgayKham.Value = DateTime.Today;
            dtpGioKham.Value = DateTime.Now;
            if (cboBacSi.Items.Count > 0) cboBacSi.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            errorProvider1.Clear();
            dgvLichKham.ClearSelection();
            txtTenBenhNhan.Focus();
        }
    }
}
