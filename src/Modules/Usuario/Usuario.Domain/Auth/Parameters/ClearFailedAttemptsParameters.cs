/***********
* Nombre del archivo: ClearFailedAttemptsParameters.cs
* Descripción:        Clase que define los parámetros necesarios para restablecer el contador
*                     de intentos fallidos de un usuario. Se utiliza principalmente después de un
*                     inicio de sesión exitoso o un cambio de contraseña.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para los parámetros de limpieza de intentos fallidos.
***********/

namespace Usuario.Domain.Auth.Parameters
{
    public class ClearFailedAttemptsParameters
    {
        public int UsuarioId { get; set; }
    }
}
