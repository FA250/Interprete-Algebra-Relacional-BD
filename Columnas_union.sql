USE [bdproy1]
GO
/****** Object:  StoredProcedure [dbo].[Columnas_cartesiano]    Script Date: 10/7/2017 6:50:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE Columnas_union @BD varchar(max), @tabla1 varchar(max),@tabla2 varchar(max)
AS
BEGIN
	declare @SP nvarchar(max)
	set @SP='use '+ @BD+ '; select * from  '+ @tabla1+' union select * from '+@tabla2

	Execute sp_describe_first_result_set @SP	
END
