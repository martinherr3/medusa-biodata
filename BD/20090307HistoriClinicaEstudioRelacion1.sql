/* Para evitar posibles problemas de p�rdida de datos, debe revisar esta secuencia de comandos detalladamente antes de ejecutarla fuera del contexto del dise�ador de base de datos.*/
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
ALTER TABLE dbo.Estudio ADD
	IDHistoriaClinica int NULL
GO
ALTER TABLE dbo.Estudio ADD CONSTRAINT
	FK_Estudio_HistoriaClinica FOREIGN KEY
	(
	IDHistoriaClinica
	) REFERENCES dbo.HistoriaClinica
	(
	IDHistoriaClinica
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
