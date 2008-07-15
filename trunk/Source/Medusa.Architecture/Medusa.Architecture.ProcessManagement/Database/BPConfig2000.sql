USE [master]
GO
IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'BPConfig')
BEGIN
CREATE DATABASE [BPConfig] ON  PRIMARY 
( NAME = N'BPConfig_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL\Data\BPConfig_Data.MDF' , SIZE = 1792KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'BPConfig_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL\Data\BPConfig_Log.LDF' , SIZE = 3840KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 COLLATE Modern_Spanish_CI_AS
END

GO
EXEC dbo.sp_dbcmptlevel @dbname=N'BPConfig', @new_cmptlevel=80
GO
ALTER DATABASE [BPConfig] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BPConfig] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BPConfig] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BPConfig] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BPConfig] SET ARITHABORT OFF 
GO
ALTER DATABASE [BPConfig] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BPConfig] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BPConfig] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BPConfig] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BPConfig] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BPConfig] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BPConfig] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BPConfig] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BPConfig] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BPConfig] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BPConfig] SET  READ_WRITE 
GO
ALTER DATABASE [BPConfig] SET RECOVERY FULL 
GO
ALTER DATABASE [BPConfig] SET  MULTI_USER 
GO
ALTER DATABASE [BPConfig] SET TORN_PAGE_DETECTION ON 
GO
if ( ((@@microsoftversion / power(2, 24) = 8) and (@@microsoftversion & 0xffff >= 760)) or 
		(@@microsoftversion / power(2, 24) >= 9) )begin 
	exec dbo.sp_dboption @dbname =  N'BPConfig', @optname = 'db chaining', @optvalue = 'OFF'
 end
USE [BPConfig]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Process]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[Process](
	[Name] [varchar](255) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Description] [varchar](1000) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Handler] [varchar](255) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Request] [varchar](255) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Response] [varchar](255) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Available] [varchar](5) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Audit] [varchar](5) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[ProcessTransactionalBehaviour] [varchar](20) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[ProcessIsolationLevel] [varchar](20) COLLATE Modern_Spanish_CI_AS NOT NULL,
	[Timeout] [int] NOT NULL,
	[Cacheable] [varchar](5) COLLATE Modern_Spanish_CI_AS NOT NULL,
 CONSTRAINT [PK_Process] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Name'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del proceso.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Name'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Description'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripción del proceso.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Description'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Handler'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del assembly y fullname de la clase de proceso.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Handler'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Request'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del assembly y fullname de la clase de request.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Request'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Response'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del assembly y fullname de la clase de response.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Response'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Available'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si el proceso está disponible para ser ejecutado. Valores posibles: true / false.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Available'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Audit'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si la ejecución del proceso debe ser auditada o no. Valores posibles: true / false.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Audit'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'ProcessTransactionalBehaviour'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Define el comportamiento transaccional del proceso raíz.

*Required: el proceso transacciona. Si hay un ámbito transaccional ya abierto, utiliza el existente, en caso contrario crea una nueva transaccion.

*RequiresNew: Siempre se crea una nueva transacción.
 
*Suppress: no transacciona, todas las operaciones se hacen sin estar en un ámbito transaccional. ' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'ProcessTransactionalBehaviour'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'ProcessIsolationLevel'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Especifica el nivel de aislamiento de la transacción.

*Chaos: los cambios pendientes de transacciones más aisladas no puede ser sobreescritos.

*ReadCommitted: los datos volátites no puede ser leidos durante la transacción, pero pueden ser modificados.

*ReadUncommitted: los datos volátines pueden ser leidos y modificados durante la transacción.

*RepeatableRead: los datos volátiles pueden ser leidos pero no modificados durante la transación. Nuevos datos pueden ser creados.

*Serializable: los datos volátiles pueden ser leidos pero no modificados, y no es posible crear nuevos datos durante la transacción.

*Snapshot: los datos volátiles pueden ser leidos. Antes de modificarse datos,  se verifica que otra transacción los haya cambiado luego de haber sido leidos. Si los datos se actualizaron, se levanta un error.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'ProcessIsolationLevel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Timeout'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Tiempo en segundos de duración de la transacción.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Timeout'
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Process_g_Name]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Process_g_Name]
	(
	@Name VARCHAR(255)
	)
AS
BEGIN
	SELECT	Process.*
	FROM	Process
	WHERE	Process.Name = @Name
END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Process_s_All]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		jlousararian
-- Create date: 27/10/2006
-- Description:	Buscar todos los procesos.
-- =============================================
CREATE PROCEDURE [dbo].[Process_s_All]
AS

SELECT	 Name
		,Description
		,Request
		,Response
		,ProcessTransactionalBehaviour
		,Handler
		,ProcessIsolationLevel
		,TimeOut
		,Available
		,Audit
		,Cacheable
	 FROM Process
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Process_i]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[Process_i]
(

	@Name varchar(255),
	@Description varchar(1000),
	@Handler varchar(255),
	@Request varchar(255),
	@Response varchar(255),
	@Available varchar(5),
	@Audit varchar(5),
	@ProcessTransactionalBehaviour varchar(20),
	@ProcessIsolationLevel varchar(20),
	@Timeout int,
	@Cacheable varchar(5)

)                 
AS

-- Description : Procedimiento Almacenado de Creacion de Process
-- Author      : jlousararian
-- Date        : 2006-10-27 05:02:04

INSERT INTO Process
(
	Name,
	Description,
	Handler,
	Request,
	Response,
	Available,
	Audit,
	ProcessTransactionalBehaviour,
	ProcessIsolationLevel,
	Timeout,
	Cacheable
)
VALUES
(
	@Name,
	@Description,
	@Handler,
	@Request,
	@Response,
	@Available,
	@Audit,
	@ProcessTransactionalBehaviour,
	@ProcessIsolationLevel,
	@Timeout,
	@Cacheable
)
    


' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Process_u]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Process_u]
(

	@Name varchar(255),
	@Description varchar(1000),
	@Handler varchar(255),
	@Request varchar(255),
	@Response varchar(255),
	@Available varchar(5),
	@Audit varchar(5),
	@ProcessTransactionalBehaviour varchar(20),
	@ProcessIsolationLevel varchar(20),
	@Timeout int,
	@Cacheable varchar(5)

)                 
AS

-- Description : Procedimiento Almacenado de Actualizacion de Process
-- Author      : jlousararian
-- Date        : 2006-10-27 05:02:04

UPDATE Process

 SET 
	Description = @Description,
	Handler = @Handler,
	Request = @Request,
	Response = @Response,
	Available = @Available,
	Audit = @Audit,
	ProcessTransactionalBehaviour = @ProcessTransactionalBehaviour,
	ProcessIsolationLevel = @ProcessIsolationLevel,
	Timeout = @Timeout,
	Cacheable = @Cacheable

WHERE 
(
	Name = @Name 
)

' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Process_d]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[Process_d]
(

	@Name varchar(255)

)                 
AS

-- Description : Procedimiento Almacenado de Eliminacion de Process
-- Author      : jlousararian
-- Date        : 2006-10-27 05:02:04

DELETE FROM 
	Process
WHERE 
	(
	Name = @Name 
)

' 
END


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Process]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[Process](
	[Name] [varchar](255) NOT NULL,
	[Description] [varchar](1000) NOT NULL,
	[Handler] [varchar](255) NOT NULL,
	[Request] [varchar](255) NOT NULL,
	[Response] [varchar](255) NOT NULL,
	[Available] [varchar](5) NOT NULL,
	[Audit] [varchar](5) NOT NULL,
	[ProcessTransactionalBehaviour] [varchar](20) NOT NULL,
	[ProcessIsolationLevel] [varchar](20) NOT NULL,
	[Timeout] [int] NOT NULL,
	[Cacheable] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Process] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Name'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del proceso.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Name'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Description'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripción del proceso.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Description'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Handler'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del assembly y fullname de la clase de proceso.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Handler'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Request'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del assembly y fullname de la clase de request.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Request'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Response'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del assembly y fullname de la clase de response.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Response'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Available'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si el proceso está disponible para ser ejecutado. Valores posibles: true / false.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Available'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Audit'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Indica si la ejecución del proceso debe ser auditada o no. Valores posibles: true / false.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Audit'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'ProcessTransactionalBehaviour'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Define el comportamiento transaccional del proceso raíz.

*Required: el proceso transacciona. Si hay un ámbito transaccional ya abierto, utiliza el existente, en caso contrario crea una nueva transaccion.

*RequiresNew: Siempre se crea una nueva transacción.
 
*Suppress: no transacciona, todas las operaciones se hacen sin estar en un ámbito transaccional. ' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'ProcessTransactionalBehaviour'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'ProcessIsolationLevel'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Especifica el nivel de aislamiento de la transacción.

*Chaos: los cambios pendientes de transacciones más aisladas no puede ser sobreescritos.

*ReadCommitted: los datos volátites no puede ser leidos durante la transacción, pero pueden ser modificados.

*ReadUncommitted: los datos volátines pueden ser leidos y modificados durante la transacción.

*RepeatableRead: los datos volátiles pueden ser leidos pero no modificados durante la transación. Nuevos datos pueden ser creados.

*Serializable: los datos volátiles pueden ser leidos pero no modificados, y no es posible crear nuevos datos durante la transacción.

*Snapshot: los datos volátiles pueden ser leidos. Antes de modificarse datos,  se verifica que otra transacción los haya cambiado luego de haber sido leidos. Si los datos se actualizaron, se levanta un error.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'ProcessIsolationLevel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'USER',N'dbo', N'TABLE',N'Process', N'COLUMN',N'Timeout'))
EXEC dbo.sp_addextendedproperty @name=N'MS_Description', @value=N'Tiempo en segundos de duración de la transacción.' , @level0type=N'USER',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Process', @level2type=N'COLUMN',@level2name=N'Timeout'
