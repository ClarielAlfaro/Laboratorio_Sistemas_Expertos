create database chatbot3
use chatbot3
drop database chatbot

create table pregunta (
idpregunta int identity (1,1) not null primary key,
descripcion varchar(50)
);

create table respuesta(
idrespuesta int identity (1,1) not null primary key,
descripcion varchar (50),
idpregunta int not null
);


Alter table respuesta add Foreign key (idpregunta) references pregunta(idpregunta);
Go

insert into respuesta (descripcion,idpregunta) values ('Me llamo ChatBot',1)
insert into respuesta (descripcion,idpregunta) values ('Fui hecho para contestar a preguntas especificas, como programa de prueba',2)
insert into respuesta (descripcion,idpregunta) values ('Buenos dias, espero tengas un dia excelente',4)
insert into respuesta (descripcion,idpregunta) values ('Dulces sueños',5)
insert into respuesta (descripcion,idpregunta) values ('Que tengas un excelente resto del dia',6)
insert into respuesta (descripcion,idpregunta) values ('Hola, como estas?',7)
insert into respuesta (descripcion,idpregunta) values ('Me alegra escucharlo', 8)
insert into respuesta (descripcion,idpregunta) values ('No tengo idea, pero de lo que estoy seguro es que estoy joven :)',9)
insert into respuesta (descripcion,idpregunta) values ('Solo hay 10 tipos de personas en el mundo, las que entienden binario y las que no',9)


insert into pregunta (descripcion) values ('buenas noches')

select * from respuesta
select * from pregunta

alter table respuesta alter column descripcion varchar(150)
