-- vista diccionario

use Ventas
go
create view diccionario as(
SELECT a.TABLE_NAME,b.ORDINAL_POSITION,b.COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE,c.CONSTRAINT_TYPE as Primaria,d.CONSTRAINT_TYPE as Foranea,e.CHECK_CLAUSE
FROM INFORMATION_SCHEMA.TABLES  as a join INFORMATION_SCHEMA.COLUMNS as b on a.TABLE_NAME=b.TABLE_NAME
											left outer join (select cpo.TABLE_NAME,COLUMN_NAME,CONSTRAINT_TYPE from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cpo 
																											   join INFORMATION_SCHEMA.TABLE_CONSTRAINTS as cpd on cpo.CONSTRAINT_NAME= cpd.CONSTRAINT_NAME and cpd.CONSTRAINT_TYPE = 'PRIMARY KEY') as c
											on b.TABLE_NAME=c.TABLE_NAME and b.COLUMN_NAME=c.COLUMN_NAME
											left outer join(select cfo.TABLE_NAME,COLUMN_NAME,CONSTRAINT_TYPE from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cfo 
																											  join INFORMATION_SCHEMA.TABLE_CONSTRAINTS as cfd on cfo.CONSTRAINT_NAME= cfd.CONSTRAINT_NAME and cfd.CONSTRAINT_TYPE = 'FOREIGN KEY') as d
											on b.TABLE_NAME=d.TABLE_NAME and b.COLUMN_NAME=d.COLUMN_NAME
											left outer join(select cco.TABLE_NAME,COLUMN_NAME,CHECK_CLAUSE from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cco 
																										   join INFORMATION_SCHEMA.CHECK_CONSTRAINTS as ccd on cco.CONSTRAINT_NAME= ccd.CONSTRAINT_NAME) as e
											on b.TABLE_NAME=e.TABLE_NAME and b.COLUMN_NAME=e.COLUMN_NAME
where TABLE_TYPE='BASE TABLE')

drop view diccionario


--para realizar igualdad de tablas se realiza la diferencia simetrica de dominios, ademas de columnas de dominios iguales: diferencia (a,b), diferencia (b,a) e interseccion (a,b)

--si el resultado es [],[],[atr1,..,atrn]										de largo {0,0,n},
--ambas tablas poseen misma ariedad y dominios,

--si el resultado es [atr-i],[],[atr1,..,atrn], o [],[atr-j],[atr1,..,atrn]		de largo {m,0,n} o {0,m,n},
--ambas tablas poseen distinta ariedad y hay dominios diferentes, pero una tabla es subcojunto de la otra,

--si el resultado es [atr-i],[atr-j],[atr1,..,atrn]								de largo {m,m,n},
--ambas tablas poseen misma ariedad pero hay dominios diferentes,

--si el resultado es [atr1,..,atrm],[atr1,..,atrn],[]							de largo {m,m,0},
--ambas tablas poseen misma ariedad pero Todo dominio es diferente,

--si el resultado es [atr1,..,atrn],[atr1,..,atrm],[] 							de largo {n,m,0},
--ambas tablas poseen distinta ariedad y Todo dominio es diferente,

--con estas observaciones en cuenta es posible realizar todas las validaciones con solo esas 2 operaciones, pero hay 4 debido a la posibilidad de tomar el nombre de las colunas en cuenta

--atributos con mismo nombre y dominios similares
select tabla1.COLUMN_NAME
from
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = '<table1>') as tabla1
join
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = '<table2>') as tabla2
on (tabla1.ORDINAL_POSITION=tabla2.ORDINAL_POSITION and tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.CHARACTER_MAXIMUM_LENGTH=tabla2.CHARACTER_MAXIMUM_LENGTH and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE) 
or (tabla1.ORDINAL_POSITION=tabla2.ORDINAL_POSITION and tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.NUMERIC_PRECISION=tabla2.NUMERIC_PRECISION and tabla1.NUMERIC_SCALE=tabla2.NUMERIC_SCALE and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE)

--atributos con dominios similares
select tabla1.COLUMN_NAME
from
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = '<table1>') as tabla1
join
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = '<table2>') as tabla2
on (tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.CHARACTER_MAXIMUM_LENGTH=tabla2.CHARACTER_MAXIMUM_LENGTH and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE) 
or (tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.NUMERIC_PRECISION=tabla2.NUMERIC_PRECISION and tabla1.NUMERIC_SCALE=tabla2.NUMERIC_SCALE and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE)


--diferencia de atributos tomando nombre en cuenta
SELECT COLUMN_NAME
FROM diccionario
WHERE TABLE_NAME = '<table1>' and COLUMN_NAME not in(
select tabla1.COLUMN_NAME
from
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = '<table1>') as tabla1
join
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = '<table2>') as tabla2
on (tabla1.ORDINAL_POSITION=tabla2.ORDINAL_POSITION and tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.CHARACTER_MAXIMUM_LENGTH=tabla2.CHARACTER_MAXIMUM_LENGTH and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE) 
or (tabla1.ORDINAL_POSITION=tabla2.ORDINAL_POSITION and tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.NUMERIC_PRECISION=tabla2.NUMERIC_PRECISION and tabla1.NUMERIC_SCALE=tabla2.NUMERIC_SCALE and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE))

--diferencia de atributos
SELECT COLUMN_NAME
FROM diccionario
WHERE TABLE_NAME = '<table1>' and COLUMN_NAME not in(
select tabla1.COLUMN_NAME
from
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = '<table1>') as tabla1
join
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = '<table2>') as tabla2
on (tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.CHARACTER_MAXIMUM_LENGTH=tabla2.CHARACTER_MAXIMUM_LENGTH and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE) 
or (tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.NUMERIC_PRECISION=tabla2.NUMERIC_PRECISION and tabla1.NUMERIC_SCALE=tabla2.NUMERIC_SCALE and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE))