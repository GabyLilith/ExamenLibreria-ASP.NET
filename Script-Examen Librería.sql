CREATE DATABASE LibreriaExamen;

USE LibreriaExamen;

CREATE TABLE Autores(
    Id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255) NOT NULL
);


CREATE TABLE Libros(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(255) NOT NULL,
    Chapters INT NOT NULL,
    Pages INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    AutorId INT FOREIGN KEY REFERENCES Autores(Id) NOT NULL
);


