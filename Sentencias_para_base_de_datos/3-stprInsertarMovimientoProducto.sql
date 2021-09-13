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

    IF EXISTS (SELECT Id FROM tblTipoMovimiento WHERE descripcion = @tipoMovimiento_Descripcion)
		BEGIN
		  IF @tipoMovimiento_Id = 1
			  BEGIN
				INSERT INTO tblProducto (codigoBarras, nombre, cantidad, precio, fechaCreacion)
				  VALUES (@codigoBarras, @nombre, @cantidad, @precio, @fechaCreacion);

				DECLARE @idProductoInsertado int = SCOPE_IDENTITY();
				
				insert into tblMovimientoProducto (producto_Id, tipoMovimiento_Id,cantidad,fechaMovimiento)
					values (@idProductoInsertado, @tipoMovimiento_Id,@cantidad ,@fechaCreacion)

				SELECT
				  'Ejecucion correcta ' AS 'stpr';
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