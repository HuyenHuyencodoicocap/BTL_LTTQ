USE [QuanLyPhongTro]
GO
/****** Object:  Table [dbo].[ChiTietHDDV]    Script Date: 09/30/2024 8:17:08 AM ******/
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
/****** Object:  Table [dbo].[CoSoTro]    Script Date: 09/30/2024 8:17:08 AM ******/
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
/****** Object:  Table [dbo].[DichVu]    Script Date: 09/30/2024 8:17:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](100) NULL,
	[GiaDichVu] [decimal](18, 2) NULL,
	[DonVi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonDV]    Script Date: 09/30/2024 8:17:08 AM ******/
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
/****** Object:  Table [dbo].[KhachThue]    Script Date: 09/30/2024 8:17:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachThue](
	[MaKhachThue] [nvarchar](12) NOT NULL,
	[TenKhachThue] [nvarchar](100) NULL,
	[TenTaiKhoan] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[QueQuan] [nvarchar](100) NULL,
	[TrangThaiThuePhong] [nvarchar](50) NULL,
	[MaPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongTro]    Script Date: 09/30/2024 8:17:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongTro](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](100) NULL,
	[TrangThaiThue] [nvarchar](50) NULL,
	[SLNguoiOToiDa] [int] NULL,
	[SLNguoiOHienTai] [int] NULL,
	[NamTaiTang] [int] NULL,
	[MaNhaTro] [int] NULL,
	[GiaPhong] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 09/30/2024 8:17:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[IsAdmin] [bit] NULL,
	[MatKhau] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 09/30/2024 8:17:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[MaThongBao] [int] IDENTITY(1,1) NOT NULL,
	[TenThongBao] [nvarchar](100) NULL,
	[ThoiGian] [datetime] NULL,
	[NoiDung] [nvarchar](max) NULL,
	[TenTaiKhoan] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangBiPhong]    Script Date: 09/30/2024 8:17:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangBiPhong](
	[MaPhong] [int] NULL,
	[MaTrangBi] [int] IDENTITY(1,1) NOT NULL,
	[TenTrangBi] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](50) NULL,
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

INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi]) VALUES (1, N'Tiền điện', CAST(3500.00 AS Decimal(18, 2)), N'kWh')
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi]) VALUES (2, N'Tiền nước', CAST(15000.00 AS Decimal(18, 2)), N'm3')
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi]) VALUES (3, N'Internet', CAST(100000.00 AS Decimal(18, 2)), N'Tháng')
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi]) VALUES (4, N'Gửi xe', CAST(100000.00 AS Decimal(18, 2)), N'Tháng')
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi]) VALUES (5, N'Dịch vụ vệ sinh', CAST(50000.00 AS Decimal(18, 2)), N'Tháng')
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [DonVi]) VALUES (6, N'', NULL, NULL)
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
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001234', N'Lê Thanh Huyền', N'lethanhhuyen', N'0912345678', CAST(N'1995-05-01' AS Date), N'Nữ', N'Hà Nội', N'Đang thuê', 1)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001235', N'Nguyễn Văn A', N'nguyenvana', N'0912345679', CAST(N'1990-06-15' AS Date), N'Nam', N'Hà Nội', N'Đang thuê', 2)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001236', N'Trần Kim Anh', N'trankimanh', N'0912345680', CAST(N'1992-07-20' AS Date), N'Nữ', N'Hà Nội', N'Đang thuê', 5)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001237', N'Đỗ Thị Mai', N'dothimai', N'0912345681', CAST(N'1998-12-12' AS Date), N'Nữ', N'Hà Nội', N'Đang thuê', 9)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001238', N'Phạm Quốc Bảo', N'phamquocbao', N'0912345682', CAST(N'1995-04-10' AS Date), N'Nam', N'Bắc Ninh', N'Đang thuê', 1)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001239', N'Ngô Thị Hằng', N'ngothihang', N'0912345683', CAST(N'1997-03-25' AS Date), N'Nữ', N'Hưng Yên', N'Đang thuê', 6)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001240', N'Bùi Đức Mạnh', N'buiducmanh', N'0912345684', CAST(N'1993-09-09' AS Date), N'Nam', N'Hòa Bình', N'Đang thuê', 2)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001241', N'Lê Hoàng Phát', N'lehoangphat', N'0912345685', CAST(N'1990-11-18' AS Date), N'Nam', N'Hà Nội', N'Đang thuê', 10)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001242', N'Đặng Thị Bích', N'dangthibich', N'0912345686', CAST(N'1999-01-01' AS Date), N'Nữ', N'Nam Định', N'Đang thuê', 4)
INSERT [dbo].[KhachThue] ([MaKhachThue], [TenKhachThue], [TenTaiKhoan], [SoDienThoai], [NgaySinh], [GioiTinh], [QueQuan], [TrangThaiThuePhong], [MaPhong]) VALUES (N'001200001243', N'Vũ Trung Đức', N'vutrungduc', N'0912345687', CAST(N'1991-08-08' AS Date), N'Nam', N'Quảng Ninh', N'Đang thuê', 7)
GO
SET IDENTITY_INSERT [dbo].[PhongTro] ON 

INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (1, N'201', N'Đã thuê', 4, 3, 2, 1, 35000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (2, N'202', N'Đã thuê', 4, 2, 2, 1, 25000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (3, N'203', N'Còn trống', 4, 0, 2, 1, 30000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (4, N'204', N'Còn trống', 4, 0, 2, 1, 40000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (5, N'301', N'Đã thuê', 4, 3, 3, 1, 35000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (6, N'302', N'Còn trống', 4, 0, 3, 1, 15000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (7, N'303', N'Còn trống', 4, 0, 3, 1, 28000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (8, N'304', N'Còn trống', 4, 0, 3, 1, 32000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (9, N'201', N'Đã thuê', 4, 2, 2, 2, 45000.0000)
INSERT [dbo].[PhongTro] ([MaPhong], [TenPhong], [TrangThaiThue], [SLNguoiOToiDa], [SLNguoiOHienTai], [NamTaiTang], [MaNhaTro], [GiaPhong]) VALUES (10, N'B202', N'Còn trống', 4, 0, 2, 2, 42000.0000)
SET IDENTITY_INSERT [dbo].[PhongTro] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'buiducmanh', 0, N'password7')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'dangthibich', 0, N'password9')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'dothimai', 0, N'password4')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'lehoangphat', 0, N'password8')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'lethanhhuyen', 1, N'password1')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'ngothihang', 0, N'password6')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'nguyenvana', 0, N'password2')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'phamquocbao', 0, N'password5')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'trankimanh', 0, N'password3')
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [IsAdmin], [MatKhau]) VALUES (N'vutrungduc', 0, N'password10')
GO
SET IDENTITY_INSERT [dbo].[TrangBiPhong] ON 

INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (1, 1, N'Giường', N'True')
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (1, 2, N'Tủ quần áo', N'True')
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (1, 3, N'Điều hòa', N'True')
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (2, 4, N'Điều hòa', N'True')
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (3, 5, N'Điều hòa', N'True')
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (NULL, 6, N'Điều hòa', NULL)
INSERT [dbo].[TrangBiPhong] ([MaPhong], [MaTrangBi], [TenTrangBi], [TrangThai]) VALUES (4, 7, N'Điều Hòa', N'True')
SET IDENTITY_INSERT [dbo].[TrangBiPhong] OFF
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
ALTER TABLE [dbo].[KhachThue]  WITH CHECK ADD FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([TenTaiKhoan])
GO
ALTER TABLE [dbo].[PhongTro]  WITH CHECK ADD FOREIGN KEY([MaNhaTro])
REFERENCES [dbo].[CoSoTro] ([MaNhaTro])
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([TenTaiKhoan])
GO
ALTER TABLE [dbo].[TrangBiPhong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongTro] ([MaPhong])
GO
