/****** Object:  StoredProcedure [dbo].[Seleccion]    Script Date: 10/3/2017 6:00:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David
-- Create date: 
-- Description:	Prueba
-- =============================================
create PROCEDURE [dbo].[Seleccion] @BD varchar(max),@tabla varchar(max), @predicado varchar(max)

AS
BEGIN
	Execute('use '+@BD+'; select * from ' +@tabla+ ' where ' +@predicado)
END
