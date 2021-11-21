SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
-- =============================================
-- Author:    Ivan Bedoya
-- Create date: 2021-09-12
-- Description:	Pendiente la definición con base en su funcionalidad final
-- =============================================
CREATE PROCEDURE [stprInsertarMovimientoProducto]
-- Add the parameters for the stored procedure here
@codigoBarras               NVARCHAR(50), 
@nombre                     NVARCHAR(255), 
@cantidad                   INT, 
@precio                     INT, 
@tipoMovimiento_Descripcion NVARCHAR(50)
AS
    BEGIN

        -- SET NOCOUNT ON added to prevent extra result sets from
        -- interfering with SELECT statements.
        SET NOCOUNT ON;
        DECLARE @fechaCreacion DATETIME= GETDATE();
        DECLARE @tipoMovimiento_Id INT;
        
		SELECT @tipoMovimiento_Id = Id
        FROM tblTipoMovimiento
        WHERE descripcion = @tipoMovimiento_Descripcion;
        
		DECLARE @producto_id INT;
        BEGIN TRY
            BEGIN TRANSACTION;
            --SI el tipo de movimiento ingresado en el procedimiento almacenado existe comenzará a realizar las validaciones.
            IF EXISTS(SELECT Id
                      FROM tblTipoMovimiento
                      WHERE descripcion = @tipoMovimiento_Descripcion)
                BEGIN
                    IF @tipoMovimiento_Id = 1
                        BEGIN
                            --SI el producto ingresado existe actualizará la cantidad en la tabla "tblProducto"
                            --Insertará el registro en la tabla "tblMovimientoProducto"
                            IF EXISTS(SELECT ID
                                      FROM tblProducto
                                      WHERE codigoBarras = @codigoBarras)
                                BEGIN
                                    SELECT @producto_id = Id
                                    FROM tblProducto
                                    WHERE codigoBarras = @codigoBarras;
                                    UPDATE tblProducto
                                      SET 
                                          cantidad = cantidad + @cantidad
                                    FROM tblProducto
                                    WHERE ID = @producto_id;
                                    INSERT INTO tblMovimientoProducto
                                    (producto_Id, 
                                     tipoMovimiento_Id, 
                                     cantidad, 
                                     fechaMovimiento
                                    )
                                    VALUES
                                    (@producto_id, 
                                     @tipoMovimiento_Id, 
                                     @cantidad, 
                                     @fechaCreacion
                                    );
                            END
                                    --Como el producto ingresado NO existe, se creará el registro en la tabla "tblProducto"
                                    --Insertará el registro en la tabla "tblMovimientoProducto";
                                ELSE
                                BEGIN
                                    INSERT INTO tblProducto
                                    (codigoBarras, 
                                     nombre, 
                                     cantidad, 
                                     precio, 
                                     fechaCreacion
                                    )
                                    VALUES
                                    (@codigoBarras, 
                                     @nombre, 
                                     @cantidad, 
                                     @precio, 
                                     @fechaCreacion
                                    );
                                    DECLARE @idProductoInsertado INT= SCOPE_IDENTITY();
                                    INSERT INTO tblMovimientoProducto
                                    (producto_Id, 
                                     tipoMovimiento_Id, 
                                     cantidad, 
                                     fechaMovimiento
                                    )
                                    VALUES
                                    (@idProductoInsertado, 
                                     @tipoMovimiento_Id, 
                                     @cantidad, 
                                     @fechaCreacion
                                    );
                            END;
                    END;
                        ELSE
                        IF @tipoMovimiento_Id = 2
                            BEGIN
                                SELECT @producto_id = Id
                                FROM tblProducto
                                WHERE codigoBarras = @codigoBarras;
                                IF(SELECT cantidad - @cantidad
                                   FROM tblProducto
                                   WHERE id = @producto_id) >= 0
                                    BEGIN
                                        UPDATE tblProducto
                                          SET 
                                              cantidad = cantidad - @cantidad
                                        FROM tblProducto
                                        WHERE ID = @producto_id;
                                        
										INSERT INTO tblMovimientoProducto
                                        (producto_Id, 
                                         tipoMovimiento_Id, 
                                         cantidad, 
                                         fechaMovimiento
                                        )
                                        VALUES
                                        (@producto_id, 
                                         @tipoMovimiento_Id, 
                                         @cantidad, 
                                         @fechaCreacion
                                        );
                                END;
                                    ELSE
                                    SELECT 'La cantidad a descontar es superior a la cantidad actual en el inventario';
                        END;
                            ELSE
                            IF @tipoMovimiento_Id = 3
                                BEGIN
                                    SELECT 'TIPO MOVIMIENTO ES 3';
                            END;
                                ELSE
                                IF @tipoMovimiento_Id = 4
                                    BEGIN
                                        SELECT 'TIPO MOVIMIENTO ES 4';
                                END;
                                    ELSE
                                    IF @tipoMovimiento_Id = 5
                                        BEGIN
                                            SELECT 'TIPO MOVIMIENTO ES 5';
                                    END;
            END;
                ELSE
                SELECT 'No existe este tipo de movimiento para el producto';
            COMMIT TRANSACTION;
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION;
            SELECT ERROR_MESSAGE();
        END CATCH;
    END;
GO