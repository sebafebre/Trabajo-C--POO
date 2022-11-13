if object_id('usuarios') is not null
	drop table usuarios;

create table usuarios
(
	id int identity,
	nombre varchar(20),
	apellido varchar(20),
	email varchar(40) not null,
	contrasena varchar(50) not null,
	primary key (id)
);

insert into usuarios(email,contrasena) values ('admin','d033e22ae348aeb5660fc2140aec35850c4da997');
insert into usuarios(email,contrasena) values ('123','40bd001563085fc35165329ea1ff5c5ecbdbbeef');

select * from usuarios;