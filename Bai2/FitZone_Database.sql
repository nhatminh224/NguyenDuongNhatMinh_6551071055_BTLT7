-- =============================================
-- Kịch bản tạo Database và Bảng cho dự án FitZone (Bài 2)
-- Server: .\SQLEXPRESS
-- =============================================

USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'FitZone')
BEGIN
    CREATE DATABASE FitZone;
END;
GO

USE FitZone;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HoiVien]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[HoiVien] (
        [MaHV] INT IDENTITY(1,1) NOT NULL,
        [HoTen] NVARCHAR(100) NOT NULL,
        [GioiTinh] BIT NULL CONSTRAINT [DF_HoiVien_GioiTinh] DEFAULT (1),
        [NgaySinh] DATE NULL,
        [SDT] VARCHAR(15) NULL,
        [Email] VARCHAR(100) NULL,
        [HangThanhVien] NVARCHAR(20) NULL,
        [NgayDangKy] DATETIME NULL CONSTRAINT [DF_HoiVien_NgayDangKy] DEFAULT (GETDATE()),
        [TrangThai] BIT NULL CONSTRAINT [DF_HoiVien_TrangThai] DEFAULT (1),
        CONSTRAINT [PK__HoiVien__2725A6D21DDA148C] PRIMARY KEY CLUSTERED ([MaHV] ASC)
    );
END;
GO

-- Chèn dữ liệu mẫu nếu bảng chưa có dữ liệu
IF NOT EXISTS (SELECT 1 FROM [dbo].[HoiVien])
BEGIN
    INSERT INTO [dbo].[HoiVien] ([HoTen], [GioiTinh], [NgaySinh], [SDT], [Email], [HangThanhVien], [NgayDangKy], [TrangThai])
    VALUES
    (N'Nguyễn Văn An', 1, '1998-05-15', '0912345678', 'an.nguyen@gmail.com', N'VIP', GETDATE(), 1),
    (N'Trần Thị Mai', 0, '2001-08-20', '0987654321', 'mai.tran@gmail.com', N'Basic', GETDATE(), 1),
    (N'Lê Hoàng Long', 1, '1995-12-10', '0901234567', 'long.le@gmail.com', N'Premium', GETDATE(), 1),
    (N'Phạm Ngọc Linh', 0, '2003-03-25', '0933221100', 'linh.pham@gmail.com', N'Basic', GETDATE(), 0);
END;
GO
