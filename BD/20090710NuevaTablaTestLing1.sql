/*
   Viernes, 10 de Julio de 200901:27:58 a.m.
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
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.TestLing
	(
	IDEstudio int NOT NULL,
	TablaValores nvarchar(4000) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.TestLing ADD CONSTRAINT
	PK_TestLing PRIMARY KEY CLUSTERED 
	(
	IDEstudio
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.TestLing ADD CONSTRAINT
	FK_TestLing_Estudio1 FOREIGN KEY
	(
	IDEstudio
	) REFERENCES dbo.Estudio
	(
	IDEstudio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
