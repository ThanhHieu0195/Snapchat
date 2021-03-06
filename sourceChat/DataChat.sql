USE [master]
GO
Drop Database DataChat
Go
/****** Object:  Database [DataChat]    Script Date: 1/10/2016 1:25:14 PM ******/
CREATE DATABASE [DataChat]
GO
ALTER DATABASE [DataChat] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DataChat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DataChat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DataChat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DataChat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DataChat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DataChat] SET ARITHABORT OFF 
GO
ALTER DATABASE [DataChat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DataChat] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DataChat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DataChat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DataChat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DataChat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DataChat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DataChat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DataChat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DataChat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DataChat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DataChat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DataChat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DataChat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DataChat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DataChat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DataChat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DataChat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DataChat] SET RECOVERY FULL 
GO
ALTER DATABASE [DataChat] SET  MULTI_USER 
GO
ALTER DATABASE [DataChat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DataChat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DataChat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DataChat] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DataChat', N'ON'
GO
USE [DataChat]
GO
/****** Object:  Table [dbo].[FriendList]    Script Date: 1/10/2016 1:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FriendList](
	[IDFriendList] [int] NOT NULL,
	[IDUser] [int] NOT NULL,
 CONSTRAINT [PK_FriendList] PRIMARY KEY CLUSTERED 
(
	[IDFriendList] ASC,
	[IDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Message]    Script Date: 1/10/2016 1:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[IDUser] [int] NOT NULL,
	[IDSender] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Message] [nvarchar](50) NULL,
	[State] [bit] NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC,
	[IDSender] ASC,
	[DateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/10/2016 1:25:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IDUser] [int] NOT NULL,
	[Username] [nvarchar](25) NOT NULL,
	[Password] [nvarchar](15) NOT NULL,
	[State] [bit] NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users_1] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[FriendList]  WITH CHECK ADD  CONSTRAINT [FK_FriendList_Users] FOREIGN KEY([IDFriendList])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[FriendList] CHECK CONSTRAINT [FK_FriendList_Users]
GO
ALTER TABLE [dbo].[FriendList]  WITH CHECK ADD  CONSTRAINT [FK_FriendList_Users1] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[FriendList] CHECK CONSTRAINT [FK_FriendList_Users1]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Users] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Users]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Users1] FOREIGN KEY([IDSender])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Users1]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Users2] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Users2]
GO
USE [master]
GO
ALTER DATABASE [DataChat] SET  READ_WRITE 
GO
