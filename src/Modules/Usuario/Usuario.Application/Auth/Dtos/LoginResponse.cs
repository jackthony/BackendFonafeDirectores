/***********
 * Nombre del archivo:  LoginResponse.cs
 * Descripción:         DTO de respuesta utilizado tras un inicio de sesión exitoso.
 *                      Contiene la información del usuario autenticado, sus módulos con permisos,
 *                      los tokens de acceso y actualización, y el identificador de sesión.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de estructura de respuesta de login con compatibilidad para trazabilidad.
 ***********/

using Shared.Kernel.Interfaces;
using Usuario.Domain.Auth.Results;
using Usuario.Domain.SEG_Modulo.Models;

namespace Usuario.Application.Auth.Dtos
{
    public class LoginResponse : ISistemaResponse
    {
        public UsuarioResult UsuarioResult { get; set; } = default!;
        public List<ModuloPermiso> Modulos { get; set; } = [];
        public string AccessToken { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
        public string SessionId { get; set; } = default!;

        public int? UsuarioId => UsuarioResult.UsuarioId;
        public string? GetSessionId => SessionId;
    }
}
