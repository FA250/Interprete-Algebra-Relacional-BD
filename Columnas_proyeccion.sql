USE [bdproy1]
GO
/****** Object:  StoredProcedure [dbo].[Columnas_agregacion]    Script Date: 10/7/2017 7:05:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE Columnas_proyeccion @BD varchar(max),  @atributos varchar(max),@tabla varchar(max)
AS
BEGIN
	declare @SP nvarchar(max)
	set @SP='use '+ @BD+ '; select '+ @atributos+' from '+@tabla

	Execute sp_describe_first_result_set @SP	
END
