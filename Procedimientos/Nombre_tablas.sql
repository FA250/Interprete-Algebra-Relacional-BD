/****** Object:  StoredProcedure [dbo].[Nombre_tablas]    Script Date: 10/4/2017 11:21:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Nombre_tablas] @BD varchar(20)
AS
BEGIN
	Execute('use '+@BD+';SELECT TABLE_NAME,TABLE_SCHEMA
	FROM INFORMATION_SCHEMA.TABLES where TABLE_TYPE=''BASE TABLE''')
END
