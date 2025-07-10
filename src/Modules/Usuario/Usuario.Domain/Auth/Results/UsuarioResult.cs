/***********
* Nombre del archivo: UsuarioResult.cs
* Descripción:        Clase que representa el resultado de un usuario para fines de autenticación y autorización.
*                     Contiene información esencial del usuario como credenciales, datos personales,
*                     estado de sesión y permisos en formato JSON.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para definir el resultado de usuario para autenticación.
***********/

namespace Usuario.Domain.Auth.Results
{
    public class UsuarioResult
    {
        public int UsuarioId { get; set; }
        public string CorreoElectronico { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public string NombreCompleto { get; set; } = default!;
        public string NombreVisual { get; set; } = default!;
        public string PrimerNombre { get; set; } = default!;
        public string Status { get; set; } = default!;
        public string SessionState { get; set; } = default!;
        public string JsonModulos { get; set; } = default!;
        public string JsonRoles { get; set; } = default!;
        public int IntentosFallidos {  get; set; } = default!;
    }
}
