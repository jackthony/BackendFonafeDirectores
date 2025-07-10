/***********
 * Nombre del archivo:  CrearUserParameters.cs
 * Descripción:         Clase de parámetros utilizada para registrar un nuevo usuario.
 *                      Contiene datos de la tabla SEG_Usuario y SEG_UsuarioInfo, incluyendo
 *                      información personal, credenciales y estado del usuario.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del modelo de entrada para el registro de usuarios.
 ***********/

namespace Usuario.Domain.User.Parameters
{
    public class CrearUserParameters
    {
        // Tabla SEG_Usuario
        public string PasswordHash { get; set; } = default!;
        public string CorreoElectronico { get; set; } = default!;
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int CargoId { get; set; }
        public int nTipoPersonal { get; set; }
        public int RolId { get; set; }
        public int Estado { get; set; }
        // Tabla SEG_UsuarioInfo
        public string ApellidoPaterno { get; set; } = default!;
        public string ApellidoMaterno { get; set; } = default!;
        public string Nombres { get; set; } = default!;
    }
}
