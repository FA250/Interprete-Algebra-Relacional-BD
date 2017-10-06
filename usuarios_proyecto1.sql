create database bdproy1
go
create schema proy1
go

create user dbaproy1

grant all on bdproy1 to dbaproy1

create user usproy1

grant select on 'tablas permanentes' to usproy1

--grant all on 'tablas temporales' to usproy1

-- opciones para creacion de usuarios, manejo de permisos incompleto

create database bdproy1
go
create schema proy1
go
--crear usuario con login y contraseñas
use bdproy1
create login dbaproy1 with password = 'password'
create user dbaproy1 for login dbaproy1 with DEFAULT_SCHEMA = proy1;
grant DELETE, INSERT, REFERENCES, UPDATE, SELECT on schema ::proy1 to dbaproy1
--crear usuario sin login
create user usproy1 without login WITH DEFAULT_SCHEMA = proy1;
-- ejemplo de como crear 'denegar acceso' de cada tabla
use Ventas

SELECT 'DENY DELETE, INSERT, REFERENCES, UPDATE ON ' + TABLE_SCHEMA + '.' + TABLE_NAME + ' TO usproy1' FROM information_schema.tables WHERE TABLE_SCHEMA='dbo'
