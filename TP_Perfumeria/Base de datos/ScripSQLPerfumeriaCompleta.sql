USE [master]
GO
/****** Object:  Database [Perfumeria_2.0]    Script Date: 10/06/2024 22:36:16 ******/
CREATE DATABASE [Perfumeria_2.0]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Perfumeria 2.0', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Perfumeria 2.0.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Perfumeria 2.0_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Perfumeria 2.0_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Perfumeria_2.0] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Perfumeria_2.0].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Perfumeria_2.0] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET ARITHABORT OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Perfumeria_2.0] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Perfumeria_2.0] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Perfumeria_2.0] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Perfumeria_2.0] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Perfumeria_2.0] SET  MULTI_USER 
GO
ALTER DATABASE [Perfumeria_2.0] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Perfumeria_2.0] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Perfumeria_2.0] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Perfumeria_2.0] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Perfumeria_2.0] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Perfumeria_2.0] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Perfumeria_2.0] SET QUERY_STORE = ON
GO
ALTER DATABASE [Perfumeria_2.0] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Perfumeria_2.0]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 10/06/2024 22:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[ID_Cargo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Cargo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cargos] PRIMARY KEY CLUSTERED 
(
	[ID_Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/06/2024 22:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Activo] [nvarchar](10) NOT NULL,
	[FK_Usuario] [int] NOT NULL,
	[FK_Estado] [int] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domicilios]    Script Date: 10/06/2024 22:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domicilios](
	[ID_Domicilio] [int] IDENTITY(1,1) NOT NULL,
	[Calle] [nvarchar](50) NOT NULL,
	[Altura] [int] NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[Distrito] [nvarchar](50) NULL,
	[Cod_Postal] [nvarchar](50) NULL,
	[Provincia] [nvarchar](50) NOT NULL,
	[Pais] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Domicilios] PRIMARY KEY CLUSTERED 
(
	[ID_Domicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 10/06/2024 22:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Num_Legajo] [int] NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Clave] [nvarchar](50) NOT NULL,
	[Perfil] [nvarchar](50) NOT NULL,
	[FK_Usuario] [int] NOT NULL,
	[FK_Cargo] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 10/06/2024 22:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[ID_Estado] [int] IDENTITY(1,1) NOT NULL,
	[Desc_Estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[ID_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 10/06/2024 22:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Producto] [nvarchar](50) NULL,
	[Descripcion_Prod] [nvarchar](50) NULL,
	[Marca] [nvarchar](50) NULL,
	[Categoria] [nvarchar](50) NULL,
	[Precio_prod] [float] NULL,
	[Cant_minima] [int] NULL,
	[Stock_Prod] [int] NULL,
	[FK_Empleado] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/06/2024 22:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Celular] [int] NULL,
	[FK_Domicilio] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 10/06/2024 22:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[ID_Ventas] [int] IDENTITY(1,1) NOT NULL,
	[Num_Venta] [int] NULL,
	[Fecha_Vta] [date] NULL,
	[Cantidad] [int] NULL,
	[Total] [float] NULL,
	[FK_Producto] [int] NULL,
	[FK_Cliente] [int] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[ID_Ventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cargos] ON 

INSERT [dbo].[Cargos] ([ID_Cargo], [Tipo_Cargo]) VALUES (1, N'Administrador Sistemas')
INSERT [dbo].[Cargos] ([ID_Cargo], [Tipo_Cargo]) VALUES (2, N'Gerente')
INSERT [dbo].[Cargos] ([ID_Cargo], [Tipo_Cargo]) VALUES (3, N'Vendedor')
INSERT [dbo].[Cargos] ([ID_Cargo], [Tipo_Cargo]) VALUES (4, N'Encargado de Stock')
SET IDENTITY_INSERT [dbo].[Cargos] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ID_Cliente], [Activo], [FK_Usuario], [FK_Estado]) VALUES (1, N'Activo', 8, 1)
INSERT [dbo].[Clientes] ([ID_Cliente], [Activo], [FK_Usuario], [FK_Estado]) VALUES (2, N'Activo', 9, 3)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Domicilios] ON 

INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (1, N'Maipu', 1200, N'Canning', N'Ezeiza', N'ez1802', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (2, N'Maipu', 200, N'Canning', N'Ezeiza', N'ez1802', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (3, N'Falsa', 123, N'Springfield', N'Ezeiza', N'ez1804', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (4, N'French', 123, N'Ezeiza', N'Ezeiza', N'ez1804', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (5, N'Rep. Colombia', 435, N'La Union', N'Ezeiza', N'ez1804', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (6, N'Saavedra', 789, N'Monte Grande', N'Esteban Echeverria', N'mg1756', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (7, N'Lacarra', 785, N'Canning', N'Esteban Echeverria', N'mg1756', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (8, N'9 de Julio', 2548, N'Capital Federal', N'CABA', N'cp1258', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (9, N'Av. Libertadores', 11457, N'Nuñez', N'CABA', N'1245CF', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (10, N'Av. Libertadores', 11457, N'Nuñez', N'CABA', N'1245CF', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (11, N'Alem', 3652, N'Monte Grande', N'Esteban Echeverria', N'1604MG', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (12, N'Berutti', 123, N'Ezeiza', N'Ezeiza', N'1804EZ', N'Buenos Aires', N'Argentina')
INSERT [dbo].[Domicilios] ([ID_Domicilio], [Calle], [Altura], [Localidad], [Distrito], [Cod_Postal], [Provincia], [Pais]) VALUES (13, N'Jujuy', 300, N'Spegazzini', N'Ezeiza', N'1804EZ', N'Buenos Aires', N'Argentina')
SET IDENTITY_INSERT [dbo].[Domicilios] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (2, 1, N'amenorque', N'123456', N'admin', 2, 1)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (3, 2, N'riascas', N'123456', N'admin', 3, 1)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (4, 3, N'msimpson', N'123456', N'gerente', 4, 2)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (5, 4, N'jdiaz', N'123456', N'vendedor', 5, 3)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (6, 5, N'mgomez', N'123456', N'vendedor', 6, 3)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (7, 6, N'egarcia', N'123456', N'encargado', 7, 4)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (9, 100, N'eperez', N'123456', N'vendedor', 11, 3)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (10, 101, N'mcanete', N'123456', N'encargado', 12, 4)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (11, 102, N'mescobar', N'123456', N'vendedor', 13, 3)
INSERT [dbo].[Empleados] ([ID_Empleado], [Num_Legajo], [NombreUsuario], [Clave], [Perfil], [FK_Usuario], [FK_Cargo]) VALUES (12, 103, N'nortega', N'123456', N'vendedor', 14, 3)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Estados] ON 

INSERT [dbo].[Estados] ([ID_Estado], [Desc_Estado]) VALUES (1, N'Al dia')
INSERT [dbo].[Estados] ([ID_Estado], [Desc_Estado]) VALUES (2, N'Deudor')
INSERT [dbo].[Estados] ([ID_Estado], [Desc_Estado]) VALUES (3, N'VIP')
INSERT [dbo].[Estados] ([ID_Estado], [Desc_Estado]) VALUES (4, N'Incobrable')
SET IDENTITY_INSERT [dbo].[Estados] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([ID_Producto], [Cod_Producto], [Descripcion_Prod], [Marca], [Categoria], [Precio_prod], [Cant_minima], [Stock_Prod], [FK_Empleado]) VALUES (1, N'001P', N'Shampoo', N'Sedal', N'Limpieza', 100, 10, 50, 7)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (2, N'Alex', N'Menorque', 36522468, N'amenorque@pefumeria.com.ar', 1159147279, 1)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (3, N'Ruth', N'Iascas', 37895632, N'riascas@pefumeria.com.ar', 1100236589, 2)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (4, N'Marge', N'Simpson', 24563258, N'msimpson@pefumeria.com.ar', 1156985689, 3)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (5, N'Julian', N'Diaz', 36589547, N'jdiaz@pefumeria.com.ar', 1123654587, 4)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (6, N'Matilda', N'Gomez', 31236985, N'mgomez@pefumeria.com.ar', 1158965874, 5)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (7, N'Enzo', N'Garcia', 37895621, N'egarcia@pefumeria.com.ar', 1154563211, 6)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (8, N'Julian', N'Alvarez', 42365236, N'river2018@gmail.com', 1159653245, 7)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (9, N'Marcelo', N'Tinelli', 18563245, N'cabe_casla@mail.com', 1159874521, 8)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (11, N'Enzo', N'Perez', 24563256, N'eperez@perfumeria.com.ar', 1145874569, 10)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (12, N'Mauricio', N'Cañete', 32659887, N'mcanete@perfumeria.com.ar', 1159786532, 11)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (13, N'Marcos', N'Escobar', 29004005, N'mescobar@perfumeria.com.ar', 1159896541, 12)
INSERT [dbo].[Usuarios] ([ID_Usuario], [Nombre], [Apellido], [DNI], [Email], [Celular], [FK_Domicilio]) VALUES (14, N'Nicolas', N'Ortega', 34569873, N'nortega@perfumeria.com.ar', 1159236523, 13)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([ID_Ventas], [Num_Venta], [Fecha_Vta], [Cantidad], [Total], [FK_Producto], [FK_Cliente]) VALUES (1, 1, CAST(N'2024-06-10' AS Date), 2, 200, 1, 1)
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Estados] FOREIGN KEY([FK_Estado])
REFERENCES [dbo].[Estados] ([ID_Estado])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Estados]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Usuarios] FOREIGN KEY([FK_Usuario])
REFERENCES [dbo].[Usuarios] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Usuarios]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Cargos] FOREIGN KEY([FK_Cargo])
REFERENCES [dbo].[Cargos] ([ID_Cargo])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Cargos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Usuarios] FOREIGN KEY([FK_Usuario])
REFERENCES [dbo].[Usuarios] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Usuarios]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Empleados] FOREIGN KEY([FK_Empleado])
REFERENCES [dbo].[Empleados] ([ID_Empleado])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Empleados]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Domicilios] FOREIGN KEY([FK_Domicilio])
REFERENCES [dbo].[Domicilios] ([ID_Domicilio])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Domicilios]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([FK_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Productos] FOREIGN KEY([FK_Producto])
REFERENCES [dbo].[Productos] ([ID_Producto])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Productos]
GO
/****** Object:  StoredProcedure [dbo].[AltaNuevoEmpleado]    Script Date: 10/06/2024 22:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AltaNuevoEmpleado]
@Calle nvarchar(50),
@Altura int,
@Localidad nvarchar(50),
@Distrito nvarchar(50),
@Cod_Postal nvarchar(50),
@Provincia nvarchar(50),
@Pais nvarchar(50),
@Nombre nvarchar(50),
@Apellido nvarchar(50),
@DNI int,
@Email nvarchar(50),
@Celular int,
@Num_Legajo int,
@NombreUsuario nvarchar(50),
@Clave nvarchar(50),
@Perfil nvarchar(50),
@FK_Cargo int

as
Begin

declare @ID_Domicilio int
declare @ID_Usuario int

insert into Domicilios (Calle, Altura, Localidad, Distrito, Cod_Postal, Provincia, Pais)
values (@Calle, @Altura, @Localidad, @Distrito, @Cod_Postal, @Provincia, @Pais)
set @ID_Domicilio = SCOPE_IDENTITY()

insert into Usuarios (Nombre, Apellido, DNI, Email, Celular, FK_Domicilio)
values (@Nombre, @Apellido, @DNI, @Email, @Celular, @ID_Domicilio)
set @ID_Usuario = SCOPE_IDENTITY()

insert into Empleados (Num_Legajo, NombreUsuario, Clave, Perfil, FK_Usuario, FK_Cargo)
values (@Num_Legajo, @NombreUsuario, @Clave, @Perfil, @ID_Usuario, @FK_Cargo)
end

GO
USE [master]
GO
ALTER DATABASE [Perfumeria_2.0] SET  READ_WRITE 
GO
