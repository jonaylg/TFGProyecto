-- Tabla Empleado
CREATE TABLE Empleado (
    id INT PRIMARY KEY,
    usuario_nick NVARCHAR(50) FOREIGN KEY REFERENCES Usuario(nick),
    nombre NVARCHAR(50),
    apellido1 NVARCHAR(50),
    apellido2 NVARCHAR(50),
    fechaNac DATE,
    fechaContr DATE,
    puesto NVARCHAR(50),
    salario FLOAT,
    email NVARCHAR(100),
    telefono INT,
    direccion NVARCHAR(100)
);