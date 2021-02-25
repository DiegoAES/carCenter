declare @dias DATETIME

SET @dias = (SELECT DATEADD(DAY,-30,getdate()))

SELECT 
	top 100 R.Nombre
FROM
	Repuesto R
	INNER JOIN FacturaRepuestos FR on FR.RepuestoId = R.RepuestoId 
	INNER JOIN Factura F ON F.FacturaId = FR.FacturaId
WHERE 
	F.fecha > @dias
GROUP BY R.RepuestoId, R.Nombre
ORDER BY SUM(FR.NumeroUnidades) DESC

