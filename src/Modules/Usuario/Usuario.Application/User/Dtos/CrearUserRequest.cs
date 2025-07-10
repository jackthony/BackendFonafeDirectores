/***********
* Nombre del archivo: CrearUserRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de creación de un nuevo usuario.
*                     Implementa 'ITrackableRequest' para fines de auditoría y contiene todos los
*                     campos necesarios para registrar un usuario, incluyendo credenciales, datos personales,
*                     roles y estado, así como metadatos para el seguimiento.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para solicitudes de creación de usuario.
***********/

using Shared.Kernel.Interfaces;

namespace Usuario.Application.User.Dtos
{
    public class CrearUserRequest : ITrackableRequest
    {
        public required string sContrasena { get; set; } = default!;
        public required string sCorreoElectronico { get; set; } = default!;
        public required int nUsuarioRegistro { get; set; }
        public required string sApellidoPaterno { get; set; }
        public required string sApellidoMaterno { get; set; }
        public required string sNombres { get; set; }
        public int nIdCargo { get; set; }
        public int nTipoPersonal { get; set; }
        public int nIdRol { get; set; }
        public int nEstado { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "USUARIO";
        public string Tabla => "SEG_Usuario";
        public string CampoId => "nUsuarioId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
