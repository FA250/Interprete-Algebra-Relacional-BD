USE [InterpreteSQL]
GO
/****** Object:  StoredProcedure [dbo].[Nombre_Columnas]    Script Date: 10/3/2017 4:54:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Nombre_Columnas] @BD varchar(20),@tabla varchar(20)
AS
BEGIN
	Execute('use '+@BD+';SELECT COLUMN_NAME 
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = '''+@tabla+''' AND TABLE_SCHEMA=''dbo''')
	
END
