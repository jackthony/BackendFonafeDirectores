/***********
 * Nombre del archivo:  CrearEspecialidadParameters.cs
 * Descripción:         Clase que encapsula los parámetros requeridos para registrar una nueva especialidad,
 *                      incluyendo información de auditoría (usuario y fecha de registro).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para modelar los datos de creación de una especialidad.
 ***********/

namespace Empresa.Domain.Especialidad.Parameters
{
    public class CrearEspecialidadParameters
    {
        public string NombreEspecialidad { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
