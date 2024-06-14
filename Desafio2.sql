CREATE TABLE Venta (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    COMENTARIOS VARCHAR(255),
    ID_USUARIO INT,
);

INSERT INTO Venta (COMENTARIOS, ID_USUARIO) VALUES
('Venta realizada sin problemas', 1),
('Cliente pidió reembolso', 2),
('Venta completada rápidamente', 3),
('Cliente muy satisfecho', 4),
('Hubo un pequeño retraso en la entrega', 5),
('Cliente compró varios productos', 6),
('Primera compra del cliente', 7),
('Cliente recurrente', 8),
('Venta realizada con descuento', 9),
('Cliente tuvo problemas con el pago', 10);

CREATE TABLE ProductosVendidos (
    id INT IDENTITY(1,1) PRIMARY KEY,
    idProducto INT,
    stock INT,
    idVenta INT,
);

INSERT INTO ProductosVendidos (idProducto, stock, idVenta) VALUES
(1, 10, 1),
(2, 5, 2),
(3, 7, 3),
(4, 3, 4),
(5, 12, 5),
(6, 8, 6),
(7, 15, 7),
(8, 6, 8),
(9, 9, 9),
(10, 4, 10);

CREATE TABLE Producto (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion VARCHAR(100),
    Costo DECIMAL(10, 2),
    PrecioVenta DECIMAL(10, 2),
    Stock INT,
    IdUsuario INT
);

INSERT INTO producto (Descripcion, Costo, PrecioVenta, Stock, IdUsuario) VALUES
('Producto A', 10.00, 15.00, 100, 1),
('Producto B', 20.50, 30.00, 200, 2),
('Producto C', 5.75, 10.00, 150, 3),
('Producto D', 8.00, 12.50, 80, 4),
('Producto E', 12.00, 18.00, 50, 5),
('Producto F', 25.00, 35.00, 120, 6),
('Producto G', 3.50, 7.00, 300, 7),
('Producto H', 7.25, 10.00, 90, 8),
('Producto I', 15.00, 25.00, 70, 9),
('Producto J', 22.50, 30.00, 60, 10);
CREATE TABLE Usuarios (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    NOMBRE VARCHAR(50),
    APELLIDO VARCHAR(50),
    NOMBREUSUARIO VARCHAR(50),
    CONTRASEÑA VARCHAR(50),
    MAIL VARCHAR(100)
);

INSERT INTO Usuarios (NOMBRE, APELLIDO, NOMBREUSUARIO, CONTRASEÑA, MAIL) VALUES
('Juan', 'Pérez', 'jperez', 'Passw0rd!', 'juan.perez@example.com'),
('María', 'García', 'mgarcia', 'P@ssw0rd!', 'maria.garcia@example.com'),
('Carlos', 'Sánchez', 'csanchez', '1234abcd', 'carlos.sanchez@example.com'),
('Ana', 'Fernández', 'afernandez', 'Abcd1234', 'ana.fernandez@example.com'),
('Luis', 'Gómez', 'lgomez', 'P@ss1234', 'luis.gomez@example.com'),
('Laura', 'Rodríguez', 'lrodriguez', 'Password1', 'laura.rodriguez@example.com'),
('David', 'López', 'dlopez', 'Contr4seña', 'david.lopez@example.com'),
('Elena', 'Martínez', 'emartinez', 'Mart1234', 'elena.martinez@example.com'),
('Jorge', 'Díaz', 'jdiaz', 'D1azP@ss', 'jorge.diaz@example.com'),
('Marta', 'Torres', 'mtorres', 'T0rres123', 'marta.torres@example.com');