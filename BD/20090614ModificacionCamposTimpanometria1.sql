/*
   Domingo, 14 de Junio de 200909:23:21 p.m.
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
ALTER TABLE dbo.Timpanometria
	DROP CONSTRAINT FK_Timpanometria_Estudio
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Timpanometria
	(
	IDEstudio int NOT NULL,
	TimpanometriaGrafico xml NULL,
	ReflejoEstapedialIzq int NULL,
	ReflejoEstapedialDer int NULL,
	TablaReflejosIzq nvarchar(4000) NULL,
	TablaReflejosDer nvarchar(4000) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
DECLARE @v sql_variant 
SET @v = N'Guarda el valor 0 para ".5" y 1 para "1.0"'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_Timpanometria', N'COLUMN', N'ReflejoEstapedialIzq'
GO
DECLARE @v sql_variant 
SET @v = N'Guarda el valor 0 para ".5" y 1 para "1.0"'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_Timpanometria', N'COLUMN', N'ReflejoEstapedialDer'
GO
IF EXISTS(SELECT * FROM dbo.Timpanometria)
	 EXEC('INSERT INTO dbo.Tmp_Timpanometria (IDEstudio, TimpanometriaGrafico, ReflejoEstapedialIzq, ReflejoEstapedialDer, TablaReflejosIzq, TablaReflejosDer)
		SELECT IDEstudio, TimpanometriaGrafico, ReflejoEstapedialIzq, ReflejoEstapedialDer, TablaReflejosIzq, TablaReflejosDer FROM dbo.Timpanometria WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Timpanometria
GO
EXECUTE sp_rename N'dbo.Tmp_Timpanometria', N'Timpanometria', 'OBJECT' 
GO
ALTER TABLE dbo.Timpanometria ADD CONSTRAINT
	PK_Timpanometria PRIMARY KEY CLUSTERED 
	(
	IDEstudio
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Timpanometria ADD CONSTRAINT
	FK_Timpanometria_Estudio FOREIGN KEY
	(
	IDEstudio
	) REFERENCES dbo.Estudio
	(
	IDEstudio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
