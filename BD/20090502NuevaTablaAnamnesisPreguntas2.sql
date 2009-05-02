/*
   Sábado, 02 de Mayo de 200901:09:40 a.m.
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
CREATE TABLE dbo.AnamnesisPreguntas
	(
	IDEstudio int NOT NULL,
	Pregunta nvarchar(250) NULL,
	Respuesta nvarchar(250) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.AnamnesisPreguntas ADD CONSTRAINT
	PK_AnamnesisPreguntas PRIMARY KEY CLUSTERED 
	(
	IDEstudio
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.AnamnesisPreguntas ADD CONSTRAINT
	FK_AnamnesisPreguntas_AnamnesisPreguntas FOREIGN KEY
	(
	IDEstudio
	) REFERENCES dbo.AnamnesisPreguntas
	(
	IDEstudio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.AnamnesisPreguntas ADD CONSTRAINT
	FK_AnamnesisPreguntas_Anamnesis FOREIGN KEY
	(
	IDEstudio
	) REFERENCES dbo.Anamnesis
	(
	IDEstudio
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
