create database bdproy1
go
create schema proy1
go

create user dbaproy1

grant all on bdproy1 to dbaproy1

create user usproy1

grant select on 'tablas permanentes' to usproy1

--grant all on 'tablas temporales' to usproy1
