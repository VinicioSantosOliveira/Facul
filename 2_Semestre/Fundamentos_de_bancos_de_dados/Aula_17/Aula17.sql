/*
Cliente (id int primary key, Nome char(100));
Enderecos (Id int primary key, Logradouro varchar(100), Numero int, Bairro varchar(50), Cidade varchar(20),
Estado char(2), Cliente_Id int references Clientes (Id));
*/

CREATE TABLE Clientes
(
    Id int Not Null Primary Key,
    Nome varchar(100)
);

CREATE TABLE Enderecos
(
    Id int Not Null Primary Key,
    Logradouro varchar(100),
    Numero int,
    Bairro varchar(50),
    Cidade varchar(20),
    Estado varchar(2),
    Clientes_Id int Not Null,
    Constraint Clientes_tem_Enderecos
        Foreign Key (Clientes_Id) references Clientes(Id)
);

--altera definiçoes da tabela
AlTER TABLE Enderecos add column Email varchar(50);--add = adiciona coluna

AlTER TABLE Enderecos drop column Email;--drop = exclui uma coluna

AlTER TABLE Enderecos drop
    Constraint Clientes_tem_Enderecos;--Apagando a chave estrangeira

AlTER TABLE Enderecos add
    Constraint Nova_Constraint
        Foreign Key (Clientes_Id)
            References Clientes(id);--Adicionando nova constraint na tabela

--inserindo dados na tupla da tabela
INSERT INTO Clientes(Id, Nome)
    value(100, 'Mari');

INSERT INTO Clientes(id, Nome)
    value(200, 'Vinicio');

SELECT * FROM Clientes;--Ver os dados das tuplas de tabela selecionada

INSERT INTO Enderecos(Id, Logradouro, Numero, Bairro, Cidade, Estado, Clientes_Id)
    value(100, 'Rua das tirivas', '36', 'Vila sao joao', 'Torres', 'RS', 100);