USE [master]
GO
/****** Object:  Database [GetirDepo]    Script Date: 1.06.2022 11:16:27 ******/
CREATE DATABASE [GetirDepo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GetirDepo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GetirDepo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GetirDepo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GetirDepo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GetirDepo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GetirDepo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GetirDepo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GetirDepo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GetirDepo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GetirDepo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GetirDepo] SET ARITHABORT OFF 
GO
ALTER DATABASE [GetirDepo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GetirDepo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GetirDepo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GetirDepo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GetirDepo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GetirDepo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GetirDepo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GetirDepo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GetirDepo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GetirDepo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GetirDepo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GetirDepo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GetirDepo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GetirDepo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GetirDepo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GetirDepo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GetirDepo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GetirDepo] SET RECOVERY FULL 
GO
ALTER DATABASE [GetirDepo] SET  MULTI_USER 
GO
ALTER DATABASE [GetirDepo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GetirDepo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GetirDepo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GetirDepo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GetirDepo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GetirDepo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GetirDepo', N'ON'
GO
ALTER DATABASE [GetirDepo] SET QUERY_STORE = OFF
GO
USE [GetirDepo]
GO
/****** Object:  Table [dbo].[tblGuncelSiparis]    Script Date: 1.06.2022 11:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGuncelSiparis](
	[sID] [smallint] IDENTITY(1,1) NOT NULL,
	[SiparisDetay] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblIptalSiparis]    Script Date: 1.06.2022 11:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIptalSiparis](
	[iptalID] [smallint] IDENTITY(1,1) NOT NULL,
	[SiparisVeren] [nvarchar](50) NULL,
	[SiparisAdres] [nvarchar](100) NULL,
	[SiparisDetay] [nvarchar](500) NULL,
	[SiparisTarih] [nvarchar](50) NULL,
	[TelefonNo] [char](15) NULL,
	[iptalNedeni] [nvarchar](200) NULL,
	[KuryeAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblIptalSiparis] PRIMARY KEY CLUSTERED 
(
	[iptalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 1.06.2022 11:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin](
	[kId] [smallint] IDENTITY(1,1) NOT NULL,
	[LUser] [nvarchar](50) NOT NULL,
	[LPassword] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tblLogin] PRIMARY KEY CLUSTERED 
(
	[kId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblsiparisDetay]    Script Date: 1.06.2022 11:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblsiparisDetay](
	[SiparisId] [smallint] IDENTITY(1,1) NOT NULL,
	[SiparisVeren] [nvarchar](50) NULL,
	[SiparisAdres] [nvarchar](100) NULL,
	[SiparisDetay] [nvarchar](500) NULL,
	[SiparisTarih] [nvarchar](50) NULL,
	[TelefonNo] [char](15) NULL,
	[KuryeAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblsiparisDetay] PRIMARY KEY CLUSTERED 
(
	[SiparisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUrunler]    Script Date: 1.06.2022 11:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUrunler](
	[uID] [smallint] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [varchar](50) NULL,
	[UrunGramaj] [nvarchar](50) NULL,
	[UrunAdet] [smallint] NULL,
 CONSTRAINT [PK_tblUrunler] PRIMARY KEY CLUSTERED 
(
	[uID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblLogin] ON 

INSERT [dbo].[tblLogin] ([kId], [LUser], [LPassword]) VALUES (5, N'yunus emre', N'03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4')
SET IDENTITY_INSERT [dbo].[tblLogin] OFF
GO
SET IDENTITY_INSERT [dbo].[tblsiparisDetay] ON 

INSERT [dbo].[tblsiparisDetay] ([SiparisId], [SiparisVeren], [SiparisAdres], [SiparisDetay], [SiparisTarih], [TelefonNo], [KuryeAdi]) VALUES (105, N'yunus emre', N'cumhuriyet mah. 147. sok', N'salatalık, su', N'1.06.2022 10:59:26', N'(234) 432-4244 ', N'Emrah Temizkan')
INSERT [dbo].[tblsiparisDetay] ([SiparisId], [SiparisVeren], [SiparisAdres], [SiparisDetay], [SiparisTarih], [TelefonNo], [KuryeAdi]) VALUES (106, N'ertert', N'ertet', N'dferer', N'1.06.2022 11:00:26', N'(324) 242-5235 ', N'Yusuf Gülşahin')
SET IDENTITY_INSERT [dbo].[tblsiparisDetay] OFF
GO
SET IDENTITY_INSERT [dbo].[tblUrunler] ON 

INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (1, N'Ekmek', N'200', 45)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (2, N'Simit', N'50', 65)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (3, N'Poğaça', N'30', 89)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (4, N'Peynir', N'100', 75)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (5, N'Zeytin', N'30', 148)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (6, N'Domates', N'500', 98)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (7, N'Salatalık', N'500', 125)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (8, N'Muz', N'500', 175)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (9, N'Çilek', N'500', 126)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (10, N'Elma', N'500', 114)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (11, N'Patates', N'1000', 125)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (13, N'Su', N'3', 123)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (14, N'Deodorant', N'100', 140)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (15, N'Parfüm', N'200', 137)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (16, N'Kola', N'300', 129)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (17, N'Soda', N'200', 200)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (18, N'Pepsi', N'1000', 220)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (19, N'Biskrem', N'80', 250)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (20, N'Hanımeller', N'80', 280)
INSERT [dbo].[tblUrunler] ([uID], [UrunAdi], [UrunGramaj], [UrunAdet]) VALUES (21, N'Çikolata', N'50', 126)
SET IDENTITY_INSERT [dbo].[tblUrunler] OFF
GO
USE [master]
GO
ALTER DATABASE [GetirDepo] SET  READ_WRITE 
GO
