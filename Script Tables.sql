USE [master]
GO
/****** Object:  Database [PTS]    Script Date: 12/21/2016 5:25:50 PM ******/
CREATE DATABASE [PTS]
GO
ALTER DATABASE [PTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [PTS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PTS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PTS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PTS] SET  MULTI_USER 
GO
ALTER DATABASE [PTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PTS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [PTS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [PTS]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Name] [nvarchar](20) NOT NULL,
	[Number] [int] NOT NULL,
	[Mgr_SSN] [int] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Edges]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edges](
	[Source] [int] NOT NULL,
	[Destination] [int] NOT NULL,
	[Transportation_Code] [nchar](3) NOT NULL,
	[Transportation_ID] [int] NOT NULL,
	[Weight] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[E_SSN] [int] NOT NULL,
	[Job_Code] [nvarchar](10) NOT NULL,
	[Salary] [int] NOT NULL,
	[Dnumber] [int] NOT NULL,
	[Super_SSN] [int] NULL,
	[Start_Date] [date] NULL,
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[E_SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Human_basics]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Human_basics](
	[SSN] [int] NOT NULL,
	[FName] [nvarchar](10) NOT NULL,
	[LName] [nvarchar](10) NOT NULL,
	[Gender] [nchar](1) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[Birth_Date] [date] NOT NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[L_SSN] [int] NOT NULL,
	[Username] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[Priv] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Maintain]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maintain](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyCode] [int] NOT NULL,
	[TransCode] [nchar](3) NOT NULL,
	[TransID] [int] NOT NULL,
	[JobDone] [bit] NOT NULL,
	[Message] [text] NULL,
 CONSTRAINT [PK_Maintain] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Maintenance]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maintenance](
	[CompanyID] [int] NOT NULL,
	[CompanyName] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Maintenance] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Maps]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maps](
	[DistrictID] [int] NOT NULL,
	[DistrictName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Maps] PRIMARY KEY CLUSTERED 
(
	[DistrictID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Time] [time](7) NOT NULL,
	[Username] [nvarchar](20) NOT NULL,
	[Source] [int] NOT NULL,
	[Destination] [int] NOT NULL,
	[Amount_Due] [float] NOT NULL,
	[Rating] [int] NULL,
	[Suggestion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PTS_Users]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PTS_Users](
	[U_SSN] [int] NOT NULL,
	[IsDependent] [int] NOT NULL,
 CONSTRAINT [PK_User_1] PRIMARY KEY CLUSTERED 
(
	[U_SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transportation_Means]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transportation_Means](
	[TransCode] [nchar](3) NOT NULL,
	[TransID] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
	[A/C] [bit] NOT NULL,
	[Fare] [float] NOT NULL,
 CONSTRAINT [PK_Transportation_Means] PRIMARY KEY CLUSTERED 
(
	[TransCode] ASC,
	[TransID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Departments] ([Name], [Number], [Mgr_SSN]) VALUES (N'Admin', 0, NULL)
INSERT [dbo].[Departments] ([Name], [Number], [Mgr_SSN]) VALUES (N'Finance', 1, 303030303)
INSERT [dbo].[Departments] ([Name], [Number], [Mgr_SSN]) VALUES (N'HumanResources', 2, 707070707)
INSERT [dbo].[Departments] ([Name], [Number], [Mgr_SSN]) VALUES (N'PublicRelations', 3, NULL)
INSERT [dbo].[Departments] ([Name], [Number], [Mgr_SSN]) VALUES (N'Contact', 4, 777888999)
INSERT [dbo].[Departments] ([Name], [Number], [Mgr_SSN]) VALUES (N'CustomerServices', 5, NULL)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (1, 2, N'MET', 1, 50)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (3, 4, N'MET', 2, 10)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (4, 5, N'MET', 2, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (5, 6, N'MET', 2, 2)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (6, 7, N'MET', 2, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (7, 8, N'MET', 2, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (8, 9, N'MET', 2, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (10, 11, N'MET', 3, 7)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (11, 12, N'MET', 3, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (12, 13, N'MET', 3, 3)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (13, 14, N'MET', 3, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (14, 15, N'MET', 3, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (15, 7, N'MET', 3, 7)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (7, 16, N'MET', 3, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (16, 17, N'MET', 3, 3)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (17, 18, N'MET', 3, 1)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (18, 2, N'MET', 3, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (19, 14, N'MET', 4, 8)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (14, 20, N'MET', 4, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (20, 8, N'MET', 4, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (8, 21, N'MET', 4, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (21, 2, N'MET', 4, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (2, 22, N'MET', 4, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (22, 23, N'MET', 4, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (23, 24, N'MET', 4, 8)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (24, 25, N'MET', 4, 3)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (25, 26, N'MET', 4, 8)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (26, 27, N'MET', 4, 7)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (27, 28, N'MET', 4, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (28, 29, N'MET', 4, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (30, 11, N'MET', 5, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (11, 12, N'MET', 5, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (12, 14, N'MET', 5, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (14, 32, N'MET', 5, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (32, 33, N'MET', 5, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (33, 4, N'MET', 5, 16)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (4, 31, N'MET', 5, 3)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (31, 34, N'MET', 5, 2)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (34, 35, N'MET', 5, 2)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (35, 36, N'MET', 5, 2)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (36, 37, N'MET', 5, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (37, 39, N'MET', 5, 9)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (39, 40, N'MET', 5, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (40, 41, N'MET', 5, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (41, 42, N'MET', 5, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (42, 29, N'MET', 5, 7)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (2, 1, N'MET', 1, 50)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (4, 3, N'MET', 2, 10)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (5, 4, N'MET', 2, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (6, 5, N'MET', 2, 2)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (7, 6, N'MET', 2, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (8, 7, N'MET', 2, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (9, 8, N'MET', 2, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (11, 10, N'MET', 3, 7)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (12, 11, N'MET', 3, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (13, 12, N'MET', 3, 3)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (14, 13, N'MET', 3, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (15, 14, N'MET', 3, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (7, 15, N'MET', 3, 7)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (16, 7, N'MET', 3, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (17, 16, N'MET', 3, 3)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (18, 17, N'MET', 3, 1)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (2, 18, N'MET', 3, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (14, 19, N'MET', 4, 8)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (20, 14, N'MET', 4, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (8, 20, N'MET', 4, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (21, 8, N'MET', 4, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (2, 21, N'MET', 4, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (22, 2, N'MET', 4, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (23, 22, N'MET', 4, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (24, 23, N'MET', 4, 8)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (25, 24, N'MET', 4, 3)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (26, 25, N'MET', 4, 8)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (27, 26, N'MET', 4, 7)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (28, 27, N'MET', 4, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (29, 28, N'MET', 4, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (11, 30, N'MET', 5, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (12, 11, N'MET', 5, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (14, 12, N'MET', 5, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (32, 14, N'MET', 5, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (33, 32, N'MET', 5, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (4, 33, N'MET', 5, 16)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (31, 4, N'MET', 5, 3)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (34, 31, N'MET', 5, 2)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (35, 34, N'MET', 5, 2)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (36, 35, N'MET', 5, 2)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (37, 36, N'MET', 5, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (39, 37, N'MET', 5, 9)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (40, 39, N'MET', 5, 6)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (41, 40, N'MET', 5, 4)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (42, 41, N'MET', 5, 5)
INSERT [dbo].[Edges] ([Source], [Destination], [Transportation_Code], [Transportation_ID], [Weight]) VALUES (29, 42, N'MET', 5, 7)
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (127842724, N'CCE200', 1000, 3, 404040404, CAST(N'2016-12-19' AS Date), 1)
INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (303030303, N'EMP100', 5000, 1, NULL, CAST(N'2016-11-03' AS Date), 2)
INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (404040404, N'EMP600', 2000, 2, 707070707, CAST(N'2016-12-26' AS Date), 3)
INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (505050505, N'ADM302', 50000, 0, NULL, CAST(N'2013-01-30' AS Date), 4)
INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (606060606, N'CTO200', 4000, 4, 777888999, CAST(N'2013-01-21' AS Date), 5)
INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (707070707, N'EMP203', 30000, 2, NULL, CAST(N'2014-06-27' AS Date), 6)
INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (777888999, N'CTO100', 15000, 4, NULL, CAST(N'2016-01-01' AS Date), 7)
INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (909090801, N'EMP102', 3000, 1, 303030303, CAST(N'2014-12-23' AS Date), 8)
INSERT [dbo].[Employee] ([E_SSN], [Job_Code], [Salary], [Dnumber], [Super_SSN], [Start_Date], [EmployeeID]) VALUES (999555999, N'EMP909', 20000, 3, NULL, CAST(N'2016-12-21' AS Date), 9)
SET IDENTITY_INSERT [dbo].[Employee] OFF
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (3533553, N'ahmed', N'ahmed', N'M', N'ahmed@gmail.com', CAST(N'2016-12-19' AS Date), N'ahmed')
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (111222333, N'Omar', N'Shaalan', N'M', N'She3lo@hotmail.com', CAST(N'1967-12-26' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (123456789, N'Karim', N'Rashidy', N'M', N'kimo@hotmail.com', CAST(N'1980-07-27' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (127842724, N'Rana', N'Shaalan', N'F', N'ahmed@live.com', CAST(N'2016-12-19' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (303030303, N'Youssef', N'Maraghy', N'M', N'Maraghy@gmail.com', CAST(N'1975-07-08' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (404040404, N'Sherif', N'Nashaat', N'M', N'Mohandseen@gmail', CAST(N'1981-11-03' AS Date), N'Mohandseen')
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (444555666, N'May', N'Abdeldayem', N'F', N'May.Ahmed1@hotmail.com', CAST(N'1985-12-23' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (505050505, N'Iman', N'Fouad', N'F', N'Okaaay@gmail', CAST(N'1970-01-01' AS Date), N'Sharabeaya')
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (606060606, N'Noura', N'Shebl', N'F', N'Nonna@gmail.com', CAST(N'1979-05-09' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (707070707, N'Nada', N'Hesham', N'F', N'Nedned@gmail.com', CAST(N'1960-05-02' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (777888999, N'Mahmoud', N'Ahmed', N'M', N'Mhmoud@hotmail.com', CAST(N'1973-12-12' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (909090801, N'Seif', N'Wael', N'M', N'Seifwael@gmail.com', CAST(N'1976-02-04' AS Date), NULL)
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (987654321, N'Ahmed', N'Khairy', N'M', N'AhmedKatkout@gmail.com', CAST(N'1983-11-03' AS Date), N'Mohandseen')
INSERT [dbo].[Human_basics] ([SSN], [FName], [LName], [Gender], [Email], [Birth_Date], [Address]) VALUES (999555999, N'Ahmed', N'Katkout', N'M', N'Katakeeto@gmail.com', CAST(N'1996-12-23' AS Date), NULL)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (3533553, N'ahmed', N'ahmed', 3)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (303030303, N'YoussefMaraghy', N'johncena', 2)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (404040404, N'SherifNashaat', N'johncena', 2)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (505050505, N'ImanFoad', N'johncena', 1)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (606060606, N'NouraShebl', N'johncena', 2)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (707070707, N'NadaHesham', N'johncena', 2)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (777888999, N'MahmoudAhmed', N'johncena', 2)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (999555999, N'AhmedKatkout9', N'EMP909', 3)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (909090801, N'SeifWael', N'johncena', 2)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (111222333, N'OmarShaalan', N'johncena', 3)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (123456789, N'KarimRashidy', N'johncena', 3)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (444555666, N'MayAbdeldayem', N'johncena', 3)
INSERT [dbo].[Login] ([L_SSN], [Username], [Password], [Priv]) VALUES (987654321, N'AhmedKhairy', N'johncena', 3)
INSERT [dbo].[Maintenance] ([CompanyID], [CompanyName], [Address], [Phone], [Email], [Password]) VALUES (1, N'El Fouad', N'323, Fifth District, New Cairo', 35858234, N'ElFouad@gmail.com', N'1787420')
INSERT [dbo].[Maintenance] ([CompanyID], [CompanyName], [Address], [Phone], [Email], [Password]) VALUES (2, N'El Yasmin', N'405, Maadi, Cairo', 37807802, N'ElYasmin@gmail.com', N'mayooy')
INSERT [dbo].[Maintenance] ([CompanyID], [CompanyName], [Address], [Phone], [Email], [Password]) VALUES (3, N'El Mawardy', N'152, Manial, Giza', 24034589, N'ElMawardy@gmail.com', N'shaalan')
INSERT [dbo].[Maintenance] ([CompanyID], [CompanyName], [Address], [Phone], [Email], [Password]) VALUES (4, N'El Saudeya', N'302, Maryouteya, Giza', 35143234, N'ElSaudeya@gmail.com', N'kikoz')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (1, N'Bank')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (2, N'Waterloo')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (3, N'Highbury & Islington')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (4, N'King''s Cross St. Pancras')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (5, N'	Euston')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (6, N'Warren Street')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (7, N'Oxford Circus ')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (8, N'Green Park')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (9, N'Victoria')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (10, N'Warwick Avenue')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (11, N'Paddington')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (12, N'Edgware Road')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (13, N'Marylebone')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (14, N'Baker Street')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (15, N'Regent''s Park')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (16, N'Piccadilly Circus')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (17, N'Charing Cross')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (18, N'Embankment')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (19, N'St. John''s Wood')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (20, N'Bond Street')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (21, N'Westminster')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (22, N'Southwark')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (23, N'London Bridge')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (24, N'Bermondsey')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (25, N'Canada Water')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (26, N'Canary Whater')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (27, N'North Greenwich')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (28, N'Canning Town')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (29, N'West Ham')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (30, N'Royal Oak')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (31, N'Farringdon')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (32, N'Great Portland Street')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (33, N'Euston Square')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (34, N'Barbican')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (35, N'Moorgate')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (36, N'Liverpool Street')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (37, N'Aldgate East')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (38, N'St. Mary''s')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (39, N'Stepney Green')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (40, N'Mile End')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (41, N'Bow Road')
INSERT [dbo].[Maps] ([DistrictID], [DistrictName]) VALUES (42, N'Bromley-by-Bow')
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [Date], [Time], [Username], [Source], [Destination], [Amount_Due], [Rating], [Suggestion]) VALUES (1, CAST(N'2012-10-12' AS Date), CAST(N'09:35:00' AS Time), N'MayAbdeldaye', 2, 6, 2, 5, N'Nice Ride')
SET IDENTITY_INSERT [dbo].[Orders] OFF
INSERT [dbo].[PTS_Users] ([U_SSN], [IsDependent]) VALUES (646464, 0)
INSERT [dbo].[PTS_Users] ([U_SSN], [IsDependent]) VALUES (111222333, 0)
INSERT [dbo].[PTS_Users] ([U_SSN], [IsDependent]) VALUES (123456789, 0)
INSERT [dbo].[PTS_Users] ([U_SSN], [IsDependent]) VALUES (444555666, 0)
INSERT [dbo].[PTS_Users] ([U_SSN], [IsDependent]) VALUES (987654321, 0)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 1, 200, 0, 1)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 2, 250, 1, 1.5)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 3, 150, 0, 1)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 4, 180, 1, 2)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 5, 220, 1, 2)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 6, 150, 0, 0.75)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 8, 20, 0, 1.2)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 10, 70, 1, 2)
INSERT [dbo].[Transportation_Means] ([TransCode], [TransID], [Capacity], [A/C], [Fare]) VALUES (N'MET', 11, 80, 1, 3)
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailConstraint]    Script Date: 12/21/2016 5:25:51 PM ******/
ALTER TABLE [dbo].[Human_basics] ADD  CONSTRAINT [EmailConstraint] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailConstraint2]    Script Date: 12/21/2016 5:25:51 PM ******/
ALTER TABLE [dbo].[Maintenance] ADD  CONSTRAINT [EmailConstraint2] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PhoneConstraint]    Script Date: 12/21/2016 5:25:51 PM ******/
ALTER TABLE [dbo].[Maintenance] ADD  CONSTRAINT [PhoneConstraint] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Edges] ADD  CONSTRAINT [DF_Sheet1$_Transportation_Code]  DEFAULT (N'MET') FOR [Transportation_Code]
GO
ALTER TABLE [dbo].[Maintenance] ADD  CONSTRAINT [DF_Maintenance_Password]  DEFAULT (N'company') FOR [Password]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Employee] FOREIGN KEY([Mgr_SSN])
REFERENCES [dbo].[Employee] ([E_SSN])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Employee]
GO
ALTER TABLE [dbo].[Edges]  WITH CHECK ADD  CONSTRAINT [FK_Sheet1$_Maps] FOREIGN KEY([Source])
REFERENCES [dbo].[Maps] ([DistrictID])
GO
ALTER TABLE [dbo].[Edges] CHECK CONSTRAINT [FK_Sheet1$_Maps]
GO
ALTER TABLE [dbo].[Edges]  WITH CHECK ADD  CONSTRAINT [FK_Sheet1$_Maps1] FOREIGN KEY([Destination])
REFERENCES [dbo].[Maps] ([DistrictID])
GO
ALTER TABLE [dbo].[Edges] CHECK CONSTRAINT [FK_Sheet1$_Maps1]
GO
ALTER TABLE [dbo].[Edges]  WITH CHECK ADD  CONSTRAINT [FK_Sheet1$_Transportation_Means] FOREIGN KEY([Transportation_Code], [Transportation_ID])
REFERENCES [dbo].[Transportation_Means] ([TransCode], [TransID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Edges] CHECK CONSTRAINT [FK_Sheet1$_Transportation_Means]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Departments] FOREIGN KEY([Dnumber])
REFERENCES [dbo].[Departments] ([Number])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Departments]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Employee] FOREIGN KEY([Super_SSN])
REFERENCES [dbo].[Employee] ([E_SSN])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Employee]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Human_basics] FOREIGN KEY([L_SSN])
REFERENCES [dbo].[Human_basics] ([SSN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Human_basics]
GO
ALTER TABLE [dbo].[Maintain]  WITH CHECK ADD  CONSTRAINT [FK_Maintain_Maintain] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[Maintenance] ([CompanyID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Maintain] CHECK CONSTRAINT [FK_Maintain_Maintain]
GO
ALTER TABLE [dbo].[Maintain]  WITH CHECK ADD  CONSTRAINT [FK_Maintain_Transportation_Means] FOREIGN KEY([TransCode], [TransID])
REFERENCES [dbo].[Transportation_Means] ([TransCode], [TransID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Maintain] CHECK CONSTRAINT [FK_Maintain_Transportation_Means]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Dest] FOREIGN KEY([Destination])
REFERENCES [dbo].[Maps] ([DistrictID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Dest]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Source] FOREIGN KEY([Source])
REFERENCES [dbo].[Maps] ([DistrictID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Source]
GO
/****** Object:  StoredProcedure [dbo].[AllDistrict]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[AllDistrict] @ID int = NULL
AS 
Select * 
from Maps m 
where m.DistrictID = ISNULL(@ID,m.DistrictID)

GO
/****** Object:  StoredProcedure [dbo].[AllStatistics]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[AllStatistics] @Username nvarchar(15) = NULL -- @count int output , @Average float output 
As 
Select Count(*) as Tcount, Avg(Rating) as Average 
from Orders
where Username = ISNULL (@Username,Username)

GO
/****** Object:  StoredProcedure [dbo].[AvgSalary]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[AvgSalary] 
as
Select Avg(Salary) as Average ,Max(Salary) as Maximum ,Min(Salary) as Minimum
from Employee

GO
/****** Object:  StoredProcedure [dbo].[CompanyLoginIn]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[CompanyLoginIn] @CompanyName nvarchar(20), @Password nvarchar (50)
as 
	Select CompanyID
	from Maintenance
	where CompanyName = @CompanyName AND Password= @Password 

GO
/****** Object:  StoredProcedure [dbo].[CountEmployees]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Counts number of employees
Create PROCEDURE [dbo].[CountEmployees] @Gender varchar(1) = NULL 
AS
	Select Count(*) as TotalNumber
	from Employee E, Human_basics H
	where E.E_SSN = H.SSN AND H.Gender = ISNULL(@Gender,H.Gender)

GO
/****** Object:  StoredProcedure [dbo].[CountRating]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[CountRating] @Num int  --@count int output
AS
select count(*) as Tcount
from Orders
where Rating = @Num

GO
/****** Object:  StoredProcedure [dbo].[DeleteCompany]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteCompany] @CompanyID int
AS
Delete
FROM Maintenance
WHERE CompanyID=@CompanyID

GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[DeleteEmployee] @ESSN int 
AS
Update Departments
set Mgr_SSN=NULL
where Mgr_SSN=@ESSN

Delete 
FROM Human_basics
WHERE SSN=(Select E_SSN From Employee where E_SSN=@ESSN)

GO
/****** Object:  StoredProcedure [dbo].[DeleteTransporationMean]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteTransporationMean] @ID int
AS
Delete
FROM Transportation_Means
WHERE TransID=@ID

GO
/****** Object:  StoredProcedure [dbo].[Editinfo]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--GetEmployeeName For DeleteEmployee EmployeeName Combobox
Create PROCEDURE [dbo].[Editinfo] @Username nvarchar(20), @address nvarchar(50),@email nvarchar(30)
AS
Update Human_basics
SET Email=@email,Address=@address
Where SSN=(Select L_SSN from Login where Username=@Username)


GO
/****** Object:  StoredProcedure [dbo].[EmailAvaliable]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[EmailAvaliable] @Email nvarchar(30)
AS
	SELECT CASE WHEN EXISTS (
    SELECT *
    FROM Human_basics H
    WHERE H.Email = @Email
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT) END	
	

GO
/****** Object:  StoredProcedure [dbo].[EmploymentDate]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Counts employees employed before certain date, we might need to cast the input before sending it here 
CREATE Procedure [dbo].[EmploymentDate] @DateOfEmployment Date 
AS
	Select Count(*) as TotalNumber
	from Employee 
	where Start_Date >= @DateOfEmployment

GO
/****** Object:  StoredProcedure [dbo].[GetCompanyName]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCompanyName]
AS
SELECT CompanyName,CompanyID
FROM Maintenance

GO
/****** Object:  StoredProcedure [dbo].[GetDepartmentNames]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetDepartmentNames]
AS
Select Name,Number
From Departments


GO
/****** Object:  StoredProcedure [dbo].[GetDepartmentsByName]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[GetDepartmentsByName] 
AS
	Select * from Departments

GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeName]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--GetEmployeeName For DeleteEmployee EmployeeName Combobox
CREATE PROCEDURE [dbo].[GetEmployeeName]
AS
SELECT (Fname + '' + LName) as EmployeeName,E_SSN
FROM Employee,Human_basics
Where E_SSN=SSN

GO
/****** Object:  StoredProcedure [dbo].[GetMaintenanceInfo]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create procedure [dbo].[GetMaintenanceInfo]
AS
	Select * 
	from Maintenance 

GO
/****** Object:  StoredProcedure [dbo].[getSalaryJobCode]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[getSalaryJobCode] @EmpSSN INT=NULL
AS
SELECT Salary,Job_Code
FROM Employee E
WHERE E.E_SSN = ISNULL(@EmpSSN,E_SSN)


GO
/****** Object:  StoredProcedure [dbo].[GetSupervisorByName]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetSupervisorByName]
AS
	Select Distinct S.E_SSN , H.Fname , H.Lname
	from Employee E, Employee S, Human_Basics H
	where S.E_SSN=E.Super_SSN

GO
/****** Object:  StoredProcedure [dbo].[GetSupervisorNames]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetSupervisorNames]
AS
Select (FName + ' ' + LName) as SupervisorNames,E_SSN
From Employee,Human_basics
Where  Super_SSN=SSN
GO
/****** Object:  StoredProcedure [dbo].[GetTrans]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTrans] 
AS
SELECT (TransCode + ' ' +  Convert(VarChar(10),TransID))
FROM Transportation_Means

GO
/****** Object:  StoredProcedure [dbo].[InsertCompany]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[InsertCompany] @CompanyID int,@CompanyName nvarchar(20),@Address nvarchar(50),@Phone int,@Email nvarchar(50)
AS
Insert into Maintenance (CompanyID,CompanyName,Address,Phone,Email,Password) values (@CompanyID,@CompanyName,@Address,@Phone,@Email,@CompanyName+ Convert(VarChar(20),@CompanyID))


GO
/****** Object:  StoredProcedure [dbo].[InsertEdge]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertEdge] @Source int, @Destinantion int,@Transcode nchar(3),@TransID int,@weight int
AS
insert into Edges (Source,Destination,Transportation_Code,Transportation_ID,Weight) values (@Source,@Destinantion,@Transcode,@TransID,@weight)

GO
/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertEmployee] @E_SSN int,@Job_Code varchar(10),@Salary int,@Dnumber int,@Super_SSN int,@StartDate date,@FName varchar(10),@LName varchar(10),@Gender nchar(1),@Email varchar(30),@Birth_Date date
As
  
Insert Into Human_basics (SSN,FName,LName,Gender,Email,Birth_Date) values (@E_SSN,@FName,@LName,@Gender,@Email,@Birth_Date)
Insert Into Employee (E_SSN,Job_Code,Salary,Dnumber,Super_SSN,Start_Date) Values (@E_SSN,@Job_Code,@Salary,@Dnumber,@Super_SSN,@StartDate)
insert Into Login values (@E_SSN,@FName + @Lname + convert(VarChar(1),(Select EmployeeID from Employee where E_SSN=@E_SSN)),@Job_Code,3) 
GO
/****** Object:  StoredProcedure [dbo].[InsertTrans]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertTrans] @TransCode nchar(3) = MET, @TransID int,@Capacity int,@AC bit,@Fare Float
AS
insert into Transportation_Means(TransCode,TransID,Capacity,[A/C],Fare) values (@TransCode,@TransID,@Capacity,@AC,@Fare)

GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertUser] @Username nvarchar(20) , @Password nvarchar(50) ,@Address nvarchar(50), @Priv int , @SSN int, @Fname nvarchar(10) , @Lname nvarchar(10) , @Gender nchar(1),@Email nvarchar(30),@BDate date,@DependantSSN int,@DependentJobCode nvarchar(10), @IsDependent bit
as
	insert into Human_basics values (@SSN,@Fname,@Lname,@Gender,@Email,@Bdate,@Address);
	insert into Login values (@SSN,@Username,@Password,@Priv);


GO
/****** Object:  StoredProcedure [dbo].[InsertUserDep]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertUserDep] @U_SSN int,@IsDependent int
AS
BEGIN
insert into PTS_Users(U_SSN,IsDependent) values (@U_SSN,@IsDependent)
END




GO
/****** Object:  StoredProcedure [dbo].[MostVistedPlace]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[MostVistedPlace]
as
Select Max(DestCount) as MaxVisited,DistrictName
from (Select Count(*) as DestCount, Destination from Orders group by Destination) as DestCount, Maps D
where Destination = D.DistrictID
group by DistrictName

GO
/****** Object:  StoredProcedure [dbo].[PendingRequest]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[PendingRequest] @CompCode int 
AS
	Select *
	from Maintain
	where CompanyCode=@CompCode AND JobDone = 0

GO
/****** Object:  StoredProcedure [dbo].[RequestDone]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[RequestDone] @RequestID int
AS
	update Maintain
	Set JobDone=1
	Where RequestID = @RequestID

GO
/****** Object:  StoredProcedure [dbo].[SendRequest]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SendRequest]  @CompCode int , @TransCode nchar(3) , @TransID int , @JobDone bit , @Msg text = NULL
AS
	Insert into Maintain
	Values (@CompCode,@TransCode,@TransID,@JobDone,@Msg)

GO
/****** Object:  StoredProcedure [dbo].[StoreOrder]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[StoreOrder] @Username nvarchar(15) , @Source int , @Destination int, @Rate int, @Suggestion text,@CurDate Date, @CurTime Time, @Amount_Due int 
as
	insert into orders
	values (@CurDate,@CurTime,@Username,@Source,@Destination,@Amount_Due,@Rate,@Suggestion)

GO
/****** Object:  StoredProcedure [dbo].[TotalOrders]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Counting total orders, that can be used with date limits of total orders, we might need to reconsider the name of the col date
CREATE Procedure [dbo].[TotalOrders] @FirstDate Date = NULL , @SecondDate Date = NULL
AS
	Select Count(*) as CountOfOrders
	from Orders O
	where O.Date >= ISNULL(@FirstDate,O.Date) AND O.Date <= ISNULL(@SecondDate,O.Date)   

GO
/****** Object:  StoredProcedure [dbo].[UpdateCompany]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCompany] @Address nvarchar(50)=NULL,@CompanyName nvarchar(20)=NULL,@Phone int=NULL,@CompanyID int=NULL,@Email nvarchar(50)=NULL
AS

UPDATE Maintenance 


SET CompanyName=@CompanyName,Phone=@Phone,Address=@Address,Email=@Email
WHERE CompanyID=ISNULL(@CompanyID,CompanyID)

GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UpdateEmployee] @EmpSSN INT=NULL,@EmpSalary INT=NULL,@EmpJC VARCHAR(10)=NULL
AS

UPDATE Employee 


SET Salary=@EmpSalary,Job_Code=@EmpJC
WHERE E_SSN=ISNULL(@EmpSSN,E_SSN)

GO
/****** Object:  StoredProcedure [dbo].[UpdateTransportationMean]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[UpdateTransportationMean] @TransCode nchar(3),@TransID int,@Capacity int,@AC bit,@Fare float
AS
Update Transportation_Means
Set Capacity=@Capacity,[A/C]=@AC,Fare=@Fare
Where TransCode=ISNULL(@TransCode,TransCode) AND TransID=ISNULL(@TransID,TransID)

GO
/****** Object:  StoredProcedure [dbo].[UserChangePassword]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[UserChangePassword] @Username nvarchar(15) , @OldPassword nvarchar(15) , @newPassword nvarchar(50)
AS 
Update Login
set Password = @newPassword
where Password = @OldPassword and Username = @Username

GO
/****** Object:  StoredProcedure [dbo].[UserLogin]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[UserLogin] @Username nvarchar(20) , @Password nvarchar(50) 
as
	Select Priv
	from Login
	where Username = @Username AND Password = @Password

GO
/****** Object:  StoredProcedure [dbo].[ViewsHistoryBetter]    Script Date: 12/21/2016 5:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[ViewsHistoryBetter] @Username nvarchar (15) = NULL
As
Select Date,Time,Username,S.DistrictName , D.DistrictName, Rating, Amount_Due, Suggestion
from Orders O, Maps S, Maps D
where Username = ISNULL (@Username,Username) AND S.DistrictID=O.Source AND D.DistrictID=O.Destination 

GO
USE [master]
GO
ALTER DATABASE [PTS] SET  READ_WRITE 
GO
