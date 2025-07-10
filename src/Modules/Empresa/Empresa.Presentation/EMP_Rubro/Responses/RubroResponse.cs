/***********
 * Nombre del archivo:  RubroResponse.cs
 * Descripción:         Clase DTO que representa la respuesta del módulo Rubro.
 *                      Contiene propiedades que describen la información de un rubro, incluyendo
 *                      su estado, fechas de registro/modificación y usuario responsable.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Definición inicial del DTO RubroResponse.
 ***********/

namespace Empresa.Presentation.Rubro.Responses
{
    public class RubroResponse
    {
        public int nIdRubro { get; set; }
        public string sNombreRubro { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public int indice { get; set; }
    }
}
