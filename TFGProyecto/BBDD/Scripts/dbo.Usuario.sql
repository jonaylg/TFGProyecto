CREATE TABLE [dbo].[Usuario] (
	[id]		INT			   IDENTITY(1,1) NOT NULL,
    [nick]      NVARCHAR (50)  NOT NULL,
    [clave]     NVARCHAR (50)  NULL,
    [pregPers]  NVARCHAR (100) NULL,
    [respuesta] NVARCHAR (100) NULL,
    [rol_id]    NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([rol_id]) REFERENCES [dbo].[Rol] ([id])
);

