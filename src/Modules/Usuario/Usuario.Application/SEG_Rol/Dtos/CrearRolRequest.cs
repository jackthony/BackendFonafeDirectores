/***********
* Nombre del archivo: CrearRolRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de creación de un nuevo rol.
*                     Contiene el nombre del rol, el identificador del usuario que lo registra
*                     y la fecha de registro.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la solicitud de creación de rol.
***********/

namespace Usuario.Application.Rol.Dtos
{
    public class CrearRolRequest
    {
        public string sNombreRol { get; set; } = default!;
        public int nIdUsuarioCreacion { get; set; }
        public bool bActivo { get; set; }
    }
}