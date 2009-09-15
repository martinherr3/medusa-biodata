/*
   Martes, 15 de Septiembre de 200912:33:30 a.m.
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
CREATE TABLE dbo.Usuario
	(
	IDUsuario int NOT NULL IDENTITY (1, 1),
	Nombre nvarchar(100) NOT NULL,
	Apellido nvarchar(100) NOT NULL,
	Nick nvarchar(100) NOT NULL,
	Password nvarchar(100) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Usuario ADD CONSTRAINT
	PK_Usuario PRIMARY KEY CLUSTERED 
	(
	IDUsuario
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
