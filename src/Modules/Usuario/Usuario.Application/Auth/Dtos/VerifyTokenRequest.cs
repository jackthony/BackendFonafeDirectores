/***********
* Nombre del archivo: VerifyTokenRequest.cs
* Descripción:        **DTO** (Data Transfer Object) para la solicitud de verificación de un token de acceso.
*                     Esta clase se utiliza principalmente para las operaciones de validación de tokens,
*                     como en el caso de un cierre de sesión, donde se necesita el token para identificar la sesión.
*                     Implementa `ISistemaRequest` para incluir metadatos de auditoría como el `Origen`, `Estado`, `Mensaje` y `TipoEvento`,
*                     aunque el `UsuarioId` es `null` aquí, ya que se espera extraer del token mismo.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la verificación de tokens, incluyendo metadatos de sistema.
***********/

using Shared.Kernel.Interfaces;

namespace Usuario.Application.Auth.Dtos
{
    public class VerifyTokenRequest : ISistemaRequest
    {
        public string Token { get; set; } = string.Empty;

        public int? UsuarioId => null;
        public string? Origen => "Auth";
        public int? Estado => 1;
        public string? Mensaje => "Cerrar sesión";
        public string? TipoEvento => "Logout";
    }
}
