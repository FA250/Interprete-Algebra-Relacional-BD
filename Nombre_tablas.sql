USE [bdproy1]
GO
/****** Object:  StoredProcedure [dbo].[Nombre_tablas]    Script Date: 10/3/2017 9:10:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Nombre_tablas] @BD varchar(20)
AS
BEGIN
	Execute('use '+@BD+';SELECT TABLE_NAME,TABLE_SCHEMA
	FROM INFORMATION_SCHEMA.TABLES')
END
