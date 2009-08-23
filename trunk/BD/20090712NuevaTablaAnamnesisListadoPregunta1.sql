/*
   Sunday, July 12, 20091:26:24 PM
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
CREATE TABLE dbo.AnamnesisListadoPregunta
	(
	IDAnamnesisListadoPregunta int NOT NULL IDENTITY (1, 1),
	Pregunta nvarchar(250) NULL,
	ClasificacionPregunta int NULL
	)  ON [PRIMARY]
GO
DECLARE @v sql_variant 
SET @v = N'Guarda un valor numerico entero que indica si es para chico o grande. 1 -> Grande. 2 -> Chico'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'AnamnesisListadoPregunta', N'COLUMN', N'ClasificacionPregunta'
GO
ALTER TABLE dbo.AnamnesisListadoPregunta ADD CONSTRAINT
	PK_AnamnesisListadoPregunta PRIMARY KEY CLUSTERED 
	(
	IDAnamnesisListadoPregunta
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
