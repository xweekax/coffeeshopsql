USE [master]
GO
/****** Object:  Database [coffeeshop]    Script Date: 9/13/2020 6:15:34 PM ******/
CREATE DATABASE [coffeeshop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'coffeeshop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\coffeeshop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'coffeeshop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\coffeeshop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [coffeeshop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [coffeeshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [coffeeshop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [coffeeshop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [coffeeshop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [coffeeshop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [coffeeshop] SET ARITHABORT OFF 
GO
ALTER DATABASE [coffeeshop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [coffeeshop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [coffeeshop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [coffeeshop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [coffeeshop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [coffeeshop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [coffeeshop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [coffeeshop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [coffeeshop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [coffeeshop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [coffeeshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [coffeeshop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [coffeeshop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [coffeeshop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [coffeeshop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [coffeeshop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [coffeeshop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [coffeeshop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [coffeeshop] SET  MULTI_USER 
GO
ALTER DATABASE [coffeeshop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [coffeeshop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [coffeeshop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [coffeeshop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [coffeeshop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [coffeeshop] SET QUERY_STORE = OFF
GO
USE [coffeeshop]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 9/13/2020 6:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[description] [varchar](50) NULL,
	[price] [float] NULL,
	[category] [varchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (1, N'Coffee', N'Black Coffee', 2, N'Beverage')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (2, N'Water', N'Bottle of Water', 2, N'Beverage')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (3, N'Green Tea', N'Herbacious Green Tea', 3, N'Beverage')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (4, N'Black Tea', N'Bold Black Tea', 3, N'Beverage')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (5, N'Blueberry Muffin', N'Freshly Baked Muffin', 4, N'Food')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (6, N'Raisin Nut Muffin', N'A Muffin with Raisins and Nuts', 4, N'Food')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (7, N'Void Essence', N'You hear the calling to the void', 9, N'Other')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (8, N'Turkey Sandwich', N'Bread, Turkey, Lettuce, Tomato', 5, N'Food')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (9, N'Old Hat', N'Its an Old Fedora', 15, N'Other')
GO
INSERT [dbo].[Product] ([ID], [name], [description], [price], [category]) VALUES (10, N'Strange Key', N'Why is there a Key?', 100, N'Other')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
USE [master]
GO
ALTER DATABASE [coffeeshop] SET  READ_WRITE 
GO
