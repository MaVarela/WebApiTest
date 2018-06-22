create database TestWebApi;
go
use TestWebApi;
go
create table Usuarios
(
	Id int identity (1,1) primary key,
	Nombre varchar(50),
	Apellido varchar(50),
	Email varchar(50),
	Password varchar(50)
);
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Marcelo','Perez','MPerez@Gmail.com','123456')
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Maria','Lopez','MLopez@Gmail.com','123456')
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Carlos','Heredia','CHeredia@Gmail.com','123456')
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Francisco','Perez','FPerez@Gmail.com','123456')
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Raúl','Fernandez','RFernandez@Gmail.com','123456')
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Héctor','Perez','HPerez@Gmail.com','123456')
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Pedro','García','PGarcia@Gmail.com','123456')
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Gabriela','Hernandez','GHernandez@Gmail.com','123456')
go
insert into dbo.Usuarios(Nombre,Apellido,Email,Password)
values('Pia','Jaimes','PJaimes@Gmail.com','123456')
go