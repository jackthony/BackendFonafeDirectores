/***********
* Nombre del archivo: LogoutParameters.cs
* Descripción:        Clase que define los parámetros necesarios para realizar la operación de cierre de sesión.
*                     Contiene la información mínima requerida para identificar al usuario
*                     cuya sesión se desea finalizar (revocar el token de refresco).
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para los parámetros de cierre de sesión.
***********/

namespace Usuario.Domain.Auth.Parameters
{
    public class LogoutParameters
    {
        public required int UserId{ get; init; }
    }
}
