USE [InterpreteSQL]
GO
/****** Object:  StoredProcedure [dbo].[Seleccion]    Script Date: 10/3/2017 4:55:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David
-- Create date: 
-- Description:	Prueba
-- =============================================
ALTER PROCEDURE [dbo].[Seleccion] @BD varchar(20),@tabla varchar(20), @predicado varchar(40)

AS
BEGIN
	Execute('use '+@BD+'; select * from ' +@tabla+ ' where ' +@predicado)
END
