CREATE TABLE [dbo].[Cliente] (
    [DNI]                  NVARCHAR (20)  NOT NULL,
    [Nombre]               NVARCHAR (50)  NOT NULL,
    [Apellido]             NVARCHAR (50)  NOT NULL,
    [Direccion]            NVARCHAR (100) NOT NULL,
    [FechaNacimiento]      NVARCHAR (50)  NOT NULL,
    [Telefono]             NVARCHAR (20)  NOT NULL,
    [CorreoElectronico]    NVARCHAR (100) NOT NULL,
    [Provincia]            NVARCHAR (50)  NOT NULL,
    [Ciudad]               NVARCHAR (50)  NOT NULL,
    [Tipo]                 NVARCHAR (50)  NOT NULL,
    [DireccionFacturacion] NVARCHAR (100) NOT NULL,
    [CVV]                  NVARCHAR (3)   NOT NULL,
    [FechaVencimiento]     NVARCHAR (10)  NOT NULL,
    [NombreTitular]        NVARCHAR (50)  NOT NULL,
    [FrecuenciaPago]       NVARCHAR (20)  NOT NULL,
    [MetodoPago]           NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([DNI] ASC)
);

