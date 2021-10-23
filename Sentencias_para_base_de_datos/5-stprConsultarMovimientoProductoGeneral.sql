SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
-- =============================================
-- Author:  	Ivan Bedoya
-- Create date: 2021-09-16
-- Description:	Permite consultar el inventario de los productos, agrupando por los movimientos de entrada y salida del productos
-- =============================================
ALTER PROCEDURE [dbo].[stprConsultarMovimientoProductoGeneral]
-- Add the parameters for the stored procedure here

AS
    BEGIN
        SET NOCOUNT ON;
        SELECT codigoBarras, 
               nombre, 
               Entradas.Total AS 'Entradas', 
               ISNULL(Salidas.Total, 0) AS 'Salidas', 
               cantidad AS 'stock', 
               precio
        FROM tblProducto AS pro
             INNER JOIN(SELECT producto_Id, 
                               TipMov.descripcion AS 'TipoMovimiento', 
                               SUM(cantidad) AS 'Total'
                        FROM tblMovimientoProducto AS MovPro
                             INNER JOIN tblTipoMovimiento AS TipMov ON MovPro.tipoMovimiento_Id = TipMov.id
                        WHERE TipMov.descripcion IN('Entrada')
                        GROUP BY producto_Id, 
                                 TipMov.descripcion) AS "Entradas" ON pro.id = Entradas.producto_Id
             LEFT JOIN(SELECT producto_Id, 
                              TipMov.descripcion AS 'TipoMovimiento', 
                              SUM(cantidad) AS 'Total'
                       FROM tblMovimientoProducto AS MovPro
                            INNER JOIN tblTipoMovimiento AS TipMov ON MovPro.tipoMovimiento_Id = TipMov.id
                       WHERE TipMov.descripcion IN('Salida', 'Averia', 'Consumo Personal', 'Otro')
                       GROUP BY producto_Id, 
                                TipMov.descripcion) AS "Salidas" ON pro.id = Salidas.producto_Id;
    END;