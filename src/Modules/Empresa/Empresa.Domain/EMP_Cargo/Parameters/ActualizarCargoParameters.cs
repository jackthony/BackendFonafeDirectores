/***********
 * Nombre del archivo:  ActualizarCargoParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para actualizar un cargo existente, incluyendo ID, nombre, usuario y fecha de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase para parámetros de actualización de cargo.
 ***********/

namespace Empresa.Domain.Cargo.Parameters
{
    public class ActualizarCargoParameters
    {
        public int CargoId { get; set; }
        public string NombreCargo { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
