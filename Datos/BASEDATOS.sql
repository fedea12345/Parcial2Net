USE [Parcial]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 10/31/2016 2:37:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[NombreApellido] [varchar](50) NULL,
	[Dni] [varchar](50) NULL,
	[FechaNacimiento] [date] NULL,
	[Id] [int] NULL,
	[Edad] [int] NULL,
	[NotaPromedio] [float] NULL
) ON [PRIMARY]

GO
