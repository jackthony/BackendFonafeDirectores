/***********
* Nombre del archivo: RefreshToken.cs
* Descripción:        Clase que representa el modelo de un token de refresco utilizado para mantener
*                     las sesiones de usuario. Contiene información sobre el token, su expiración,
*                     estado de revocación y el usuario asociado.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para el modelo de RefreshToken.
***********/

namespace Usuario.Domain.Auth.Models
{
    public class RefreshToken
    {
        public long RefreshTokenId { get; set; }
        public int UsuarioId { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime Expiracion { get; set; }
        public DateTime Creacion { get; set; }
        public bool Revocado { get; set; }
        public string? IpRegistro { get; set; }
    }
}
