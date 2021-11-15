
CREATE TABLE [dbo].[tblTipoMovimiento]
(
  [id]          INT NOT NULL IDENTITY, 
  [descripcion] NVARCHAR(50) NOT NULL,
  CONSTRAINT [PK_tblTipoMovimiento_id] PRIMARY KEY (id),
  CONSTRAINT [UQ_tblTipoMovimiento_descripcion] UNIQUE ([descripcion])
);

CREATE TABLE [dbo].[tblProducto]
(
  [id]            INT NOT NULL IDENTITY, 
  [codigoBarras]  NVARCHAR(50) NOT NULL, 
  [nombre]        NVARCHAR(255) NOT NULL, 
  [cantidad]      INT NOT NULL, 
  [precio]        INT NOT NULL, 
  [fechaCreacion] DATETIME NOT NULL
					  DEFAULT GETDATE(),
  CONSTRAINT [PK_tblProducto_id] PRIMARY KEY ([id]),
  CONSTRAINT [UQ_tblProducto_codigoBarras] UNIQUE([codigoBarras]),
  CONSTRAINT [UQ_tblProducto_nombre] UNIQUE([nombre]),
  CONSTRAINT [CK_tblProducto_cantidad] CHECK([cantidad] >= 0)
);

ALTER TABLE [dbo].[tblProducto]
ADD CONSTRAINT [CK_tblProducto_precio] CHECK([precio] >= 0);

CREATE TABLE [dbo].[tblMovimientoProducto]
(
  [id]                INT NOT NULL IDENTITY, 
  [producto_Id]       INT NOT NULL, 
  [tipoMovimiento_Id] INT NOT NULL, 
  [cantidad]          INT NOT NULL, 
  [fechaMovimiento]   DATETIME NOT NULL
						 DEFAULT GETDATE(),
  CONSTRAINT [PK_tblMovimientoProducto_id] PRIMARY KEY ([ID]),
  CONSTRAINT [FK_tblProducto_Id_tblMovimientoProducto_producto_Id] FOREIGN KEY([producto_Id]) REFERENCES [tblProducto]([Id]), 
  CONSTRAINT [FK_tblTipoMovimiento_Id_tblMovimientoProducto_tipoMovimiento_Id] FOREIGN KEY([tipoMovimiento_Id]) REFERENCES [tblTipoMovimiento]([Id]));

ALTER TABLE [dbo].[tblMovimientoProducto] ADD CONSTRAINT [CK_tblMovimientoProducto_precio] CHECK([cantidad] >= 0);

CREATE TABLE [dbo].[tblCombo]
(
  [id]       INT NOT NULL IDENTITY, 
  [nroCombo] int NOT NULL, 
  [nombre]   NVARCHAR(255) NOT NULL, 
  [subtotal] INT NULL,
  CONSTRAINT [PK_tblCombo_id] PRIMARY KEY([id]),
  CONSTRAINT [UQ_tblCombo_nroCombo] UNIQUE([nroCombo]),
  CONSTRAINT [UQ_tblCombo_nombre] UNIQUE([nombre]),
);

CREATE TABLE [dbo].[tblProductoxCombo]
(
  [id]          INT NOT NULL IDENTITY, 
  [combo_id]    INT NOT NULL, 
  [producto_id] INT NOT NULL,
  [cantidad]	INT NOT NULL,
  CONSTRAINT [PK_tblProductoxCombo_id] PRIMARY KEY ([id]),
  CONSTRAINT [FK_tblCombo_Id_tblproductoxCombo_combo_Id] FOREIGN KEY([combo_Id]) REFERENCES [tblCombo]([Id]), 
  CONSTRAINT [FK_tblProducto_Id_tblproductoxCombo_producto_Id] FOREIGN KEY([producto_Id]) REFERENCES [tblProducto]([Id]),
  CONSTRAINT [UQ_tblProductoxCombo_combo_id_producto_id] UNIQUE ([combo_id] , [producto_id])
);

CREATE TABLE [dbo].[tblPedido]
(
  [id]          INT NOT NULL IDENTITY, 
  [nroPedido]   INT NOT NULL, 
  [nombreCombo] NVARCHAR(255) NOT NULL, 
  [fechaPedido] DATETIME NOT NULL
					DEFAULT GETDATE(), 
  [envio]       BIT NOT NULL, 
  [valorEnvio]  INT NOT NULL, 
  [subtotal]    INT NOT NULL, 
  [total]       INT NOT NULL,
  CONSTRAINT [PK_tblPedido_id] PRIMARY KEY([id]),
  CONSTRAINT [UQ_tblPedido_nroPedido] UNIQUE([nroPedido]),
  --CONSTRAINT [UQ_tblPedido_nombreCombo] UNIQUE([nombreCombo]),
);

CREATE TABLE [dbo].[tblProductoxPedido]
(
  [id]          INT NOT NULL IDENTITY, 
  [pedido_id]   INT NOT NULL, 
  [producto_id] INT NOT NULL,
  [cantidad_producto]	INT NOT NULL,
  CONSTRAINT [PK_tblProductoxPedido_id] PRIMARY KEY(id),
  CONSTRAINT [FK_tblPedido_id_tblproductoxPedido_pedido_id] FOREIGN KEY([pedido_id]) REFERENCES [tblPedido]([id]), 
  CONSTRAINT [FK_tblProducto_id_tblproductoxPedido_producto_id] FOREIGN KEY([producto_id]) REFERENCES [tblProducto]([id]));

/*
Drop table tblproductoxPedido
Drop table tblPedido
Drop table tblproductoxCombo
Drop table tblCombo
Drop table tblMovimientoProducto
Drop table tblProducto
Drop table tblTipoMovimiento
*/
/*
SELECT CONSTRAINT_NAME,
     TABLE_SCHEMA ,
     TABLE_NAME,
     CONSTRAINT_TYPE
     FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
   WHERE TABLE_NAME in ('tblMovimientoProducto','tblProducto','tblTipoMovimiento','tblproductoxPedido','tblPedido','tblproductoxCombo','tblCombo')
   order by 3
*/

