CREATE OR ALTER PROCEDURE updateVehiculoStatus
(
@vehiculo INT, 
@fecha   varchar(20)
)
AS
BEGIN
    UPDATE Vehiculo
      SET 
          Estado = CASE
                       WHEN
    (
        SELECT len(isnull(@fecha,''))
    ) = 0
                       THEN 'Rentado'
                       ELSE 'Disponible'
                   END
    WHERE id = @vehiculo;
END;