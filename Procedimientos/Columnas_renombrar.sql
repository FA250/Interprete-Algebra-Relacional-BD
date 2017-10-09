/****** Object:  StoredProcedure [dbo].[Columnas_agregacion]    Script Date: 10/9/2017 12:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Columnas_renombrar @BD varchar(max), @tabla varchar(max), @nuevaTabla varchar(max),@atributos varchar(max)
AS
BEGIN
	execute('use '+ @BD+ '; select * into '+@nuevaTabla+' from (select '+@atributos+' from '+@tabla+') as origen')
	
END
