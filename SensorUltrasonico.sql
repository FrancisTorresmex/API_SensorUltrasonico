USE [master]
GO
/****** Object:  Database [SensorUltrasonico]    Script Date: 07/08/2022 04:45:36 p. m. ******/
CREATE DATABASE [SensorUltrasonico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SensorUltrasonico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SensorUltrasonico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SensorUltrasonico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SensorUltrasonico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SensorUltrasonico] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SensorUltrasonico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SensorUltrasonico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET ARITHABORT OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SensorUltrasonico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SensorUltrasonico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SensorUltrasonico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SensorUltrasonico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET RECOVERY FULL 
GO
ALTER DATABASE [SensorUltrasonico] SET  MULTI_USER 
GO
ALTER DATABASE [SensorUltrasonico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SensorUltrasonico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SensorUltrasonico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SensorUltrasonico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SensorUltrasonico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SensorUltrasonico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SensorUltrasonico', N'ON'
GO
ALTER DATABASE [SensorUltrasonico] SET QUERY_STORE = OFF
GO
USE [SensorUltrasonico]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 07/08/2022 04:45:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NOT NULL,
	[Edad] [int] NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Telefono] [varchar](13) NULL,
	[Mensaje] [varchar](max) NULL,
 CONSTRAINT [PK_Registro] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sensor]    Script Date: 07/08/2022 04:45:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sensor](
	[IdRegistro] [int] IDENTITY(1,1) NOT NULL,
	[Sensor] [varchar](20) NULL,
	[Fecha] [date] NOT NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Sensor] PRIMARY KEY CLUSTERED 
(
	[IdRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Registro] ON 

INSERT [dbo].[Registro] ([IdUsuario], [Nombre], [Edad], [Correo], [Telefono], [Mensaje]) VALUES (1, N'prueba1', 65, N'prueba1@correo.com', NULL, NULL)
INSERT [dbo].[Registro] ([IdUsuario], [Nombre], [Edad], [Correo], [Telefono], [Mensaje]) VALUES (2, N'prueba2', 21, N'prueba2@gmail.com', N'1234123412', N'Es muy buena aplicación')
INSERT [dbo].[Registro] ([IdUsuario], [Nombre], [Edad], [Correo], [Telefono], [Mensaje]) VALUES (3, N'prueba3', 6, N'p3@gmail.com', N'111111111', N'buena')
INSERT [dbo].[Registro] ([IdUsuario], [Nombre], [Edad], [Correo], [Telefono], [Mensaje]) VALUES (4, N'a', 13, N'a', N'123', N'a')
INSERT [dbo].[Registro] ([IdUsuario], [Nombre], [Edad], [Correo], [Telefono], [Mensaje]) VALUES (5, N'prueba4', 34, N'prueba4@gmail.com', N'123123123', N'es mala')
INSERT [dbo].[Registro] ([IdUsuario], [Nombre], [Edad], [Correo], [Telefono], [Mensaje]) VALUES (6, N'prueba5', 12, N'prueba5@gmail.com', N'1234512345', N'ta buena')
INSERT [dbo].[Registro] ([IdUsuario], [Nombre], [Edad], [Correo], [Telefono], [Mensaje]) VALUES (7, N'prueba6', 57, N'prueba6@gmail.com', N'12345678910', N'12345')
INSERT [dbo].[Registro] ([IdUsuario], [Nombre], [Edad], [Correo], [Telefono], [Mensaje]) VALUES (8, N'prueba7', 42, N'prueba7@gmail.com', N'121212121', N'Mejorable')
SET IDENTITY_INSERT [dbo].[Registro] OFF
GO
SET IDENTITY_INSERT [dbo].[Sensor] ON 

INSERT [dbo].[Sensor] ([IdRegistro], [Sensor], [Fecha], [IdUsuario]) VALUES (1, N'Ultrasonico', CAST(N'2022-06-21' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Sensor] OFF
GO
ALTER TABLE [dbo].[Sensor]  WITH CHECK ADD  CONSTRAINT [FK_Sensor_Registro] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Registro] ([IdUsuario])
GO
ALTER TABLE [dbo].[Sensor] CHECK CONSTRAINT [FK_Sensor_Registro]
GO
USE [master]
GO
ALTER DATABASE [SensorUltrasonico] SET  READ_WRITE 
GO
