/*
   Martes, 19 de Mayo de 200912:20:06 p.m.
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
ALTER TABLE dbo.AnamnesisPreguntas
	DROP CONSTRAINT FK_AnamnesisPreguntas_Anamnesis
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_AnamnesisPreguntas
	(
	IDEstudio int NOT NULL,
	Pregunta nvarchar(250) NULL,
	Respuesta nvarchar(250) NULL,
	IDAnamnesisPreguntas int NOT NULL IDENTITY (1, 1)
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_AnamnesisPreguntas OFF
GO
IF EXISTS(SELECT * FROM dbo.AnamnesisPreguntas)
	 EXEC('INSERT INTO dbo.Tmp_AnamnesisPreguntas (IDEstudio, Pregunta, Respuesta)
		SELECT IDEstudio, Pregunta, Respuesta FROM dbo.AnamnesisPreguntas WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.AnamnesisPreguntas
GO
EXECUTE sp_rename N'dbo.Tmp_AnamnesisPreguntas', N'AnamnesisPreguntas', 'OBJECT' 
GO
ALTER TABLE dbo.AnamnesisPreguntas ADD CONSTRAINT
	PK_AnamnesisPreguntas PRIMARY KEY CLUSTERED 
	(
	IDAnamnesisPreguntas
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

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
