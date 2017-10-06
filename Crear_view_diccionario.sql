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
alter PROCEDURE Crear_view_diccionario @BD varchar(max)
AS
BEGIN
	declare @crearView nvarchar(max)

	SET @crearView =  N'EXEC ' + @BD + '.sys.sp_executesql '
	+ 'N''create view diccionario as(
			SELECT a.TABLE_NAME,b.COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE,c.CONSTRAINT_TYPE as Primaria,d.CONSTRAINT_TYPE as Foranea,e.CHECK_CLAUSE
			FROM INFORMATION_SCHEMA.TABLES  as a join INFORMATION_SCHEMA.COLUMNS as b on a.TABLE_NAME=b.TABLE_NAME
														left outer join (select cpo.TABLE_NAME,COLUMN_NAME,CONSTRAINT_TYPE from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cpo 
																														   join INFORMATION_SCHEMA.TABLE_CONSTRAINTS as cpd on cpo.CONSTRAINT_NAME= cpd.CONSTRAINT_NAME and cpd.CONSTRAINT_TYPE = ''''PRIMARY KEY'''') as c
														on b.TABLE_NAME=c.TABLE_NAME and b.COLUMN_NAME=c.COLUMN_NAME
														left outer join(select cfo.TABLE_NAME,COLUMN_NAME,CONSTRAINT_TYPE from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cfo 
																														  join INFORMATION_SCHEMA.TABLE_CONSTRAINTS as cfd on cfo.CONSTRAINT_NAME= cfd.CONSTRAINT_NAME and cfd.CONSTRAINT_TYPE = ''''FOREIGN KEY'''') as d
														on b.TABLE_NAME=d.TABLE_NAME and b.COLUMN_NAME=d.COLUMN_NAME
														left outer join(select cco.TABLE_NAME,COLUMN_NAME,CHECK_CLAUSE from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cco 
																													   join INFORMATION_SCHEMA.CHECK_CONSTRAINTS as ccd on cco.CONSTRAINT_NAME= ccd.CONSTRAINT_NAME) as e
														on b.TABLE_NAME=e.TABLE_NAME and b.COLUMN_NAME=e.COLUMN_NAME
			where TABLE_TYPE=''''BASE TABLE'''')''';

	EXEC sys.sp_executesql @crearView;
	
END
GO
