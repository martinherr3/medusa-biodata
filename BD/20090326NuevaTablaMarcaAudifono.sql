/*
   jueves, 26 de marzo de 200908:54:38 p.m.
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
CREATE TABLE dbo.MarcaAudifono
	(
	IDMarca int NOT NULL,
	Nombre nvarchar(20) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.MarcaAudifono ADD CONSTRAINT
	PK_MarcaAudifono PRIMARY KEY CLUSTERED 
	(
	IDMarca
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX IX_MarcaAudifono ON dbo.MarcaAudifono
	(
	IDMarca
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
COMMIT
