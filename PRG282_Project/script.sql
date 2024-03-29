USE [master]
GO
/****** Object:  Database [MilitaryComDB]    Script Date: 2019/10/23 8:48:00 PM ******/
DROP DATABASE [MilitaryComDB]
GO

CREATE DATABASE [MilitaryComDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MilitaryComDB', FILENAME = N'c:\Users\MilitaryComDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MilitaryComDB_log', FILENAME = N'c:\Users\MilitaryComDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MilitaryComDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MilitaryComDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MilitaryComDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MilitaryComDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MilitaryComDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MilitaryComDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MilitaryComDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MilitaryComDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MilitaryComDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MilitaryComDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MilitaryComDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MilitaryComDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MilitaryComDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MilitaryComDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MilitaryComDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MilitaryComDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MilitaryComDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MilitaryComDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MilitaryComDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MilitaryComDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MilitaryComDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MilitaryComDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MilitaryComDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MilitaryComDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MilitaryComDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MilitaryComDB] SET  MULTI_USER 
GO
ALTER DATABASE [MilitaryComDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MilitaryComDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MilitaryComDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MilitaryComDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MilitaryComDB]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2019/10/23 8:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[Name] [varchar](50) NULL,
	[DOB] [date] NULL,
	[Email] [nvarchar](150) NULL,
	[MobileNo] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Users]    Script Date: 2019/10/23 8:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblRank](
	[RankID] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Title] [varchar](50) NULL
) ON [PRIMARY]

GO
CREATE TABLE [dbo].[tbl_Users](
	[IDNumber] [bigint] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[Age] [int] NULL,
	[RankID] [int] NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]

ALTER TABLE tbl_Users
ADD FOREIGN KEY(RankID) REFERENCES tblRank(RankID)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblRank]    Script Date: 2019/10/23 8:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO


GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [MilitaryComDB] SET  READ_WRITE 
GO


USE [MilitaryComDB]
GO
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('James','Dean',27,8,'JDean','JD123')
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('Thato','Ndlovu',34,7,'TNdlovu','TN123')
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('Karren','Du Plessis',23,9,'KDUPlessis','KDP123')
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('Melissa','Paddington',41,3,'MPaddington','MP123')
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('Bongani','Ndimande',48,2,'BNdimande','BN123')
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('Sphesihle','Ntuli',50,1,'SNtuli','SN123')
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('Zinhle','Mbatha',37,4,'ZMbatha','ZM123')
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('Kyle','Pillay',40,5,'KPillay','KP123')
INSERT INTO tbl_Users(Name,Surname,Age,RankID,Username,[Password])
VALUES('Shria','Moodley',45,6,'SMoodley','SM123')

INSERT INTO tblRank(Title)
VALUES('Admiral')
INSERT INTO tblRank(Title)
VALUES('Captain')
INSERT INTO tblRank(Title)
VALUES('Commander')
INSERT INTO tblRank(Title)
VALUES('Lietenant')
INSERT INTO tblRank(Title)
VALUES('Warrent Officer')
INSERT INTO tblRank(Title)
VALUES('Petty Officer')
INSERT INTO tblRank(Title)
VALUES('Sergeant')
INSERT INTO tblRank(Title)
VALUES('Corporal')
INSERT INTO tblRank(Title)
VALUES('Private')