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
alter PROCEDURE  cant_Columnas @BD varchar(max), @tabla varchar(max)
AS
BEGIN
	Execute('use '+ @BD+ '; SELECT count(COLUMN_NAME) as cantidad FROM diccionario WHERE TABLE_NAME = '''+@tabla+'''')
END
GO
