USE [bdproy1]
GO
/****** Object:  StoredProcedure [dbo].[Operacion_join]    Script Date: 10/9/2017 11:31:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
alter PROCEDURE Operacion_natural_join  @BD varchar(max),@tabla1 varchar(max),@table2 varchar(max),@predicado varchar(max),@atributos varchar(max)
AS
BEGIN
	execute('use '+@BD+'; select '+@atributos+' from '+@tabla1+' join '+@table2+' on '+@predicado) 
END
