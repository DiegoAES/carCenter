declare @dias DATETIME

SET @dias = (SELECT DATEADD(DAY,-60,getdate()))

SELECT 
	C.PrimerNombre, C.PrimerApellido
FROM
	Cliente C
	INNER JOIN Factura F on C.ClienteId = F.ClienteId 
WHERE 
	F.fecha > @dias
GROUP BY C.ClienteId, C.PrimerNombre, C.PrimerApellido
HAVING SUM(F.TotalFactura) > 1000000

