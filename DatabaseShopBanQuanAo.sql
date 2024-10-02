CREATE DATABASE CSM
use CSM
CREATE TABLE NguoiDung (
    NguoiDungID INT PRIMARY KEY IDENTITY(1,1),
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau NVARCHAR(255) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    SoDienThoai NVARCHAR(15),
    DiaChi NVARCHAR(255),
	SoThich NVARCHAR(255),
    VaiTro NVARCHAR(50) DEFAULT 'KhachHang',
    NgayTao DATETIME DEFAULT GETDATE(),
	PhanKhucKH NVARCHAR(100) DEFAULT N'Khách Hàng Mới',
	Train BIT DEFAULT 1, 
    KichHoat BIT DEFAULT 1
);
CREATE TABLE DanhMuc (
    DanhMucID INT PRIMARY KEY IDENTITY(1,1),
    TenDanhMuc NVARCHAR(100) NOT NULL,
);
CREATE TABLE SanPham (
    SanPhamID INT PRIMARY KEY IDENTITY(1,1),
    TenSanPham NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(MAX),
    Gia DECIMAL(18, 2) NOT NULL,
    SoLuongTonKho INT NOT NULL,
    DanhMucID INT,
    HinhAnhUrl NVARCHAR(255),
    NgayTao DATETIME DEFAULT GETDATE(),
    KichHoat BIT DEFAULT 1,
    FOREIGN KEY (DanhMucID) REFERENCES DanhMuc(DanhMucID)
);
CREATE TABLE DonHang (
    DonHangID INT PRIMARY KEY IDENTITY(1,1),
    NguoiDungID INT NOT NULL,
    TongTien DECIMAL(18, 2) NOT NULL,
    TinhTrangDonHang NVARCHAR(50) NOT NULL,
    NgayDatHang DATETIME DEFAULT GETDATE(),
    DiaChiGiaoHang NVARCHAR(255),
    FOREIGN KEY (NguoiDungID) REFERENCES NguoiDung(NguoiDungID)
);
CREATE TABLE ChiTietDonHang (
    ChiTietDonHangID INT PRIMARY KEY IDENTITY(1,1),
    DonHangID INT NOT NULL,
    SanPhamID INT NOT NULL,
    SoLuong INT NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (DonHangID) REFERENCES DonHang(DonHangID),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);
CREATE TABLE GioHang (
    GioHangID INT PRIMARY KEY IDENTITY(1,1),
    NguoiDungID INT NOT NULL,
    SanPhamID INT NOT NULL,
    SoLuong INT NOT NULL,
    FOREIGN KEY (NguoiDungID) REFERENCES NguoiDung(NguoiDungID),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);
CREATE TABLE ThanhToan (
    ThanhToanID INT PRIMARY KEY IDENTITY(1,1),
    DonHangID INT NOT NULL,
    HinhThucThanhToan NVARCHAR(50) NOT NULL,
    TinhTrangThanhToan NVARCHAR(50) NOT NULL,
    NgayThanhToan DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (DonHangID) REFERENCES DonHang(DonHangID)
);
CREATE TABLE PhanHoi (
    PhanHoiID INT PRIMARY KEY IDENTITY(1,1),
    SanPhamID INT NOT NULL,
    NguoiDungID INT NOT NULL,
    NoiDung NVARCHAR(MAX),
    DanhGia INT CHECK(DanhGia BETWEEN 1 AND 5),
    NgayPhanHoi DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID),
    FOREIGN KEY (NguoiDungID) REFERENCES NguoiDung(NguoiDungID)
);
--Thêm người dùng
INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, Email, SoDienThoai, DiaChi, SoThich, VaiTro)
VALUES 
('admin', 'MatKhauAdmin', 'Nguyen Van A', 'admin@example.com', '0123456789', '123 Đường ABC', 'Thích công nghệ', 'Admin');
INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, Email, SoDienThoai, DiaChi, SoThich, VaiTro)
VALUES 
('user01', 'MatKhauUser01', 'Tran Van B', 'user01@example.com', '0987654321', '456 Đường XYZ', 'Thích thời trang', 'KhachHang');
-- Thêm danh mục sp
-- Thêm các danh mục trước
INSERT INTO [CSM].[dbo].[DanhMuc] 
    ([TenDanhMuc]) 
VALUES 
    (N'Danh mục tuổi teen'),
    (N'Danh mục thanh niên'),
    (N'Danh mục công sở'),
    (N'Danh mục trung niên'),
    (N'Danh mục người lớn tuổi'),
    (N'Danh mục thể thao'),
    (N'Danh mục người cao tuổi'),
    (N'Danh mục thời trang dạ hội'),
    (N'Danh mục áo sơ mi'),
    (N'Danh mục áo thun');
	--DELETE FROM [CSM].[dbo].[DanhMuc];
-- Thêm sản phẩm
INSERT INTO [CSM].[dbo].[SanPham] 
    ([TenSanPham], [MoTa], [Gia], [SoLuongTonKho], [DanhMucID], [HinhAnhUrl], [NgayTao], [KichHoat]) 
VALUES 
    (N'Áo khoác tuổi teen', N'Áo khoác phong cách trẻ, thích hợp cho độ tuổi 15-20', 1000000, 50, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục tuổi teen'), null, GETDATE(), 1),
    (N'Quần jean nam', N'Quần jean phong cách cho nam độ tuổi 18-25', 2000000, 40, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục thanh niên'), null, GETDATE(), 1),
    (N'Áo sơ mi công sở', N'Áo sơ mi phù hợp cho độ tuổi 25-35', 3000000, 60, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục công sở'), null, GETDATE(), 1),
    (N'Váy dạ hội', N'Váy dạ hội sang trọng, phù hợp cho độ tuổi 35-45', 5000000, 30, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục trung niên'), null, GETDATE(), 1),
    (N'Áo dài truyền thống', N'Áo dài truyền thống, thích hợp cho độ tuổi 40-55', 4000000, 20, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục người lớn tuổi'), null, GETDATE(), 1),
    (N'Quần áo thể thao', N'Quần áo thể thao dành cho mọi độ tuổi', 1500000, 70, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục thể thao'), null, GETDATE(), 1),
    (N'Áo khoác người lớn tuổi', N'Áo khoác ấm áp cho độ tuổi 60-70', 6000000, 10, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục người cao tuổi'), null, GETDATE(), 1),
    (N'Đầm dạ hội trung niên', N'Đầm dạ hội dành cho độ tuổi 55-65', 7000000, 15, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục thời trang dạ hội'), null, GETDATE(), 1),
    (N'Áo sơ mi người lớn tuổi', N'Áo sơ mi dành cho người độ tuổi 70-80', 8000000, 8, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục áo sơ mi'), null, GETDATE(), 1),
    (N'Áo thun phong cách', N'Áo thun thời trang cho độ tuổi 15-25', 1000000, 100, (SELECT DanhMucID FROM DanhMuc WHERE TenDanhMuc = N'Danh mục áo thun'), null, GETDATE(), 1);
	--DELETE FROM [CSM].[dbo].SanPham;

	select *from SanPham
