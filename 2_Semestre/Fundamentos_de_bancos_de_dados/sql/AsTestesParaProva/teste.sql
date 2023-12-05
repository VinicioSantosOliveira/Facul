CREATE TABLE Clientes
(
    id int Not Null Primary Key,
    nome varchar(70) Not Null,
    cpf varchar(15) Not Null
);

CREATE TABLE Produtos
(
    cod_prod int Not Null Primary Key,
    nome_prod varchar(100) Not Null,
    preco float Not Null
    id_cliente int Not Null,
    Constraint id_cliente
        Foreign Key (id_cliente) references Clientes(id)
);

DROP TABLE demo;

--dml

INSERT INTO Clientes(id, nome, cpf)
    value(10, 'vini', '999.999.999-00');

INSERT INTO Clientes(Id, Nome)
    value(100, 'Mari');