USE [master]
GO
/****** Object:  Database [antri]    Script Date: 06/11/2021 12:53:34 ******/
CREATE DATABASE [antri] ON  PRIMARY 
( NAME = N'antri', FILENAME = N'C:\AntrianTobasa\Database\antri.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'antri_log', FILENAME = N'C:\AntrianTobasa\Database\antri_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [antri] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [antri].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [antri] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [antri] SET ANSI_NULLS OFF
GO
ALTER DATABASE [antri] SET ANSI_PADDING OFF
GO
ALTER DATABASE [antri] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [antri] SET ARITHABORT OFF
GO
ALTER DATABASE [antri] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [antri] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [antri] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [antri] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [antri] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [antri] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [antri] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [antri] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [antri] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [antri] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [antri] SET  DISABLE_BROKER
GO
ALTER DATABASE [antri] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [antri] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [antri] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [antri] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [antri] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [antri] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [antri] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [antri] SET  READ_WRITE
GO
ALTER DATABASE [antri] SET RECOVERY FULL
GO
ALTER DATABASE [antri] SET  MULTI_USER
GO
ALTER DATABASE [antri] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [antri] SET DB_CHAINING OFF
GO
USE [antri]
GO
/****** Object:  Table [dbo].[runningtexts]    Script Date: 06/11/2021 12:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[runningtexts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[station_name] [nchar](32) NOT NULL,
	[sticky] [bit] NOT NULL,
	[active] [bit] NOT NULL,
	[running_text] [varchar](255) NOT NULL,
 CONSTRAINT [PK_runningtexts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[runningtexts] ON
INSERT [dbo].[runningtexts] ([id], [station_name], [sticky], [active], [running_text]) VALUES (1, N'DISP#1                          ', 1, 1, N'Running text Display #1 dari database server')
INSERT [dbo].[runningtexts] ([id], [station_name], [sticky], [active], [running_text]) VALUES (2, N'DISP#2                          ', 1, 1, N'Running text Display #2 dari database server')
SET IDENTITY_INSERT [dbo].[runningtexts] OFF
/****** Object:  Table [dbo].[posts]    Script Date: 06/11/2021 12:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[posts](
	[name] [nchar](32) NOT NULL,
	[keterangan] [varchar](255) NULL,
	[numberprefix] [char](2) NULL,
 CONSTRAINT [PK_posts] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST0                           ', N'Pos layanan 1', N'A ')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST1                           ', N'Pos layanan 2', N'B ')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST2                           ', N'Pos layanan 3', N'C ')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST3                           ', N'Pos layanan 4', N'D ')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST4                           ', N'Pos layanan 5', N'BK')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST5                           ', N'Pos layanan 6', N'TU')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST6                           ', N'Pos layanan 7', N'DR')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST7                           ', N'Pos layanan 8', N'P ')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST8                           ', N'Pos layanan 9', N'Z ')
INSERT [dbo].[posts] ([name], [keterangan], [numberprefix]) VALUES (N'POST9                           ', N'Pos layanan 10', N'HO')
/****** Object:  Table [dbo].[logins]    Script Date: 06/11/2021 12:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[logins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [char](50) NOT NULL,
	[password] [char](64) NOT NULL,
	[expired] [datetime] NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_logins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_logins] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[logins] ON
INSERT [dbo].[logins] ([id], [username], [password], [expired], [active]) VALUES (1, N'tobasaqueue                                       ', N'A1410C6E07BDA0D774A76E644024801EB00175B27B85D0289469978603EBB9F4', CAST(0x0000B25800000000 AS DateTime), 1)
INSERT [dbo].[logins] ([id], [username], [password], [expired], [active]) VALUES (2, N'admin                                             ', N'51C5FB67361F529DD9DDF96959FC5FA51960E0F7516560290BD7BFCF9421C6F6', CAST(0x0000B25800000000 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[logins] OFF
/****** Object:  Table [dbo].[jobs]    Script Date: 06/11/2021 12:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jobs](
	[id] [int] NOT NULL,
	[number] [int] NOT NULL,
	[status] [nchar](10) NOT NULL,
	[station] [nchar](32) NULL,
	[post] [nchar](32) NOT NULL,
	[source] [nchar](32) NULL,
	[date] [date] NOT NULL,
	[starttime] [datetime] NOT NULL,
	[calltime] [datetime] NULL,
	[endtime] [datetime] NULL,
	[call2time] [datetime] NULL,
 CONSTRAINT [PK_jobs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ipaccesslists]    Script Date: 06/11/2021 12:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ipaccesslists](
	[ipaddress] [nchar](15) NOT NULL,
	[allowed] [bit] NOT NULL,
	[keterangan] [varchar](50) NULL,
 CONSTRAINT [PK_ipaccesslist] PRIMARY KEY CLUSTERED 
(
	[ipaddress] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ipaccesslists] ([ipaddress], [allowed], [keterangan]) VALUES (N'10.62.22.1     ', 1, N'Komputer devepoment')
INSERT [dbo].[ipaccesslists] ([ipaddress], [allowed], [keterangan]) VALUES (N'192.168.1.1    ', 1, N'Komputer Caller #1')
INSERT [dbo].[ipaccesslists] ([ipaddress], [allowed], [keterangan]) VALUES (N'192.168.1.2    ', 1, N'Komputer Caller #2')
/****** Object:  Table [dbo].[stations]    Script Date: 06/11/2021 12:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stations](
	[name] [nchar](32) NOT NULL,
	[post] [nchar](32) NOT NULL,
	[keterangan] [varchar](255) NULL,
	[canlogin] [bit] NOT NULL,
 CONSTRAINT [PK_stations] PRIMARY KEY CLUSTERED 
(
	[name] ASC,
	[post] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#1                         ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'ADMIN#2                         ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#1                          ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#2                          ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#3                          ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#4                          ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'CALL#5                          ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#1                          ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'DISP#2                          ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST0                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#1                        ', N'POST9                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST0                           ', NULL, 1)
GO
print 'Processed 100 total records'
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST1                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST2                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST3                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST4                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST5                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST6                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST7                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST8                           ', NULL, 1)
INSERT [dbo].[stations] ([name], [post], [keterangan], [canlogin]) VALUES (N'TICKET#2                        ', N'POST9                           ', NULL, 1)
/****** Object:  Table [dbo].[sequences]    Script Date: 06/11/2021 12:53:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sequences](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [int] NOT NULL,
	[status] [nchar](10) NOT NULL,
	[station] [nchar](32) NULL,
	[post] [nchar](32) NOT NULL,
	[source] [nchar](32) NULL,
	[date] [date] NOT NULL,
	[starttime] [datetime] NOT NULL,
	[calltime] [datetime] NULL,
	[endtime] [datetime] NULL,
	[call2time] [datetime] NULL,
 CONSTRAINT [PK_sequences] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_sequences]    Script Date: 06/11/2021 12:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_sequences]
AS 
SELECT seq.id, 
       seq.number, 
       seq.status, 
       seq.station, 
       seq.post, 
       seq.source, 
       seq.starttime, 
       seq.endtime , 
       vsr.numberleft ,
       vsr.numbermax
FROM sequences seq
JOIN
	(
		SELECT post,MIN(id) AS idmin , COUNT(number) AS numberleft, MAX(number) AS numbermax
		FROM sequences WHERE status = 'WAITING' AND [date] = (SELECT CAST(getdate() AS date))
		GROUP BY post
	) AS vsr
ON seq.post = vsr.post
WHERE seq.id = vsr.idmin
AND [date] = (SELECT CAST(getdate() AS date))
GO
/****** Object:  View [dbo].[v_posts_queue_summary]    Script Date: 06/11/2021 12:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_posts_queue_summary]
AS 
select name,numberprefix,keterangan
,( SELECT MAX(number)   FROM sequences WHERE status = 'PROCESS' AND post = name AND [date] = CAST(getdate()as DATE) ) AS called_last
,( SELECT COUNT(number) FROM jobs      WHERE status = 'PROCESS' AND post = name AND [date] = CAST(getdate()as DATE) ) AS called_total
,( SELECT MIN(number)   FROM sequences WHERE status = 'WAITING' AND post = name AND [date] = CAST(getdate()as DATE) ) AS waiting_first
,( SELECT MAX(number)   FROM sequences WHERE status = 'WAITING' AND post = name AND [date] = CAST(getdate()as DATE) ) AS waiting_last
,( SELECT COUNT(number) FROM sequences WHERE status = 'WAITING' AND post = name AND [date] = CAST(getdate()as DATE) ) AS waiting_total
from posts
GO
/****** Object:  Trigger [tr_update_jobs]    Script Date: 06/11/2021 12:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tr_update_jobs]
ON [dbo].[sequences]
FOR UPDATE AS

BEGIN
 SET NOCOUNT ON
 
 UPDATE jobs
 SET   [number] = i.[number]
      ,[status] = i.[status]
      ,[station] = i.[station]
      ,[post] = i.[post]
      ,[source] = i.[source]
      ,[date] = i.[date]
      ,[starttime] = i.[starttime]
      ,[calltime] = i.[calltime]
      ,[call2time] = i.[call2time]
      ,[endtime] = i.[endtime]
 
 FROM INSERTED as i
 INNER JOIN jobs on jobs.id = i.id
 
END
GO
/****** Object:  Default [DF_runningtexts_sticky]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[runningtexts] ADD  CONSTRAINT [DF_runningtexts_sticky]  DEFAULT ((0)) FOR [sticky]
GO
/****** Object:  Default [DF_runningtexts_active]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[runningtexts] ADD  CONSTRAINT [DF_runningtexts_active]  DEFAULT ((1)) FOR [active]
GO
/****** Object:  Default [DF_logins_expired]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[logins] ADD  CONSTRAINT [DF_logins_expired]  DEFAULT (dateadd(year,(1),getdate())) FOR [expired]
GO
/****** Object:  Default [DF_logins_active]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[logins] ADD  CONSTRAINT [DF_logins_active]  DEFAULT ((1)) FOR [active]
GO
/****** Object:  Default [DF__jobs__status__014935CB]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[jobs] ADD  DEFAULT (N'WAITING') FOR [status]
GO
/****** Object:  Default [DF_jobs_date]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[jobs] ADD  CONSTRAINT [DF_jobs_date]  DEFAULT (getdate()) FOR [date]
GO
/****** Object:  Default [DF__jobs__starttime__03317E3D]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[jobs] ADD  DEFAULT (getdate()) FOR [starttime]
GO
/****** Object:  Default [DF_stations_canlogin]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[stations] ADD  CONSTRAINT [DF_stations_canlogin]  DEFAULT ((1)) FOR [canlogin]
GO
/****** Object:  Default [DF__sequences__statu__108B795B]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[sequences] ADD  DEFAULT (N'WAITING') FOR [status]
GO
/****** Object:  Default [DF_sequences_date]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[sequences] ADD  CONSTRAINT [DF_sequences_date]  DEFAULT (getdate()) FOR [date]
GO
/****** Object:  Default [DF__sequences__start__1273C1CD]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[sequences] ADD  DEFAULT (getdate()) FOR [starttime]
GO
/****** Object:  ForeignKey [FK_stations_posts]    Script Date: 06/11/2021 12:53:35 ******/
ALTER TABLE [dbo].[stations]  WITH CHECK ADD  CONSTRAINT [FK_stations_posts] FOREIGN KEY([post])
REFERENCES [dbo].[posts] ([name])
GO
ALTER TABLE [dbo].[stations] CHECK CONSTRAINT [FK_stations_posts]
GO
