/****** Object:  StoredProcedure [dbo].[Columnas_join]    Script Date: 10/9/2017 11:33:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE Columnas_natural_join @BD varchar(max), @tabla1 varchar(max),@tabla2 varchar(max), @predicado varchar(max)
AS
BEGIN

	declare @SP nvarchar(max)
	set @SP='use '+ @BD+ '; select * from  '+ @tabla1+' join '+@tabla2+' on '+@predicado

	Execute sp_describe_first_result_set @SP
	
END
