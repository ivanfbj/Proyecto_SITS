SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan Bedoya
-- Create date: 2021-10-25
-- Description:	Consultar la lista de los productos asociados a un Combo
-- =============================================
ALTER PROCEDURE stprConsultarProductosDelCombo 
	-- Add the parameters for the stored procedure here
	@tblCombo_nombre nvarchar(255)  
	  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		select	c.nroCombo
				,c.nombre as 'nombreCombo'
				,c.subtotal as 'subtotalCombo'
				,p.codigoBarras
				,p.nombre as 'nombreProducto'
				,p.cantidad as 'stock'
				,p.precio
				,pc.cantidad as 'cantidadDelCombo'
			from tblCombo as c
			inner join tblProductoxCombo as pc on c.id = pc.combo_id
			INNER JOIN tblProducto as p on pc.producto_id = p.id
			where c.nombre = @tblCombo_nombre
END
GO
