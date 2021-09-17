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