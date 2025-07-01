using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Domain.Auth.Parameters
{
    public class ChangePasswordParameters
    {
        public int UsuarioId { get; set; }               // ID del usuario a modificar
        public int UsuarioModificaId { get; set; }          // ID del usuario que registra
        public string newPasswordHash { get; set; } // Nuevo hash de la contraseña
        public DateTime FechaModificacion { get; set; }
    }
}
