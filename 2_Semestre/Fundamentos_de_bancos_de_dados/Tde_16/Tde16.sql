/*
Professor(id INT PK, nome CHAR(100), especialização CHAR(100), idade INT);
Disciplina(id_disc INT PK, disciplina CHAR(50), carga_horaria INT);
Software(id INT PK, nome CHAR(100), tipo CHAR(40));
Leciona(professor_id REFERENCES Professor(id), disciplina_id REFERENCES disciplina(id_disc));
Utiliza(disciplina_id REFERENCES disciplina(id_disc), software_id REFERENCES software(id));
*/

CREATE TABLE Professors
(
    id int Not Null Primary Key,
    nome varchar(100) Not Null,
    especializacao varchar(100) Not Null,
    idade int Not Null
);

CREATE TABLE Disciplinas
(
    id_disc int Not Null Primary Key,
    disciplina varchar(50) Not Null,
    carga_horaria int Not Null
);

CREATE TABLE Softwares
(
    id int Not Null Primary Key,
    nome varchar(100) Not Null,
    tipo varchar(50) Not Null
);

CREATE TABLE Leciona
(
    id_leciona int Not Null,
    prof_id int Not Null,
    disc_id int Not Null,
    Constraint FK_Professores_Leciona_Disciplinas
        Foreign Key (prof_id)
            References Professores(id),
    Constraint FK_Disciplinas_tem_Professores
        Foreign Key (disc_id)
            References Disciplinas(id_disc)
);

CREATE TABLE Utiliza
(
    disc_id int Not Null,
    software_id int Not Null,
    Constraint FK_Disciplinas_utiliza_Softwares
        Foreign Key (disc_id)
            References Disciplina(id_disc),
    Constraint FK_Software_utiliza_Disciplinas
        Foreign Key (software_id)
            References Softwares(id)
);