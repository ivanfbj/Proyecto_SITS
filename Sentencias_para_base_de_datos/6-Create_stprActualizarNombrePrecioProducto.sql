SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan Bedoya
-- Create date: 2021-10-10
-- Description:	Actualización del nombre o precio del producto
-- =============================================
CREATE PROCEDURE [dbo].[stprActualizarNombrePrecioProducto]
	@codigoBarras		NVARCHAR(50),
	@nombreOprecio		NVARCHAR(255),
	@columnaActualizar	NVARCHAR(255)

AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @producto_id INT;
	BEGIN TRY
		BEGIN TRANSACTION;

			IF EXISTS(SELECT id FROM tblProducto
						where codigoBarras = @codigoBarras)
				BEGIN
					SELECT @producto_id = id
					FROM tblProducto
					where codigoBarras = @codigoBarras;

					IF @columnaActualizar = 'nombre'
						UPDATE tblProducto SET nombre = @nombreOprecio where id = @producto_id;
					ELSE
					IF @columnaActualizar = 'precio'
						UPDATE tblProducto SET precio = @nombreOprecio where id = @producto_id;
					ELSE
					SELECT 'COLUMNA NO PARAMETRIZADA';

				END;
			ELSE
			Select 'No existe este producto';
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		SELECT ERROR_MESSAGE();
	END CATCH;

END;

