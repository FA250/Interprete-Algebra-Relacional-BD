/****** Object:  StoredProcedure [dbo].[Columnas_cartesiano]    Script Date: 10/7/2017 3:37:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE Columnas_agrupacion @BD varchar(max), @tabla1 varchar(max),@agrupacion varchar(max),@funAgregacion varchar(max)
AS
BEGIN
	declare @SP nvarchar(max)
	set @SP='use '+ @BD+ '; select '+@agrupacion+@funAgregacion+' from '+@tabla1+' group by '+@agrupacion

	Execute sp_describe_first_result_set @SP	
END
