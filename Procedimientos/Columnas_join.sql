/****** Object:  StoredProcedure [dbo].[Columnas_cartesiano]    Script Date: 10/6/2017 9:06:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE Columnas_join @BD varchar(max), @tabla1 varchar(max),@tabla2 varchar(max), @predicado varchar(max)
AS
BEGIN

	declare @SP nvarchar(max)
	set @SP='use '+ @BD+ '; select * from  '+ @tabla1+' join '+@tabla2+' on '+@predicado

	Execute sp_describe_first_result_set @SP
	
END
