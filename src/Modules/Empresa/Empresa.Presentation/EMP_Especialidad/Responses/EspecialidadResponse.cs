/***********
 * Nombre del archivo:  EspecialidadResponse.cs
 * Descripción:         Clase DTO que representa la respuesta del módulo Especialidad.
 *                      Contiene propiedades que describen la información de una especialidad,
 *                      incluyendo su identificador, nombre, estado, fechas de registro y modificación,
 *                      así como los usuarios responsables y un índice auxiliar.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial del DTO EspecialidadResponse.
 ***********/

namespace Empresa.Presentation.Especialidad.Responses
{
    public class EspecialidadResponse
    {
        public int nIdEspecialidad { get; set; }
        public string sNombreEspecialidad { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public int indice { get; set; }
    }
}
