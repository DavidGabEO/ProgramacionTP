
--Procedimientos almacenados

select * from detallescarreras where id_carrera = 22
select * from asignaturas where id_asignatura = 2 
select * from carreras where id_carrera = 20

--Borrar Carrera y detalles por id
CREATE PROCEDURE SP_BORRAR_CARRERA_Y_DETALLES
@idCarrera int
AS
BEGIN

DELETE FROM DETALLESCARRERAS WHERE id_carrera = @idCarrera
DELETE FROM CARRERAS WHERE id_carrera =@idCarrera

END


--Delete de asignatura (y detalles donde este la asignatura antes)

CREATE PROCEDURE SP_BORRAR_ASIGNATURA_Y_DETALLES
@idAsignatura int
AS
BEGIN
DELETE FROM DETALLESCARRERAS WHERE id_asignatura = @idAsignatura

DELETE FROM ASIGNATURAS WHERE id_asignatura = @idAsignatura

END



--Output de id carrera introduciend el nombre de la carrera 
CREATE PROCEDURE SP_CONSEGUIR_ID_CARRERA
@nombre varchar(100),
@id int output
AS
BEGIN

SET @id = (select id_carrera from CARRERAS where nombre = @nombre)

END

--set @id_carrera = (select MAX(id_carrera)+1 FROM CARRERAS)

select * from carreras;

CREATE PROCEDURE SP_PARA_REPORTE
@nombre varchar(100)
AS
BEGIN

select a.nombre AS Asignatura, tc.tipoCursada  AS Cursado, dc.anioCursado AS Año  
from detallescarreras dc join asignaturas a on dc.id_asignatura = a.id_asignatura
join TIPOS_CURSADAS tc on dc.id_tipo_cursada = tc.id_tipo_cursada
join CARRERAS c on dc.id_carrera = c.id_carrera
where c.nombre = @nombre
order by dc.anioCursado, tc.tipoCursada 
END


-- SP Report Rocio 
CREATE PROCEDURE [dbo].[SP_CARRERAS]
@tipo int
AS
BEGIN 

if @tipo = 0 or @tipo = -1
SELECT        ASIGNATURAS.nombre AS Asignatura, CARRERAS.nombre AS Carrera, CARRERAS.titulo AS Titulo, TIPOS_CARRERAS.tipoCarrera AS Tipo
FROM            ASIGNATURAS INNER JOIN
                         DETALLESCARRERAS ON ASIGNATURAS.id_asignatura = DETALLESCARRERAS.id_asignatura INNER JOIN
                         CARRERAS ON DETALLESCARRERAS.id_carrera = CARRERAS.id_carrera INNER JOIN
                         TIPOS_CARRERAS ON CARRERAS.id_tipo_carrera = TIPOS_CARRERAS.id_tipo_carrera


if @tipo is not null
SELECT        ASIGNATURAS.nombre AS Asignatura, CARRERAS.nombre AS Carrera, CARRERAS.titulo AS Titulo, TIPOS_CARRERAS.tipoCarrera AS Tipo
FROM            ASIGNATURAS INNER JOIN
                         DETALLESCARRERAS ON ASIGNATURAS.id_asignatura = DETALLESCARRERAS.id_asignatura INNER JOIN
                         CARRERAS ON DETALLESCARRERAS.id_carrera = CARRERAS.id_carrera INNER JOIN
                         TIPOS_CARRERAS ON CARRERAS.id_tipo_carrera = TIPOS_CARRERAS.id_tipo_carrera
						 WHERE TIPOS_CARRERAS.id_tipo_carrera = @tipo
END






--Para quitar asignatura de detalle
CREATE PROCEDURE SP_BORRAR_DETALLE_ASIGNATURA
@id int
AS
BEGIN

DELETE FROM DETALLESCARRERAS WHERE id_asignatura = @id

END



select * from DETALLESCARRERAS


--Borrar usuarios
CREATE PROCEDURE SP_BORRAR_USUARIO
@usuario varchar(50)
AS
BEGIN

Delete from usuarios  where usuario = @usuario 

END



--Consultar usuarios
CREATE PROCEDURE SP_CONSULTAR_USUARIOS
AS
BEGIN

select * from usuarios
END


--Consultar carreras que tienen una materia

CREATE PROCEDURE SP_CARRERAS_POR_MATERIA
@nombre varchar(50)
AS
BEGIN

select c.id_carrera, c.nombre, c.titulo, tcr.tipoCarrera, a.nombre, dc.anioCursado,tc.tipoCursada 
from DETALLESCARRERAS dc join CARRERAS c on dc.id_carrera = c.id_carrera
join ASIGNATURAS a on a.id_asignatura = dc.id_asignatura
join TIPOS_CURSADAS tc on tc.id_tipo_cursada = dc.id_tipo_cursada
join TIPOS_CARRERAS tcr on tcr.id_tipo_carrera = c.id_tipo_carrera 
where a.nombre like @nombre + '%'
END

--Consultar materias que tiene una carrera
DROP PROCEDURE SP_MATERIAS_POR_CARRERA
CREATE PROCEDURE SP_MATERIAS_POR_CARRERA
@nombre varchar (100) = null,
@titulo varchar (100) = null
as
begin
select dc.id_asignatura, a.nombre, tc.tipoCursada, dc.anioCursado  from CARRERAS c 
join  DETALLESCARRERAS dc on c.id_carrera = dc.id_carrera
join ASIGNATURAS a on a.id_asignatura = dc.id_asignatura
join TIPOS_CURSADAS tc on tc.id_tipo_cursada = dc.id_tipo_cursada
where (c.nombre = @nombre  or c.titulo= @titulo)
order by dc.anioCursado, tc.tipoCursada
end
--Consultar carreras

CREATE PROCEDURE SP_CONSULTAR_CARRERAS
AS
BEGIN

select * from carreras order by id_tipo_carrera, nombre

END

select * from asignaturas
--Insertar Asignatura
CREATE PROCEDURE SP_INSERTAR_ASIGNATURA
@nombre varchar(150)
AS
BEGIN

declare @id int
select @id = ( max(id_asignatura))+1  from asignaturas

insert into ASIGNATURAS(id_asignatura, nombre)
values(@id, @nombre)

END


--Consultar asignaturas
CREATE PROCEDURE SP_CONSULTAR_ASIGNATURAS
AS
BEGIN

SELECT * FROM ASIGNATURAS

END

--Consultar tipos cursadas (Para cargar combo)
CREATE PROCEDURE SP_CONSULTAR_TIPOS_CURSADAS
AS
BEGIN

SELECT * FROM TIPOS_CURSADAS


END


--Consultar tipos carreras (Para cargar combo)
CREATE PROCEDURE SP_CONSULTAR_TIPOS_CARRERAS
AS
BEGIN

SELECT * FROM TIPOS_CARRERAS

END
select * from asignaturas
drop procedure sp_insertar_carrera
--Insertar Carrera (Esto va a necesitar un output)
create PROCEDURE SP_INSERTAR_CARRERA
@nombre varchar(50),
@titulo varchar(50),
@id_tipo_carrera int,
@id_carrera int output
AS
BEGIN


set @id_carrera = (select MAX(id_carrera)+1 FROM CARRERAS)
if @id_carrera is null
begin
SET @id_carrera =1
end

 INSERT INTO carreras(id_carrera, nombre, titulo, id_tipo_carrera)
 VALUES (@id_carrera, @nombre, @titulo, @id_tipo_carrera)

END

select * from DETALLESCARRERAS

-- Insertar DetalleCarrera 

CREATE PROCEDURE SP_INSERTAR_DETALLESCARRERAS
@id_carrera int,
@id_asignatura int,
@anioCursado int,
@id_tipo_cursada int
AS
BEGIN

INSERT INTO DETALLESCARRERAS(id_carrera, id_asignatura, anioCursado, id_tipo_cursada)
VALUES (@id_carrera, @id_asignatura, @anioCursado, @id_tipo_cursada)


END


select * from TIPOS_CURSADAS


select * from detallescarreras
select * from carreras

insert into carreras(id_carrera, nombre, titulo, id_tipo_carrera)
values( 1, 'Lala', 'Lolo', 1)


select c.id_carrera, c.nombre, a.nombre from carreras c join DETALLESCARRERAS dc on c.id_carrera = dc.id_carrera 
join ASIGNATURAS a on a.id_asignatura = dc.id_asignatura


insert into asignaturas(id_asignatura, nombre)
values(2, 'Laboratorio I')