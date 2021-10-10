
CREATE TABLE [dbo].[tblTipoMovimiento]
(
  [Id]          INT NOT NULL PRIMARY KEY IDENTITY, 
  [descripcion] NVARCHAR(50) NOT NULL UNIQUE);

CREATE TABLE [dbo].[tblProducto]
(
  [Id]            INT NOT NULL PRIMARY KEY IDENTITY, 
  [codigoBarras]  NVARCHAR(50) NOT NULL UNIQUE, 
  [nombre]        NVARCHAR(255) NOT NULL UNIQUE, 
  [cantidad]      INT NOT NULL, 
  [precio]        MONEY NOT NULL, 
  [fechaCreacion] DATETIME NOT NULL
					  DEFAULT GETDATE());

ALTER TABLE [dbo].[tblProducto]
ADD CONSTRAINT [Check_tblProducto_precio] CHECK(0 <= [precio]);

CREATE TABLE [dbo].[tblMovimientoProducto]
(
  [Id]                INT NOT NULL PRIMARY KEY IDENTITY, 
  [producto_Id]       INT NOT NULL, 
  [tipoMovimiento_Id] INT NOT NULL, 
  [cantidad]          INT NOT NULL, 
  [fechaMovimiento]   DATETIME NOT NULL
						 DEFAULT GETDATE(), 
  CONSTRAINT [FK_tblProducto_Id_tblMovimientoProducto_producto_Id] FOREIGN KEY([producto_Id]) REFERENCES [tblProducto]([Id]), 
  CONSTRAINT [FK_tblTipoMovimiento_Id_tblMovimientoProducto_tipoMovimiento_Id] FOREIGN KEY([tipoMovimiento_Id]) REFERENCES [tblTipoMovimiento]([Id]));

ALTER TABLE [dbo].[tblMovimientoProducto]
ADD CONSTRAINT [Check_tblMovimientoProducto_precio] CHECK(0 <= [precio]);

CREATE TABLE [dbo].[tblCombo]
(
  [Id]       INT NOT NULL PRIMARY KEY IDENTITY, 
  [nroCombo] NVARCHAR(50) NOT NULL UNIQUE, 
  [nombre]   NVARCHAR(255) NOT NULL, 
  [subtotal] MONEY NOT NULL, );

CREATE TABLE [dbo].[tblproductoxCombo]
(
  [Id]          INT NOT NULL PRIMARY KEY IDENTITY, 
  [combo_Id]    INT NOT NULL, 
  [producto_Id] INT NOT NULL, 
  CONSTRAINT [FK_tblCombo_Id_tblproductoxCombo_combo_Id] FOREIGN KEY([combo_Id]) REFERENCES [tblCombo]([Id]), 
  CONSTRAINT [FK_tblProducto_Id_tblproductoxCombo_producto_Id] FOREIGN KEY([producto_Id]) REFERENCES [tblProducto]([Id]));
CREATE TABLE [dbo].[tblPedido]
(
  [Id]          INT NOT NULL PRIMARY KEY IDENTITY, 
  [nroPedido]   NVARCHAR(50) NOT NULL UNIQUE, 
  [nombreCombo] NVARCHAR(50) NOT NULL UNIQUE, 
  [fechaPedido] DATETIME NOT NULL
					DEFAULT GETDATE(), 
  [envio]       BIT NOT NULL, 
  [valorEnvio]  MONEY NOT NULL, 
  [subtotal]    MONEY NOT NULL, 
  [total]       MONEY NOT NULL, );

CREATE TABLE [dbo].[tblproductoxPedido]
(
  [Id]          INT NOT NULL PRIMARY KEY IDENTITY, 
  [pedido_Id]   INT NOT NULL, 
  [producto_Id] INT NOT NULL, 
  CONSTRAINT [FK_tblPedido_Id_tblproductoxPedido_pedido_Id] FOREIGN KEY([pedido_Id]) REFERENCES [tblPedido]([Id]), 
  CONSTRAINT [FK_tblProducto_Id_tblproductoxPedido_producto_Id] FOREIGN KEY([producto_Id]) REFERENCES [tblProducto]([Id]));
/*
Drop table tblMovimientoProducto
Drop table tblProducto
Drop table tblTipoMovimiento
Drop table tblproductoxPedido
Drop table tblPedido
Drop table tblproductoxCombo
Drop table tblCombo
*/