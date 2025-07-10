/***********
* Nombre del archivo: CargoResponse.cs
* Descripción:        **DTO** (Data Transfer Object) para la **respuesta de un cargo**.
*                     Esta clase encapsula los datos detallados de un cargo que se devuelven al cliente,
*                     incluyendo su identificador, nombre, estado de actividad, fechas de registro y modificación,
*                     así como los IDs de los usuarios que realizaron dichas acciones y un índice para ordenamiento o paginación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la respuesta de cargo.
***********/

namespace Empresa.Presentation.Cargo.Responses
{
    public class CargoResponse
    {
        public int nIdCargo { get; set; }
        public string sNombreCargo { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public int indice { get; set; }
    }
}
