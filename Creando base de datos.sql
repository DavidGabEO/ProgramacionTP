--Create database GestionCarreras

--Use GestionCarreras

--drop database GestionCarreras           
										

													--Tipo asignatura pasada a detalle
Create table ASIGNATURAS(id_asignatura int, nombre varchar(80), 
constraint pk_asignatura primary key (id_asignatura),)

Create table TIPOS_CARRERAS(id_tipo_carrera int, tipoCarrera varchar(50)
constraint pk_tipos_carreras primary key (id_tipo_carrera))

Create table CARRERAS(id_carrera int, nombre varchar(50), titulo varchar(50), id_tipo_carrera int
constraint pk_carreras primary key (id_carrera)
constraint fk_tipo_carrera_carrera foreign key (id_tipo_carrera) references TIPOS_CARRERAS(id_tipo_carrera))

Create table TIPOS_CURSADAS(id_tipo_cursada int, tipoCursada varchar(40)
constraint pk_tipos_cursadas primary key (id_tipo_cursada))
	
Create table DETALLESCARRERAS ( id_carrera int, id_asignatura int, anioCursado int, id_tipo_cursada int
constraint pk_detallescarreras primary key (id_carrera, id_asignatura),
constraint fk_detalles_carrera foreign key (id_carrera) references CARRERAS(id_carrera),
constraint fk_detalles_asignatura foreign key (id_asignatura) references ASIGNATURAS(id_asignatura),
constraint fk_cursadas_detalles foreign key (id_tipo_cursada) references TIPOS_CURSADAS(id_tipo_cursada) )




---Inserts basicos

insert into TIPOS_CARRERAS(id_tipo_carrera, tipoCarrera)
values (1, 'Grado'), (2, 'Posgrado'), (3,'Tecnicatura'), (4,'Diplomatura')

insert into TIPOS_CURSADAS (id_tipo_cursada, tipoCursada)
values (1, 'Primer cuatrimestre'), (2,'Segundo Cuatrimestre'), (3,'Anual')

insert into ASIGNATURAS (id_asignatura, nombre)
values (1, 'Programacion II')

select * from asignaturas 

select * from tipos_carreras