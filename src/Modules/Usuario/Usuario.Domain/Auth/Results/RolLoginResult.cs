/***********
* Nombre del archivo: RolLoginResult.cs
* Descripción:        Clase que encapsula la información básica de un rol para ser utilizada durante
*                     el proceso de inicio de sesión o autenticación. Contiene el identificador
*                     y el nombre del rol.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para definir el resultado de rol en el login.
***********/

namespace Usuario.Domain.Auth.Results
{
    public class RolLoginResult
    {
        public int RolId { get; set; }
        public string NombreRol { get; set; } = string.Empty;
    }
}
