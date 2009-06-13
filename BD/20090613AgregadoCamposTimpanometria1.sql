/*
   Sábado, 13 de Junio de 200912:27:18 a.m.
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
ALTER TABLE dbo.Timpanometria ADD
	ReflejoEstapedialIzq int NULL,
	ReflejoEstapedialDer int NULL,
	TablaReflejosIzq nvarchar(200) NULL,
	TablaReflejosDer nvarchar(200) NULL
GO
DECLARE @v sql_variant 
SET @v = N'Guarda el valor 0 para ".5" y 1 para "1.0"'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Timpanometria', N'COLUMN', N'ReflejoEstapedialIzq'
GO
DECLARE @v sql_variant 
SET @v = N'Guarda el valor 0 para ".5" y 1 para "1.0"'
EXECUTE sp_addextendedproperty N'MS_Description', @v, N'SCHEMA', N'dbo', N'TABLE', N'Timpanometria', N'COLUMN', N'ReflejoEstapedialDer'
GO
COMMIT
