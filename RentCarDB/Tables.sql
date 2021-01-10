--CREATE DATABASE SistemaRentCar;
GO
USE SistemaRentCar;
GO
-- ESTADO (ACTIVO/INACTIVO)
-- ESTADO VEHICULO (DISPONIBLE/RENTADO/MANTENIMIENTO)
-- TIPO PERSONA (FISICA/JURIDICA)
-- TANDA (MATUTINA/VESPERTINA/MIXTA)
-- Cuando un vehiculo se renta, crear trigger o buscard id de vehiculo para actualizar estado a RENTADO
-- Cuando se llena la fecha de devolucion, actualizar estado a Disponible
-- LOS UNICOS VEHICULOS QUE ESTARAN EN LA LISTA PARA RENTAR SON LOS DISPONIBLES
-- ESTADO GOMAS (CORRECTO/INCORRECTO)
--------------------------------------------------------------------------------------
IF OBJECT_ID('dbo.RentaDevolucion', 'U') IS NOT NULL
    DROP TABLE dbo.RentaDevolucion;
GO
IF OBJECT_ID('dbo.Inspeccion', 'U') IS NOT NULL
    DROP TABLE dbo.Inspeccion;
GO
IF OBJECT_ID('dbo.Empleado', 'U') IS NOT NULL
    DROP TABLE dbo.Empleado;
GO
IF OBJECT_ID('dbo.Cliente', 'U') IS NOT NULL
    DROP TABLE dbo.Cliente;
GO
IF OBJECT_ID('dbo.Vehiculo', 'U') IS NOT NULL
    DROP TABLE dbo.Vehiculo;
GO
IF OBJECT_ID('dbo.TipoCombustible', 'U') IS NOT NULL
    DROP TABLE dbo.TipoCombustible;
GO
IF OBJECT_ID('dbo.Modelo', 'U') IS NOT NULL
    DROP TABLE dbo.Modelo;
GO
IF OBJECT_ID('dbo.Marca', 'U') IS NOT NULL
    DROP TABLE dbo.Marca;
GO
IF OBJECT_ID('dbo.TipoVehiculo', 'U') IS NOT NULL
    DROP TABLE dbo.TipoVehiculo;
GO
--------------------------------------------------------------------------------------
CREATE TABLE TipoVehiculo
(Id          INT
 PRIMARY KEY NOT NULL, 
 Descripcion VARCHAR(50), 
 Estado      VARCHAR(10)
);
GO
CREATE TABLE Marca
(Id          INT
 PRIMARY KEY NOT NULL, 
 Descripcion VARCHAR(50), 
 Estado      VARCHAR(10)
);
GO
CREATE TABLE Modelo
(Id          INT
 PRIMARY KEY NOT NULL, 
 Descripcion VARCHAR(50), 
 Estado      VARCHAR(10), 
 Marca       INT NOT NULL
                 FOREIGN KEY REFERENCES Marca(Id)
);
GO
CREATE TABLE TipoCombustible
(Id          INT
 PRIMARY KEY NOT NULL, 
 Descripcion VARCHAR(50), 
 Estado      VARCHAR(10)
);
GO
CREATE TABLE Vehiculo
(Id              INT
 PRIMARY KEY NOT NULL, 
 Descripcion     VARCHAR(50), 
 Chasis          VARCHAR(50), 
 Motor           VARCHAR(50), 
 Placa           VARCHAR(50), 
 Estado          VARCHAR(10), 
 TipoVehiculo    INT NOT NULL
                     FOREIGN KEY REFERENCES TipoVehiculo(Id), 
 Marca           INT NOT NULL
                     FOREIGN KEY REFERENCES Marca(Id), 
 Modelo          INT NOT NULL
                     FOREIGN KEY REFERENCES Modelo(Id), 
 TipoCombustible INT NOT NULL
                     FOREIGN KEY REFERENCES TipoCombustible(Id)
);
GO
CREATE TABLE Cliente
(Id             INT
 PRIMARY KEY NOT NULL, 
 Nombre         VARCHAR(50), 
 Apellido       VARCHAR(50), 
 Cedula         VARCHAR(50), 
 TarjetaCredito VARCHAR(50), 
 LimiteCredito  DECIMAL(18, 2), 
 TipoPersona    VARCHAR(10), 
 Estado         VARCHAR(10)
);
GO
CREATE TABLE Empleado
(Id           INT
 PRIMARY KEY NOT NULL, 
 Nombre       VARCHAR(50), 
 Apellido     VARCHAR(50), 
 Cedula       VARCHAR(50), 
 Tanda        VARCHAR(15), 
 Comision     DECIMAL(18, 2), 
 FechaIngreso DATE, 
 Estado       VARCHAR(10), 
 Contrasena   VARCHAR(20)
);
GO
CREATE TABLE Inspeccion
(Id                    INT
 PRIMARY KEY NOT NULL, 
 Vehiculo              INT FOREIGN KEY REFERENCES Vehiculo(Id), 
 Cliente               INT FOREIGN KEY REFERENCES Cliente(Id), 
 Ralladuras            CHAR(2), 
 CantidadCombustible   VARCHAR(10), 
 GomaRepuesto          CHAR(2), 
 Gato                  CHAR(2), 
 RoturaCristal         CHAR(2), 
 Fecha                 DATE, 
 Empleado              INT FOREIGN KEY REFERENCES Empleado(Id), 
 EstadoGomasDelanteras VARCHAR(10), 
 EstadoGomasTraseras   VARCHAR(10), 
 Estado                VARCHAR(10)
);
GO
CREATE TABLE RentaDevolucion
(Id              INT
 PRIMARY KEY NOT NULL, 
 Empleado        INT FOREIGN KEY REFERENCES Empleado(Id), 
 Vehiculo        INT FOREIGN KEY REFERENCES Vehiculo(Id), 
 Cliente         INT FOREIGN KEY REFERENCES Cliente(Id), 
 FechaRenta      DATE, 
 FechaDevolucion DATE, 
 MontoDia        DECIMAL(18, 2), 
 Dias            INT, 
 Comentario      VARCHAR(200), 
 Estado          VARCHAR(10)
);
GO