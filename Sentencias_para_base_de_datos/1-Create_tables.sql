CREATE TABLE [dbo].[tblTipoMovimiento]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [descripcion] NVARCHAR(50) not NULL unique
)

CREATE TABLE [dbo].[tblProducto]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [codigoBarras] NVARCHAR(50) NOT NULL unique, 
    [nombre] NVARCHAR(255) NOT NULL, 
    [cantidad] INT NOT NULL, 
    [precio] MONEY NOT NULL, 
    [fechaCreacion] DATETIME NOT NULL DEFAULT Getdate() 
)

CREATE TABLE [dbo].[tblMovimientoProducto]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [producto_Id] INT NOT NULL, 
    [tipoMovimiento_Id] INT NOT NULL,
	[cantidad] INT NOT NULL,
    [fechaMovimiento] DATETIME NOT NULL DEFAULT Getdate(),
	CONSTRAINT FK_tblProducto_Id_tblMovimientoProducto_producto_Id FOREIGN KEY (producto_Id) REFERENCES tblProducto (Id),
	CONSTRAINT FK_tblTipoMovimiento_Id_tblMovimientoProducto_tipoMovimiento_Id FOREIGN KEY (tipoMovimiento_Id) REFERENCES tblTipoMovimiento (Id)
 
)

