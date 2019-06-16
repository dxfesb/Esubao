USE [master]
GO
/****** Object:  Database [EsuBao]    Script Date: 2019/6/16 18:58:58 ******/
CREATE DATABASE [EsuBao] ON  PRIMARY 
( NAME = N'EsuBao', FILENAME = N'D:\毕业设计\EsuBao.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EsuBao_log', FILENAME = N'D:\毕业设计\EsuBao_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EsuBao].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EsuBao] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EsuBao] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EsuBao] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EsuBao] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EsuBao] SET ARITHABORT OFF 
GO
ALTER DATABASE [EsuBao] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EsuBao] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EsuBao] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EsuBao] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EsuBao] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EsuBao] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EsuBao] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EsuBao] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EsuBao] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EsuBao] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EsuBao] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EsuBao] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EsuBao] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EsuBao] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EsuBao] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EsuBao] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EsuBao] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EsuBao] SET RECOVERY FULL 
GO
ALTER DATABASE [EsuBao] SET  MULTI_USER 
GO
ALTER DATABASE [EsuBao] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EsuBao] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EsuBao', N'ON'
GO
USE [EsuBao]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Company_ID] [int] NOT NULL,
	[Company_Name] [nvarchar](50) NULL,
	[Contact_information] [nvarchar](50) NULL,
	[Range] [nvarchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Company_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fahuo]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fahuo](
	[Express_number] [nvarchar](250) NOT NULL,
	[OOnsignor] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Shipping_outlets] [varchar](50) NULL,
	[Dot_information] [varchar](50) NULL,
	[Corporate_name] [varchar](50) NULL,
	[Delivery_Express] [int] NULL,
 CONSTRAINT [PK_Fahuo] PRIMARY KEY CLUSTERED 
(
	[Express_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[order]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[order](
	[Express_number] [nvarchar](50) NOT NULL,
	[OOnsignor] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Shipping_outtlets] [varchar](50) NULL,
	[Dot_information] [varchar](50) NULL,
	[Corporate_name] [varchar](50) NULL,
	[Delivery_Express] [int] NULL,
 CONSTRAINT [PK_PiLiangXiaDan] PRIMARY KEY CLUSTERED 
(
	[Express_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shouhuo]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shouhuo](
	[Express_number] [nvarchar](50) NOT NULL,
	[Consignoee] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[Corporate_name] [varchar](50) NULL,
	[Receiving_address] [varchar](50) NULL,
	[city_adddress] [varchar](50) NULL,
	[xian_address] [varchar](50) NULL,
	[address] [varchar](50) NULL,
 CONSTRAINT [PK_Shouhuo] PRIMARY KEY CLUSTERED 
(
	[Express_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_AdminUser]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_AdminUser](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [nvarchar](50) NULL,
	[AdminPwd] [nvarchar](50) NULL,
 CONSTRAINT [PK_T_AdminUser] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_expreMiss]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_expreMiss](
	[ExpreMissID] [int] IDENTITY(1,1) NOT NULL,
	[Express_number] [nvarchar](50) NOT NULL,
	[Express_status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_expreMiss] PRIMARY KEY CLUSTERED 
(
	[ExpreMissID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Refund]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Refund](
	[Refund_id] [int] IDENTITY(1,1) NOT NULL,
	[Express_number] [nvarchar](50) NOT NULL,
	[Refund_status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_Refund] PRIMARY KEY CLUSTERED 
(
	[Refund_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_replay]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_replay](
	[Replay_id] [int] IDENTITY(1,1) NOT NULL,
	[Replay_mess] [nvarchar](max) NOT NULL,
	[advice_id] [int] NOT NULL,
	[Replay_date] [date] NOT NULL,
	[Replay_zt] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_replay] PRIMARY KEY CLUSTERED 
(
	[Replay_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tousu]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tousu](
	[Tousu_id] [int] IDENTITY(1,1) NOT NULL,
	[Tousu_title] [varchar](50) NULL,
	[Tousu_name] [varchar](50) NULL,
	[role] [varchar](50) NULL,
	[Contact_number] [varchar](50) NULL,
	[Waybill_No] [varchar](50) NULL,
	[Tousu_Message] [varchar](max) NULL,
	[Tousu_Date] [date] NOT NULL,
 CONSTRAINT [PK_Tousu] PRIMARY KEY CLUSTERED 
(
	[Tousu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[transportation]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transportation](
	[id] [int] NOT NULL,
	[Type_shipping] [varchar](50) NULL,
	[Durationf_transportation] [varchar](50) NULL,
	[Starting_price] [varchar](50) NULL,
	[Heavy_cargo] [varchar](50) NULL,
	[Light _goods] [varchar](50) NULL,
 CONSTRAINT [PK_Table_2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[User_Id] [int] IDENTITY(1,1) NOT NULL,
	[User_uaername] [nvarchar](50) NULL,
	[User_password] [nvarchar](50) NULL,
	[User_Name] [nvarchar](50) NULL,
	[User_Sex] [nvarchar](50) NULL,
	[User_Company] [nvarchar](50) NULL,
	[User_fixedphone] [nvarchar](50) NULL,
	[User_Phone] [nvarchar](50) NULL,
	[User_Email] [nvarchar](50) NULL,
	[User_city] [nvarchar](50) NULL,
	[User_note] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ZiXunJianYi]    Script Date: 2019/6/16 18:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZiXunJianYi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[Message_type] [varchar](50) NULL,
	[Message_person] [varchar](50) NULL,
	[Contact_number] [varchar](50) NULL,
	[Mail_box] [varchar](50) NULL,
	[Waybill_No] [varchar](50) NULL,
	[Message] [varchar](max) NULL,
	[MessDate] [date] NOT NULL,
 CONSTRAINT [PK_ZiXunJianYi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_AdminUser] ON 

INSERT [dbo].[T_AdminUser] ([AdminID], [AdminName], [AdminPwd]) VALUES (1, N'张三', N'123456')
INSERT [dbo].[T_AdminUser] ([AdminID], [AdminName], [AdminPwd]) VALUES (2, N'毛涛', N'123456')
INSERT [dbo].[T_AdminUser] ([AdminID], [AdminName], [AdminPwd]) VALUES (3, N'祝涵雪', N'123456')
INSERT [dbo].[T_AdminUser] ([AdminID], [AdminName], [AdminPwd]) VALUES (4, N'罗文杰', N'123456')
INSERT [dbo].[T_AdminUser] ([AdminID], [AdminName], [AdminPwd]) VALUES (5, N'戴小芳', N'123456')
SET IDENTITY_INSERT [dbo].[T_AdminUser] OFF
SET IDENTITY_INSERT [dbo].[Tousu] ON 

INSERT [dbo].[Tousu] ([Tousu_id], [Tousu_title], [Tousu_name], [role], [Contact_number], [Waybill_No], [Tousu_Message], [Tousu_Date]) VALUES (1, N'投诉你家物流', N'张三', N'收货人', N'123333333', N'3333333333', N'32323', CAST(N'2019-06-16' AS Date))
SET IDENTITY_INSERT [dbo].[Tousu] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([User_Id], [User_uaername], [User_password], [User_Name], [User_Sex], [User_Company], [User_fixedphone], [User_Phone], [User_Email], [User_city], [User_note]) VALUES (1, N'张三', N'123456', N'张三', N'男', N'深圳有限公司', N'122222', N'222222', N'28989@qq.com', N'深圳', N'不可用')
INSERT [dbo].[User] ([User_Id], [User_uaername], [User_password], [User_Name], [User_Sex], [User_Company], [User_fixedphone], [User_Phone], [User_Email], [User_city], [User_note]) VALUES (2, N'李四', N'123456', N'张三', N'男', N'深圳有限公司', N'122222', N'222222', N'28989@qq.com', N'深圳', N'可用')
INSERT [dbo].[User] ([User_Id], [User_uaername], [User_password], [User_Name], [User_Sex], [User_Company], [User_fixedphone], [User_Phone], [User_Email], [User_city], [User_note]) VALUES (3, N'戴小芳', N'123456', N'张三', N'男', N'深圳有限公司', N'122222', N'222222', N'28989@qq.com', N'深圳', N'不可用')
INSERT [dbo].[User] ([User_Id], [User_uaername], [User_password], [User_Name], [User_Sex], [User_Company], [User_fixedphone], [User_Phone], [User_Email], [User_city], [User_note]) VALUES (4, N'祝涵雪', N'123456', N'张三', N'男', N'深圳有限公司', N'122222', N'222222', N'28989@qq.com', N'深圳', N'不可用')
INSERT [dbo].[User] ([User_Id], [User_uaername], [User_password], [User_Name], [User_Sex], [User_Company], [User_fixedphone], [User_Phone], [User_Email], [User_city], [User_note]) VALUES (5, N'罗文杰', N'123456', N'张三', N'男', N'深圳有限公司', N'122222', N'222222', N'28989@qq.com', N'深圳', N'可用')
INSERT [dbo].[User] ([User_Id], [User_uaername], [User_password], [User_Name], [User_Sex], [User_Company], [User_fixedphone], [User_Phone], [User_Email], [User_city], [User_note]) VALUES (6, N'毛涛', N'123456', N'张三', N'男', N'深圳有限公司', N'122222', N'222222', N'28989@qq.com', N'深圳', N'不可用')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[ZiXunJianYi] ON 

INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (13, N'质量不好', N'建议', N'张三', N'1233444555', N'293939@qq.com', N'2333333', N'质量不太好又', CAST(N'2019-06-06' AS Date))
INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (18, N'质量不好', N'建议', N'张三', N'1233444555', N'293939@qq.com', N'2333333', N'质量不太好又', CAST(N'2019-06-06' AS Date))
INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (20, N'质量不好', N'建议', N'张三', N'1233444555', N'293939@qq.com', N'2333333', N'质量不太好又', CAST(N'2019-06-06' AS Date))
INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (21, N'质量不好', N'建议', N'张三', N'1233444555', N'293939@qq.com', N'2333333', N'质量不太好又', CAST(N'2019-06-06' AS Date))
INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (22, N'我很喜欢这个东西，态度很好，物流很快', N'建议', N'李四', N'12323222332', N'382838@qq.com', N'2323232323', N'好的呢', CAST(N'2019-06-16' AS Date))
INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (24, N'质量不好', N'建议', N'张三', N'1233444555', N'293939@qq.com', N'2333333', N'质量不太好又', CAST(N'2019-06-06' AS Date))
INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (25, N'质量不好', N'建议', N'张三', N'1233444555', N'293939@qq.com', N'2333333', N'质量不太好又', CAST(N'2019-06-06' AS Date))
INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (26, N'质量不好', N'建议', N'张三', N'1233444555', N'293939@qq.com', N'2333333', N'质量不太好又', CAST(N'2019-06-06' AS Date))
INSERT [dbo].[ZiXunJianYi] ([Id], [title], [Message_type], [Message_person], [Contact_number], [Mail_box], [Waybill_No], [Message], [MessDate]) VALUES (27, N'我很喜欢这个东西，态度很好，物流很快', N'建议', N'李四', N'12323222332', N'382838@qq.com', N'2323232323', N'好的呢', CAST(N'2019-06-16' AS Date))
SET IDENTITY_INSERT [dbo].[ZiXunJianYi] OFF
ALTER TABLE [dbo].[Fahuo]  WITH CHECK ADD  CONSTRAINT [FK_quick_order_Table_2] FOREIGN KEY([Delivery_Express])
REFERENCES [dbo].[transportation] ([id])
GO
ALTER TABLE [dbo].[Fahuo] CHECK CONSTRAINT [FK_quick_order_Table_2]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_PiLiangXiaDan_transportation] FOREIGN KEY([Delivery_Express])
REFERENCES [dbo].[transportation] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_PiLiangXiaDan_transportation]
GO
ALTER TABLE [dbo].[T_expreMiss]  WITH CHECK ADD  CONSTRAINT [FK_T_expreMiss_PiLiangXiaDan] FOREIGN KEY([Express_number])
REFERENCES [dbo].[order] ([Express_number])
GO
ALTER TABLE [dbo].[T_expreMiss] CHECK CONSTRAINT [FK_T_expreMiss_PiLiangXiaDan]
GO
ALTER TABLE [dbo].[T_Refund]  WITH CHECK ADD  CONSTRAINT [FK_T_Refund_PiLiangXiaDan] FOREIGN KEY([Express_number])
REFERENCES [dbo].[order] ([Express_number])
GO
ALTER TABLE [dbo].[T_Refund] CHECK CONSTRAINT [FK_T_Refund_PiLiangXiaDan]
GO
ALTER TABLE [dbo].[T_replay]  WITH CHECK ADD  CONSTRAINT [FK_T_replay_ZiXunJianYi] FOREIGN KEY([advice_id])
REFERENCES [dbo].[ZiXunJianYi] ([Id])
GO
ALTER TABLE [dbo].[T_replay] CHECK CONSTRAINT [FK_T_replay_ZiXunJianYi]
GO
USE [master]
GO
ALTER DATABASE [EsuBao] SET  READ_WRITE 
GO
