USE [bdproy1]
GO
/****** Object:  StoredProcedure [dbo].[Columnas_union]    Script Date: 10/8/2017 6:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE Columnas_diferencia @BD varchar(max), @tabla1 varchar(max),@tabla2 varchar(max)
AS
BEGIN
	declare @SP nvarchar(max)
	set @SP='use '+ @BD+ '; select * from '+@tabla1+' except select * from '+@tabla2

	Execute sp_describe_first_result_set @SP	
END
