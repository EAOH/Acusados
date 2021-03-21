set language 'SPANISH'
--Usar Master
use master

--Crear la Base de datos
create database BDAcusados
go

--Posicionarnos en nuestra BD
use BDAcusados
go

--Creacion de Tablas

--Acusado
create table TBL_Acusado(
Acu_CA int identity(1,1) primary key,
Acu_Nombre1 varchar(50) not null,
Acu_Nombre2 varchar(50) not null,
Acu_Apellido1 varchar(50) not null,
Acu_Apellido2 varchar(50) not null,
Acu_ID varchar(15) unique not null,
Acu_Genero varchar(10) check(Acu_Genero in ('Masculino','Femenino')) not null,
Acu_Estado_Civil varchar(8) check(Acu_Estado_Civil in ('Soltero','Casado')) not null,
Acu_Alias varchar(50),
Acu_Nivel_Edu varchar (15) check (Acu_Nivel_Edu in ('Analfabeta','Preescolar','Primaria','Secundaria','Profesionista','Licenciado','Maestría','Doctorado')) not null,
Acu_Pais varchar (50) not null,
Acu_Depto varchar(50) not null,
Acu_Ciudad varchar(50) not null,
Acu_Calle varchar(50) not null,
Acu_Extra varchar(100),
Acu_Nacido_el date not null,
Acu_Nacionalidad varchar(50) not null,
Acu_Pais_Nacido varchar(50) not null,
Acu_Depto_Nacido varchar(50) not null,
Acu_Ciudad_Nacido varchar(50) not null,
Acu_Altura_m decimal (3,2) not null,
Acu_Peso_lb decimal (6,2) not null,
Acu_Piel varchar (10) check (Acu_Piel in ('Albino','Blanco','Afro','Trigueño')) not null,
Acu_Pelo varchar (10) check (Acu_Pelo in ('Negro','Castaño','Rubio','Pelirrojo')) not null,
Acu_Ojos varchar (10) check (Acu_Ojos in ('Cafés','Azules','Verdes','Grises')) not null,
Acu_Ocupacion varchar (50),
)

--Email del Acusado
create table TBL_Acusado_Email(
Acu_CA int,
Acu_Email varchar(100),
primary key (Acu_CA,Acu_Email),
foreign key (Acu_CA) references TBL_Acusado(Acu_CA) on delete cascade
)

--Rasgo del Acusado
create table TBL_Acusado_Rasgo(
Acu_CA int,
Acu_Rasgo varchar(100),
primary key (Acu_CA,Acu_Rasgo),
foreign key (Acu_CA) references TBL_Acusado(Acu_CA) on delete cascade
)

--Historial del Acusado
create table TBL_Acusado_Historial(
Acu_CA int,
Acu_Delito varchar(50),
Acu_Descripcion varchar(100) not null,
primary key (Acu_CA,Acu_Delito,Acu_Descripcion),
foreign key (Acu_CA) references TBL_Acusado(Acu_CA) on delete cascade
)

--Teléfono del Acusado
create table TBL_Acusado_Tel(
Acu_CA int,
Acu_Tel varchar(15),
primary key (Acu_CA,Acu_Tel),
foreign key (Acu_CA) references TBL_Acusado(Acu_CA) on delete cascade
)

--Foto del Acusado
create table TBL_Acusado_Foto(
Acu_CA int,
Acu_Foto image,
Acu_Posicion varchar(20) check(Acu_Posicion in ('Frente','Perfil izquierdo','Perfil derecho')),
primary key (Acu_CA,Acu_Posicion),
foreign key (Acu_CA) references TBL_Acusado(Acu_CA) on delete cascade
)

--Fiscalía
create table TBL_Fiscalia(
Fis_CF int identity(1,1) primary key,
Fis_Nombre varchar(50) not null,
Fis_Nombre1_Admi varchar(50) not null,
Fis_Nombre2_Admi varchar(50) not null,
Fis_Apellido1_Admi varchar(50) not null,
Fis_Apellido2_Admi varchar(50) not null,
Fis_Pais varchar(50) not null,
Fis_Depto varchar(50) not null,
Fis_Ciudad varchar (50) not null,
Fis_Calle varchar (50) Not null,
Fis_Extra varchar (100),
)

--Teléfono del Fiscalía
create table TBL_Fiscalia_Tel(
Fis_CF int,
Fis_Tel varchar(15),
primary key (Fis_CF,Fis_Tel),
foreign key (Fis_CF) references TBL_Fiscalia(Fis_CF) on delete cascade
)

--Email del Fiscalía
create table TBL_Fiscalia_Email(
Fis_CF int,
Fis_Email varchar(100),
primary key (Fis_CF,Fis_Email),
foreign key (Fis_CF) references TBL_Fiscalia(Fis_CF) on delete cascade
)

--Expedientes
create table TBL_Expediente(
Exp_NE int identity (1,1) primary key,
Exp_Etapa varchar(15) check (Exp_Etapa in ('Apertura','Investigación','Juicio','Conclusión')) not null,
Exp_Especialidad varchar(15) check (Exp_Especialidad in ('Homicidio','Robo','Narcotráfico','Niñez','Corrupción','Fraude','Violencia','Financiero')) not null,
Exp_Fecha_Fin date,
Exp_Fecha_Inicio date not null,
Exp_Estado varchar (50) check (Exp_Estado in ('Abierto','Cerrado')) not null,
Acu_CA int ,
Fis_CF int ,
foreign key (Acu_CA) references TBL_Acusado(Acu_CA),
foreign key (Fis_CF) references TBL_Fiscalia(Fis_CF)
)

alter table TBL_Expediente add check (Exp_Fecha_Fin>Exp_Fecha_Inicio)

--Motivos de cierre del Expediente
create table TBL_Expediente_Motivo(
Exp_NE int,
Exp_Motivo varchar(100),
primary key (Exp_NE,Exp_Motivo),
foreign key (Exp_NE) references TBL_Expediente(Exp_NE) on delete cascade
)

--Observaciones del expediente
create table TBL_Expediente_Observaciones(
Exp_NE int,
Exp_Observacion varchar(100)	,
primary key (Exp_NE,Exp_Observacion),
foreign key (Exp_NE) references TBL_Expediente(Exp_NE) on delete cascade
)

--Evidencia
create table TBL_Evidencia(
Evi_CE int identity (1,1) primary key,
Evi_Descripcion_Larga varchar (200) not null,
Evi_Descripcion_Corta varchar (100) not null,
Evi_Foto image,
Exp_NE int ,
foreign key (Exp_NE) references TBL_Expediente(Exp_NE)
)

--Delitos
create table TBL_Delito(
Del_CID int identity (1,1) primary key,
Del_Nombre varchar (50) not null,
Del_Nivel decimal (4,2) not null,
Del_Pena_Max varchar (50) not null,
Del_Dias_Pena int check (Del_Dias_Pena<30),
Del_Meses_Pena int check (Del_Meses_Pena<12),
Del_Año_Pena int,
Del_Fianza money,
)

--Cuentan
create table TBL_Cuentan(
Exp_NE int,
Del_CID int,
primary key (Exp_NE,Del_CID),
foreign key (Exp_NE) references TBl_Expediente(Exp_NE),
foreign key (Del_CID) references TBL_Delito (Del_CID)
)

--Abogados
create table TBL_Abogado (
Abo_CIA int identity (1,1) primary key,
Abo_ID varchar(15) unique not null,
Abo_Genero varchar(10) check(Abo_Genero in ('Masculino','Femenino')) not null,
Abo_NC int not null,
Abo_Fecha_C date not null,
Abo_Inicio_Ejerc date not null,
Abo_Nombre1 varchar(50) not null,
Abo_Nombre2 varchar(50) not null,
Abo_Apellido1 varchar(50) not null,
Abo_Apellido2 varchar(50) not null,
Abo_Pais varchar (50) not null,
Abo_Depto varchar(50) not null,
Abo_Ciudad varchar(50) not null,
Abo_Calle varchar(50) not null,
Abo_Extra varchar(100),
)

--Email del Abogado
create table TBL_Abogado_Email(
Abo_CIA int ,
Abo_Email varchar(100),
primary key (Abo_CIA,Abo_Email),
foreign key (Abo_CIA) references TBL_Abogado(Abo_CIA) on delete cascade
)

--Tel del Abogado
create table TBL_Abogado_Tel(
Abo_CIA int,
Abo_Tel varchar (15),
primary key (Abo_CIA,Abo_Tel),
foreign key (Abo_CIA) references TBL_Abogado(Abo_CIA) on delete cascade
)

--Asociados
create table TBL_Asociados (
Exp_NE int,
Abo_CIA int,
Abo_Rol varchar (10) check (Abo_Rol in ('Defensor','Acusador')) not null,
primary key (Exp_NE,Abo_CIA),
foreign key (Exp_NE) references TBL_Expediente (Exp_NE),
foreign key (Abo_CIA) references TBL_Abogado (Abo_CIA)
)

--Usuario
create table TBL_Usuario (
Usu_Usuario varchar (50) primary key,
Usu_Contraseña varchar (50) not null,
Usu_ID varchar (15) unique not null,
Usu_Nombre1 varchar(50) not null,
Usu_Nombre2 varchar(50) not null,
Usu_Apellido1 varchar(50) not null,
Usu_Apellido2 varchar(50) not null,
Usu_Tipo varchar (15) check (Usu_Tipo in ('Detective','Fiscal','Administrador')) not null,
Usu_Acceso bit not null,
)

--Bitacora
create table TBL_Bitacora (
Usu_Usuario varchar (50),
Bit_Actividad varchar (100) not null,
Bit_PC varchar (50) not null,
Bit_Afectado varchar (100) not null,
Bit_Fecha datetime,
primary key (Usu_Usuario,Bit_Fecha),
foreign key (Usu_Usuario) references TBL_Usuario (Usu_Usuario) on delete cascade
)

--Insertar Acusados
insert into TBL_Acusado values ('Miguel','Saúl','Carrasco','Soler','1167732287754','Masculino','Casado','','Primaria','Honduras','Francisco Morazan','Municipio del distrito central','Centro','','11-07-1952','Hondureño','Honduras','Francisco Morazan','Municipio del distrito central',1.06,2.43,'Trigueño','Negro','Azules','')
insert into TBL_Acusado values ('Lucía','Naiara','Sanz','Gomez','7702707934488','Femenino','Soltero','','Secundaria','Honduras','Francisco Morazan','Municipio del distrito central','Centro','','15-02-1933','Hondureña','Honduras','Francisco Morazan','Municipio del distrito central',3.57,5.63,'Albino','Castaño','Verdes','')
insert into TBL_Acusado values ('Lucas','Iker','Soler','Benitez','9881714750882','Masculino','Soltero','','Profesionista','Honduras','Francisco Morazan','Municipio del distrito central','Centro','','14-01-1970','Hondureña','Honduras','Francisco Morazan','Municipio del distrito central',0.68,2.91,'Blanco','Rubio','Grises','')
insert into TBL_Acusado values ('Raquel','Manuela','Vargas','Diaz','6678288668598','Femenino','Casado','','Licenciado','Honduras','Francisco Morazan','Municipio del distrito central','Centro','','08-10-1926','Hondureña','Honduras','Francisco Morazan','Municipio del distrito central',3.66,5.07,'Afro','Pelirrojo','Cafés','')
insert into TBL_Acusado values ('Jorge','Ismael','Pujol','Flores','3195155895190','Masculino','Casado','','Maestría','Honduras','Francisco Morazan','Municipio del distrito central','Centro','','29-08-1938','Hondureña','Honduras','Francisco Morazan','Municipio del distrito central',3.39,5.23,'Trigueño','Negro','Verdes','')
insert into TBL_Acusado values ('África','Carmen','Cano','Fuentes','9291834937822','Femenino','Soltero','','Doctorado','Honduras','Francisco Morazan','Municipio del distrito central','Centro','','09-04-1955','Hondureño','Honduras','Francisco Morazan','Municipio del distrito central',4.51,3.49,'Albino','Castaño','Cafés','')
insert into TBL_Acusado values ('Rayan','Iker','Serrano','Blanco','1527993208887','Masculino','Soltero','','Analfabeta','Honduras','Francisco Morazan','Municipio del distrito central','Centro','','17-02-1921','Hondureño','Honduras','Francisco Morazan','Municipio del distrito central',6.52,0.17,'Blanco','Rubio','Azules','')
insert into TBL_Acusado values ('Ariadna','Malak','Fernandez','Mora','8888862325352','Femenino','Casado','','Preescolar','Honduras','Francisco Morazan','Municipio del distrito central','Centro','','29-04-1978','Hondureño','Honduras','Francisco Morazan','Municipio del distrito central',0.31,3.46,'Albino','Pelirrojo','Azules','')
select * from TBL_Acusado

--Insertar en Email Acusados
insert into TBL_Acusado_Email values (1,'MiguelÁngelVilaEsteban@yahoo.com')
insert into TBL_Acusado_Email values (2,'MarinaMolinaRamirez@hotmail.com')
insert into TBL_Acusado_Email values (3,'RodrigoMedinaHerrero@gmail.com')
insert into TBL_Acusado_Email values (4,'ÁngelaHidalgoVazquez@hotmail.com')
insert into TBL_Acusado_Email values (5,'DanielMarinGutierrez@yahoo.com')
insert into TBL_Acusado_Email values (6,'BeatrizTorresCabrera@gmail.com')
insert into TBL_Acusado_Email values (7,'MiguelMartiFerrer@yahoo.com')
insert into TBL_Acusado_Email values (8,'PaulaRuizPrieto@hotmail.com')
select * from TBL_Acusado_Email

--Ingresar rasgos del acusado
insert into TBL_Acusado_Rasgo values (1,'Canas')
insert into TBL_Acusado_Rasgo values (2,'Corte en la mejilla')
insert into TBL_Acusado_Rasgo values (3,'Ojos de diferente color')
insert into TBL_Acusado_Rasgo values (4,'Alopecia')
insert into TBL_Acusado_Rasgo values (5,'Ojo de vidrio')
insert into TBL_Acusado_Rasgo values (6,'Tatuaje de cobra en el cuello')
insert into TBL_Acusado_Rasgo values (7,'No tiene el pulgar de la mano izquierda')
insert into TBL_Acusado_Rasgo values (8,'Quemaduras en el rostro')
select * from TBL_Acusado_Rasgo

--Ingresar historial del acusado
insert into TBL_Acusado_Historial values (1,'Robo','Robo un bolso a Ana')
insert into TBL_Acusado_Historial values (2,'Homicidio','Mato a Omar')
insert into TBL_Acusado_Historial values (3,'Narcotrafico','Venta de drogas en el Centro')
insert into TBL_Acusado_Historial values (4,'Corrupcion','Acepto soborno')
insert into TBL_Acusado_Historial values (5,'Fraude','Publicidad engañosa')
insert into TBL_Acusado_Historial values (6,'Niñez','Explotacion infantil')
insert into TBL_Acusado_Historial values (7,'Evacion de impuestos','No declaro impuestos por años')
insert into TBL_Acusado_Historial values (8,'Robo','Robo a mano armada un banco')
select * from TBL_Acusado_Historial

--Insertar en Telefono Acusados
insert into TBL_Acusado_Tel values (1,'82336849')
insert into TBL_Acusado_Tel values (2,'33924033')
insert into TBL_Acusado_Tel values (3,'60135827')
insert into TBL_Acusado_Tel values (4,'88478563')
insert into TBL_Acusado_Tel values (5,'82700125')
insert into TBL_Acusado_Tel values (6,'53530096')
insert into TBL_Acusado_Tel values (7,'41795712')
insert into TBL_Acusado_Tel values (8,'73328669')
select * from TBL_Acusado_Tel

--Insertar en Foto Acusados
insert into TBL_Acusado_Foto values (1,null,'Frente')
insert into TBL_Acusado_Foto values (2,null,'Frente')
insert into TBL_Acusado_Foto values (3,null,'Frente')
insert into TBL_Acusado_Foto values (4,null,'Frente')
insert into TBL_Acusado_Foto values (5,null,'Frente')
insert into TBL_Acusado_Foto values (6,null,'Frente')
insert into TBL_Acusado_Foto values (7,null,'Frente')
insert into TBL_Acusado_Foto values (8,null,'Frente')
select * from TBL_Acusado_Foto

--Insertar Fiscalía
insert into TBL_Fiscalia values ('FEDCV','Víctor','Ian','Ramirez','Montero','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Fiscalia values ('FEDH','José','Antonio','Bosch','Carrasco','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Fiscalia values ('FEN','Marina','Diana','Sanchez','Alonso','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Fiscalia values ('FEM','Álvaro','Víctor','Sola','Lopez','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Fiscalia values ('FEEPT','Natalia','Lorena','Ramos','Ramos','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Fiscalia values ('FETCCOP','Miguel','Martín','Costa','Moreno','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Fiscalia values ('FEMA','Noa','Malak','Bosch','Carrasco','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Fiscalia values ('FESCCO','Gonzalo','Nil','Lozano','Suarez','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
select * from TBL_Fiscalia

--Insertar en Telefono Fiscalia
insert into TBL_Fiscalia_Tel values (1,'59166980')
insert into TBL_Fiscalia_Tel values (2,'78609951')
insert into TBL_Fiscalia_Tel values (3,'73413178')
insert into TBL_Fiscalia_Tel values (4,'88235995')
insert into TBL_Fiscalia_Tel values (5,'81499517')
insert into TBL_Fiscalia_Tel values (6,'91691402')
insert into TBL_Fiscalia_Tel values (7,'47782409')
insert into TBL_Fiscalia_Tel values (8,'94939171')
select * from TBL_Fiscalia_Tel

--Insertar en Email Fiscalia
insert into TBL_Fiscalia_Email values (1,'FEDCV@yahoo.com')
insert into TBL_Fiscalia_Email values (2,'FEDH@hotmail.com')
insert into TBL_Fiscalia_Email values (3,'FEN@gmail.com')
insert into TBL_Fiscalia_Email values (4,'FEM@hotmail.com')
insert into TBL_Fiscalia_Email values (5,'FEEPT@yahoo.com')
insert into TBL_Fiscalia_Email values (6,'FETCCOP@gmail.com')
insert into TBL_Fiscalia_Email values (7,'FEMA@yahoo.com')
insert into TBL_Fiscalia_Email values (8,'FESCCO@hotmail.com')
select * from TBL_Fiscalia_Email

--Insertar Expediente
insert into TBL_Expediente values ('Apertura','Homicidio',null,'04-12-2000','Abierto',1,1)
insert into TBL_Expediente values ('Investigación','Robo',null,'21-02-1913','Abierto',2,2)
insert into TBL_Expediente values ('Juicio','Narcotráfico',null,'28-09-1913','Abierto',3,3)
insert into TBL_Expediente values ('Conclusión','Niñez','30-11-1926','23-07-1920','Cerrado',4,4)
insert into TBL_Expediente values ('Apertura','Corrupción',null,'29-01-1992','Abierto',5,5)
insert into TBL_Expediente values ('Investigación','Fraude',null,'08-12-1996','Abierto',6,6)
insert into TBL_Expediente values ('Juicio','Violencia',null,'18-04-1935','Abierto',7,7)
insert into TBL_Expediente values ('Conclusión','Financiero','23-01-1983','28-12-1955','Cerrado',8,8)
select * from TBL_Expediente

--Insertar motivos de cierre
insert into TBL_Expediente_Motivo values (1,'La investigacion con el acusado no avanzo')
insert into TBL_Expediente_Motivo values (2,'La investigacion con el acusado no avanzo')
insert into TBL_Expediente_Motivo values (3,'Se encontro un nuevo acusado')
insert into TBL_Expediente_Motivo values (4,'Se encontro inocente el acusado')
insert into TBL_Expediente_Motivo values (5,'Se encontro inocente el acusado')
insert into TBL_Expediente_Motivo values (6,'No se pudo seguir la pista')
insert into TBL_Expediente_Motivo values (7,'No se pudo seguir la pista')
insert into TBL_Expediente_Motivo values (8,'Se encontro un nuevo acusado')
select * from TBL_Expediente_Motivo

--Insertar observaciones del expediente
insert into TBL_Expediente_Observaciones values (1,'Este expediente tiene un Origen fisico que fue sustituido cuando migramos a un sistema digital')
insert into TBL_Expediente_Observaciones values (2,'Este expediente tiene un Origen fisico que fue sustituido cuando migramos a un sistema digital')
insert into TBL_Expediente_Observaciones values (3,'Este expediente tiene un Origen fisico que fue sustituido cuando migramos a un sistema digital')
insert into TBL_Expediente_Observaciones values (4,'Este expediente tiene un Origen fisico que fue sustituido cuando migramos a un sistema digital')
insert into TBL_Expediente_Observaciones values (5,'Este expediente tiene un Origen fisico que fue sustituido cuando migramos a un sistema digital')
insert into TBL_Expediente_Observaciones values (6,'Este expediente tiene un Origen fisico que fue sustituido cuando migramos a un sistema digital')
insert into TBL_Expediente_Observaciones values (7,'Este expediente tiene un Origen fisico que fue sustituido cuando migramos a un sistema digital')
insert into TBL_Expediente_Observaciones values (8,'Este expediente tiene un Origen fisico que fue sustituido cuando migramos a un sistema digital')
select * from TBL_Expediente_Observaciones

--Insertar Evidencia
insert into TBL_Evidencia values ('Arma pulso cortante encontrada en la vivienda del sospechoso','Cuchillo',null,1)
insert into TBL_Evidencia values ('El sospechoso se encontro con un bolso lleno de documentos de los cuales no es el propietario','Bolso robado',null,2)
insert into TBL_Evidencia values ('Encontrado con sustancia de dudosa indole','Cocaina',null,3)
insert into TBL_Evidencia values ('Se ubico un total de 150 niños en una bodega a nombre del sospechoso','Testigos',null,4)
insert into TBL_Evidencia values ('Desviacion en un estado financiero con un total de 1000000 L','Bitacora',null,5)
insert into TBL_Evidencia values ('El producto en cuestion no tiene los efectos promocionales','Estudio quimico del producto',null,6)
insert into TBL_Evidencia values ('Victima con grandes heridad de corte y golpes en todo el cuerpo','Testigo',null,7)
insert into TBL_Evidencia values ('Se realizo una inspeccion fiscal y el propietario de la empresa carecia de 5 años de data','Resumen de la inspeccion',null,8)
select * from TBL_Evidencia

--Insercciones de delito
insert into TBL_Delito values ('Homicidio',10,'Cadena perpetua sin libertad a fianza',0,0,0,0)
insert into TBL_Delito values ('Robo',3.9,'5 años de prision o fianza 5000 L',0,0,5,5000)
insert into TBL_Delito values ('Posecion de drogas',7.8,'10 años de prision sin libertad a fianza',0,0,10,0)
insert into TBL_Delito values ('Secuestro',7.8,'25 años de prision sin libertad a fianza',0,0,25,0)
insert into TBL_Delito values ('Corrupcion',10,'30 años de prision sin libertad a fianza',0,0,30,0)
insert into TBL_Delito values ('Publicidad engañosa',3,'1000 Lempiras por afectado',0,0,0,1000)
insert into TBL_Delito values ('Violencia domestica',9.5,'15 años de carcel sin libertad a fianza',0,0,15,1000)
insert into TBL_Delito values ('Evancion de impuestos',9.5,'10 millones de lempiras',0,0,0,10000000)
select * from TBL_Delito

--Insercciones de Cuentan
insert into TBL_Cuentan values (1,1)
insert into TBL_Cuentan values (2,2)
insert into TBL_Cuentan values (3,3)
insert into TBL_Cuentan values (4,4)
insert into TBL_Cuentan values (5,5)
insert into TBL_Cuentan values (6,6)
insert into TBL_Cuentan values (7,7)
insert into TBL_Cuentan values (8,8)
select * from TBL_Cuentan

--Inserciones Abogado
insert into TBL_Abogado values ('9401632979775','Masculino',1,'01-06-1992','15-10-1961','Ismael','Pol','Ortiz','Garcia','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Abogado values ('7917984534871','Femenino',2,'01-01-1906','19-05-1950','Aitana','Aroa', 'Gimenez', 'Saez','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Abogado values ('1962171830938','Masculino',3,'18-08-1951','30-08-1959','Óscar', 'Marc', 'Herrera', 'Moya','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Abogado values ('8299998254272','Femenino',4,'28-02-1948','02-03-1930','Alexia', 'Sandra', 'Gallardo', 'Velasco','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Abogado values ('9336527629096','Masculino',5,'07-06-1910','16-12-1930','César', 'Aleix', 'Castro', 'Santiago','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Abogado values ('7858701880755','Femenino',6,'24-04-1999','12-06-1929','Nora', 'Carla', 'Leon', 'Castillo','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Abogado values ('2439882868693','Masculino',7,'26-11-1985','08-02-1902','Andrés', 'Jon', 'Gutierrez', 'Roman','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
insert into TBL_Abogado values ('672073245165','Femenino',8,'06-03-1956','18-10-1938','Aya', 'Andrea', 'Hernandez', 'Lorenzo','Honduras','Francisco Morazan','Municipio del distrito central','Centro','')
select * from TBL_Abogado

--Insertar en Email Abogado
insert into TBL_Abogado_Email values (1,'A@yahoo.com')
insert into TBL_Abogado_Email values (2,'B@hotmail.com')
insert into TBL_Abogado_Email values (3,'C@gmail.com')
insert into TBL_Abogado_Email values (4,'D@hotmail.com')
insert into TBL_Abogado_Email values (5,'E@yahoo.com')
insert into TBL_Abogado_Email values (6,'F@gmail.com')
insert into TBL_Abogado_Email values (7,'G@yahoo.com')
insert into TBL_Abogado_Email values (8,'H@hotmail.com')
select * from TBL_Abogado_Email

--Insertar en Telefono Abogado
insert into TBL_Abogado_Tel values (1,'60959306')
insert into TBL_Abogado_Tel values (2,'97482381')
insert into TBL_Abogado_Tel values (3,'78826836')
insert into TBL_Abogado_Tel values (4,'55674495')
insert into TBL_Abogado_Tel values (5,'33903585')
insert into TBL_Abogado_Tel values (6,'88249117')
insert into TBL_Abogado_Tel values (7,'59646720')
insert into TBL_Abogado_Tel values (8,'49322371')
select * from TBL_Abogado_Tel

--Inserciones Asociados
insert into TBL_Asociados values (1,1,'Defensor')
insert into TBL_Asociados values (2,2,'Acusador')
insert into TBL_Asociados values (3,3,'Defensor')
insert into TBL_Asociados values (4,4,'Acusador')
insert into TBL_Asociados values (5,5,'Defensor')
insert into TBL_Asociados values (6,6,'Acusador')
insert into TBL_Asociados values (7,7,'Defensor')
insert into TBL_Asociados values (8,8,'Acusador')
select * from TBL_Asociados

--Inserciones Usuarios
insert into TBL_Usuario values ('Alex','Alex','0801199818007','Alex','Ernesto','Ortega','Hernandez','Detective',1)
insert into TBL_Usuario values ('Alexander','Alexander','0801199818000','Alexander','Emilio','Ortega','Hernandez','Fiscal',1)
insert into TBL_Usuario values ('Elio','Elio','0801199818003','Elio','Alexandro','Ortega','Hernandez','Administrador',1)
insert into TBL_Usuario values ('Blanca','Blanca','0801199818001','Blanca','Azucena','Hernandez','Medina','Detective',0)
insert into TBL_Usuario values ('Karen','Karen','0801199818002','Karen','Francisca','Hernandez','Guzman','Fiscal',0)
insert into TBL_Usuario values ('Bianca','Bianca','0801199818004','Bianca','Valeria','Andrades','Osorio','Administrador',0)
insert into TBL_Usuario values ('Lucila','Lucila','0801200018003','Lucila','Maria','Ortega','Hernandez','Detective',0)
insert into TBL_Usuario values ('Antonio','Antonio','0801199818009','Antonio','Josue','Escobar','Mata','Fiscal',0)
select * from TBL_Usuario

--Inserciones Bitacora
insert into TBL_Bitacora values ('Alex','Ingresar al sistema','1','Alex','8-6-2019 05:23 PM')
insert into TBL_Bitacora values ('Alexander','Ingresar al sistema','2','Alexander','8-6-2019 05:23 PM')
insert into TBL_Bitacora values ('Elio','Ingresar al sistema','3','Elio','8-6-2019 05:23 PM')
insert into TBL_Bitacora values ('Blanca','Ingresar al sistema','4','Blanca','8-6-2019 05:23 PM')
insert into TBL_Bitacora values ('Karen','Ingresar al sistema','5','Karen','8-6-2019 05:23 PM')
insert into TBL_Bitacora values ('Bianca','Ingresar al sistema','6','Bianca','8-6-2019 05:23 PM')
insert into TBL_Bitacora values ('Lucila','Ingresar al sistema','7','Lucila','8-6-2019 05:23 PM')
insert into TBL_Bitacora values ('Antonio','Ingresar al sistema','8','Antonio','8-6-2019 05:23 PM')
select * from TBL_Bitacora 


--Vistas 1
create view VW_Peor
as select distinct count(H.Acu_CA) as Cant_Crimenes, H.Acu_CA as Codigo
from TBL_Acusado_Historial H
group by H.Acu_CA


create procedure PA_Peor_Acusado
as
declare @Maximo int
select @Maximo=Max(P.Cant_Crimenes) from VW_Peor P

select A.Acu_CA, concat(A.Acu_Nombre1,' ',A.Acu_Nombre2,' ',A.Acu_Apellido1,' ',A.Acu_Apellido2) as Nombre,E.Acu_Email as Email,
A.Acu_Genero as Genero,concat(A.Acu_Pais,' ',A.Acu_Depto,' ',A.Acu_Ciudad,' ',A.Acu_Calle,' ',A.Acu_Extra) as Dirección,A.Acu_Altura_m as Altura,
A.Acu_Peso_lb as Peso,A.Acu_Alias as Alias,DATEDIFF(yy,A.Acu_Nacido_el,GETDATE()) as Edad,F.Acu_Foto as Foto,F.Acu_Posicion as Posición
from TBL_Acusado_Historial H inner join TBl_Acusado A on H.Acu_CA=A.Acu_CA
inner join tbl_Acusado_Email E on A.Acu_CA=E.Acu_CA
inner join TBL_Acusado_Foto F on F.Acu_CA=A.Acu_CA
inner join VW_Peor P on A.Acu_CA=P.Codigo
where P.Cant_Crimenes=@Maximo

--Vistas 2
create view VW_Expedientes
as select E.Exp_NE as Numero,E.Exp_Fecha_Inicio as Abierto, E.Exp_Fecha_Fin as Cierre,E.Exp_Estado as Estado,E.Exp_Especialidad as Especialidad,
E.Exp_Etapa as Etapa,M.Exp_Motivo as Motivo_Cierre, O.Exp_Observacion as Observacion,D.Del_Nombre as Delito,
A.Acu_CA as Codigo_Acusado, concat(A.Acu_Nombre1,' ',A.Acu_Nombre2,' ',A.Acu_Apellido1,' ',A.Acu_Apellido2) as Nombre_acusado,
Ev.Evi_Descripcion_Corta as Nombre_evidencia
 from TBL_Acusado A inner join TBL_Expediente E on E.Acu_CA=A.Acu_CA inner join TBL_Expediente_Motivo M on M.Exp_NE=E.Exp_NE
 inner join TBL_Expediente_Observaciones O on O.Exp_NE=E.Exp_NE inner join TBL_Evidencia Ev on Ev.Exp_NE=E.Exp_NE 
 inner join TBL_Cuentan C on C.Exp_NE=E.Exp_NE inner join TBL_Delito D on D.Del_CID=C.Del_CID

create proc PA_Expedientes
 @Codigo int
 as select * from VW_Expedientes E
 where E.Codigo_Acusado=@Codigo

--Vista 3
create proc PA_Abogados_Acusadores
@Nombre varchar(50)=null,
@Codigo int=null
as select A.Abo_CIA as Codigo,A.Abo_ID as Identidad, A.Abo_Genero as Genero, A.Abo_NC as Numero_colegiacion,Abo_Fecha_C as Fecha_Colegiacion,
 DATEDIFF(yy,A.Abo_Inicio_Ejerc,GETDATE()) as Años_Experiencia,
 concat(A.Abo_Nombre1,' ',A.Abo_Nombre2,' ',A.Abo_Apellido1,' ',A.Abo_Apellido2) as Nombre,
 concat(A.Abo_Pais,' ',A.Abo_Depto,' ',A.Abo_Ciudad,' ',A.Abo_Calle,' ',A.Abo_Extra) as Dirección from TBL_Abogado A 
 inner join TBL_Abogado_Email E on E.Abo_CIA=A.Abo_CIA inner join TBL_Abogado_Tel T on T.Abo_CIA=A.Abo_CIA 
 inner join TBL_Asociados Aso on Aso.Abo_CIA=A.Abo_CIA
 where (Aso.Abo_Rol='Acusador') and ((@Codigo=A.Abo_CIA) or (@Nombre=A.Abo_Nombre1))


 --Vista 4
 create procedure PA_Cantidad_delito
 @Nombre varchar (50)
 as select count(E.Acu_CA) as Cantidad_Infractores, D.Del_Nombre as Delito
   from TBL_Cuentan C inner join TBL_Delito D on C.Del_CID=D.Del_CID inner join TBL_Expediente E on E.Exp_NE=C.Exp_NE
 inner join TBL_Acusado A on A.Acu_CA=E.Acu_CA
 where D.Del_Nombre=@Nombre
 group by D.Del_Nombre


 --Vista 5
create proc PA_Acusados_Defendidos
@Nombre varchar(50)
as select A.Acu_CA as Codigo, concat (A.Acu_Nombre1, ' ', A.Acu_Nombre2, ' ',A.Acu_Apellido1,' ',A.Acu_Apellido2) as Nombre,
A.Acu_ID as Identidad,A.Acu_Genero as Genero,A.Acu_Estado_Civil as Estado_civil,A.Acu_Alias as Alias,A.Acu_Nivel_Edu as Educacion,
concat(A.Acu_Pais,' ',A.Acu_Depto,' ',A.Acu_Ciudad,' ',A.Acu_Calle,' ',A.Acu_Extra) as Dirección, A.Acu_Nacido_el as Fecha_Nacimiento,
A.Acu_Nacionalidad as Nacionalidad, concat(A.Acu_Pais_Nacido,' ',A.Acu_Depto_Nacido,' ',A.Acu_Ciudad_Nacido) as Orginario,
A.Acu_Altura_m as Altura, A.Acu_Peso_lb as Peso, A.Acu_Ocupacion as Ocupacion
from TBL_Acusado A inner join TBL_Expediente E on A.Acu_CA=E.Acu_CA inner join TBL_Asociados Aso on E.Exp_NE=Aso.Exp_NE
 inner join TBL_Abogado Abo on Aso.Abo_CIA=Abo.Abo_CIA
 where (Aso.Abo_Rol='Defensor') and (@Nombre=Abo.Abo_Nombre1)

 --Bitacora
 create procedure PA_Agregar_Bitacora
@Usu_Usuario varchar (50),
@Bit_Actividad varchar (100),
@Bit_Afectado varchar (100)
 as insert into TBL_Bi
 tacora values (@Usu_Usuario,@Bit_Actividad,HOST_NAME(),@Bit_Afectado ,GETDATE())