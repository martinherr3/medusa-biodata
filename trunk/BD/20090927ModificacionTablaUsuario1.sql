/*
   Domingo, 27 de Septiembre de 200909:22:13 p.m.
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
ALTER TABLE dbo.Usuario ADD
	TipoUsuario int NOT NULL
GO
DECLARE @v sql_variant 
SET @v = N'Para dos tipos de usuarios: Administrador -> 0 y Usuario Comun -> 1. El Administrador puede entrar al ABM de Usuarios'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Usuario', N'COLUMN', N'TipoUsuario'
GO
COMMIT
