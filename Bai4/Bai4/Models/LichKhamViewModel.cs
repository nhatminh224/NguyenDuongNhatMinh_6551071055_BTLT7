using System;

namespace Bai4.Models
{
    public class LichKhamViewModel
    {
        public int MaLich { get; set; }
        public string TenBenhNhan { get; set; } = null!;
        public string? Sdt { get; set; }
        public DateOnly NgayKham { get; set; }
        public string NgayKhamFormatted => NgayKham.ToString("dd/MM/yyyy");
        public string GioKham { get; set; } = null!;
        public int MaBs { get; set; }
        public string TenBacSiHienThi { get; set; } = null!;
        public string? ChuyenKhoa { get; set; }
        public string? TrangThai { get; set; }
    }

    public class BacSiComboItem
    {
        public int MaBs { get; set; }
        public string DisplayText { get; set; } = null!;
    }
}
