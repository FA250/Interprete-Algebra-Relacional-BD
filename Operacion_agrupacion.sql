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
alter PROCEDURE Operacion_agrupacion @BD varchar(max), @tabla1 varchar(max), @agrupacion varchar(max), @funAgregacion varchar(max)
AS
BEGIN
	execute('use '+ @BD + '; select '+@agrupacion+@funAgregacion+' from '+@tabla1+' group by '+@agrupacion)
END
GO
