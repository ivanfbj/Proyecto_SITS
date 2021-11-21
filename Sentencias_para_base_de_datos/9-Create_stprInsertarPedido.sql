SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan Bedoya
-- Create date: 2021-09-11
-- Description:	Procedimiento almacenado para guardar la información de los pedidos en las tablas  tblPedido y tblProductoxPedido
-- =============================================
ALTER PROCEDURE stprInsertarPedido 
	-- Add the parameters for the stored procedure here
	@INidPedido int = NULL,
	@nombreCombo nvarchar(255) = NULL,
	@envio bit = NULL,
	@valorEnvio int = NULL,
	@subtotal int = NULL,
	@total int = NULL,
	@codigoDeBarras nvarchar(50) = NULL,
	@cantidad_producto INT = NULL,
	@OUTidPedido int = NULL OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION;
			IF @INidPedido IS NULL
				BEGIN
					DECLARE @nroPedido int;

					--Obtener el nroPedido que se va a registrar
					select @nroPedido = ISNULL(max(nroPedido),0) + 1
						from tblPedido

					insert into tblPedido (nroPedido, nombreCombo, envio, valorEnvio, subtotal, total) values (@nroPedido, @nombreCombo, @envio, @valorEnvio, @subtotal, @total);

					set @OUTidPedido = SCOPE_IDENTITY();
				END
			ELSE IF @INidPedido IS NOT NULL
				BEGIN
					IF EXISTS(SELECT id FROM tblProducto where codigoBarras = @codigoDeBarras)
						BEGIN

							DECLARE @producto_id INT;

							SELECT @producto_id = id
								FROM tblProducto
								where codigoBarras = @codigoDeBarras;

							IF NOT EXISTS (select id from tblProductoxPedido where pedido_id = @INidPedido and producto_id = @producto_id)
								INSERT INTO tblProductoxPedido (pedido_id, producto_id, cantidad_producto) values (@INidPedido, @producto_id, @cantidad_producto);
							ELSE 
								BEGIN
									DECLARE @tblProductoxPedido_id INT;
									
									select @tblProductoxPedido_id  = id 
										from tblProductoxPedido
										where pedido_id = @INidPedido and producto_id = @producto_id

									UPDATE tblProductoxPedido set cantidad_producto += @cantidad_producto where id = @tblProductoxPedido_id;
								END
						END
					ELSE
							SELECT 'PRODUCTO NO EXISTE';
				END
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		SELECT ERROR_MESSAGE();
	END CATCH;
END
GO


/*
DECLARE @parametroSalida int;

exec stprInsertarPedido 
@INidPedido = '3',
@nombreCombo = 'Combo prueba Ivan',
@envio = 0,
@valorEnvio = '1000',
@subtotal = '1500',
@total = '2500',
--@codigoDeBarras = '7702993028261',
--@cantidad_producto = '2',
@OUTidPedido = @parametroSalida Output

--select @parametroSalida

select *
from tblPedido;

--exec stprInsertarPedido @INidPedido = 3, @codigoDeBarras = '7702133879494', @cantidad_producto = '2';

select *
from tblProductoxPedido;


select *
from tblProducto
where id in (select producto_id
from tblProductoxPedido)

/*
truncate table tblProductoxPedido

ALTER TABLE [dbo].[tblProductoxPedido] DROP CONSTRAINT [FK_tblPedido_id_tblproductoxPedido_pedido_id]

truncate table tblPedido

ALTER TABLE [dbo].[tblProductoxPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_id_tblproductoxPedido_pedido_id] FOREIGN KEY([pedido_id]) REFERENCES [dbo].[tblPedido] ([id])
GO

ALTER TABLE [dbo].[tblProductoxPedido] CHECK CONSTRAINT [FK_tblPedido_id_tblproductoxPedido_pedido_id]


*/
*/