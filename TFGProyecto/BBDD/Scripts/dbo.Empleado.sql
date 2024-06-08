CREATE TABLE [dbo].[Empleado] (
    [id]           INT            IDENTITY (1, 1) NOT NULL,
    [usuario_nick] NVARCHAR (50)  NULL,
    [nombre]       NVARCHAR (50)  NULL,
    [apellido1]    NVARCHAR (50)  NULL,
    [apellido2]    NVARCHAR (50)  NULL,
    [fechaNac]     DATE           NULL,
    [fechaContr]   DATE           NULL,
    [puesto]       NVARCHAR (50)  NULL,
    [salario]      FLOAT (53)     NULL,
    [email]        NVARCHAR (100) NULL,
    [telefono]     INT            NULL,
    [direccion]    NVARCHAR (100) NULL,
	[dni]          NVARCHAR (9)   NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([usuario_nick]) REFERENCES [dbo].[Usuario] ([nick])
);

