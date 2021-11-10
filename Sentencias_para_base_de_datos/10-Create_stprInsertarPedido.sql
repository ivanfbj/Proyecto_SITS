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
	@INidPedido int, 
	@codigoDeBarras nvarchar(50),
	@OUTidPedido int OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT @INidPedido, @codigoDeBarras;

	select @OUTidPedido = 123;

	if @INidPedido = ''
		select 'INidPedido está vacío'
END
GO


/*
DECLARE @parametroSalida int;

exec stprInsertarPedido '123','dfj',@parametroSalida Output

select @parametroSalida
*/