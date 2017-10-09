/****** Object:  StoredProcedure [dbo].[Validar_dominio]    Script Date: 10/8/2017 4:13:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE Atributos_iguales @BD varchar(max),@tabla1 varchar(max),@tabla2 varchar(max)
AS
BEGIN
--atributos con mismo nombre y dominios similares

	Execute('use '+@BD+
			'; select tabla1.COLUMN_NAME
				from
				(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
				FROM diccionario
				WHERE TABLE_NAME = '''+@tabla1+''') as tabla1
				join
				(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
				FROM diccionario
				WHERE TABLE_NAME = '''+@tabla2+''') as tabla2
				on (tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.CHARACTER_MAXIMUM_LENGTH=tabla2.CHARACTER_MAXIMUM_LENGTH and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE) 
				or (tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.NUMERIC_PRECISION=tabla2.NUMERIC_PRECISION and tabla1.NUMERIC_SCALE=tabla2.NUMERIC_SCALE and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE)'
	)
END
