USE [master]
GO
/****** Object:  Database [QUANGLYNHATHUOC]    Script Date: 11/16/2016 9:33:29 PM ******/
CREATE DATABASE [QUANGLYNHATHUOC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANGLYNHATHUOC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.CAOTHUONG\MSSQL\DATA\QUANGLYNHATHUOC.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANGLYNHATHUOC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.CAOTHUONG\MSSQL\DATA\QUANGLYNHATHUOC_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANGLYNHATHUOC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET  MULTI_USER 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANGLYNHATHUOC', N'ON'
GO
USE [QUANGLYNHATHUOC]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 11/16/2016 9:33:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD](
	[IDCTHD] [int] IDENTITY(1,1) NOT NULL,
	[TENTHUOC] [nvarchar](100) NULL,
	[DVT] [int] NULL,
	[SOLUONG] [int] NULL,
	[GIABAN] [varchar](50) NULL,
	[THANHTIEN] [varchar](50) NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[IDCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DONVITINH]    Script Date: 11/16/2016 9:33:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVITINH](
	[IDDVT] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](50) NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[IDDVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/16/2016 9:33:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[IDHOADON] [int] IDENTITY(1,1) NOT NULL,
	[NGAYTAOHD] [datetime] NULL,
	[NGUOITAOHD] [int] NULL,
	[TONGTIEN] [varchar](50) NULL,
	[IDCTHD] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[IDHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAITHUOC]    Script Date: 11/16/2016 9:33:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITHUOC](
	[IDLOAITHUOC] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAITHUOC] [nvarchar](100) NULL,
 CONSTRAINT [PK_LOAITHUOC] PRIMARY KEY CLUSTERED 
(
	[IDLOAITHUOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 11/16/2016 9:33:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[IDNGUOIDUNG] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [datetime] NULL,
	[QUEQUAN] [nvarchar](100) NULL,
	[CMND] [int] NULL,
	[HINHANH] [nvarchar](50) NULL,
	[TRINHDO] [int] NULL,
	[QUYEN] [int] NULL,
	[SDT] [int] NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[IDNGUOIDUNG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHAPHANG]    Script Date: 11/16/2016 9:33:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAPHANG](
	[IDNHAPHANG] [int] IDENTITY(1,1) NOT NULL,
	[NGAYNHAPHANG] [datetime] NULL,
	[TENTHUOC] [nvarchar](50) NULL,
	[SOLUONG] [int] NULL,
	[DVT] [nvarchar](50) NULL,
	[GIANHAP] [varchar](50) NULL,
	[THANHTIEN] [varchar](50) NULL,
 CONSTRAINT [PK_NHAPHANG] PRIMARY KEY CLUSTERED 
(
	[IDNHAPHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 11/16/2016 9:33:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[IDQUYDINH] [int] IDENTITY(1,1) NOT NULL,
	[PHANTRAMCHIETKHAU] [int] NULL,
	[TENQUYDINH] [nvarchar](50) NULL,
	[TENTHUOC] [nvarchar](100) NULL,
 CONSTRAINT [PK_QUYDINH] PRIMARY KEY CLUSTERED 
(
	[IDQUYDINH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THUOC]    Script Date: 11/16/2016 9:33:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUOC](
	[IDTHUOC] [int] IDENTITY(1,1) NOT NULL,
	[TENTHUOC] [nvarchar](100) NULL,
	[THANHPHAN] [ntext] NULL,
	[CHIDINH] [ntext] NULL,
	[LIEUDUNG] [ntext] NULL,
	[CHONGCHIDINH] [ntext] NULL,
	[THANTRONG] [ntext] NULL,
	[PHANUNGPHU] [ntext] NULL,
	[TUONGTACTHUOC] [ntext] NULL,
	[TRINHBAYDONGGOI] [ntext] NULL,
	[NHASANXUAT] [nchar](10) NULL,
	[SOLUONG] [int] NULL,
	[DONVI] [nvarchar](50) NULL,
	[GIABAN] [nvarchar](50) NULL,
	[HINHANH] [nvarchar](50) NULL,
	[LOAITHUOC] [nvarchar](50) NULL,
 CONSTRAINT [PK_THUOC] PRIMARY KEY CLUSTERED 
(
	[IDTHUOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DONVITINH] ON 

INSERT [dbo].[DONVITINH] ([IDDVT], [TEN]) VALUES (1, N'Vỉ')
INSERT [dbo].[DONVITINH] ([IDDVT], [TEN]) VALUES (2, N'Hộp')
INSERT [dbo].[DONVITINH] ([IDDVT], [TEN]) VALUES (3, N'Thùng')
INSERT [dbo].[DONVITINH] ([IDDVT], [TEN]) VALUES (4, N'Viên')
SET IDENTITY_INSERT [dbo].[DONVITINH] OFF
SET IDENTITY_INSERT [dbo].[LOAITHUOC] ON 

INSERT [dbo].[LOAITHUOC] ([IDLOAITHUOC], [TENLOAITHUOC]) VALUES (1, N'Kháng viêm giảm đau')
INSERT [dbo].[LOAITHUOC] ([IDLOAITHUOC], [TENLOAITHUOC]) VALUES (2, N'Kháng sinh')
INSERT [dbo].[LOAITHUOC] ([IDLOAITHUOC], [TENLOAITHUOC]) VALUES (3, N'Thực phẩm chức năng')
INSERT [dbo].[LOAITHUOC] ([IDLOAITHUOC], [TENLOAITHUOC]) VALUES (4, N'Tiểu đường – Mỡ máu')
INSERT [dbo].[LOAITHUOC] ([IDLOAITHUOC], [TENLOAITHUOC]) VALUES (5, N'Tiêu hóa – Gan mật')
INSERT [dbo].[LOAITHUOC] ([IDLOAITHUOC], [TENLOAITHUOC]) VALUES (6, N'Tim mạch – Huyết áp')
SET IDENTITY_INSERT [dbo].[LOAITHUOC] OFF
SET IDENTITY_INSERT [dbo].[QUYDINH] ON 

INSERT [dbo].[QUYDINH] ([IDQUYDINH], [PHANTRAMCHIETKHAU], [TENQUYDINH], [TENTHUOC]) VALUES (1, 30, N'QD1', NULL)
SET IDENTITY_INSERT [dbo].[QUYDINH] OFF
SET IDENTITY_INSERT [dbo].[THUOC] ON 

INSERT [dbo].[THUOC] ([IDTHUOC], [TENTHUOC], [THANHPHAN], [CHIDINH], [LIEUDUNG], [CHONGCHIDINH], [THANTRONG], [PHANUNGPHU], [TUONGTACTHUOC], [TRINHBAYDONGGOI], [NHASANXUAT], [SOLUONG], [DONVI], [GIABAN], [HINHANH], [LOAITHUOC]) VALUES (1, N'Panadol – Thuốc giảm đau, hạ sốt', N'Paracetamol 500mg', N'Điều trị đau nhẹ đến vừa bao gồm: Đau đầu, đau nửa đầu, đau cơ, đau bụng kinh, đau họng, đau cơ xương, sốt và đau sau khi tiêm vacxin, đau sau khi nhổ răng hoặc sau các thủ thuật nha khoa, đau răng, đau do viêm xương khớp
Hạ sốt', N'- Người lớn, trẻ > 12 tuổi: 1 – 2 viên x 3 – 4 lần/ngày, không quá 8 viên/ngày
- Trẻ 7 – 12 tuổi: 1 viên/lần, không quá 4 viên/ngày
- Khoảng cách tối thiểu giữa 2 lần ướng là 4 giờ', N'Mẫn cảm với bất cứ thành phần nào của thuốc
Suy gan nặng', N'Không uống khi đói', N'Hiếm: Dị ứng, ngứa', N'(khi sử dụng chung với những thuốc sau đây, sẽ gây ảnh hưởng tác dụng của thuốc)

Rượu, các thuốc khác chứa paracetamol', N'Viên nén dài: 500 mg x 10 vỉ x 10 viên', NULL, 100, N'vỉ', N'12000', NULL, N'Kháng viêm giảm đau')
INSERT [dbo].[THUOC] ([IDTHUOC], [TENTHUOC], [THANHPHAN], [CHIDINH], [LIEUDUNG], [CHONGCHIDINH], [THANTRONG], [PHANUNGPHU], [TUONGTACTHUOC], [TRINHBAYDONGGOI], [NHASANXUAT], [SOLUONG], [DONVI], [GIABAN], [HINHANH], [LOAITHUOC]) VALUES (2, N'PARACETAMOL 500mg', N'Paracetamol			500,0 mg
Tá dược 				vừa đủ 1 viên
(Povidon, Natri laurylsulfat, Primelosa, bột talc, magnesi stearat)', N'Điều trị làm giảm các triệu chứng sốt, đau nhức như : nhức đầu, đau răng, đau nhức do cảm cúm, đau họng, đau sau khi tiêm ngừa hay nhổ răng, đau do hành kinh, đau do vận động.

Paracetamol là thuốc thay thế salicylat để giảm đau nhẹ và hạ sốt.', N'Dạng bào chế này dùng cho trẻ em cân nặng từ 13 – 50kg (từ 2 – 15 tuổi).
Liều Paracetamol hàng ngày tính theo cân nặng của trẻ, tuổi của trẻ chỉ để tham khảo hướng dẫn.
Nếu không biết cân nặng của trẻ, cần phải cân trẻ để tính liều lượng thích hợp nhất.', N'Trẻ em dưới 12 tuổi. Người có tiền sử nhạy cảm với paracetamol. Người bị suy gan. Người thiếu hụt glucose-6-phosphat dehydrogenase.', N'Ban da và các phản ứng dị ứng  khác thỉnh thoảng xảy ra.
Thông báo cho Bác sĩ những tác dụng không mong muốn gặp phải khi sử dụng thuốc.', N'Uống paracetamol dài ngày và liều cao có thể làm tăng tác dụng chống đông của coumarin và dẫn chất indandion.
Cần lưu ý khả năng gây hạ sốt nghiêm trọng ở người bệnh dùng đồng thời phenothiazin và liệu pháp hạ nhiệt.
Độc tính trên gan tăng đối với người nghiện rượu, bệnh nhân dùng thuốc chống co giật (phenytoin, barbiturat, carbamazepin) hay isoniazid.', N'Paracetamol hấp thu nhanh chóng và hoàn toàn qua đường tiêu hóa, nồng độ đỉnh trong huyết tương đạt trong vòng 30 - 60 phút sau khi uống thuốc với liều điều trị. Paracetamol phân bố nhanh và đồng đều trong phần lớn các mô của cơ thể. Khoảng 25% paracetamol trong máu gắn với protein huyết tương.Thời gian bán thải của paracetamol trong huyết tương là 1,5 - 3 giờ. Thuốc được đào thải qua nước tiểu.', N'Viên nang cứng.

Chai 100 viên; Chai 500 viên; Hộp 10 vỉ x 10 viên.', N'ACD       ', NULL, N'Vỉ', N'1000', N'ABC', N'Kháng viêm giảm đau')
INSERT [dbo].[THUOC] ([IDTHUOC], [TENTHUOC], [THANHPHAN], [CHIDINH], [LIEUDUNG], [CHONGCHIDINH], [THANTRONG], [PHANUNGPHU], [TUONGTACTHUOC], [TRINHBAYDONGGOI], [NHASANXUAT], [SOLUONG], [DONVI], [GIABAN], [HINHANH], [LOAITHUOC]) VALUES (3, N'Tatanol 500mg', N'Acetaminophen', N'Điều trị các cơn đau từ nhẹ đến trung bình do cảm cúm, nhức đầu, đau họng, đau nhức cơ xương, đau do hành kinh, đau răng, đau nửa đầu
Hạ sốt trong sốt do thấp khớp, cảm cúm và các nhiễm trùng đường hô hấp trên khác', N'60 mg/kg/24 giờ.
Các lần uống cách nhau tối thiểu 4 giờ
Bệnh nhân suy thận nặng: các lần uống cách nhau tối thiểu 8 giờ.', N'Mẫn cảm với bất cứ thành phần nào của thuốc
Bệnh nhân thiếu hụt glucose-6-phosphat dehydrogenase
Bệnh nhân suy gan, suy thận nặng', N'Triệu chứng kéo dài > 10 ngày
Người già, trẻ em', N'Hiếm khi gặp dị ứng da', N'(khi sử dụng chung với những thuốc sau đây, sẽ gây ảnh hưởng tác dụng của thuốc)

Liều cao tăng hiệu quả thuốc kháng đông', N'Tatanol viên nén: 500 mg x 20 vỉ  x 10 viên
Tatanol: gói chứa bột uống:  80 mg x hộp 25 gói; 150 mg x hộp 25 gói; 250 mg x hộp 30 gói
Tatanol Trẻ em: viên nén: 120 mg x 10 vỉ x 10 viên; 10 vỉ x 20 viên
Tatanol Children viên nén: 325 mg x 10 vỉ x 10 viên
Tatanol Forte: Viên nén: 650 mg x 20 vỉ x 5 viên', N'VN        ', NULL, N'Vỉ', N'10000', N'Tatanol 500mg', N'Kháng viêm giảm đau')
SET IDENTITY_INSERT [dbo].[THUOC] OFF
USE [master]
GO
ALTER DATABASE [QUANGLYNHATHUOC] SET  READ_WRITE 
GO
