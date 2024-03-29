/*
   jueves, 26 de marzo de 200910:23:13 p.m.
   Usuario: martinh
   Servidor: MARTINH-PC
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
ALTER TABLE dbo.Audifono ADD CONSTRAINT
	FK_Audifono_Audifono FOREIGN KEY
	(
	IDAudifono
	) REFERENCES dbo.Audifono
	(
	IDAudifono
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Audifono ADD CONSTRAINT
	FK_Audifono_MarcaAudifono FOREIGN KEY
	(
	IDAudifono
	) REFERENCES dbo.MarcaAudifono
	(
	IDMarca
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
