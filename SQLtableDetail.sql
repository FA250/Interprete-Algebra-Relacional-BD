--http://weblogs.sqlteam.com/joew/archive/2008/04/27/60574.aspx
use Ventas

--ver lista tablas de base
go
create view diccionario as(
SELECT a.TABLE_NAME,b.COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE,c.CONSTRAINT_TYPE as Primaria,d.CONSTRAINT_TYPE as Foranea,e.CHECK_CLAUSE
FROM Ventas.INFORMATION_SCHEMA.TABLES  as a join Ventas.INFORMATION_SCHEMA.COLUMNS as b on a.TABLE_NAME=b.TABLE_NAME
											left outer join (select cpo.TABLE_NAME,COLUMN_NAME,CONSTRAINT_TYPE from Ventas.INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cpo 
																											   join Ventas.INFORMATION_SCHEMA.TABLE_CONSTRAINTS as cpd on cpo.CONSTRAINT_NAME= cpd.CONSTRAINT_NAME and cpd.CONSTRAINT_TYPE = 'PRIMARY KEY') as c
											on b.TABLE_NAME=c.TABLE_NAME and b.COLUMN_NAME=c.COLUMN_NAME
											left outer join(select cfo.TABLE_NAME,COLUMN_NAME,CONSTRAINT_TYPE from Ventas.INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cfo 
																											  join Ventas.INFORMATION_SCHEMA.TABLE_CONSTRAINTS as cfd on cfo.CONSTRAINT_NAME= cfd.CONSTRAINT_NAME and cfd.CONSTRAINT_TYPE = 'FOREIGN KEY') as d
											on b.TABLE_NAME=d.TABLE_NAME and b.COLUMN_NAME=d.COLUMN_NAME
											left outer join(select cco.TABLE_NAME,COLUMN_NAME,CHECK_CLAUSE from Ventas.INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as cco 
																										   join Ventas.INFORMATION_SCHEMA.CHECK_CONSTRAINTS as ccd on cco.CONSTRAINT_NAME= ccd.CONSTRAINT_NAME) as e
											on b.TABLE_NAME=e.TABLE_NAME and b.COLUMN_NAME=e.COLUMN_NAME
where TABLE_TYPE='BASE TABLE'
)
go
--drop view diccionario


--atributos con mismo nombre y dominios similares
select tabla1.COLUMN_NAME --,tabla2.COLUMN_NAME,tabla1.DATA_TYPE,tabla1.CHARACTER_MAXIMUM_LENGTH,tabla1.NUMERIC_PRECISION,tabla1.NUMERIC_SCALE,tabla1.IS_NULLABLE
from
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = 'lineas_de_facturas') as tabla1
join
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = 'productos') as tabla2
on (tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.CHARACTER_MAXIMUM_LENGTH=tabla2.CHARACTER_MAXIMUM_LENGTH and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE) 
or (tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.NUMERIC_PRECISION=tabla2.NUMERIC_PRECISION and tabla1.NUMERIC_SCALE=tabla2.NUMERIC_SCALE and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE)

--diferencia de atributos
SELECT COLUMN_NAME
FROM diccionario
WHERE TABLE_NAME = 'lineas_de_facturas' and COLUMN_NAME not in(
select tabla1.COLUMN_NAME
from
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = 'lineas_de_facturas') as tabla1
join
(SELECT COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,IS_NULLABLE
FROM diccionario
WHERE TABLE_NAME = 'productos') as tabla2
on (tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.CHARACTER_MAXIMUM_LENGTH=tabla2.CHARACTER_MAXIMUM_LENGTH and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE) 
or (tabla1.COLUMN_NAME=tabla2.COLUMN_NAME and tabla1.DATA_TYPE=tabla2.DATA_TYPE and tabla1.NUMERIC_PRECISION=tabla2.NUMERIC_PRECISION and tabla1.NUMERIC_SCALE=tabla2.NUMERIC_SCALE and tabla1.IS_NULLABLE=tabla2.IS_NULLABLE))

go
--seleccion
--select * from <table> where <predicado>
--proyeccion
--select <lista_atributos> from <table>
--union
--select * from <table1> union select * from <table2>
--diferencia
--select * from <table1> except select * from <table2>
--producto cartesiano
--select * from <table1>,<table2>
--interseccion
--select * from <table1> intersect select * from <table2>
-- division

--select distinct lista_atributos_dif
--from <table1> as t1s
--where not exists(select *   
--				 from Tabla2 as t2s
--				 where not exists(select * 
--								  from Tabla1 as t1i
--								  where (t1i.lista_atrib_igual = t2s.lista_atrib_igual) and (t1i.lista_atributos_dif = t1s.lista_atributos_dif)))

-- renombrar
--select * into <table1> from (select <atrib1> as <newAtrib1>,<atribn> as <newAtribn> from cantones) as origen
-- join
--select * from <table1>join<table2> on <predicado>
-- natural join
-- select * from <table1>join<table2> on <table1.nombreAtrib=table2.nombreAtrib>
-- agregacion
-- select <lista_funciones_atrib> from <table1>
-- agrupacion
-- select <lista_atrib_agrup->,<lista_funciones_atrib> from <table1> group by <lista_atrib_agrup+>
--ver tablas
select COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,Primaria,Foranea,CHECK_CLAUSE from diccionario where TABLE_NAME='provincias'
--ver referencia crusada
select COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,Primaria,Foranea,CHECK_CLAUSE from diccionario where COLUMN_NAME='id_provincia'
select TABLE_NAME from diccionario where COLUMN_NAME='id_provincia'