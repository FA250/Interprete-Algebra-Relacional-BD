GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE Columnas_agregacion @BD varchar(max), @tabla1 varchar(max),@funAgregacion varchar(max)
AS
BEGIN
	declare @SP nvarchar(max)
	set @SP='use '+ @BD+ '; select '+@funAgregacion+' from '+@tabla1

	Execute sp_describe_first_result_set @SP	
END
