using Usuario.Domain.Auth.Results;
<<<<<<< HEAD
=======
using Usuario.Domain.SEG_Modulo.Models;
>>>>>>> origin/masterboa

namespace Usuario.Application.Auth.Dtos
{
    public class LoginResponse
    {
        public UsuarioResult UsuarioResult { get; set; } = default!;
<<<<<<< HEAD
=======
        public List<ModuloPermiso> Modulos { get; set; } = [];
>>>>>>> origin/masterboa
        public string AccessToken { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
    }
}
