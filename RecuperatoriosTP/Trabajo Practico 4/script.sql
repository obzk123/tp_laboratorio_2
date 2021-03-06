USE [master]
GO
/****** Object:  Database [equipos]    Script Date: 11/20/2021 7:54:34 PM ******/
CREATE DATABASE [equipos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'equipos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\equipos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'equipos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\equipos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [equipos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [equipos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [equipos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [equipos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [equipos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [equipos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [equipos] SET ARITHABORT OFF 
GO
ALTER DATABASE [equipos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [equipos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [equipos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [equipos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [equipos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [equipos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [equipos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [equipos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [equipos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [equipos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [equipos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [equipos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [equipos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [equipos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [equipos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [equipos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [equipos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [equipos] SET RECOVERY FULL 
GO
ALTER DATABASE [equipos] SET  MULTI_USER 
GO
ALTER DATABASE [equipos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [equipos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [equipos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [equipos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [equipos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [equipos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'equipos', N'ON'
GO
ALTER DATABASE [equipos] SET QUERY_STORE = OFF
GO
USE [equipos]
GO
/****** Object:  Table [dbo].[tablaEquipos]    Script Date: 11/20/2021 7:54:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablaEquipos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ganados] [int] NOT NULL,
	[empatados] [int] NOT NULL,
	[perdidos] [int] NOT NULL,
	[golesafavor] [int] NOT NULL,
	[golesencontra] [int] NOT NULL,
	[fechasmaximas] [int] NULL,
	[nombretorneo] [varchar](50) NULL,
	[capacidadMaxima] [int] NULL,
 CONSTRAINT [PK_tablaEquipos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tablaEquipos] ON 

INSERT [dbo].[tablaEquipos] ([id], [nombre], [ganados], [empatados], [perdidos], [golesafavor], [golesencontra], [fechasmaximas], [nombretorneo], [capacidadMaxima]) VALUES (46, N'River', 0, 0, 0, 0, 0, 20, N'Torneo Base de datos', 15)
INSERT [dbo].[tablaEquipos] ([id], [nombre], [ganados], [empatados], [perdidos], [golesafavor], [golesencontra], [fechasmaximas], [nombretorneo], [capacidadMaxima]) VALUES (47, N'Boca', 0, 0, 0, 0, 0, 20, N'Torneo Base de datos', 15)
INSERT [dbo].[tablaEquipos] ([id], [nombre], [ganados], [empatados], [perdidos], [golesafavor], [golesencontra], [fechasmaximas], [nombretorneo], [capacidadMaxima]) VALUES (48, N'San Lorenzo', 0, 0, 0, 0, 0, 20, N'Torneo Base de datos', 15)
INSERT [dbo].[tablaEquipos] ([id], [nombre], [ganados], [empatados], [perdidos], [golesafavor], [golesencontra], [fechasmaximas], [nombretorneo], [capacidadMaxima]) VALUES (49, N'Racing', 0, 0, 0, 0, 0, 20, N'Torneo Base de datos', 15)
INSERT [dbo].[tablaEquipos] ([id], [nombre], [ganados], [empatados], [perdidos], [golesafavor], [golesencontra], [fechasmaximas], [nombretorneo], [capacidadMaxima]) VALUES (50, N'Estudiantes', 0, 0, 0, 0, 0, 20, N'Torneo Base de datos', 15)
SET IDENTITY_INSERT [dbo].[tablaEquipos] OFF
GO
USE [master]
GO
ALTER DATABASE [equipos] SET  READ_WRITE 
GO
