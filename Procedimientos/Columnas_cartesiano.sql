/****** Object:  StoredProcedure [dbo].[Columnas_cartesiano]    Script Date: 10/6/2017 10:03:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[Columnas_cartesiano] @BD varchar(max), @tabla1 varchar(max),@tabla2 varchar(max)
AS
BEGIN
	declare @SP nvarchar(max)
	set @SP='use '+ @BD+ '; select * from  '+ @tabla1+','+@tabla2

	Execute sp_describe_first_result_set @SP	
END
