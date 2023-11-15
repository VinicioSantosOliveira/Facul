-- Comentario curto

/*
Insere
um
comentario
longo
*/

/*
Cliente (id int primary key, Nome char(100));
Enderecos (Id int primary key, Logradouro varchar(100), Numero int, Bairro varchar(50), Cidade varchar(20),
Estado char(2), Cliente_Id int references Clientes (Id));
*/

CREATE TABLE Clientes
(
    Id int Not Null Primary Key,
    Nome char(100)
);

CREATE TABLE Enderecos
(
    Id int Not Null Primary Key,
    Logradouro varchar(100),
    Numero int,
    Bairro varchar(50),
    Cidade varchar(20),
    Estado char(2),
    Clientes_Id int Not Null,
    Constraint Clientes_tem_Enderecos
        Foreign Key (Clientes_Id) references Clientes(Id)
);