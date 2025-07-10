/***********
 * Nombre del archivo:  CrearRubroParameters.cs
 * Descripción:         Clase que encapsula los parámetros necesarios para registrar un nuevo rubro,
 *                      incluyendo su nombre y los datos de auditoría de creación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de los parámetros de creación de rubro.
 ***********/

namespace Empresa.Domain.Rubro.Parameters
{
    public class CrearRubroParameters
    {
        public string NombreRubro { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
