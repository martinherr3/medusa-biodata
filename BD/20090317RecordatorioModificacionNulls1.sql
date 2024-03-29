/*
   martes, 17 de marzo de 200911:08:46 p.m.
   Usuario: 
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
CREATE TABLE dbo.Tmp_Recordatorio
	(
	IDRecordatorio int NOT NULL IDENTITY (1, 1),
	FechaRecordatorio datetime NOT NULL,
	Descripcion nvarchar(200) NOT NULL,
	IDVinculado int NULL,
	TipoVinculado int NOT NULL
	)  ON [PRIMARY]
GO
DECLARE @v sql_variant 
SET @v = N'Enum Audifono, Molde, etc. Indica de que tabla es el IDVinculado'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Tmp_Recordatorio', N'COLUMN', N'TipoVinculado'
GO
SET IDENTITY_INSERT dbo.Tmp_Recordatorio ON
GO
IF EXISTS(SELECT * FROM dbo.Recordatorio)
	 EXEC('INSERT INTO dbo.Tmp_Recordatorio (IDRecordatorio, FechaRecordatorio, Descripcion, IDVinculado, TipoVinculado)
		SELECT IDRecordatorio, FechaRecordatorio, Descripcion, IDVinculado, TipoVinculado FROM dbo.Recordatorio WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Recordatorio OFF
GO
DROP TABLE dbo.Recordatorio
GO
EXECUTE sp_rename N'dbo.Tmp_Recordatorio', N'Recordatorio', 'OBJECT' 
GO
ALTER TABLE dbo.Recordatorio ADD CONSTRAINT
	PK_Recordatorio PRIMARY KEY CLUSTERED 
	(
	IDRecordatorio
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
