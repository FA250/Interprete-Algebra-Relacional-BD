/****** Object:  StoredProcedure [dbo].[Nombre_Columnas]    Script Date: 10/6/2017 4:47:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Nombre_Columnas] @BD varchar(max),@tabla varchar(max),@schema varchar(max)
AS
BEGIN

	Execute('use '+@BD+';SELECT COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = '''+@tabla+'''AND TABLE_SCHEMA='''+@schema+'''')
	
END
