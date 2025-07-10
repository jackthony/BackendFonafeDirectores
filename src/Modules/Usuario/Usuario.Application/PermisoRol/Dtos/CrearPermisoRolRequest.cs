/***********
* Nombre del archivo: CrearPermisoRolRequest.cs
* Descripción:        **DTO** (Data Transfer Object) para la solicitud de creación de un nuevo permiso de rol.
*                     Esta clase encapsula los datos necesarios para registrar un permiso
*                     específico que asocia un rol, un módulo y una acción. Incluye el ID del usuario
*                     que realiza el registro y la fecha de creación para propósitos de auditoría.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la creación de permisos de rol.
***********/

namespace Usuario.Application.PermisoRol.Dtos
{
    public class CrearPermisoRolRequest
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime dtFechaRegistro { get; set; }
    }
}
