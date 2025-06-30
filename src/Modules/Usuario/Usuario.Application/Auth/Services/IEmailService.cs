using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Services
{
    public interface IEmailService
    {
        Task SendPasswordResetEmailAsync(string to, string resetLink, CancellationToken ct = default);
        Task SendConfirmationEmailAsync(string to, string resetLink, CancellationToken ct = default);
        Task SendAdminRecoveroyAccountEmailAsync(string nombre, string emailAdmin, string emailUsuario,CancellationToken ct = default);
    }
}
