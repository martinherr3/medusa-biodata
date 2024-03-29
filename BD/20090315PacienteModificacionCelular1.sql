/*
   domingo, 15 de marzo de 200921:26:29
   Usuario: 
   Servidor: Gerardo
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
ALTER TABLE dbo.Paciente
	DROP CONSTRAINT FK_Paciente_Ciudad
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Paciente
	(
	IDPaciente int NOT NULL IDENTITY (1, 1),
	Nombre nvarchar(100) NOT NULL,
	Apellido nvarchar(100) NOT NULL,
	Direccion nvarchar(150) NULL,
	TipoDocumento int NOT NULL,
	NumeroDocumento numeric(18, 0) NOT NULL,
	CorreoElectronico nvarchar(100) NULL,
	FechaNacimiento datetime NULL,
	Sexo nchar(1) NULL,
	Comentario nvarchar(250) NULL,
	Telefono nvarchar(50) NULL,
	Celular nvarchar(50) NULL,
	IDCiudad int NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_Paciente ON
GO
IF EXISTS(SELECT * FROM dbo.Paciente)
	 EXEC('INSERT INTO dbo.Tmp_Paciente (IDPaciente, Nombre, Apellido, Direccion, TipoDocumento, NumeroDocumento, CorreoElectronico, FechaNacimiento, Sexo, Comentario, Telefono, Celular, IDCiudad)
		SELECT IDPaciente, Nombre, Apellido, Direccion, TipoDocumento, NumeroDocumento, CorreoElectronico, FechaNacimiento, Sexo, Comentario, Telefono, CONVERT(nvarchar(50), Celular), IDCiudad FROM dbo.Paciente WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Paciente OFF
GO
ALTER TABLE dbo.ObraSocialXPaciente
	DROP CONSTRAINT FK_ObraSocialXPaciente_Paciente
GO
ALTER TABLE dbo.HistoriaClinica
	DROP CONSTRAINT FK_HistoriaClinica_Paciente
GO
ALTER TABLE dbo.AudifonoPaciente
	DROP CONSTRAINT FK_AudifonoPaciente_Paciente
GO
DROP TABLE dbo.Paciente
GO
EXECUTE sp_rename N'dbo.Tmp_Paciente', N'Paciente', 'OBJECT' 
GO
ALTER TABLE dbo.Paciente ADD CONSTRAINT
	PK_Paciente PRIMARY KEY CLUSTERED 
	(
	IDPaciente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Paciente ADD CONSTRAINT
	FK_Paciente_Ciudad FOREIGN KEY
	(
	IDCiudad
	) REFERENCES dbo.Ciudad
	(
	IDCiudad
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AudifonoPaciente ADD CONSTRAINT
	FK_AudifonoPaciente_Paciente FOREIGN KEY
	(
	IDPaciente
	) REFERENCES dbo.Paciente
	(
	IDPaciente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HistoriaClinica ADD CONSTRAINT
	FK_HistoriaClinica_Paciente FOREIGN KEY
	(
	IDPaciente
	) REFERENCES dbo.Paciente
	(
	IDPaciente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
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
