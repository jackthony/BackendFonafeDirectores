/***********
 * Nombre del archivo:  CrearSectorParameters.cs
 * Descripción:         Clase que encapsula los parámetros requeridos para registrar un nuevo sector,
 *                      incluyendo el nombre y los datos de trazabilidad del usuario que lo registra.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros para creación de sector.
 ***********/

namespace Empresa.Domain.Sector.Parameters
{
    public class CrearSectorParameters
    {
        public string NombreSector { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
