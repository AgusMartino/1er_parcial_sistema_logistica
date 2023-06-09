USE [master]
GO
/****** Object:  Database [parcial_sap]    Script Date: 21/5/2023 20:35:36 ******/
CREATE DATABASE [parcial_sap]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'parcial_sap', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\parcial_sap.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'parcial_sap_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\parcial_sap_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [parcial_sap] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [parcial_sap].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [parcial_sap] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [parcial_sap] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [parcial_sap] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [parcial_sap] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [parcial_sap] SET ARITHABORT OFF 
GO
ALTER DATABASE [parcial_sap] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [parcial_sap] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [parcial_sap] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [parcial_sap] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [parcial_sap] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [parcial_sap] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [parcial_sap] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [parcial_sap] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [parcial_sap] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [parcial_sap] SET  DISABLE_BROKER 
GO
ALTER DATABASE [parcial_sap] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [parcial_sap] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [parcial_sap] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [parcial_sap] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [parcial_sap] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [parcial_sap] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [parcial_sap] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [parcial_sap] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [parcial_sap] SET  MULTI_USER 
GO
ALTER DATABASE [parcial_sap] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [parcial_sap] SET DB_CHAINING OFF 
GO
ALTER DATABASE [parcial_sap] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [parcial_sap] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [parcial_sap] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [parcial_sap] SET QUERY_STORE = OFF
GO
USE [parcial_sap]
GO
/****** Object:  Table [dbo].[Detalle_de_transaccion]    Script Date: 21/5/2023 20:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_de_transaccion](
	[id_detalle] [int] NOT NULL,
	[id_transaccion] [int] NULL,
	[id_producto] [int] NULL,
	[Cantidad] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Detalle_de_transaccion] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 21/5/2023 20:35:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[id_inventario] [int] NOT NULL,
	[id_producto] [int] NULL,
	[id_sucursal] [int] NULL,
	[Cantidad] [decimal](18, 0) NULL,
 CONSTRAINT [PK_inventario] PRIMARY KEY CLUSTERED 
(
	[id_inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 21/5/2023 20:35:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Precio] [decimal](18, 0) NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sucursal]    Script Date: 21/5/2023 20:35:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sucursal](
	[id] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[Localidad] [varchar](50) NULL,
	[tipo_de_sucursal] [int] NULL,
 CONSTRAINT [PK_tienda] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_sucursal]    Script Date: 21/5/2023 20:35:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_sucursal](
	[id_tipo_sucursal] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_tipo_sucursal] PRIMARY KEY CLUSTERED 
(
	[id_tipo_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transaccion]    Script Date: 21/5/2023 20:35:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaccion](
	[id_transaccion] [int] NOT NULL,
	[id_origen] [int] NULL,
	[id_destino] [int] NULL,
	[id_usuario] [int] NULL,
	[Fecha_de_transaccion] [datetime] NULL,
 CONSTRAINT [PK_transaccion] PRIMARY KEY CLUSTERED 
(
	[id_transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 21/5/2023 20:35:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] NOT NULL,
	[usuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [parcial_sap] SET  READ_WRITE 
GO
