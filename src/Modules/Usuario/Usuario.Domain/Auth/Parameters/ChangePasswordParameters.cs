/***********
* Nombre del archivo: ChangePasswordParameters.cs
* Descripción:        Clase que define los parámetros necesarios para la operación de cambio de contraseña.
*                     Contiene el identificador del usuario y el nuevo hash de la contraseña
*                     a establecer.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para los parámetros de cambio de contraseña.
***********/

namespace Usuario.Domain.Auth.Parameters
{
    public class ChangePasswordParameters
    {
        public int UsuarioId { get; set; }               // ID del usuario
        public string newPasswordHash { get; set; } // Nuevo hash de la contraseña
        public int UsuarioModificaId { get; set; }
        public DateTime FechaModifica {  get; set; }
    }
}
