﻿CREATE TABLE PolizaVida (
    Id INT PRIMARY KEY IDENTITY,
    Edad INT NOT NULL,
    Sexo VARCHAR(10) NOT NULL,
    Ocupacion VARCHAR(100) NOT NULL,
    Peso FLOAT NOT NULL,
    Altura FLOAT NOT NULL,
    DietaId INT NOT NULL,
    ActividadId INT NOT NULL,
    ConsumeAlcohol BIT NOT NULL,
    ConsumeTabaco BIT NOT NULL,
    ConsumeDrogas BIT NOT NULL,
    Hematologicas BIT NOT NULL,
    Gastrointestinales BIT NOT NULL,
    Endocrinas BIT NOT NULL,
    Infecciosas BIT NOT NULL,
    Autoinmunes BIT NOT NULL,
    Neurologicas BIT NOT NULL,
    Renales BIT NOT NULL,
    Hepaticas BIT NOT NULL,
    Diabetes BIT NOT NULL,
    Cancer BIT NOT NULL,
    Respiratorias BIT NOT NULL,
    Cardiacas BIT NOT NULL,
    TieneTerminacionAnticipada BIT NOT NULL,
    TieneIncapacidadTemporal BIT NOT NULL,
    TieneAccidentes BIT NOT NULL,
    CapitalAsegurado FLOAT NOT NULL,
    Dni VARCHAR(20) NOT NULL,
    FOREIGN KEY (DietaId) REFERENCES Dietas(Id),
    FOREIGN KEY (ActividadId) REFERENCES Actividades(Id)
);