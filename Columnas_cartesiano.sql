-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
alter PROCEDURE Columnas_cartesiano @BD varchar(max), @tabla1 varchar(max),@tabla2 varchar(max)
AS
BEGIN
	declare @crearView nvarchar(max)

	SET @crearView =  N'EXEC ' + @BD + '.sys.sp_executesql '
	+ 'N''create view producCartesiano as (select * from  '+ @tabla1+','+@tabla2+')''';

	EXEC sys.sp_executesql @crearView;

	Execute('use '+@BD+';SELECT COLUMN_NAME
	FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_NAME = ''producCartesiano''')

	Execute('use '+@BD+'; drop view producCartesiano')
	
END
GO

