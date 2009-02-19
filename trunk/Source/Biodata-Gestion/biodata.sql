SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoEstudio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoEstudio](
	[idTipoEstudio] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[descripcion] [nvarchar](max) NULL,
	[esquemaDatos] [xml] NULL,
 CONSTRAINT [PK_TipoEstudio] PRIMARY KEY CLUSTERED 
(
	[idTipoEstudio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObraSocial]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ObraSocial](
	[idObraSocial] [int] IDENTITY(1,1) NOT NULL,
	[razonSocial] [nvarchar](50) NULL,
	[direccion] [nvarchar](100) NULL,
	[contacto] [nvarchar](50) NULL,
 CONSTRAINT [PK_ObraSocial] PRIMARY KEY CLUSTERED 
(
	[idObraSocial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Audifono]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Audifono](
	[idAudifono] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_Audifono] PRIMARY KEY CLUSTERED 
(
	[idAudifono] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Molde]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Molde](
	[idMolde] [int] NOT NULL,
	[descripcion] [varchar](max) NULL,
 CONSTRAINT [PK_Molde] PRIMARY KEY CLUSTERED 
(
	[idMolde] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Estudio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Estudio](
	[idEstudio] [int] NOT NULL,
	[fechaEstudio] [datetime] NULL,
	[datos] [xml] NULL,
	[descripcion] [nvarchar](max) NULL,
	[idConsulta] [int] NULL,
	[idTipoEstudio] [int] NULL,
 CONSTRAINT [PK_Estudio] PRIMARY KEY CLUSTERED 
(
	[idEstudio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Consulta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Consulta](
	[idConsulta] [int] NOT NULL,
	[fechaConsulta] [datetime] NULL,
	[diagnostico] [nvarchar](max) NULL,
	[idHistoriaClinica] [int] NULL,
 CONSTRAINT [PK_Consulta] PRIMARY KEY CLUSTERED 
(
	[idConsulta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HistoriaClinica]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HistoriaClinica](
	[idHistoriaClinica] [int] NOT NULL,
	[antecedentesFamiliares] [nvarchar](max) NULL,
	[antecedentesPersonales] [nvarchar](max) NULL,
	[datosDeInteres] [nvarchar](max) NULL,
	[idPaciente] [int] NOT NULL,
 CONSTRAINT [PK_HistoriaClinica] PRIMARY KEY CLUSTERED 
(
	[idHistoriaClinica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MoldePaciente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MoldePaciente](
	[idMolde] [int] NOT NULL,
	[idPaciente] [int] NOT NULL,
 CONSTRAINT [PK_MoldePaciente] PRIMARY KEY CLUSTERED 
(
	[idMolde] ASC,
	[idPaciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AudifonoPaciente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AudifonoPaciente](
	[idAudifono] [int] NOT NULL,
	[idPaciente] [int] NOT NULL,
 CONSTRAINT [PK_AudifonoPaciente] PRIMARY KEY CLUSTERED 
(
	[idAudifono] ASC,
	[idPaciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Paciente]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Paciente](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[direccion] [nvarchar](100) NULL,
	[fechaNacimiento] [nchar](10) NULL,
	[numDocumento] [varchar](10) NULL,
	[sexo] [nchar](1) NULL,
	[idObraSocial] [int] NULL,
	[comentario] [nvarchar](max) NULL,
 CONSTRAINT [PK_paciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Estudio_Consulta]') AND parent_object_id = OBJECT_ID(N'[dbo].[Estudio]'))
ALTER TABLE [dbo].[Estudio]  WITH CHECK ADD  CONSTRAINT [FK_Estudio_Consulta] FOREIGN KEY([idConsulta])
REFERENCES [dbo].[Consulta] ([idConsulta])
GO
ALTER TABLE [dbo].[Estudio] CHECK CONSTRAINT [FK_Estudio_Consulta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Estudio_TipoEstudio]') AND parent_object_id = OBJECT_ID(N'[dbo].[Estudio]'))
ALTER TABLE [dbo].[Estudio]  WITH CHECK ADD  CONSTRAINT [FK_Estudio_TipoEstudio] FOREIGN KEY([idTipoEstudio])
REFERENCES [dbo].[TipoEstudio] ([idTipoEstudio])
GO
ALTER TABLE [dbo].[Estudio] CHECK CONSTRAINT [FK_Estudio_TipoEstudio]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Consulta_HistoriaClinica]') AND parent_object_id = OBJECT_ID(N'[dbo].[Consulta]'))
ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_HistoriaClinica] FOREIGN KEY([idHistoriaClinica])
REFERENCES [dbo].[HistoriaClinica] ([idHistoriaClinica])
GO
ALTER TABLE [dbo].[Consulta] CHECK CONSTRAINT [FK_Consulta_HistoriaClinica]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_HistoriaClinica_Paciente]') AND parent_object_id = OBJECT_ID(N'[dbo].[HistoriaClinica]'))
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_Paciente]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MoldePaciente_Molde]') AND parent_object_id = OBJECT_ID(N'[dbo].[MoldePaciente]'))
ALTER TABLE [dbo].[MoldePaciente]  WITH CHECK ADD  CONSTRAINT [FK_MoldePaciente_Molde] FOREIGN KEY([idMolde])
REFERENCES [dbo].[Molde] ([idMolde])
GO
ALTER TABLE [dbo].[MoldePaciente] CHECK CONSTRAINT [FK_MoldePaciente_Molde]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MoldePaciente_Paciente]') AND parent_object_id = OBJECT_ID(N'[dbo].[MoldePaciente]'))
ALTER TABLE [dbo].[MoldePaciente]  WITH CHECK ADD  CONSTRAINT [FK_MoldePaciente_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[MoldePaciente] CHECK CONSTRAINT [FK_MoldePaciente_Paciente]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AudifonoPaciente_Audifono]') AND parent_object_id = OBJECT_ID(N'[dbo].[AudifonoPaciente]'))
ALTER TABLE [dbo].[AudifonoPaciente]  WITH CHECK ADD  CONSTRAINT [FK_AudifonoPaciente_Audifono] FOREIGN KEY([idAudifono])
REFERENCES [dbo].[Audifono] ([idAudifono])
GO
ALTER TABLE [dbo].[AudifonoPaciente] CHECK CONSTRAINT [FK_AudifonoPaciente_Audifono]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AudifonoPaciente_Paciente]') AND parent_object_id = OBJECT_ID(N'[dbo].[AudifonoPaciente]'))
ALTER TABLE [dbo].[AudifonoPaciente]  WITH CHECK ADD  CONSTRAINT [FK_AudifonoPaciente_Paciente] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Paciente] ([idPaciente])
GO
ALTER TABLE [dbo].[AudifonoPaciente] CHECK CONSTRAINT [FK_AudifonoPaciente_Paciente]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Paciente_ObraSocial]') AND parent_object_id = OBJECT_ID(N'[dbo].[Paciente]'))
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_ObraSocial] FOREIGN KEY([idObraSocial])
REFERENCES [dbo].[ObraSocial] ([idObraSocial])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_ObraSocial]
