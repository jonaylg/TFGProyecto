CREATE TABLE [dbo].[Trabajo] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]      NVARCHAR (100) NULL,
    [Descripcion] NVARCHAR (250) NULL,
	[Peligroso]	  BIT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

