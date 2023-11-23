create database girolouco

create table Clientes(
idcliente int identity primary key,
nomecliente varchar (max),
sobrenome varchar(max),
cpf varchar(max)
);

create table Inventario(
iditem int identity primary key,
idcliente int,
idmaquina int,
quantidade int,
valor varchar(max)
);

create table Maquinas(
idmaquina int identity primary key,
tipo varchar(max),
patrimonio varchar(max),
memoria varchar(max)
);