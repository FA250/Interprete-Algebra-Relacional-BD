USE [InterpreteSQL]
GO
/****** Object:  StoredProcedure [dbo].[Verificar_BD]    Script Date: 10/3/2017 4:55:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[Verificar_BD] @BD varchar(20)
AS
BEGIN
	if db_id(@BD) is not null
		select 'existe' as Resultado
END
