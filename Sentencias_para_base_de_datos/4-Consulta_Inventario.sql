select codigoBarras
	,nombre
	,Entradas.Total as 'Entradas'
	,isNull(Salidas.Total,0) as 'Salidas'
	, cantidad as 'stock'
	,precio
from tblProducto as pro
inner join (
			select	producto_Id
					,TipMov.descripcion as 'TipoMovimiento'
					,sum(cantidad) as 'Total'
				from tblMovimientoProducto as MovPro
					inner join tblTipoMovimiento as TipMov on MovPro.tipoMovimiento_Id=TipMov.id
			where TipMov.descripcion in ('Entrada')
			group by producto_Id,TipMov.descripcion ) AS "Entradas"  on pro.id=Entradas.producto_Id
left join (
			select	producto_Id
					,TipMov.descripcion as 'TipoMovimiento'
					,sum(cantidad) as 'Total'
				from tblMovimientoProducto as MovPro
					inner join tblTipoMovimiento as TipMov on MovPro.tipoMovimiento_Id=TipMov.id
			where TipMov.descripcion in ('Salida','Averia','Consumo Personal','Otro')
			group by producto_Id,TipMov.descripcion ) AS "Salidas"  on pro.id=Salidas.producto_Id

			