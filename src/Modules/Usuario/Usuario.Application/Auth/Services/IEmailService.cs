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
    }
}
