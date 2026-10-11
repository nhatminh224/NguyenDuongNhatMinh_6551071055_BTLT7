using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai4.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai4
{
    public partial class FormBacSi : Form
    {
        public FormBacSi()
        {
            InitializeComponent();
        }

        private async void FormBacSi_Load(object sender, EventArgs e)
        {
            await LoadDataBacSiAsync();
        }

        private async Task LoadDataBacSiAsync()
        {
            try
            {
                using var context = new AnKhangClinicContext();
                var list = await context.BacSis
                    .AsNoTracking()
                    .OrderBy(b => b.MaBs)
                    .ToListAsync();

                dgvBacSi.DataSource = list;
                dgvBacSi.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBacSi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBacSi.CurrentRow != null && dgvBacSi.CurrentRow.Index >= 0)
            {
                if (dgvBacSi.CurrentRow.DataBoundItem is BacSi bs)
                {
                    txtMaBS.Text = bs.MaBs.ToString();
                    txtHoTen.Text = bs.HoTen;
                    txtChuyenKhoa.Text = bs.ChuyenKhoa ?? string.Empty;
                    txtSDT.Text = bs.Sdt ?? string.Empty;
                    errorProvider1.Clear();
                }
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string hoTen = txtHoTen.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên bác sĩ không được để trống!");
                MessageBox.Show("Vui lòng nhập Họ tên bác sĩ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            try
            {
                using var context = new AnKhangClinicContext();

                var bacSiMoi = new BacSi
                {
                    HoTen = hoTen,
                    ChuyenKhoa = string.IsNullOrWhiteSpace(txtChuyenKhoa.Text) ? null : txtChuyenKhoa.Text.Trim(),
                    Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim()
                };

                context.BacSis.Add(bacSiMoi);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                await LoadDataBacSiAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!int.TryParse(txtMaBS.Text, out int maBS) || maBS <= 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ cần sửa từ danh sách!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên bác sĩ không được để trống!");
                MessageBox.Show("Vui lòng nhập Họ tên bác sĩ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            try
            {
                using var context = new AnKhangClinicContext();
                var bs = await context.BacSis.FindAsync(maBS);

                if (bs == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin bác sĩ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bs.HoTen = hoTen;
                bs.ChuyenKhoa = string.IsNullOrWhiteSpace(txtChuyenKhoa.Text) ? null : txtChuyenKhoa.Text.Trim();
                bs.Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim();

                await context.SaveChangesAsync();

                MessageBox.Show("Cập nhật thông tin bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataBacSiAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa bác sĩ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!int.TryParse(txtMaBS.Text, out int maBS) || maBS <= 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ cần xóa từ danh sách!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa bác sĩ '{txtHoTen.Text.Trim()}' (Mã: {maBS}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog != DialogResult.Yes) return;

            try
            {
                using var context = new AnKhangClinicContext();
                var bs = await context.BacSis.FindAsync(maBS);

                if (bs == null)
                {
                    MessageBox.Show("Không tìm thấy bác sĩ cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.BacSis.Remove(bs);
                await context.SaveChangesAsync();

                MessageBox.Show("Xóa bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                await LoadDataBacSiAsync();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa bác sĩ này vì đang có lịch khám của bệnh nhân liên kết tới!",
                    "Lỗi ràng buộc dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            await LoadDataBacSiAsync();
        }

        private void LamMoiForm()
        {
            txtMaBS.Clear();
            txtHoTen.Clear();
            txtChuyenKhoa.Clear();
            txtSDT.Clear();
            errorProvider1.Clear();
            dgvBacSi.ClearSelection();
            txtHoTen.Focus();
        }
    }
}
