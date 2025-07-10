/***********
 * Nombre del archivo:  CrearMinisterioParameters.cs
 * Descripción:         Clase de parámetros utilizada para registrar un nuevo Ministerio, incluyendo información del usuario que realiza el registro y la fecha.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para la operación de creación de ministerios.
 ***********/

namespace Empresa.Domain.Ministerio.Parameters
{
    public class CrearMinisterioParameters
    {
        public string NombreMinisterio { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
