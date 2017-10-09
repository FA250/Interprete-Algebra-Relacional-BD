-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE Crear_tabla_temp @BD varchar(max), @tabla varchar(max),@consulta varchar(max)
AS
BEGIN
	execute( 'use '+@BD+'; IF OBJECT_ID('''+@tabla+''', ''U'') IS NOT NULL 
	DROP TABLE '+@tabla+'; ')
	execute('use '+@BD+'; select * into '+ @tabla+' from ('+@consulta+') as origen')
END
GO