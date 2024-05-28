CREATE TABLE [dbo].[RolPrivilegio] (
    [rol_id]        NVARCHAR (50) NOT NULL,
    [privilegio_id] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([rol_id] ASC, [privilegio_id] ASC),
    FOREIGN KEY ([privilegio_id]) REFERENCES [dbo].[Privilegio] ([id]),
    FOREIGN KEY ([rol_id]) REFERENCES [dbo].[Rol] ([id])
);

