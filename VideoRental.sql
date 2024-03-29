USE [master]
GO
/****** Object:  Database [VideoRental]    Script Date: 14/12/2019 12:58:09 AM ******/
CREATE DATABASE [VideoRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoRental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VideoRental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoRental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VideoRental] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoRental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoRental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoRental] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoRental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoRental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoRental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoRental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoRental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoRental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoRental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoRental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoRental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoRental] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoRental] SET  MULTI_USER 
GO
ALTER DATABASE [VideoRental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoRental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoRental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoRental] SET QUERY_STORE = OFF
GO
USE [VideoRental]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 14/12/2019 12:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NULL,
	[CustomerAddress] [varchar](50) NULL,
	[CustomerContact] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 14/12/2019 12:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VideoID] [int] NULL,
	[CustomerID] [int] NULL,
	[RentalDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_Rental] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video]    Script Date: 14/12/2019 12:58:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[Ratting] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Copies] [int] NULL,
	[Cost] [int] NULL,
	[Plot] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([ID], [CustomerName], [CustomerAddress], [CustomerContact]) VALUES (1, N'Jong Li', N'Auckland', N'147852369')
INSERT [dbo].[Customer] ([ID], [CustomerName], [CustomerAddress], [CustomerContact]) VALUES (2, N'Pongi', N'Hamilton', N'258963147')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Rental] ON 

INSERT [dbo].[Rental] ([ID], [VideoID], [CustomerID], [RentalDate], [ReturnDate]) VALUES (1, 1, 1, N'14/12/2019', N'Rent')
INSERT [dbo].[Rental] ([ID], [VideoID], [CustomerID], [RentalDate], [ReturnDate]) VALUES (2, 2, 2, N'14/12/2019', N'Rent')
SET IDENTITY_INSERT [dbo].[Rental] OFF
SET IDENTITY_INSERT [dbo].[Video] ON 

INSERT [dbo].[Video] ([ID], [Title], [Ratting], [Year], [Copies], [Cost], [Plot], [Genre]) VALUES (1, N'Race', N'5', N'2016', 10, 5, N'Action', N'Action')
INSERT [dbo].[Video] ([ID], [Title], [Ratting], [Year], [Copies], [Cost], [Plot], [Genre]) VALUES (2, N'Deadpool', N'6.5', N'2016', 9, 5, N'Comedy', N'Comedy')
SET IDENTITY_INSERT [dbo].[Video] OFF
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [FK_Rental_Customer]
GO
ALTER TABLE [dbo].[Rental]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Video] FOREIGN KEY([VideoID])
REFERENCES [dbo].[Video] ([ID])
GO
ALTER TABLE [dbo].[Rental] CHECK CONSTRAINT [FK_Rental_Video]
GO
USE [master]
GO
ALTER DATABASE [VideoRental] SET  READ_WRITE 
GO
