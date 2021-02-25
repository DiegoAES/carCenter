declare @dias DATETIME

SET @dias = (SELECT DATEADD(DAY,-60,getdate()))

SELECT 
	T.Nombre
FROM
	Tienda T
	INNER JOIN Factura F on T.TiendaId = F.TiendaId 
	INNER JOIN FacturaRepuestos FR ON FR.FacturaId = F.FacturaId
WHERE 
	F.fecha > @dias
	AND FR.RepuestoId = 100
GROUP BY T.TiendaId, T.Nombre
HAVING SUM(FR.NumeroUnidades) > 100

