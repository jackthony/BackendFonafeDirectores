/***********
* Nombre del archivo: LoginParameters.cs
* Descripción:        Clase que define los parámetros de entrada para la operación de inicio de sesión.
*                     Contiene la información mínima necesaria, como el correo electrónico,
*                     para intentar autenticar a un usuario en el sistema.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para los parámetros de inicio de sesión.
***********/

namespace Usuario.Domain.Auth.Parameters
{
    public class LoginParameters
    {
        public required string Correo { get; init; }
    }
}
