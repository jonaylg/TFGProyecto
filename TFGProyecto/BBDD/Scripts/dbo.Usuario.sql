-- Tabla Usuario
CREATE TABLE Usuario (
    nick NVARCHAR(50) PRIMARY KEY,
    clave NVARCHAR(50),
    pregPers NVARCHAR(100),
    respuesta NVARCHAR(100),
    rol_id INT FOREIGN KEY REFERENCES Rol(id)
);