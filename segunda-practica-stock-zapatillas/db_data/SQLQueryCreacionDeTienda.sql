USE master -- Selecciono la base de datos master
GO
CREATE DATABASE TIENDA_DB -- Crea la base de datos TIENDA_DB
GO
USE TIENDA_DB -- Cambia el contexto para trabajar con TIENDA_DB
GO

-- Configuración de parámetros antes de crear tablas
SET ANSI_NULLS ON 
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creación de la tabla TIPOS
CREATE TABLE [dbo].[TIPOS] (
    [IdTipo] INT IDENTITY(1,1) NOT NULL, -- ID autoincremental
    [Descripcion] VARCHAR(20) NOT NULL, -- Nombre del tipo (Ej: Deportivo, Fútbol, etc.)
    CONSTRAINT [PK_TIPOS] PRIMARY KEY CLUSTERED ([IdTipo] ASC) -- Clave primaria
) ON [PRIMARY]
GO

-- Creación de la tabla ZAPATILLAS
CREATE TABLE [dbo].[ZAPATILLAS] (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [Nombre] VARCHAR(20) NOT NULL,
    [Talle] INT NOT NULL,
    [Marca] VARCHAR(20) NOT NULL,
    [EstaDisponible] BIT NOT NULL DEFAULT 1, -- 1 = Disponible, 0 = No Disponible
    [Codigo] INT NOT NULL DEFAULT (ABS(CHECKSUM(NEWID())) % 1000000), -- Número aleatorio entre 0 y 999999
    [IdTipo] INT NOT NULL, -- Relación con la tabla TIPOS
    CONSTRAINT [PK_ZAPATILLAS] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ZAPATILLAS_TIPOS] FOREIGN KEY ([IdTipo]) REFERENCES [dbo].[TIPOS]([IdTipo]) -- Relación con TIPOS
) ON [PRIMARY]
GO

-- Inserción de datos en TIPOS
INSERT INTO TIPOS (Descripcion) VALUES ('Deportivo')
INSERT INTO TIPOS (Descripcion) VALUES ('Fútbol')
INSERT INTO TIPOS (Descripcion) VALUES ('Running')
GO

-- Inserción de datos en ZAPATILLAS
INSERT INTO ZAPATILLAS (Nombre, Talle, Marca, EstaDisponible, IdTipo) 
VALUES ('Air Force One', 40, 'Nike', 1, 1) -- Suponiendo que "Deportivo" tiene IdTipo = 1
GO
