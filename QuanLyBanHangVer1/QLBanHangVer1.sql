USE [master]
GO
/****** Object:  Database [QLBanHangVer1]    Script Date: 20/12/2023 2:39:30 PM ******/
CREATE DATABASE [QLBanHangVer1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBanHangVer1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBanHangVer1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBanHangVer1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLBanHangVer1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLBanHangVer1] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBanHangVer1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBanHangVer1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLBanHangVer1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBanHangVer1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBanHangVer1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLBanHangVer1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBanHangVer1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBanHangVer1] SET  MULTI_USER 
GO
ALTER DATABASE [QLBanHangVer1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBanHangVer1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBanHangVer1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBanHangVer1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBanHangVer1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBanHangVer1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLBanHangVer1] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLBanHangVer1] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLBanHangVer1]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [nvarchar](10) NOT NULL,
	[TenChucVu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHangHoa] [nvarchar](10) NOT NULL,
	[HanSuDung] [nvarchar](20) NULL,
	[TenHangHoa] [nvarchar](100) NULL,
	[NoiSanXuat] [nvarchar](100) NULL,
	[DonViTinh] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH](
	[MaKhach] [nvarchar](10) NOT NULL,
	[SDT] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[LoaiKhach] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNhaCungCap] [nvarchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nvarchar](10) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[MaChucVu] [nvarchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[SDT] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[NgaySinh] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [nvarchar](10) NOT NULL,
	[NgayNhap] [nvarchar](20) NULL,
	[TongTien] [float] NULL,
	[MaNhanVien] [nvarchar](10) NULL,
	[MaNhaCungCap] [nvarchar](10) NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
	[MaHangHoa] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPhieuXuat] [nvarchar](10) NOT NULL,
	[NgayXuat] [nvarchar](20) NULL,
	[TongTien] [float] NULL,
	[MaNhanVien] [nvarchar](10) NULL,
	[MaKhach] [nvarchar](10) NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
	[MaHangHoa] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYENDANGNHAP]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYENDANGNHAP](
	[TenDangNhap] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
	[MaChucVu] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'0', N'ADMIN')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'1', N'NHAN VIEN')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'2', N'0')
GO
INSERT [dbo].[HANGHOA] ([MaHangHoa], [HanSuDung], [TenHangHoa], [NoiSanXuat], [DonViTinh]) VALUES (N'HH001', N'19/12/2023', N'Trà', N'Rừng', N'300000')
INSERT [dbo].[HANGHOA] ([MaHangHoa], [HanSuDung], [TenHangHoa], [NoiSanXuat], [DonViTinh]) VALUES (N'HH002', N'19/12/2023', N'Dâu', N'Rừng', N'100000')
GO
INSERT [dbo].[KHACH] ([MaKhach], [SDT], [DiaChi], [LoaiKhach]) VALUES (N'KH001', N'123456789', N'Thu Duc', N'VIP')
GO
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SDT], [Email]) VALUES (N'NCC1', N'Nha Cung Cap 1', N'Thien Duong', N'12345', N'NCC1@gmail.com')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SDT], [Email]) VALUES (N'NCC2', N'', N'', N'', N'')
GO
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [SDT], [DiaChi], [NgaySinh]) VALUES (N'NV001', N'1', N'Thanh Truong', N'Nam', N'123', N'Thu Duc', N'28/06/2004')
GO
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [TongTien], [MaNhanVien], [MaNhaCungCap], [DonGia], [SoLuong], [MaHangHoa]) VALUES (N'0', N'19/12/2023', 900000, N'NV001', N'NCC1', 300000, 3, N'HH001')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [TongTien], [MaNhanVien], [MaNhaCungCap], [DonGia], [SoLuong], [MaHangHoa]) VALUES (N'1', N'19/12/2023', 200000, N'NV001', N'NCC1', 100000, 2, N'HH002')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [TongTien], [MaNhanVien], [MaNhaCungCap], [DonGia], [SoLuong], [MaHangHoa]) VALUES (N'2', N'19/12/2023', 600000, N'NV001', N'NCC1', 300000, 2, N'HH001')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [TongTien], [MaNhanVien], [MaNhaCungCap], [DonGia], [SoLuong], [MaHangHoa]) VALUES (N'3', N'19/12/2023', 600000, N'NV001', N'NCC2', 300000, 2, N'HH001')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [TongTien], [MaNhanVien], [MaNhaCungCap], [DonGia], [SoLuong], [MaHangHoa]) VALUES (N'4', N'19/12/2023', 300000, N'NV001', N'NCC2', 100000, 3, N'HH002')
GO
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [TongTien], [MaNhanVien], [MaKhach], [DonGia], [SoLuong], [MaHangHoa]) VALUES (N'1', N'19/12/2023', 600000, N'NV001', N'KH001', 300000, 2, N'HH001')
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [TongTien], [MaNhanVien], [MaKhach], [DonGia], [SoLuong], [MaHangHoa]) VALUES (N'2', N'19/12/2023', 600000, N'NV001', N'KH001', 300000, 2, N'HH001')
GO
INSERT [dbo].[QUYENDANGNHAP] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'0', N'0', N'0')
INSERT [dbo].[QUYENDANGNHAP] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'1', N'1', N'1')
INSERT [dbo].[QUYENDANGNHAP] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'2', N'2', N'0')
INSERT [dbo].[QUYENDANGNHAP] ([TenDangNhap], [MatKhau], [MaChucVu]) VALUES (N'Anh Do', N'1', N'0')
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HANGHOA] ([MaHangHoa])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KHACH] ([MaKhach])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KHACH] ([MaKhach])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KHACH] ([MaKhach])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[QUYENDANGNHAP]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[QUYENDANGNHAP]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[QUYENDANGNHAP]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
/****** Object:  StoredProcedure [dbo].[danhSachKhachHang]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[danhSachKhachHang]
as select * from KHACH
GO
/****** Object:  StoredProcedure [dbo].[layDanhSachHangHoa]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layDanhSachHangHoa]
as select * from HANGHOA
GO
/****** Object:  StoredProcedure [dbo].[LayDanhSachMaChucVu]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayDanhSachMaChucVu]
as select MaChucVu from CHUCVU
GO
/****** Object:  StoredProcedure [dbo].[layDanhSachMaHangHoa]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layDanhSachMaHangHoa]
as select MaHangHoa from HANGHOA
GO
/****** Object:  StoredProcedure [dbo].[layDanhSachMaNCC]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layDanhSachMaNCC]
as select MaNhaCungCap from NHACUNGCAP
GO
/****** Object:  StoredProcedure [dbo].[layDanhSachMaNhanVien]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layDanhSachMaNhanVien]
as select MaNhanVien from NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[LayDanhSachNhaCungCap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayDanhSachNhaCungCap]
as select * from NHACUNGCAP
GO
/****** Object:  StoredProcedure [dbo].[layDanhSachNhanVien]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layDanhSachNhanVien]
as select * from NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[LayDanhSachQuyenDangNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayDanhSachQuyenDangNhap]
as select * from QUYENDANGNHAP
GO
/****** Object:  StoredProcedure [dbo].[layDonGia]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layDonGia](@maHH nvarchar(10))
as select DonViTinh from HANGHOA where MaHangHoa=@maHH
GO
/****** Object:  StoredProcedure [dbo].[layPhieuNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layPhieuNhap]
as select * from PHIEUNHAP
GO
/****** Object:  StoredProcedure [dbo].[layPhieuXuat]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layPhieuXuat]
as select * from PHIEUXUAT
GO
/****** Object:  StoredProcedure [dbo].[layTatCaChucVu]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layTatCaChucVu]
as select * from CHUCVU
GO
/****** Object:  StoredProcedure [dbo].[layTenDangNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layTenDangNhap]
as select TenDangNhap from QUYENDANGNHAP
GO
/****** Object:  StoredProcedure [dbo].[layTenHangHoa]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[layTenHangHoa](@maHH nvarchar(10))
as select TenHangHoa from HANGHOA where MaHangHoa=@maHH
GO
/****** Object:  StoredProcedure [dbo].[SP_AuthoLogin]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_AuthoLogin](
@Username nvarchar(20),
@Password nvarchar(20),
@JobID nvarchar(20))
as
begin
    if exists (select * from QUYENDANGNHAP where TenDangNhap = @Username and MatKhau = @Password and MaChucVu = 0)
        select 1 as code
    else if exists (select * from QUYENDANGNHAP where TenDangNhap = @Username and MatKhau = @Password and MaChucVu = @JobID)
        select 0 as code
    else if exists(select * from QUYENDANGNHAP where TenDangNhap = @Username and MatKhau != @Password) 
        select 2 as code
    else select 3 as code
end
GO
/****** Object:  StoredProcedure [dbo].[suaChucVu]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaChucVu](@maChucVu nvarchar(50),@tenDangNhap nvarchar(50))
as update CHUCVU set TenChucVu=@tenDangNhap where MaChucVu=@maChucVu
GO
/****** Object:  StoredProcedure [dbo].[suaHangHoa]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaHangHoa](@maHH nvarchar(10),@hanSuDung nvarchar(20),@tenHH nvarchar(100),@noiSanXuat nvarchar(100),@donViTinh nvarchar(30))
as update HANGHOA set HanSuDung=@hanSuDung,TenHangHoa=@tenHH,NoiSanXuat=@noiSanXuat,DonViTinh=@donViTinh where MaHangHoa=@maHH
GO
/****** Object:  StoredProcedure [dbo].[suaKhachHang]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaKhachHang](@maKH nvarchar(10), @sdt nvarchar(10),@diaChi nvarchar(100),@loaiKhach nvarchar(50))
as update KHACH set SDT=@sdt,DiaChi=@diaChi,LoaiKhach=@loaiKhach where MaKhach=@maKH
GO
/****** Object:  StoredProcedure [dbo].[suaNhaCungCap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaNhaCungCap](@maNhaCungCap nvarchar(50),@tenNhaCungCap nvarchar(50),@diaChi nvarchar(50),@soDienThoai nvarchar(50),@email nvarchar(50))
as update NHACUNGCAP set TenNhaCungCap=@tenNhaCungCap,DiaChi=@diaChi,SDT=@soDienThoai,Email=@email
GO
/****** Object:  StoredProcedure [dbo].[suaNhaCungCap1]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaNhaCungCap1](@maNhaCungCap nvarchar(50),@tenNhaCungCap nvarchar(50),@diaChi nvarchar(50),@soDienThoai nvarchar(50),@email nvarchar(50))
as update NHACUNGCAP set TenNhaCungCap=@tenNhaCungCap,DiaChi=@diaChi,SDT=@soDienThoai,Email=@email where MaNhaCungCap=@maNhaCungCap
GO
/****** Object:  StoredProcedure [dbo].[suaNhanVien]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaNhanVien](@maNV nvarchar(10),@maChucVu nvarchar(10),@tenNV nvarchar(100),@gioiTinh nvarchar(10),@sDT nvarchar(10),@diaChi nvarchar(100),@ngaySinh nvarchar(20))
as update NHANVIEN set MaChucVu=@maChucVu,TenNhanVien=@tenNV,GioiTinh=@gioiTinh,SDT=@sDT,DiaChi=@diaChi,NgaySinh=@ngaySinh where MaNhanVien=@maNV
GO
/****** Object:  StoredProcedure [dbo].[suaQuyenDangNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaQuyenDangNhap](@tenDangNhap nvarchar(50),@matKhau nvarchar(50),@maChucVu nvarchar(50))
as update QUYENDANGNHAP set MatKhau=@matKhau,MaChucVu=@maChucVu where TenDangNhap=@tenDangNhap
GO
/****** Object:  StoredProcedure [dbo].[timKiemPhieuNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timKiemPhieuNhap](@maNCC nvarchar(10))
as select * from PHIEUNHAP where MaNhaCungCap=@maNCC
GO
/****** Object:  StoredProcedure [dbo].[timKiemPhieuXuat]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timKiemPhieuXuat](@maKH nvarchar(10))
as select * from PHIEUNHAP where MaNhaCungCap=@maKH
GO
/****** Object:  StoredProcedure [dbo].[timKiemPhieuXuat1]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timKiemPhieuXuat1](@maKH nvarchar(10))
as select * from PHIEUXUAT where MaKhach=@maKH
GO
/****** Object:  StoredProcedure [dbo].[tinhTongPhieuNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tinhTongPhieuNhap]
as select sum(TongTien) from PHIEUNHAP
GO
/****** Object:  StoredProcedure [dbo].[tinhTongPhieuNhap1]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tinhTongPhieuNhap1](@maNCC nvarchar(10))
as select sum(TongTien) from PHIEUNHAP where MaNhaCungCap=@maNCC
GO
/****** Object:  StoredProcedure [dbo].[tinhTongPhieuNhap2]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tinhTongPhieuNhap2](@maNCC nvarchar(10))
as select sum(TongTien) AS tongTienNhap from PHIEUNHAP where MaNhaCungCap=@maNCC
GO
/****** Object:  StoredProcedure [dbo].[tinhTongPhieuXuat]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tinhTongPhieuXuat](@maKH nvarchar(10))
as select sum(TongTien) AS tongTienNhap from PHIEUXUAT where MaKhach=@maKH
GO
/****** Object:  StoredProcedure [dbo].[themChucVu]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themChucVu](@maChucVu nvarchar(50),@tenChucVu nvarchar(50))
as insert into CHUCVU values (@maChucVu,@tenChucVu)
GO
/****** Object:  StoredProcedure [dbo].[themHangHoa]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themHangHoa](@maHH nvarchar(10),@hanSuDung nvarchar(20),@tenHH nvarchar(100),@noiSanXuat nvarchar(100),@donViTinh nvarchar(30))
as insert into HANGHOA values(@maHH,@hanSuDung,@tenHH,@noiSanXuat,@donViTinh)
GO
/****** Object:  StoredProcedure [dbo].[themKhachHang]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themKhachHang](@maKH nvarchar(10),@SDT nvarchar(10),@diaChi nvarchar(100),@loaiKhach nvarchar(50))
as insert into KHACH values(@maKH,@SDT,@diaChi,@loaiKhach)
GO
/****** Object:  StoredProcedure [dbo].[themNhaCungCap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themNhaCungCap](@maNhaCungCap nvarchar(50),@tenNhaCungCap nvarchar(50),@diaChi nvarchar(50),@soDienThoai nvarchar(50),@email nvarchar(50))
as insert into NHACUNGCAP values (@maNhaCungCap,@tenNhaCungCap,@diaChi,@soDienThoai,@email)
GO
/****** Object:  StoredProcedure [dbo].[themNhanVien]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themNhanVien](@maNV nvarchar(10),@maChucVu nvarchar(10),@tenNV nvarchar(100),@gioiTinh nvarchar(10),@sDT nvarchar(10),@diaChi nvarchar(100),@ngaySinh nvarchar(20))
as insert into NHANVIEN values(@maNV,@maChucVu,@tenNV,@gioiTinh,@sDT,@diaChi,@ngaySinh)
GO
/****** Object:  StoredProcedure [dbo].[themPhieuNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themPhieuNhap](@maPN nvarchar(10),@ngayNhap nvarchar(10),@tongTien float,@maNV nvarchar(10),@maNCC nvarchar(10),@donGia float,@soLuong int,@maHH nvarchar(10))
as insert into PHIEUNHAP values(@maPN,@ngayNhap,@tongTien,@maNV,@maNCC,@donGia,@soLuong,@maHH)
GO
/****** Object:  StoredProcedure [dbo].[themPhieuXuat]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themPhieuXuat](@maPX nvarchar(10),@ngayNhap nvarchar(10),@tongTien float,@maNV nvarchar(10),@maKH nvarchar(10),@donGia float,@soLuong int,@maHH nvarchar(10))
as insert into PHIEUXUAT values(@maPX,@ngayNhap,@tongTien,@maNV,@maKH,@donGia,@soLuong,@maHH)
GO
/****** Object:  StoredProcedure [dbo].[ThemQuyenDangNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemQuyenDangNhap](@tenDangNhap nvarchar(50),@matKhau nvarchar(50),@maChucVu nvarchar(50))
as insert into QUYENDANGNHAP values (@tenDangNhap,@matKhau,@maChucVu)
GO
/****** Object:  StoredProcedure [dbo].[xoaChucVu]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaChucVu](@maChucVu nvarchar(50))
as delete CHUCVU where MaChucVu=@maChucVu
GO
/****** Object:  StoredProcedure [dbo].[xoaHangHoa]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaHangHoa](@maHH nvarchar(10))
as delete HANGHOA where MaHangHoa=@maHH
GO
/****** Object:  StoredProcedure [dbo].[xoaKhachHang]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaKhachHang](@maKH nvarchar(10))
as delete KHACH where MaKhach=@maKH
GO
/****** Object:  StoredProcedure [dbo].[xoaNhaCungCap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaNhaCungCap](@maNhaCungCap nvarchar(50))
as delete NHACUNGCAP where MaNhaCungCap=@maNhaCungCap
GO
/****** Object:  StoredProcedure [dbo].[xoaNhanVien]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaNhanVien](@maNV nvarchar(10))
as delete from NHANVIEN where MaNhanVien=@maNV
GO
/****** Object:  StoredProcedure [dbo].[xoaPhieuNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaPhieuNhap](@maPN nvarchar(10))
as delete PHIEUNHAP where MaPhieuNhap=@maPN
GO
/****** Object:  StoredProcedure [dbo].[xoaQuyenDangNhap]    Script Date: 20/12/2023 2:39:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaQuyenDangNhap](@tenDangNhap nvarchar(50))
as delete QUYENDANGNHAP where TenDangNhap=@tenDangNhap
GO
USE [master]
GO
ALTER DATABASE [QLBanHangVer1] SET  READ_WRITE 
GO
select MaChucVu from QUYENDANGNHAP where TenDangNhap='0' and MatKhau='0'
GO
create proc xoaPhieuXuat(@maPX nvarchar(10))
as delete PHIEUXUAT where MaPhieuXuat=@maPX
GO
create proc timHangHoaTheoMa(@maHH nvarchar(10))
as select * from HANGHOA where MaHangHoa = @maHH
GO 
select * from NHANVIEN where GioiTinh = N'Nữ'
