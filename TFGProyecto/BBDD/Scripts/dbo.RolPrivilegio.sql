CREATE TABLE RolPrivilegio (
    rol_id INT,
    privilegio_id INT,
    FOREIGN KEY (rol_id) REFERENCES Rol(id),
    FOREIGN KEY (privilegio_id) REFERENCES Privilegio(id),
    PRIMARY KEY (rol_id, privilegio_id)
);