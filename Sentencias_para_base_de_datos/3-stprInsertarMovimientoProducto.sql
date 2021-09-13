SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:    Ivan Bedoya
-- Create date: 2021-09-12
-- Description:	Pendiente la definición con base en su funcionalidad final
-- =============================================
ALTER PROCEDURE [stprInsertarMovimientoProducto]
-- Add the parameters for the stored procedure here
@codigoBarras nvarchar(50),
@nombre nvarchar(255),
@cantidad int,
@precio money,
@tipoMovimiento_Descripcion nvarchar(50)

AS
BEGIN

  -- SET NOCOUNT ON added to prevent extra result sets from
  -- interfering with SELECT statements.
  SET NOCOUNT ON;

  DECLARE @fechaCreacion datetime = GETDATE();
  DECLARE @tipoMovimiento_Id int;
	  SELECT
		@tipoMovimiento_Id = Id
	  FROM tblTipoMovimiento
	  WHERE descripcion = @tipoMovimiento_Descripcion;


  BEGIN TRY
	--SI el tipo de movimiento ingresado en el procedimiento almacenado existe comenzará a realizar las validaciones.
    IF EXISTS (SELECT Id FROM tblTipoMovimiento WHERE descripcion = @tipoMovimiento_Descripcion)
		BEGIN
		  IF @tipoMovimiento_Id = 1
			  BEGIN
				--SI el producto ingresado existe actualizará la cantidad en la tabla "tblProducto"
				--Insertará el registro en la tabla "tblMovimientoProducto"
				IF EXISTS (SELECT ID FROM tblProducto WHERE codigoBarras = @codigoBarras)
					BEGIN
						DECLARE @producto_id int;
						
						SELECT @producto_id = Id 
							FROM tblProducto 
							WHERE codigoBarras = @codigoBarras;

						UPDATE tblProducto 
							SET cantidad = cantidad + @cantidad
						FROM tblProducto
						WHERE ID = @producto_id

						INSERT INTO tblMovimientoProducto (producto_Id, tipoMovimiento_Id, cantidad, fechaMovimiento)
							VALUES (@producto_id, @tipoMovimiento_Id,@cantidad ,@fechaCreacion);


					END
				--Como el producto ingresado NO existe, se creará el registro en la tabla "tblProducto"
				--Insertará el registro en la tabla "tblMovimientoProducto"
				ELSE
					BEGIN
						INSERT INTO tblProducto (codigoBarras, nombre, cantidad, precio, fechaCreacion)
							VALUES (@codigoBarras, @nombre, @cantidad, @precio, @fechaCreacion);

						DECLARE @idProductoInsertado int = SCOPE_IDENTITY();
				
						INSERT INTO tblMovimientoProducto (producto_Id, tipoMovimiento_Id,cantidad,fechaMovimiento)
							VALUES (@idProductoInsertado, @tipoMovimiento_Id,@cantidad ,@fechaCreacion)

				SELECT
				  'PRODUCTO CREADO EXITOSAMENTE ' AS 'stpr';
					END

			  END
		  ELSE IF @tipoMovimiento_Id = 2
			  BEGIN
				SELECT
				  'TIPO MOVIMIENTO ES 2'
			  END
		  ELSE IF @tipoMovimiento_Id = 3
			  BEGIN
				SELECT
				  'TIPO MOVIMIENTO ES 3'
			  END
		  ELSE IF @tipoMovimiento_Id = 4
			  BEGIN
				SELECT
				  'TIPO MOVIMIENTO ES 4'
			  END

		  ELSE IF @tipoMovimiento_Id = 5
			  BEGIN
				SELECT
				  'TIPO MOVIMIENTO ES 5'
			  END

		END
    ELSE
      SELECT
        'No existe este tipo de movimiento para el producto'


  END TRY
  BEGIN CATCH

    --ROLLBACK TRANSACTION;
    SELECT
      ERROR_MESSAGE();


  END CATCH;






END

GO