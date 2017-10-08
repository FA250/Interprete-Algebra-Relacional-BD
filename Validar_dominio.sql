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
CREATE PROCEDURE Validar_dominio @BD varchar(max),@tabla1 varchar(max),@tabla2 varchar(max)
AS
BEGIN
--diferencia simetrica
	Execute('use '+@BD+
			'; SELECT COLUMN_NAME,ORDINAL_POSITION,TABLE_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION
				FROM diccionario
				WHERE (TABLE_NAME = '''+@tabla1+''' or TABLE_NAME = '''+@tabla2+''')  and COLUMN_NAME not in(
				select tabla1.COLUMN_NAME
				from
				(SELECT ORDINAL_POSITION,COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
				FROM diccionario
				WHERE TABLE_NAME = '''+@tabla1+''') as tabla1
				join
				(SELECT ORDINAL_POSITION,COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
				FROM diccionario
				WHERE TABLE_NAME = '''+@tabla2+''') as tabla2
				on (tabla1.ORDINAL_POSITION=tabla2.ORDINAL_POSITION and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.CHARACTER_MAXIMUM_LENGTH=tabla2.CHARACTER_MAXIMUM_LENGTH and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE) 
				or (tabla1.ORDINAL_POSITION=tabla2.ORDINAL_POSITION and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.NUMERIC_PRECISION=tabla2.NUMERIC_PRECISION and tabla1.NUMERIC_SCALE=tabla2.NUMERIC_SCALE and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE))
				order by ORDINAL_POSITION'
	)
END
GO
