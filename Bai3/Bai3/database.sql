-- ====================================================
-- Script tạo CSDL SunriseHomestayDB cho Câu 3
-- ====================================================

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'SunriseHomestayDB')
BEGIN
    CREATE DATABASE SunriseHomestayDB;
END
GO

USE SunriseHomestayDB;
GO

-- Xóa bảng cũ nếu tồn tại (theo thứ tự khóa ngoại)
IF OBJECT_ID('Phong', 'U') IS NOT NULL DROP TABLE Phong;
IF OBJECT_ID('LoaiPhong', 'U') IS NOT NULL DROP TABLE LoaiPhong;
GO

-- 1. Bảng LoaiPhong
CREATE TABLE LoaiPhong (
    MaLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(100) NOT NULL,
    GiaMoiDem DECIMAL(18,2) NULL,
    MoTa NVARCHAR(255) NULL
);
GO

-- 2. Bảng Phong
CREATE TABLE Phong (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    SoPhong VARCHAR(10) NOT NULL,
    TangSo INT NULL,
    TinhTrang NVARCHAR(20) NULL,
    HinhAnh NVARCHAR(255) NULL,
    MaLoai INT NULL CONSTRAINT FK_Phong_LoaiPhong FOREIGN KEY REFERENCES LoaiPhong(MaLoai) ON DELETE SET NULL
);
GO

-- 3. Dữ liệu mẫu ban đầu
INSERT INTO LoaiPhong (TenLoai, GiaMoiDem, MoTa) VALUES
(N'Phòng Đơn', 35000, N'Phòng đơn 1 giường'),
(N'Phòng Đôi', 20000, N'Phòng đôi 2 giường đơn hoặc 1 đôi'),
(N'Phòng VIP', 30000, N'Phòng VIP ban công view đẹp');
GO

INSERT INTO Phong (SoPhong, TangSo, TinhTrang, HinhAnh, MaLoai) VALUES
('1', 1, N'Trống', 'room1.jpg', 1),
('2', 1, N'Đang ở', 'room2.jpg', 2),
('3', 2, N'Đang dọn', 'room3.jpg', 1),
('4', 4, N'Đang dọn', 'room4.jpg', 2),
('5', 5, N'Đang dọn', 'room5.jpg', 3);
GO
