create database coppel
use coppel
--1. tabla centro de trabajo 
create table centro_de_trabajo ( Numero_Centro int primary key , cuidad varchar ( 100 ), Nombre_Centro varchar ( 150 ) ); 
--2. Tabla Puesto
create table ID_Puesto ( Numero_Puesto int primary key , Nombre_Puesto varchar ( 100 ) , Direcion_Departamento varchar ( 100 )
) ; 
-- 3. tabla empleado
-- incluye las llaves foraneas para la relacion `` Trabaja`` y ``Tiene``
create table empleado ( Numero_Empledo int primary key , Nombre varchar ( 100 ) not null ,
Apellido_Paterno varchar ( 100 ) not null , Apellido_Materno varchar  ( 100 ) , Fecha_Nacimineto date , 
RFC varchar ( 13) unique , Numero_Centro varchar ( 100 ) 
-- relacion con Centro de Trabajo FK_Numero_Centro int ,
-- relacion con puesto FK_Numero_Puesto int ,
-- atributos adicionales es_Directivo bit default , 
constraint FK_Numero_CENTRO foreign key ( Nombre_Centro ) references Centro_De_Trabajo ( Numero_Centro ) ,
constraint  FK_Empleado_Puesto foreign key ( Numero_Puesto ) references ID_Puesto ( Numero_Puesto ) ) ; 
--4. tabla para el rol de directivo ( Especializacion)
create table Directivo_info (FK_Numero_Empleado int primary key , Numero_Centro_Supervisa int , presentacion_Combustible money 

constraint FK_Directivo_Empleado foreign key (FK_Numero_Empleado) references Empleado ( Numero_Empleado );