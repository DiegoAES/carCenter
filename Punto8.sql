CREATE PROCEDURE AjustarInventario 
	@RepuestoId int,
	@CantidadVendida int
AS
BEGIN
	UPDATE 
		Repuesto
	SET 
		UnidadesDisponibles = UnidadesDisponibles - @CantidadVendida
	WHERE
		RepuestoId = @RepuestoId
END
GO
