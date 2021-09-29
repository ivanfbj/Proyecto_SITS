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

CREATE TABLE [dbo].[tblCombo]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [nroCombo] NVARCHAR(50) NOT NULL unique, 
    [nombre] NVARCHAR(255) NOT NULL,  
    [subtotal] MONEY NOT NULL, 
)

CREATE TABLE [dbo].[tblproductoxCombo]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [combo_Id] INT NOT NULL, 
    [producto_Id] INT NOT NULL, 
	CONSTRAINT FK_tblCombo_Id_tblproductoxCombo_combo_Id FOREIGN KEY (combo_Id) REFERENCES tblCombo (Id),
	CONSTRAINT FK_tblProducto_Id_tblproductoxCombo_producto_Id FOREIGN KEY (producto_Id) REFERENCES tblProducto (Id),
)
CREATE TABLE [dbo].[tblPedido]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [nroPedido] NVARCHAR(50) NOT NULL unique, 
    [nombreCombo] NVARCHAR(50) NOT NULL unique,
    [envio] BIT NOT NULL, 
    [valorEnvio] MONEY NOT NULL,
    [subtotal] MONEY NOT NULL, 
    [total] MONEY NOT NULL,

)
CREATE TABLE [dbo].[tblproductoxPedido]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [pedido_Id] INT NOT NULL, 
    [producto_Id] INT NOT NULL, 
	CONSTRAINT FK_tblPedido_Id_tblproductoxPedido_pedido_Id FOREIGN KEY (pedido_Id) REFERENCES tblPedido (Id),
	CONSTRAINT FK_tblProducto_Id_tblproductoxPedido_producto_Id FOREIGN KEY (producto_Id) REFERENCES tblProducto (Id),
)