/*
   Domingo, 23 de Agosto de 200908:55:21 p.m.
   Usuario: gerardo
   Servidor: GERARDO
   Base de datos: BiodataNH
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar esta secuencia de comandos detalladamente antes de ejecutarla fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Audifono
	DROP CONSTRAINT FK_Audifono_MarcaAudifono
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Audifono
	(
	IDAudifono int NOT NULL IDENTITY (1, 1),
	NombreModelo nvarchar(100) NOT NULL,
	IDMarca int NOT NULL,
	Observacion nvarchar(200) NULL,
	Tipo int NOT NULL,
	Senal int NULL,
	Programable bit NULL,
	FranjaAdaptacion xml NULL,
	PresionMaximaSalida numeric(18, 0) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
DECLARE @v sql_variant 
SET @v = N'Retroauricular, Minicanal, Cic, Canal, Half Shell, Full Shell. Enum para esto'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_Audifono', N'COLUMN', N'Tipo'
GO
DECLARE @v sql_variant 
SET @v = N'Enum Digital o Analogico'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_Audifono', N'COLUMN', N'Senal'
GO
DECLARE @v sql_variant 
SET @v = N'Volumen de salida en DB'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_Audifono', N'COLUMN', N'PresionMaximaSalida'
GO
SET IDENTITY_INSERT dbo.Tmp_Audifono ON
GO
IF EXISTS(SELECT * FROM dbo.Audifono)
	 EXEC('INSERT INTO dbo.Tmp_Audifono (IDAudifono, NombreModelo, IDMarca, Observacion, Tipo, Senal, Programable, FranjaAdaptacion, PresionMaximaSalida)
		SELECT IDAudifono, NombreModelo, CONVERT(int, Marca), Observacion, Tipo, Senal, Programable, FranjaAdaptacion, PresionMaximaSalida FROM dbo.Audifono WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Audifono OFF
GO
ALTER TABLE dbo.AudifonoPaciente
	DROP CONSTRAINT FK_AudifonoPaciente_Audifono
GO
ALTER TABLE dbo.MoldeAudifono
	DROP CONSTRAINT FK_MoldeAudifono_Audifono
GO
ALTER TABLE dbo.SeleccionAudifono
	DROP CONSTRAINT FK_SeleccionAudifono_Audifono
GO
DROP TABLE dbo.Audifono
GO
EXECUTE sp_rename N'dbo.Tmp_Audifono', N'Audifono', 'OBJECT' 
GO
ALTER TABLE dbo.Audifono ADD CONSTRAINT
	PK_Audifono PRIMARY KEY CLUSTERED 
	(
	IDAudifono
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Audifono ADD CONSTRAINT
	FK_Audifono_MarcaAudifono FOREIGN KEY
	(
	IDMarca
	) REFERENCES dbo.MarcaAudifono
	(
	IDMarca
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.SeleccionAudifono ADD CONSTRAINT
	FK_SeleccionAudifono_Audifono FOREIGN KEY
	(
	IDAudifono
	) REFERENCES dbo.Audifono
	(
	IDAudifono
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MoldeAudifono ADD CONSTRAINT
	FK_MoldeAudifono_Audifono FOREIGN KEY
	(
	IDAudifono
	) REFERENCES dbo.Audifono
	(
	IDAudifono
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AudifonoPaciente ADD CONSTRAINT
	FK_AudifonoPaciente_Audifono FOREIGN KEY
	(
	IDAudifono
	) REFERENCES dbo.Audifono
	(
	IDAudifono
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
