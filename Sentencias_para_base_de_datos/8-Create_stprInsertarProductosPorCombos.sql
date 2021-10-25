SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan Bedoya
-- Create date: 2021-10-24
-- Description:	Procedimiento para realizar la creación de los combos y asignación de productos
-- =============================================
ALTER PROCEDURE [stprInsertarProductosPorCombos] 
	-- Add the parameters for the stored procedure here
	@tblCombo_nroCombo			int,
	@tblCombo_nombre			NVARCHAR(255),
	@tblProducto_codigoBarras	NVARCHAR(50),
	@tblProductoxCombo_cantidad	int
AS
BEGIN

	SET NOCOUNT ON;
	DECLARE @tblCombo_id INT;
	DECLARE @tblProducto_id INT;
	declare @tblCombo_subtotal INT;

	SELECT @tblCombo_id = id
	FROM tblCombo
	WHERE nombre = @tblCombo_nombre;

	SELECT @tblProducto_id = id
    FROM tblProducto
    WHERE codigoBarras = @tblProducto_codigoBarras

	BEGIN TRY
		BEGIN TRANSACTION;
			IF EXISTS(select id
						from tblCombo
						where nombre = @tblCombo_nombre)
				BEGIN
					INSERT INTO tblProductoxCombo (combo_id,producto_id,cantidad) VALUES (@tblCombo_id, @tblProducto_id, @tblProductoxCombo_cantidad);
					
					SELECT @tblCombo_subtotal  = SUM(p.precio * pc.cantidad)
						FROM tblCombo as c
						INNER JOIN tblProductoxCombo as pc on c.id = pc.combo_id
						INNER JOIN tblProducto as p on pc.producto_id = p.id
						WHERE c.id = @tblcombo_id
						GROUP BY c.id,nroCombo,c.subtotal;
					
					update tblCombo set subtotal = @tblCombo_subtotal where id = @tblCombo_id;
				END;
			ELSE
				BEGIN
					INSERT INTO tblCombo (nroCombo, nombre) VALUES (@tblCombo_nroCombo, @tblCombo_nombre);
					DECLARE @idComboInsertado INT= SCOPE_IDENTITY();
					INSERT INTO tblProductoxCombo (combo_id,producto_id,cantidad) VALUES (@idComboInsertado, @tblProducto_id, @tblProductoxCombo_cantidad);
					
					SELECT @tblCombo_subtotal  = SUM(p.precio * pc.cantidad)
						FROM tblCombo as c
						INNER JOIN tblProductoxCombo as pc on c.id = pc.combo_id
						INNER JOIN tblProducto as p on pc.producto_id = p.id
						WHERE c.id = @tblcombo_id
						GROUP BY c.id,nroCombo,c.subtotal;
					
					update tblCombo set subtotal = @tblCombo_subtotal where id = @tblCombo_id;
				END;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		SELECT ERROR_MESSAGE();
	END CATCH;




END
GO
