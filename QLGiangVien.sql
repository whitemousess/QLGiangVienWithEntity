USE [QLGiangVien]
GO
/****** Object:  Table [dbo].[diemsv]    Script Date: 5/23/2023 1:23:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diemsv](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[masv] [nvarchar](50) NOT NULL,
	[mamon] [nvarchar](50) NOT NULL,
	[diemthi] [nvarchar](10) NOT NULL,
	[diemquatrinh] [nvarchar](10) NOT NULL,
	[diemtrungbinh] [nvarchar](10) NOT NULL,
	[trangthai] [nvarchar](4) NULL,
 CONSTRAINT [PK_diemsv] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[feedback]    Script Date: 5/23/2023 1:23:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[feedback](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_feedback] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GV]    Script Date: 5/23/2023 1:23:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GV](
	[magv] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](max) NOT NULL,
	[sdt] [nvarchar](11) NULL,
	[ghichu] [nvarchar](255) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[diachi] [nvarchar](50) NULL,
	[hinhanh] [image] NULL,
 CONSTRAINT [PK_GV] PRIMARY KEY CLUSTERED 
(
	[magv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 5/23/2023 1:23:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[maKhoa] [nvarchar](50) NOT NULL,
	[tenKhoa] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lop]    Script Date: 5/23/2023 1:23:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lop](
	[Malop] [nvarchar](50) NOT NULL,
	[Tenlop] [nvarchar](50) NOT NULL,
	[NienKhoa] [nvarchar](50) NOT NULL,
	[magv] [nvarchar](50) NOT NULL,
	[makhoa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__class__3313BBCD3D05FBA7] PRIMARY KEY CLUSTERED 
(
	[Malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monday]    Script Date: 5/23/2023 1:23:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monday](
	[mamon] [nvarchar](50) NOT NULL,
	[magv] [nvarchar](50) NOT NULL,
	[tenmon] [nvarchar](50) NULL,
	[trinhdo] [nvarchar](50) NULL,
 CONSTRAINT [PK__MONDAY__A2CD2A19DE912096] PRIMARY KEY CLUSTERED 
(
	[mamon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 5/23/2023 1:23:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[masv] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](255) NOT NULL,
	[gender] [nvarchar](3) NOT NULL,
	[dob] [datetime] NULL,
	[sdt] [nvarchar](11) NULL,
	[malop] [nvarchar](50) NULL,
	[address] [nchar](10) NULL,
	[anhthe] [image] NULL,
 CONSTRAINT [PK_sinhvien_1] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 5/23/2023 1:23:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[type] [nvarchar](1) NULL,
	[email] [char](255) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[diemsv]  WITH CHECK ADD  CONSTRAINT [FK_diemsv_monday] FOREIGN KEY([mamon])
REFERENCES [dbo].[monday] ([mamon])
GO
ALTER TABLE [dbo].[diemsv] CHECK CONSTRAINT [FK_diemsv_monday]
GO
ALTER TABLE [dbo].[diemsv]  WITH CHECK ADD  CONSTRAINT [FK_diemsv_sinhvien] FOREIGN KEY([masv])
REFERENCES [dbo].[sinhvien] ([masv])
GO
ALTER TABLE [dbo].[diemsv] CHECK CONSTRAINT [FK_diemsv_sinhvien]
GO
ALTER TABLE [dbo].[feedback]  WITH CHECK ADD  CONSTRAINT [FK_feedback_user] FOREIGN KEY([username])
REFERENCES [dbo].[user] ([username])
GO
ALTER TABLE [dbo].[feedback] CHECK CONSTRAINT [FK_feedback_user]
GO
ALTER TABLE [dbo].[lop]  WITH CHECK ADD  CONSTRAINT [FK_class_GV] FOREIGN KEY([magv])
REFERENCES [dbo].[GV] ([magv])
GO
ALTER TABLE [dbo].[lop] CHECK CONSTRAINT [FK_class_GV]
GO
ALTER TABLE [dbo].[lop]  WITH CHECK ADD  CONSTRAINT [FK_class_Khoa] FOREIGN KEY([makhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[lop] CHECK CONSTRAINT [FK_class_Khoa]
GO
ALTER TABLE [dbo].[monday]  WITH CHECK ADD  CONSTRAINT [FK_monday_GV1] FOREIGN KEY([magv])
REFERENCES [dbo].[GV] ([magv])
GO
ALTER TABLE [dbo].[monday] CHECK CONSTRAINT [FK_monday_GV1]
GO
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_sinhvien_class] FOREIGN KEY([malop])
REFERENCES [dbo].[lop] ([Malop])
GO
ALTER TABLE [dbo].[sinhvien] CHECK CONSTRAINT [FK_sinhvien_class]
GO
