USE [InterpreteSQL]
GO
/****** Object:  StoredProcedure [dbo].[Verificar_tabla]    Script Date: 10/3/2017 4:56:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Verificar_tabla] @BD varchar(20),@tabla varchar(20)
AS
BEGIN
	Exec ('use '+ @BD+'; if object_id('''+@tabla+''') is not null
		select ''existe'' as Resultado')
	
END
