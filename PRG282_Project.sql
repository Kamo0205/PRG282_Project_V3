if Not(Exists (Select [name] From sys.databases Where [name] = 'MilitaryComDB'))
Begin
	Create Database [MilitaryComDB]
End
Go
use [MilitaryComDB]
GO
CREATE TABLE [tblRanks](
	[RankID] [bigint] IDENTITY PRIMARY KEY NOT NULL,
	[Title] [varchar](15) NOT NULL
)
Go
Insert Into [tblRanks]([Title])
Values('Low Soldier')
Insert Into [tblRanks]([Title])
Values('High Soldier')
Insert Into [tblRanks]([Title])
Values('Low Leutenent')
Insert Into [tblRanks]([Title])
Values('High Leutenent')
Insert Into [tblRanks]([Title])
Values('Low Officer')
Insert Into [tblRanks]([Title])
Values('High Officer')
Insert Into [tblRanks]([Title])
Values('Low Commander')
Insert Into [tblRanks]([Title])
Values('High Commander')
Go
CREATE TABLE [tblUsers](
	[IDNumber] [bigint] IDENTITY PRIMARY KEY NOT NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[Age] [int] NULL,
	[RankID] [bigint] NOT NULL FOREIGN KEY REFERENCES [tblRanks]([RankID]),
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL
)
Go
Insert Into [tblUsers]([Name],[Surname],[Age],[RankID],[Username],[Password])
Values('Admarh','Solin',0,8,'Admin','Tzuw|53')
Go
Create Table [tblMessages]
(
	[MessageID] [bigint] Identity Not Null Primary Key,
	[IDNumber] [bigint] Not Null Foreign Key References [tblUsers]([IDNumber]),
	[Content] [Nvarchar](100) Not Null,
	[Date] [Date] Not Null Default GETDATE()
)
Go
Create View [User Info] As
Select [tblUsers].[IDNumber], [tblUsers].[Name], [tblUsers].[Surname], [tblUsers].[Age], [tblUsers].[Username], [tblUsers].[Password], [tblRanks].[Title]
From [tblUsers]
Inner Join [tblRanks] On [tblRanks].[RankID] = [tblUsers].[RankID];
Go
Create View [Message Info] As
Select [tblUsers].[Name], [tblUsers].[Surname],[tblMessages].[Content]
From [tblUsers]
Inner Join [tblMessages] On [tblMessages].[IDNumber] = [tblUsers].[IDNumber]
Go
Create View [Login Info] As
Select [tblUsers].[Username], [tblUsers].[Password]
From [tblUsers]
Go
use master
Go