/***********
* Nombre del archivo: CrearRolRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de creación de un nuevo rol.
*                     Contiene el nombre del rol, el identificador del usuario que lo registra
*                     y la fecha de registro.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la solicitud de creación de rol.
***********/

namespace Usuario.Application.Rol.Dtos
{
    public class CrearRolRequest
    {
        public string sNombreRol { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }
        public DateTime dtFechaRegistro { get; set; }
    }
}