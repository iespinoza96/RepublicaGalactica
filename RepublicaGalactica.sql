CREATE DATABASE RepublicaGalactica
GO
USE RepublicaGalactica
GO
CREATE TABLE Galaxia(
IdGalaxia INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(40),
)
GO

CREATE TABLE Sistema(
IdSistema INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(40),
IdGalaxia int,
CONSTRAINT FK_IdGalaxia FOREIGN KEY(IdGalaxia) REFERENCES Galaxia(IdGalaxia)
)
GO

CREATE TABLE Planeta(
IdPlaneta INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(40),
IdSistema INT,
CONSTRAINT FK_IdSistema FOREIGN KEY(IdSistema) REFERENCES Sistema(IdSistema)
)
GO

CREATE TABLE Especie(
IdEspecie INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(40),
IdPlaneta INT,
CONSTRAINT FK_IdPlaneta FOREIGN KEY(IdPlaneta) REFERENCES Planeta(IdPlaneta)
)
GO

CREATE TABLE OrdenJedi(
IdOrdenJedi INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(40),
Edad INT,
NivelMidiclorianosSangre INT,
DatosDeInteres VARCHAR(40),
IdEspecie int,
CONSTRAINT FK_IdEspecie FOREIGN KEY(IdEspecie) REFERENCES Especie(IdEspecie)
)
GO

CREATE TABLE SistemasAmenazados(
IdSistemasAmenazados INT PRIMARY KEY IDENTITY(1,1),
IdSistema INT,
Amenazado BIT,
CONSTRAINT FK_IdSistema1 FOREIGN KEY(IdSistema) REFERENCES Sistema(IdSistema)
)
GO

CREATE TABLE Maestro(
IdMaestro INT PRIMARY KEY IDENTITY(1,1),
IdOrdenJedi INT,
IdSistemasAmenazados INT,
Rango bit,
CONSTRAINT FK_IdOrdenJedi FOREIGN KEY(IdOrdenJedi) REFERENCES OrdenJedi(IdOrdenJedi),
CONSTRAINT FK_IdSistemasAmenazados FOREIGN KEY(IdSistemasAmenazados) REFERENCES SistemasAmenazados(IdSistemasAmenazados)
)
GO

CREATE TABLE Padawan(
IdPadawan INT PRIMARY KEY IDENTITY(1,1),
IdOrdenJedi INT,
IdMaestro INT,
CONSTRAINT FK_IdOrdenJedi1 FOREIGN KEY(IdOrdenJedi) REFERENCES OrdenJedi(IdOrdenJedi),
CONSTRAINT FK_IdMaestro FOREIGN KEY(IdMaestro) REFERENCES Maestro(IdMaestro)
)

GO

CREATE TABLE MiembrosConsejo(
IdMiembrosConsejo INT PRIMARY KEY IDENTITY(1,1),
Rango bit,
IdMaestro INT,
CONSTRAINT FK_IdMaestro1 FOREIGN KEY(IdMaestro) REFERENCES Maestro(IdMaestro)
)
GO

INSERT INTO Galaxia(Nombre) VALUES ('La galaxia')
INSERT INTO Sistema(Nombre) VALUES('Abregado')
INSERT INTO Sistema(Nombre) VALUES('llenium')
INSERT INTO Sistema(Nombre) VALUES('Coruscant')
INSERT INTO Sistema(Nombre) VALUES('Desconocida')
INSERT INTO Sistema(Nombre) VALUES('Kashyyk')
GO

INSERT INTO Planeta(Nombre,IdSistema) VALUES ('D Qar', 2)
INSERT INTO Planeta(Nombre,IdSistema) VALUES ('Abregado-Rae', 1)
INSERT INTO Planeta(Nombre,IdSistema) VALUES ('Abregado-dai', 1)
INSERT INTO Planeta(Nombre,IdSistema) VALUES ('Abregado-fus', 1)
INSERT INTO Planeta(Nombre,IdSistema) VALUES ('Abregado-san', 1)
INSERT INTO Planeta(Nombre,IdSistema) VALUES ('Abregado-taki', 1)
INSERT INTO Planeta(Nombre,IdSistema) VALUES ('Coruscant', 3)
INSERT INTO Planeta(Nombre,IdSistema) VALUES ('Desconocida', 4)
INSERT INTO Planeta(Nombre,IdSistema) VALUES ('Tatooine', 2)
INSERT INTO Especie(Nombre,IdPlaneta) VALUES ('Humano',3)
INSERT INTO Especie(Nombre,IdPlaneta) VALUES ('Desconocida',4)
INSERT INTO Especie(Nombre,IdPlaneta) VALUES ('Humano',9)
GO

INSERT INTO OrdenJedi(Nombre,Edad,NivelMidiclorianosSangre,DatosDeInteres,IdEspecie)
VALUES              ('Qui-Gon Jinn', 47, 10000, 'Estatura 1,93', 1)
INSERT INTO OrdenJedi(Nombre,Edad,NivelMidiclorianosSangre,DatosDeInteres,IdEspecie)
VALUES('Obi-Wan Kenobi', 47, 13400, 'Alias:El negociador', 1)
INSERT INTO OrdenJedi(Nombre,Edad,NivelMidiclorianosSangre,DatosDeInteres,IdEspecie)
VALUES('Yoda', 900, 17700, 'Estatura 66cm', 2)
 INSERT INTO OrdenJedi(Nombre,Edad,NivelMidiclorianosSangre,DatosDeInteres,IdEspecie)
VALUES('Dooku',20 , 8800, 'Estatura 1.93', 1)
INSERT INTO OrdenJedi(Nombre,Edad,NivelMidiclorianosSangre,DatosDeInteres,IdEspecie)
VALUES('Anakin Skywalker ',20 , 00, 'Estatura 1.85', 3)
GO

INSERT INTO SistemasAmenazados(IdSistema,Amenazado)
VALUES(5,0)
INSERT INTO SistemasAmenazados(IdSistema,Amenazado)
VALUES(1,0)
INSERT INTO SistemasAmenazados(IdSistema,Amenazado)
VALUES(2,0)
GO
INSERT INTO Maestro(IdOrdenJedi,IdSistemasAmenazados,Rango)
VALUES (3,1,1)
INSERT INTO Maestro(IdOrdenJedi,IdSistemasAmenazados,Rango)
VALUES (2,2,1)
INSERT INTO Maestro(IdOrdenJedi,IdSistemasAmenazados,Rango)
VALUES (1,3,1)
GO







CREATE PROCEDURE Informe

AS

SELECT
OrdenJedi.Nombre as NombreCaballero,
SistemasAmenazados.IdSistemasAmenazados,
--SistemasAmenazados.Amenazado,
Sistema.Nombre as NombreCombate,
Maestro.Rango as Rango

from Maestro
inner join SistemasAmenazados on SistemasAmenazados.IdSistemasAmenazados=Maestro.IdSistemasAmenazados
--inner join Maestro on Maestro.IdSistemasAmenazados=SistemasAmenazados.IdSistemasAmenazados
inner join OrdenJedi on OrdenJedi.IdOrdenJedi=Maestro.IdOrdenJedi
inner join Sistema on Sistema.IdSistema=SistemasAmenazados.IdSistema
GO

