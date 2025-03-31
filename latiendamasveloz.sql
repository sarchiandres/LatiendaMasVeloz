-- Creación de la Base de Datos
CREATE DATABASE IF NOT EXISTS SistemaFacturacion;
USE SistemaFacturacion;

-- Tabla TipoEmpleado (Simplificada)
CREATE TABLE IF NOT EXISTS TipoEmpleado (
    id_tipo_empleado INT AUTO_INCREMENT PRIMARY KEY,
    nombre_tipo VARCHAR(50) NOT NULL
);

-- Insertar solo dos tipos de empleado
INSERT INTO TipoEmpleado (nombre_tipo) VALUES 
('Administrador'),
('Normal');

-- Tabla Cliente
CREATE TABLE IF NOT EXISTS Cliente (
    documento INT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    numero VARCHAR(20)
);

-- Tabla Proveedor
CREATE TABLE IF NOT EXISTS Proveedor (
    documento_proveedor INT PRIMARY KEY,
    nombre_p VARCHAR(100) NOT NULL,
    contacto INT
);

-- Tabla Empleado (Simplificada)
CREATE TABLE IF NOT EXISTS Empleado (
    documento_id_empleado INT PRIMARY KEY,
    nombre_empleado VARCHAR(100) NOT NULL,
    tipo_empleado INT NOT NULL,
    FOREIGN KEY (tipo_empleado) REFERENCES TipoEmpleado(id_tipo_empleado)
);

-- Tabla Producto
CREATE TABLE IF NOT EXISTS Producto (
    id_producto INT AUTO_INCREMENT PRIMARY KEY,
    nombre_producto VARCHAR(100) NOT NULL,
    documento_proveedor INT NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    stock INT DEFAULT 0,
    FOREIGN KEY (documento_proveedor) REFERENCES Proveedor(documento_proveedor)
);

-- Tabla Factura
CREATE TABLE IF NOT EXISTS Factura (
    id_factura INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    id_empleado INT NOT NULL,
    fecha_factura DATETIME DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(10,2) DEFAULT 0,
    FOREIGN KEY (id_cliente) REFERENCES Cliente(documento),
    FOREIGN KEY (id_empleado) REFERENCES Empleado(documento_id_empleado)
);

-- Tabla DetalleFactura
CREATE TABLE IF NOT EXISTS DetalleFactura (
    id_detalle INT AUTO_INCREMENT PRIMARY KEY,
    id_factura INT NOT NULL,
    id_producto INT NOT NULL,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (id_factura) REFERENCES Factura(id_factura),
    FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);

-- PROCEDIMIENTOS ALMACENADOS

-- 1. Procedimiento para insertar un nuevo cliente
DELIMITER //
CREATE PROCEDURE sp_InsertarCliente(
    IN p_documento INT,
    IN p_nombre VARCHAR(100),
    IN p_numero VARCHAR(20)
)
BEGIN
    INSERT INTO Cliente(documento, nombre, numero)
    VALUES (p_documento, p_nombre, p_numero);
END //
DELIMITER ;

-- 2. Procedimiento para actualizar un cliente
DELIMITER //
CREATE PROCEDURE sp_ActualizarCliente(
    IN p_documento INT,
    IN p_nombre VARCHAR(100),
    IN p_numero VARCHAR(20)
)
BEGIN
    UPDATE Cliente
    SET nombre = p_nombre, numero = p_numero
    WHERE documento = p_documento;
END //
DELIMITER ;

-- 3. Procedimiento para eliminar un cliente
DELIMITER //
CREATE PROCEDURE sp_EliminarCliente(
    IN p_documento INT
)
BEGIN
    DELETE FROM Cliente WHERE documento = p_documento;
END //
DELIMITER ;

-- 4. Procedimiento para insertar un nuevo proveedor
DELIMITER //
CREATE PROCEDURE sp_InsertarProveedor(
    IN p_documento_proveedor INT,
    IN p_nombre_p VARCHAR(100),
    IN p_contacto INT
)
BEGIN
    INSERT INTO Proveedor(documento_proveedor, nombre_p, contacto)
    VALUES (p_documento_proveedor, p_nombre_p, p_contacto);
END //
DELIMITER ;

-- 5. Procedimiento para actualizar un proveedor
DELIMITER //
CREATE PROCEDURE sp_ActualizarProveedor(
    IN p_documento_proveedor INT,
    IN p_nombre_p VARCHAR(100),
    IN p_contacto INT
)
BEGIN
    UPDATE Proveedor
    SET nombre_p = p_nombre_p, contacto = p_contacto
    WHERE documento_proveedor = p_documento_proveedor;
END //
DELIMITER ;

-- 6. Procedimiento para eliminar un proveedor
DELIMITER //
CREATE PROCEDURE sp_EliminarProveedor(
    IN p_documento_proveedor INT
)
BEGIN
    DELETE FROM Proveedor WHERE documento_proveedor = p_documento_proveedor;
END //
DELIMITER ;

-- 7. Procedimiento para insertar un nuevo empleado
DELIMITER //
CREATE PROCEDURE sp_InsertarEmpleado(
    IN p_documento_id_empleado INT,
    IN p_nombre_empleado VARCHAR(100),
    IN p_tipo_empleado INT
)
BEGIN
    INSERT INTO Empleado(documento_id_empleado, nombre_empleado, tipo_empleado)
    VALUES (p_documento_id_empleado, p_nombre_empleado, p_tipo_empleado);
END //
DELIMITER ;

-- 8. Procedimiento para actualizar un empleado
DELIMITER //
CREATE PROCEDURE sp_ActualizarEmpleado(
    IN p_documento_id_empleado INT,
    IN p_nombre_empleado VARCHAR(100),
    IN p_tipo_empleado INT
)
BEGIN
    UPDATE Empleado
    SET nombre_empleado = p_nombre_empleado, 
        tipo_empleado = p_tipo_empleado
    WHERE documento_id_empleado = p_documento_id_empleado;
END //
DELIMITER ;

-- 9. Procedimiento para eliminar un empleado
DELIMITER //
CREATE PROCEDURE sp_EliminarEmpleado(
    IN p_documento_id_empleado INT
)
BEGIN
    DELETE FROM Empleado WHERE documento_id_empleado = p_documento_id_empleado;
END //
DELIMITER ;

-- 10. Procedimiento para verificar si un empleado es administrador
DELIMITER //
CREATE PROCEDURE sp_VerificarAdmin(
    IN p_documento_id_empleado INT
)
BEGIN
    SELECT EXISTS (
        SELECT 1 FROM Empleado e
        JOIN TipoEmpleado t ON e.tipo_empleado = t.id_tipo_empleado
        WHERE e.documento_id_empleado = p_documento_id_empleado
        AND t.nombre_tipo = 'Administrador'
    ) AS es_admin;
END //
DELIMITER ;

-- 11. Procedimiento para insertar un nuevo producto
DELIMITER //
CREATE PROCEDURE sp_InsertarProducto(
    IN p_nombre_producto VARCHAR(100),
    IN p_documento_proveedor INT,
    IN p_precio DECIMAL(10,2),
    IN p_stock INT
)
BEGIN
    INSERT INTO Producto(nombre_producto, documento_proveedor, precio, stock)
    VALUES (p_nombre_producto, p_documento_proveedor, p_precio, p_stock);
    
    SELECT LAST_INSERT_ID() as id_producto;
END //
DELIMITER ;

-- 12. Procedimiento para actualizar un producto
DELIMITER //
CREATE PROCEDURE sp_ActualizarProducto(
    IN p_id_producto INT,
    IN p_nombre_producto VARCHAR(100),
    IN p_documento_proveedor INT,
    IN p_precio DECIMAL(10,2),
    IN p_stock INT
)
BEGIN
    UPDATE Producto
    SET nombre_producto = p_nombre_producto, 
        documento_proveedor = p_documento_proveedor,
        precio = p_precio,
        stock = p_stock
    WHERE id_producto = p_id_producto;
END //
DELIMITER ;

-- 13. Procedimiento para eliminar un producto
DELIMITER //
CREATE PROCEDURE sp_EliminarProducto(
    IN p_id_producto INT
)
BEGIN
    DELETE FROM Producto WHERE id_producto = p_id_producto;
END //
DELIMITER ;

-- 14. Procedimiento para crear una nueva factura
DELIMITER //
CREATE PROCEDURE sp_CrearFactura(
    IN p_id_cliente INT,
    IN p_id_empleado INT
)
BEGIN
    INSERT INTO Factura(id_cliente, id_empleado)
    VALUES (p_id_cliente, p_id_empleado);
    
    SELECT LAST_INSERT_ID() as id_factura;
END //
DELIMITER ;

-- 15. Procedimiento para agregar un item a la factura
DELIMITER //
CREATE PROCEDURE sp_AgregarDetalleFactura(
    IN p_id_factura INT,
    IN p_id_producto INT,
    IN p_cantidad INT
)
BEGIN
    DECLARE v_precio DECIMAL(10,2);
    DECLARE v_subtotal DECIMAL(10,2);
    DECLARE v_stock_actual INT;
    
    -- Obtener precio y stock actual del producto
    SELECT precio, stock INTO v_precio, v_stock_actual 
    FROM Producto 
    WHERE id_producto = p_id_producto;
    
    -- Verificar stock suficiente
    IF v_stock_actual >= p_cantidad THEN
        -- Calcular subtotal
        SET v_subtotal = v_precio * p_cantidad;
        
        -- Insertar detalle
        INSERT INTO DetalleFactura(id_factura, id_producto, cantidad, precio_unitario, subtotal)
        VALUES (p_id_factura, p_id_producto, p_cantidad, v_precio, v_subtotal);
        
        -- Actualizar stock
        UPDATE Producto 
        SET stock = stock - p_cantidad 
        WHERE id_producto = p_id_producto;
        
        -- Actualizar total de la factura
        UPDATE Factura 
        SET total = total + v_subtotal 
        WHERE id_factura = p_id_factura;
        
        SELECT 'Producto agregado correctamente' AS resultado;
    ELSE
        SELECT 'Stock insuficiente' AS resultado;
    END IF;
END //
DELIMITER ;

-- 16. Procedimiento para anular una factura
DELIMITER //
CREATE PROCEDURE sp_AnularFactura(
    IN p_id_factura INT
)
BEGIN
    DECLARE done INT DEFAULT FALSE;
    DECLARE v_id_producto INT;
    DECLARE v_cantidad INT;
    
    -- Cursor para recorrer los detalles de la factura
    DECLARE cur CURSOR FOR 
        SELECT id_producto, cantidad 
        FROM DetalleFactura 
        WHERE id_factura = p_id_factura;
    
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;
    
    -- Comprobar si la factura existe
    IF EXISTS (SELECT 1 FROM Factura WHERE id_factura = p_id_factura) THEN
        -- Iniciar transacción
        START TRANSACTION;
        
        -- Abrir cursor
        OPEN cur;
        
        read_loop: LOOP
            FETCH cur INTO v_id_producto, v_cantidad;
            IF done THEN
                LEAVE read_loop;
            END IF;
            
            -- Restaurar stock
            UPDATE Producto 
            SET stock = stock + v_cantidad 
            WHERE id_producto = v_id_producto;
        END LOOP;
        
        CLOSE cur;
        
        -- Eliminar detalles de factura
        DELETE FROM DetalleFactura WHERE id_factura = p_id_factura;
        
        -- Eliminar factura
        DELETE FROM Factura WHERE id_factura = p_id_factura;
        
        COMMIT;
        
        SELECT 'Factura anulada correctamente' AS resultado;
    ELSE
        SELECT 'La factura no existe' AS resultado;
    END IF;
END //
DELIMITER ;

-- 17. Procedimiento para obtener una factura completa con sus detalles
DELIMITER //
CREATE PROCEDURE sp_ObtenerFacturaCompleta(
    IN p_id_factura INT
)
BEGIN
    -- Datos de la factura
    SELECT f.id_factura, f.fecha_factura, f.total,
           c.documento, c.nombre AS nombre_cliente, c.numero,
           e.documento_id_empleado, e.nombre_empleado, t.nombre_tipo AS tipo_empleado
    FROM Factura f
    JOIN Cliente c ON f.id_cliente = c.documento
    JOIN Empleado e ON f.id_empleado = e.documento_id_empleado
    JOIN TipoEmpleado t ON e.tipo_empleado = t.id_tipo_empleado
    WHERE f.id_factura = p_id_factura;
    
    -- Detalles de la factura
    SELECT df.id_detalle, df.id_producto, p.nombre_producto,
           df.cantidad, df.precio_unitario, df.subtotal
    FROM DetalleFactura df
    JOIN Producto p ON df.id_producto = p.id_producto
    WHERE df.id_factura = p_id_factura;
END //
DELIMITER ;

-- 18. Procedimiento para buscar productos por nombre
DELIMITER //
CREATE PROCEDURE sp_BuscarProductos(
    IN p_nombre VARCHAR(100)
)
BEGIN
    SELECT p.id_producto, p.nombre_producto, p.precio, p.stock,
           pv.documento_proveedor, pv.nombre_p AS nombre_proveedor
    FROM Producto p
    JOIN Proveedor pv ON p.documento_proveedor = pv.documento_proveedor
    WHERE p.nombre_producto LIKE CONCAT('%', p_nombre, '%');
END //
DELIMITER ;

-- 19. Procedimiento para obtener ventas por período
DELIMITER //
CREATE PROCEDURE sp_ObtenerVentasPorPeriodo(
    IN p_fecha_inicio DATETIME,
    IN p_fecha_fin DATETIME
)
BEGIN
    SELECT f.id_factura, f.fecha_factura, c.nombre AS cliente, 
           e.nombre_empleado, t.nombre_tipo AS tipo_empleado,
           f.total
    FROM Factura f
    JOIN Cliente c ON f.id_cliente = c.documento
    JOIN Empleado e ON f.id_empleado = e.documento_id_empleado
    JOIN TipoEmpleado t ON e.tipo_empleado = t.id_tipo_empleado
    WHERE f.fecha_factura BETWEEN p_fecha_inicio AND p_fecha_fin
    ORDER BY f.fecha_factura DESC;
END //
DELIMITER ;

-- 20. Procedimiento para obtener productos con stock bajo
DELIMITER //
CREATE PROCEDURE sp_ProductosStockBajo(
    IN p_limite_stock INT
)
BEGIN
    SELECT p.id_producto, p.nombre_producto, p.stock, p.precio,
           pv.nombre_p AS proveedor
    FROM Producto p
    JOIN Proveedor pv ON p.documento_proveedor = pv.documento_proveedor
    WHERE p.stock <= p_limite_stock
    ORDER BY p.stock ASC;
END //
DELIMITER ;

-- 21. Procedimiento para obtener el rendimiento de empleados (ventas)
DELIMITER //
CREATE PROCEDURE sp_RendimientoEmpleados(
    IN p_fecha_inicio DATETIME,
    IN p_fecha_fin DATETIME
)
BEGIN
    SELECT e.documento_id_empleado, e.nombre_empleado, 
           t.nombre_tipo AS tipo_empleado,
           COUNT(f.id_factura) AS total_facturas,
           SUM(f.total) AS monto_total
    FROM Empleado e
    JOIN TipoEmpleado t ON e.tipo_empleado = t.id_tipo_empleado
    LEFT JOIN Factura f ON e.documento_id_empleado = f.id_empleado
    WHERE (f.fecha_factura BETWEEN p_fecha_inicio AND p_fecha_fin OR f.fecha_factura IS NULL)
    GROUP BY e.documento_id_empleado, e.nombre_empleado, t.nombre_tipo
    ORDER BY monto_total DESC;
END //
DELIMITER ;

-- 22. Procedimiento para obtener todos los empleados
DELIMITER //
CREATE PROCEDURE sp_ObtenerEmpleados()
BEGIN
    SELECT e.documento_id_empleado, e.nombre_empleado,
           t.id_tipo_empleado, t.nombre_tipo
    FROM Empleado e
    JOIN TipoEmpleado t ON e.tipo_empleado = t.id_tipo_empleado
    ORDER BY e.nombre_empleado;
END //
DELIMITER ;

-- 23. Procedimiento para obtener todos los tipos de empleado
DELIMITER //
CREATE PROCEDURE sp_ObtenerTiposEmpleado()
BEGIN
    SELECT * FROM TipoEmpleado;
END //
DELIMITER ;