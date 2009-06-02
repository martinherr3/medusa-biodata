/*
   Domingo, 31 de Mayo de 200910:16:44 p.m.
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
ALTER TABLE dbo.ObraSocialXPaciente
	DROP CONSTRAINT FK_ObraSocialXPaciente_Paciente
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ObraSocialXPaciente
	DROP CONSTRAINT FK_ObraSocialXPaciente_ObraSocial
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_ObraSocialXPaciente
	(
	IDPaciente int NOT NULL,
	IDObraSocial int NOT NULL,
	NumeroAfiliado nvarchar(100) NULL,
	IDObraSocialXPaciente int NOT NULL IDENTITY (1, 1)
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_ObraSocialXPaciente OFF
GO
IF EXISTS(SELECT * FROM dbo.ObraSocialXPaciente)
	 EXEC('INSERT INTO dbo.Tmp_ObraSocialXPaciente (IDPaciente, IDObraSocial, NumeroAfiliado)
		SELECT IDPaciente, IDObraSocial, NumeroAfiliado FROM dbo.ObraSocialXPaciente WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.ObraSocialXPaciente
GO
EXECUTE sp_rename N'dbo.Tmp_ObraSocialXPaciente', N'ObraSocialXPaciente', 'OBJECT' 
GO
ALTER TABLE dbo.ObraSocialXPaciente ADD CONSTRAINT
	PK_ObraSocialXPaciente_1 PRIMARY KEY CLUSTERED 
	(
	IDObraSocialXPaciente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ObraSocialXPaciente ADD CONSTRAINT
	FK_ObraSocialXPaciente_ObraSocial FOREIGN KEY
	(
	IDObraSocial
	) REFERENCES dbo.ObraSocial
	(
	IDObraSocial
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ObraSocialXPaciente ADD CONSTRAINT
	FK_ObraSocialXPaciente_Paciente FOREIGN KEY
	(
	IDPaciente
	) REFERENCES dbo.Paciente
	(
	IDPaciente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
