USE [master]
GO
/****** Object:  Database [QLNV]    Script Date: 06/10/2023 12:03:45 PM ******/
CREATE DATABASE [QLNV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLNV.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLNV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLNV_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLNV] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLNV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLNV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNV] SET  MULTI_USER 
GO
ALTER DATABASE [QLNV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLNV]
GO
/****** Object:  Table [dbo].[TB_ChucVu]    Script Date: 06/10/2023 12:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ChucVu](
	[MaCV] [nchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_TB_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_DanToc]    Script Date: 06/10/2023 12:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_DanToc](
	[MaDT] [nchar](10) NOT NULL,
	[TenDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_TB_DanToc] PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_NhanVien]    Script Date: 06/10/2023 12:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_NhanVien](
	[MSNV] [nchar](10) NOT NULL,
	[Ho_Ten] [nvarchar](50) NULL,
	[HSL] [float] NULL,
	[MaPB] [nchar](10) NULL,
	[CCCD] [float] NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[NamSinh] [text] NULL,
	[ChuyenNganh] [nvarchar](50) NULL,
	[PhuCap] [float] NULL,
	[NgayVaoLam] [text] NULL,
	[MaDT] [nchar](10) NULL,
	[MaTG] [nchar](10) NULL,
	[MaCV] [nchar](10) NULL,
	[SDT] [text] NULL,
 CONSTRAINT [PK_TB_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MSNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_PhongBan]    Script Date: 06/10/2023 12:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PhongBan](
	[MaPB] [nchar](10) NOT NULL,
	[TenPhongBan] [nvarchar](50) NULL,
 CONSTRAINT [PK_TB_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_ThiDua]    Script Date: 06/10/2023 12:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ThiDua](
	[MaTD] [nchar](10) NOT NULL,
	[NoiDung] [nvarchar](50) NULL,
	[LyDo] [nvarchar](50) NULL,
	[NgayThangNam] [text] NULL,
	[MSNV] [nchar](10) NULL,
 CONSTRAINT [PK_TB_ThiDua] PRIMARY KEY CLUSTERED 
(
	[MaTD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_TonGiao]    Script Date: 06/10/2023 12:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TonGiao](
	[MaTG] [nchar](10) NOT NULL,
	[TenTG] [nvarchar](50) NULL,
 CONSTRAINT [PK_TB_TonGiao] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[TB_ChucVu] ([MaCV], [TenCV]) VALUES (N'1         ', N'Nhân Viên')
INSERT [dbo].[TB_ChucVu] ([MaCV], [TenCV]) VALUES (N'2         ', N'Quản Lý')
INSERT [dbo].[TB_ChucVu] ([MaCV], [TenCV]) VALUES (N'3         ', N'Trưởng Phòng')
INSERT [dbo].[TB_ChucVu] ([MaCV], [TenCV]) VALUES (N'4         ', N'Bảo Vệ')
INSERT [dbo].[TB_ChucVu] ([MaCV], [TenCV]) VALUES (N'5         ', N'Giám Đốc')
INSERT [dbo].[TB_DanToc] ([MaDT], [TenDT]) VALUES (N'1         ', N'Khác')
INSERT [dbo].[TB_DanToc] ([MaDT], [TenDT]) VALUES (N'2         ', N'Kinh')
INSERT [dbo].[TB_DanToc] ([MaDT], [TenDT]) VALUES (N'3         ', N'Hoa')
INSERT [dbo].[TB_DanToc] ([MaDT], [TenDT]) VALUES (N'4         ', N'Khơ-me')
INSERT [dbo].[TB_DanToc] ([MaDT], [TenDT]) VALUES (N'5         ', N'Thái')
INSERT [dbo].[TB_DanToc] ([MaDT], [TenDT]) VALUES (N'6         ', N'HMông')
INSERT [dbo].[TB_NhanVien] ([MSNV], [Ho_Ten], [HSL], [MaPB], [CCCD], [DiaChi], [NamSinh], [ChuyenNganh], [PhuCap], [NgayVaoLam], [MaDT], [MaTG], [MaCV], [SDT]) VALUES (N'NV01      ', N'Trần Vạn Kiếp', 8.5, N'1         ', 94089003615, N'Long Phú, ST', N'12/01/1989', N'CĐCNTT', 1500000, N'20/10/2016', N'1         ', N'1         ', N'5         ', N'0911799975')
INSERT [dbo].[TB_NhanVien] ([MSNV], [Ho_Ten], [HSL], [MaPB], [CCCD], [DiaChi], [NamSinh], [ChuyenNganh], [PhuCap], [NgayVaoLam], [MaDT], [MaTG], [MaCV], [SDT]) VALUES (N'NV02      ', N'Trần Thị Kiều My', 6.2, N'3         ', 365600087, N'Phường 3, ST', N'04/09/1987', N'CĐCNTT', 350000, N'01/01/2020', N'2         ', N'1         ', N'3         ', N'0933488559')
INSERT [dbo].[TB_NhanVien] ([MSNV], [Ho_Ten], [HSL], [MaPB], [CCCD], [DiaChi], [NamSinh], [ChuyenNganh], [PhuCap], [NgayVaoLam], [MaDT], [MaTG], [MaCV], [SDT]) VALUES (N'NV03      ', N'Lý Thị Kiều Mai', 5.6, N'2         ', 94198000098, N'Trần Đề, ST', N'01/02/1998', N'Y sĩ Đa khoa', 500000, N'01/01/2019', N'3         ', N'1         ', N'2         ', N'0583206317')
INSERT [dbo].[TB_NhanVien] ([MSNV], [Ho_Ten], [HSL], [MaPB], [CCCD], [DiaChi], [NamSinh], [ChuyenNganh], [PhuCap], [NgayVaoLam], [MaDT], [MaTG], [MaCV], [SDT]) VALUES (N'NV04      ', N'Ngô Tống Giang', 5.5, N'5         ', 94093000193, N'Lê Hồng Phong', N'29/11/1993', N'CĐCNTT', 150000, N'30/08/2021', N'5         ', N'2         ', N'1         ', N'0397291193')
INSERT [dbo].[TB_NhanVien] ([MSNV], [Ho_Ten], [HSL], [MaPB], [CCCD], [DiaChi], [NamSinh], [ChuyenNganh], [PhuCap], [NgayVaoLam], [MaDT], [MaTG], [MaCV], [SDT]) VALUES (N'NV05      ', N'Nguyễn Thúy VY', 4.3, N'7         ', 365645795, N'Mỹ Xuyên, ST', N'19/09/1995', N'CĐCNTT', 50000, N'09/09/2022', N'6         ', N'4         ', N'4         ', N'0396587123')
INSERT [dbo].[TB_NhanVien] ([MSNV], [Ho_Ten], [HSL], [MaPB], [CCCD], [DiaChi], [NamSinh], [ChuyenNganh], [PhuCap], [NgayVaoLam], [MaDT], [MaTG], [MaCV], [SDT]) VALUES (N'NV06      ', N'Phúa T. Kim Luông', 5.3, N'4         ', 94192003192, N'Mỹ Xuyên, ST', N'28/10/1992', N'CĐ Công tác XH', 75000, N'15/01/2016', N'4         ', N'3         ', N'1         ', N'0375744571')
INSERT [dbo].[TB_PhongBan] ([MaPB], [TenPhongBan]) VALUES (N'1         ', N'Ban Giám Đốc')
INSERT [dbo].[TB_PhongBan] ([MaPB], [TenPhongBan]) VALUES (N'2         ', N'Phòng Tổ Chức')
INSERT [dbo].[TB_PhongBan] ([MaPB], [TenPhongBan]) VALUES (N'3         ', N'Phòng Kế Hoạch')
INSERT [dbo].[TB_PhongBan] ([MaPB], [TenPhongBan]) VALUES (N'4         ', N'Phòng Kế Toán')
INSERT [dbo].[TB_PhongBan] ([MaPB], [TenPhongBan]) VALUES (N'5         ', N'Phòng Làm Việc 1')
INSERT [dbo].[TB_PhongBan] ([MaPB], [TenPhongBan]) VALUES (N'6         ', N'Phòng Làm Việc 2')
INSERT [dbo].[TB_PhongBan] ([MaPB], [TenPhongBan]) VALUES (N'7         ', N'Phòng Bảo Vệ')
INSERT [dbo].[TB_ThiDua] ([MaTD], [NoiDung], [LyDo], [NgayThangNam], [MSNV]) VALUES (N'KL01      ', N'Kỹ luật cảnh cáo', N'Nghỉ nhiều', N'01/10/2023', N'NV05      ')
INSERT [dbo].[TB_ThiDua] ([MaTD], [NoiDung], [LyDo], [NgayThangNam], [MSNV]) VALUES (N'KT01      ', N'Khen Thưởng+500.000', N'Siêng năng', N'04/10/2023', N'NV01      ')
INSERT [dbo].[TB_ThiDua] ([MaTD], [NoiDung], [LyDo], [NgayThangNam], [MSNV]) VALUES (N'KT02      ', N'Khuyến khích', N'Nổ lực làm việc', N'04/10/2023', N'NV03      ')
INSERT [dbo].[TB_ThiDua] ([MaTD], [NoiDung], [LyDo], [NgayThangNam], [MSNV]) VALUES (N'KT03      ', N'Khuyến khích', N'Nổ lực làm việc', N'04/10/2023', N'NV02      ')
INSERT [dbo].[TB_ThiDua] ([MaTD], [NoiDung], [LyDo], [NgayThangNam], [MSNV]) VALUES (N'KT04      ', N'Biểu dương', N'Chăm chỉ', N'04/10/2023', N'NV06      ')
INSERT [dbo].[TB_ThiDua] ([MaTD], [NoiDung], [LyDo], [NgayThangNam], [MSNV]) VALUES (N'KT05      ', N'Biểu dương', N'Siêng năng', N'03/10/2023', N'NV04      ')
INSERT [dbo].[TB_TonGiao] ([MaTG], [TenTG]) VALUES (N'1         ', N'Không')
INSERT [dbo].[TB_TonGiao] ([MaTG], [TenTG]) VALUES (N'2         ', N'Phật Giáo')
INSERT [dbo].[TB_TonGiao] ([MaTG], [TenTG]) VALUES (N'3         ', N'Thiên Chúa')
INSERT [dbo].[TB_TonGiao] ([MaTG], [TenTG]) VALUES (N'4         ', N'Tin Lành')
INSERT [dbo].[TB_TonGiao] ([MaTG], [TenTG]) VALUES (N'5         ', N'Cao Đài')
INSERT [dbo].[TB_TonGiao] ([MaTG], [TenTG]) VALUES (N'6         ', N'Hòa Hảo')
INSERT [dbo].[TB_TonGiao] ([MaTG], [TenTG]) VALUES (N'7         ', N'Khác')
ALTER TABLE [dbo].[TB_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_TB_NhanVien_TB_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[TB_ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[TB_NhanVien] CHECK CONSTRAINT [FK_TB_NhanVien_TB_ChucVu]
GO
ALTER TABLE [dbo].[TB_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_TB_NhanVien_TB_DanToc] FOREIGN KEY([MaDT])
REFERENCES [dbo].[TB_DanToc] ([MaDT])
GO
ALTER TABLE [dbo].[TB_NhanVien] CHECK CONSTRAINT [FK_TB_NhanVien_TB_DanToc]
GO
ALTER TABLE [dbo].[TB_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_TB_NhanVien_TB_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[TB_PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[TB_NhanVien] CHECK CONSTRAINT [FK_TB_NhanVien_TB_PhongBan]
GO
ALTER TABLE [dbo].[TB_NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_TB_NhanVien_TB_TonGiao] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TB_TonGiao] ([MaTG])
GO
ALTER TABLE [dbo].[TB_NhanVien] CHECK CONSTRAINT [FK_TB_NhanVien_TB_TonGiao]
GO
ALTER TABLE [dbo].[TB_ThiDua]  WITH CHECK ADD  CONSTRAINT [FK_TB_ThiDua_TB_NhanVien] FOREIGN KEY([MSNV])
REFERENCES [dbo].[TB_NhanVien] ([MSNV])
GO
ALTER TABLE [dbo].[TB_ThiDua] CHECK CONSTRAINT [FK_TB_ThiDua_TB_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLNV] SET  READ_WRITE 
GO
