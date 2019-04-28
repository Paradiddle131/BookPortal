USE [master]
GO

/****** Object:  Database [BookPortalDB]    Script Date: 4/28/2019 10:06:28 PM ******/
CREATE DATABASE [BookPortalDB] ON  PRIMARY 
( NAME = N'BookPortalDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BookPortalDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BookPortalDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BookPortalDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookPortalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BookPortalDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BookPortalDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BookPortalDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BookPortalDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BookPortalDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [BookPortalDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BookPortalDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BookPortalDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BookPortalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BookPortalDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BookPortalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BookPortalDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BookPortalDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BookPortalDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BookPortalDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BookPortalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BookPortalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BookPortalDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BookPortalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BookPortalDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BookPortalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BookPortalDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BookPortalDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BookPortalDB] SET  MULTI_USER 
GO

ALTER DATABASE [BookPortalDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BookPortalDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BookPortalDB] SET  READ_WRITE 
GO


USE [BookPortalDB]
GO

/****** Object:  Table [dbo].[Review]    Script Date: 4/28/2019 10:05:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Review](
	[ReviewId] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nchar](50) NULL,
	[BookName] [nchar](50) NULL,
	[ReviewType] [nchar](50) NULL,
	[BookSubject] [nchar](50) NULL,
	[BookAnalysis] [nchar](999) NULL,
	[AuthorName] [nchar](50) NULL,
	[OtherBooks] [nchar](50) NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[ReviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [BookPortalDB]
GO

INSERT INTO [dbo].[Review]
           ([Category]
           ,[BookName]
           ,[ReviewType]
           ,[BookSubject]
           ,[BookAnalysis]
           ,[AuthorName]
           ,[OtherBooks])
     VALUES
           (<Category, nchar(50),>
           ,<BookName, nchar(50),>
           ,<ReviewType, nchar(50),>
           ,<BookSubject, nchar(50),>
           ,<BookAnalysis, nchar(999),>
           ,<AuthorName, nchar(50),>
           ,<OtherBooks, nchar(50),>)
GO


