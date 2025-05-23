USE [QuanLyPhongTro]
GO
/****** Object:  Table [dbo].[ChiTietHDDV]    Script Date: 10/08/2024 3:48:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHDDV](
	[MaChiTietHDDV] [int] IDENTITY(1,1) NOT NULL,
	[MaDichVu] [int] NULL,
	[MaHoaDon] [int] NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietHDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CoSoTro]    Script Date: 10/08/2024 3:48:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoSoTro](
	[MaNhaTro] [int] IDENTITY(1,1) NOT NULL,
	[SLPhong] [int] NULL,
	[TinhThanhPho] [nvarchar](100) NULL,
	[QuanHuyen] [nvarchar](100) NULL,
	[PhuongXa] [nvarchar](100) NULL,
	[SoNha] [nvarchar](100) NULL,
	[SoTang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 10/08/2024 3:48:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](100) NULL,
	[GiaDichVu] [decimal](18, 2) NULL,
	[DonVi] [nvarchar](50) NULL,
	[ThoiGianTao] [datetime] NULL,
	[ThoiGianThayDoi] [datetime] NULL,
	[LanThayDoi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonDV]    Script Date: 10/08/2024 3:48:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonDV](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[TinhTrangHoaDon] [nvarchar](50) NULL,
	[NgayTao] [date] NULL,
	[MaPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachThue]    Script Date: 10/08/2024 3:48:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachThue](
	[MaKhachThue] [nvarchar](12) NOT NULL,
	[TenKhachThue] [nvarchar](100) NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[QueQuan] [nvarchar](100) NULL,
	[TrangThaiThuePhong] [bit] NULL,
	[MaPhong] [int] NULL,
	[MaTaiKhoan] [int] NULL,
	[NgayThue] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
	[LanThue] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongTro]    Script Date: 10/08/2024 3:48:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongTro](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](100) NULL,
	[TrangThaiThue] [bit] NULL,
	[SLNguoiOToiDa] [int] NULL,
	[SLNguoiOHienTai] [int] NULL,
	[NamTaiTang] [int] NULL,
	[MaNhaTro] [int] NULL,
	[GiaPhong] [money] NULL,
	[Dientichphong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 10/08/2024 3:48:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[IsAdmin] [bit] NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 10/08/2024 3:48:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[MaThongBao] [int] IDENTITY(1,1) NOT NULL,
	[TenThongBao] [nvarchar](100) NULL,
	[NoiDung] [nvarchar](max) NULL,
	[MaTaiKhoan] [int] NULL,
	[ThoiGianHetHan] [datetime] NULL,
	[ThoiGianBatDau] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangBiPhong]    Script Date: 10/08/2024 3:48:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangBiPhong](
	[MaPhong] [int] NULL,
	[MaTrangBi] [int] IDENTITY(1,1) NOT NULL,
	[TenTrangBi] [nvarchar](100) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTrangBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHDDV] ON 

INSERT [dbo].[ChiTietHDDV] ([MaChiTietHDDV], [MaDichVu], [MaHoaDon], [SoLuong]) VALUES (1, 1, 1, 100)
INSERT [dbo].[ChiTietHDDV] ([MaChiTietHDDV], [MaDichVu], [MaHoaDon], [SoLuong]) VALUES (2, 2, 1, 30)
INSERT [dbo].[ChiTietHDDV] ([MaChiTietHDDV], [MaDichVu], [MaHoaDon], [SoLuong]) VALUES (3, 1, 2, 80)
INSERT [dbo].[ChiTietHDDV] ([MaChiTietHDDV], [MaDichVu], [MaHoaDon], [SoLuong]) VALUES (4, 3, 2, 1)
INSERT [dbo].[ChiTietHDDV] ([MaChiTietHDDV], [MaDichVu], [MaHoaDon], [SoLuong]) VALUES (5, 1, 3, 120)
INSERT [dbo].[ChiTietHDDV] ([MaChiTietHDDV], [MaDichVu], [MaHoaDon], [SoLuong]) VALUES (6, 2, 3, 50)
INSERT [dbo].[ChiTietHDDV] ([MaChiTietHDDV], [MaDichVu], [MaHoaDon], [SoLuong]) VALUES (7, 1, 4, 90)
INSERT [dbo].[ChiTietHDDV] ([MaChiTietHDDV], [MaDichVu], [MaHoaDon], [SoLuong]) VALUES (8, 2, 4, 20)
SET IDENTITY_INSERT [dbo].[ChiTietHDDV] OFF
GO
SET IDENTITY_INSERT [dbo].[CoSoTro] ON 

INSERT [dbo].[CoSoTro] ([MaNhaTro], [SLPhong], [TinhThanhPho], [QuanHuyen], [PhuongXa], [SoNha], [SoTang]) VALUES (1, 10, N'TP. Hà Nội', N'Cầu Giấy', N'Yên Hòa', N'67 Yên Hòa', 5)
INSERT [dbo].[CoSoTro] ([MaNhaTro], [SLPhong], [TinhThanhPho], [QuanHuyen], [PhuongXa], [SoNha], [SoTang]) VALUES (2, 8, N'TP. Hà Nội', N'Đống Đa', N'Mỹ Đình 2', N'152 Mỹ Đình', 4)
INSERT [dbo].[CoSoTro] ([MaNhaTro], [SLPhong], [TinhThanhPho], [QuanHuyen], [PhuongXa], [SoNha], [SoTang]) VALUES (3, 4, N'TP. Hà Nội', N'Đống Đa', N'Láng Thượng', N'898 Láng', 5)
SET IDENTITY_INSERT [dbo].[CoSoTro] OFF
GO
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi], [ThoiGianTao], [ThoiGianThayDoi], [LanThayDoi]) VALUES (1, N'Tiền điện', CAST(3500.00 AS Decimal(18, 2)), N'kWh', NULL, NULL, NULL)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi], [ThoiGianTao], [ThoiGianThayDoi], [LanThayDoi]) VALUES (2, N'Tiền nước', CAST(15000.00 AS Decimal(18, 2)), N'm3', NULL, NULL, NULL)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi], [ThoiGianTao], [ThoiGianThayDoi], [LanThayDoi]) VALUES (3, N'Internet', CAST(100000.00 AS Decimal(18, 2)), N'Tháng', NULL, NULL, NULL)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi], [ThoiGianTao], [ThoiGianThayDoi], [LanThayDoi]) VALUES (4, N'Gửi xe', CAST(100000.00 AS Decimal(18, 2)), N'Tháng', NULL, NULL, NULL)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi], [ThoiGianTao], [ThoiGianThayDoi], [LanThayDoi]) VALUES (5, N'Dịch vụ vệ sinh', CAST(50000.00 AS Decimal(18, 2)), N'Tháng', NULL, NULL, NULL)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi], [ThoiGianTao], [ThoiGianThayDoi], [LanThayDoi]) VALUES (6, N'', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonDV] ON 

INSERT [dbo].[HoaDonDV] ([MaHoaDon], [TinhTrangHoaDon], [NgayTao], [MaPhong]) VALUES (1, N'Chưa thanh toán', CAST(N'2023-09-01' AS Date), 1)
INSERT [dbo].[HoaDonDV] ([MaHoaDon], [TinhTrangHoaDon], [NgayTao], [MaPhong]) VALUES (2, N'Chưa thanh toán', CAST(N'2023-09-01' AS Date), 2)
INSERT [dbo].[HoaDonDV] ([MaHoaDon], [TinhTrangHoaDon], [NgayTao], [MaPhong]) VALUES (3, N'Chưa thanh toán', CAST(N'2023-09-01' AS Date), 5)
INSERT [dbo].[HoaDonDV] ([MaHoaDon], [TinhTrangHoaDon], [NgayTao], [MaPhong]) VALUES (4, N'Chưa thanh toán', CAST(N'2023-09-01' AS Date), 9)
INSERT [dbo].[HoaDonDV] ([MaHoaDon], [TinhTrangHoaDon], [NgayTao], [MaPhong]) VALUES (5, N'Chưa thanh toán', CAST(N'2023-09-01' AS Date), 6)
SET IDENTITY_INSERT [dbo].[HoaDonDV] OFF
GO
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001234', N'Lê Thanh Huyền', N'0912345678', CAST(N'1995-05-01' AS Date), N'Nữ', N'Hà Nội', 1, 1, 5, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001235', N'Nguyễn Văn A', N'0912345679', CAST(N'1990-06-15' AS Date), N'Nam', N'Hà Nội', 1, 2, 7, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001236', N'Trần Kim Anh', N'0912345680', CAST(N'1992-07-20' AS Date), N'Nữ', N'Hà Nội', 1, 5, 10, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001237', N'Nguyễn Thị PA', N'0912345681', CAST(N'1998-12-12' AS Date), N'Nữ', N'Hà Nội', 1, 9, 13, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001238', N'Phạm Quốc Bảo', N'0912345682', CAST(N'1995-04-10' AS Date), N'Nam', N'Bắc Ninh', 1, 1, 9, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001239', N'Ngô Thị Hằng', N'0912345683', CAST(N'1997-03-25' AS Date), N'Nữ', N'Hưng Yên', 0, 6, 6, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001240', N'Nguyễn Quỳnh Sơn', N'0912345684', CAST(N'1993-09-09' AS Date), N'Nam', N'Hòa Bình', 0, 2, 12, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001241', N'Lê Hoàng Phát', N'0912345685', CAST(N'1990-11-18' AS Date), N'Nam', N'Hà Nội', 1, 10, 4, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001242', N'Đặng Thị Bích', N'0912345686', CAST(N'1999-01-01' AS Date), N'Nữ', N'Nam Định', 1, 4, 2, NULL, NULL, NULL)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong], [MaTaiKhoan], [NgayThue], [NgayHetHan], [LanThue]) VALUES (N'001200001243', N'Vũ Trung Đức', N'0912345687', CAST(N'1991-08-08' AS Date), N'Nam', N'Quảng Ninh', 1, 7, 1, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[PhongTro] ON 

INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (1, N'A201', 1, 4, 3, 2, 1, 35000.0000, 20)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (2, N'A202', 1, 4, 2, 2, 1, 25000.0000, 15)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (3, N'A203', 1, 4, 0, 2, 1, 30000.0000, 18)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (4, N'A204', 1, 4, 0, 2, 1, 40000.0000, 40)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (5, N'A301', 1, 4, 3, 3, 1, 35000.0000, 35)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (6, N'A302', 0, 4, 0, 3, 1, 15000.0000, 15)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (7, N'A303', 1, 4, 0, 3, 1, 28000.0000, 20)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (8, N'A304', 1, 4, 0, 3, 1, 32000.0000, 25)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (9, N'B201', 1, 4, 2, 2, 2, 45000.0000, 40)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (10, N'B202', 1, 4, 0, 2, 2, 42000.0000, 40)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong], [Dientichphong]) VALUES (11, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PhongTro] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'vuductrung', 0, N'123', 1)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'dangthibich', 0, N'123', 2)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'VuMinh', 1, N'123', 3)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'lehoangphat', 0, N'password8', 4)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'lethanhhuyen', 1, N'password1', 5)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'ngothihang', 0, N'password6', 6)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'nguyenvana', 0, N'password2', 7)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'phamquocbao', 0, N'password5', 9)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'trankimanh', 0, N'password3', 10)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'NguyenQuynhSon', 1, N'123', 12)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau], [MaTaiKhoan]) VALUES (N'NguyenThiPA', 0, N'123', 13)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[TrangBiPhong] ON 

INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (1, 1, N'Giường', NULL)
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (1, 2, N'Tủ quần áo', NULL)
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (1, 3, N'Điều hòa', NULL)
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (2, 4, N'Điều hòa', NULL)
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (3, 5, N'Điều hòa', NULL)
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (NULL, 6, N'Điều hòa', NULL)
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (4, 7, N'Điều Hòa', NULL)
SET IDENTITY_INSERT [dbo].[TrangBiPhong] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__B106EAF87C6CC249]    Script Date: 10/08/2024 3:48:47 PM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHDDV]  WITH CHECK ADD FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[ChiTietHDDV]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDonDV] ([MaHoaDon])
GO
ALTER TABLE [dbo].[HoaDonDV]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongTro] ([MaPhong])
GO
ALTER TABLE [dbo].[KhachThue]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongTro] ([MaPhong])
GO
ALTER TABLE [dbo].[KhachThue]  WITH CHECK ADD  CONSTRAINT [FK_KhachThue_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[KhachThue] CHECK CONSTRAINT [FK_KhachThue_TaiKhoan]
GO
ALTER TABLE [dbo].[PhongTro]  WITH CHECK ADD FOREIGN KEY([MaNhaTro])
REFERENCES [dbo].[CoSoTro] ([MaNhaTro])
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD  CONSTRAINT [FK_ThongBao_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[ThongBao] CHECK CONSTRAINT [FK_ThongBao_TaiKhoan]
GO
ALTER TABLE [dbo].[TrangBiPhong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongTro] ([MaPhong])
GO
