/****** Object:  StoredProcedure [dbo].[Operacion_division]    Script Date: 10/8/2017 5:16:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Operacion_division] @BD varchar(max),@tabla1 varchar(max),@tabla2 varchar(max), @atributos varchar(max), @predicado1 varchar(max),@predicado2 varchar(max)
AS
BEGIN

--select distinct <lista_atributos_dif>
--from <table1> as t1s
--where not exists(select *   
--				 from <table2> as t2s
--				 where not exists(select * 
--								  from <table1> as t1i
--								  where (t1i.<lista_atrib_igual> = t2s.<lista_atrib_igual>) and (t1i.<lista_atributos_dif> = t1s.<lista_atributos_dif>)))
	execute('use '+@BD+'; select distinct '+@atributos+'
							from '+@tabla1+' as t1s
							where not exists(select *   
											 from '+@tabla2+' as t2s
											 where not exists(select * 
															  from '+@tabla1+' as t1i						
															  where ('+@predicado1+') and ('+@predicado2+')))')
END
