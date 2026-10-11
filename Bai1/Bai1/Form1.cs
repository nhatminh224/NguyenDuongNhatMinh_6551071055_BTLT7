using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai1.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        /// <summary>
        /// Tải toàn bộ danh sách Thể loại sách từ CSDL lên DataGridView
        /// </summary>
        private async Task LoadDataAsync()
        {
            try
            {
                using var context = new TriThucBooksContext();
                var danhSach = await context.TheLoaiSaches
                    .AsNoTracking()
                    .OrderBy(tl => tl.MaTl)
                    .ToListAsync();

                dgvTheLoai.DataSource = danhSach;
                dgvTheLoai.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi người dùng chọn dòng trên DataGridView: tự động đổ dữ liệu lên các controls
        /// </summary>
        private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow != null && dgvTheLoai.CurrentRow.Index >= 0)
            {
                if (dgvTheLoai.CurrentRow.DataBoundItem is TheLoaiSach theLoai)
                {
                    txtMaTL.Text = theLoai.MaTl.ToString();
                    txtTenTL.Text = theLoai.TenTheLoai;
                    txtMoTa.Text = theLoai.MoTa ?? string.Empty;
                    lblNgayTao.Text = theLoai.NgayTao?.ToString("yyyy/MM/dd HH:mm:ss") ?? string.Empty;
                    errorProvider1.Clear();
                }
            }
        }

        /// <summary>
        /// Chức năng Thêm mới thể loại sách
        /// </summary>
        private async void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tenTheLoai = txtTenTL.Text.Trim();

            // Validate dữ liệu đầu vào: Không được để trống Tên thể loại
            if (string.IsNullOrEmpty(tenTheLoai))
            {
                errorProvider1.SetError(txtTenTL, "Tên thể loại không được để trống!");
                MessageBox.Show("Vui lòng nhập Tên thể loại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTL.Focus();
                return;
            }

            try
            {
                using var context = new TriThucBooksContext();

                // Kiểm tra trùng tên thể loại khi thêm mới (không phân biệt hoa thường)
                bool daTonTai = await context.TheLoaiSaches
                    .AnyAsync(x => x.TenTheLoai.ToLower() == tenTheLoai.ToLower());

                if (daTonTai)
                {
                    errorProvider1.SetError(txtTenTL, "Tên thể loại này đã tồn tại trong hệ thống!");
                    MessageBox.Show("Tên thể loại đã tồn tại! Vui lòng chọn tên khác.", "Trùng lặp dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTL.Focus();
                    return;
                }

                var theLoaiMoi = new TheLoaiSach
                {
                    TenTheLoai = tenTheLoai,
                    MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim(),
                    SoLuongSach = 0,
                    NgayTao = DateTime.Now
                };

                context.TheLoaiSaches.Add(theLoaiMoi);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm thể loại sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chức năng Sửa / Cập nhật thông tin thể loại sách
        /// </summary>
        private async void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Kiểm tra đã chọn dòng cần sửa chưa
            if (!int.TryParse(txtMaTL.Text, out int maTL) || maTL <= 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa từ danh sách!", "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTheLoai = txtTenTL.Text.Trim();

            // Validate dữ liệu: Không được để trống Tên thể loại
            if (string.IsNullOrEmpty(tenTheLoai))
            {
                errorProvider1.SetError(txtTenTL, "Tên thể loại không được để trống!");
                MessageBox.Show("Vui lòng nhập Tên thể loại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTL.Focus();
                return;
            }

            try
            {
                using var context = new TriThucBooksContext();

                // Kiểm tra trùng tên thể loại với các thể loại khác
                bool trungTenKhac = await context.TheLoaiSaches
                    .AnyAsync(x => x.MaTl != maTL && x.TenTheLoai.ToLower() == tenTheLoai.ToLower());

                if (trungTenKhac)
                {
                    errorProvider1.SetError(txtTenTL, "Tên thể loại đã được sử dụng bởi thể loại khác!");
                    MessageBox.Show("Tên thể loại đã được sử dụng bởi thể loại khác!", "Trùng lặp dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTL.Focus();
                    return;
                }

                var theLoai = await context.TheLoaiSaches.FindAsync(maTL);
                if (theLoai == null)
                {
                    MessageBox.Show("Không tìm thấy thể loại cần cập nhật trong CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                theLoai.TenTheLoai = tenTheLoai;
                theLoai.MoTa = string.IsNullOrWhiteSpace(txtMoTa.Text) ? null : txtMoTa.Text.Trim();

                await context.SaveChangesAsync();

                MessageBox.Show("Cập nhật thông tin thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chức năng Xóa thể loại sách với hộp thoại xác nhận và bắt lỗi DbUpdateException
        /// </summary>
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Kiểm tra đã chọn dòng cần xóa chưa
            if (!int.TryParse(txtMaTL.Text, out int maTL) || maTL <= 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa từ danh sách!", "Chưa chọn dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa thể loại '{txtTenTL.Text.Trim()}' (Mã: {maTL}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using var context = new TriThucBooksContext();
                var theLoai = await context.TheLoaiSaches.FindAsync(maTL);

                if (theLoai == null)
                {
                    MessageBox.Show("Không tìm thấy thể loại cần xóa trong CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.TheLoaiSaches.Remove(theLoai);
                await context.SaveChangesAsync();

                MessageBox.Show("Xóa thể loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiForm();
                await LoadDataAsync();
            }
            catch (DbUpdateException)
            {
                // Bắt lỗi khi thể loại đang được sách khác tham chiếu (khóa ngoại Foreign Key)
                MessageBox.Show(
                    "Không thể xóa thể loại này vì đang được sách khác tham chiếu hoặc có ràng buộc dữ liệu!",
                    "Lỗi ràng buộc dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chức năng Tìm kiếm theo Tên thể loại dùng LINQ (Where + Contains)
        /// </summary>
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            await ThucHienTimKiemAsync();
        }

        private async void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Chống tiếng bíp khi nhấn Enter trong TextBox
                await ThucHienTimKiemAsync();
            }
        }

        private async Task ThucHienTimKiemAsync()
        {
            try
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                using var context = new TriThucBooksContext();
                var query = context.TheLoaiSaches.AsNoTracking().AsQueryable();

                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(tl => tl.TenTheLoai.Contains(tuKhoa));
                }

                var ketQua = await query.OrderBy(tl => tl.MaTl).ToListAsync();
                dgvTheLoai.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy thể loại nào phù hợp với từ khóa '{tuKhoa}'!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chức năng Làm mới: Xóa trắng form và tải lại danh sách
        /// </summary>
        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            await LoadDataAsync();
        }

        private void LamMoiForm()
        {
            txtMaTL.Clear();
            txtTenTL.Clear();
            txtMoTa.Clear();
            lblNgayTao.Text = "---";
            txtTimKiem.Clear();
            errorProvider1.Clear();
            txtTenTL.Focus();
        }
    }
}
