/****** Object:  StoredProcedure [dbo].[Verificar_tabla]    Script Date: 10/3/2017 6:10:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Verificar_tabla] @BD varchar(max),@tabla varchar(max)
AS
BEGIN
	Exec ('use '+ @BD+'; if object_id('''+@tabla+''') is not null
		select ''existe'' as Resultado')
	
END
