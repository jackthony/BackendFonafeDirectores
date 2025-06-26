using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Services
{
    public interface IAuditServicePassword
    {
        Task LogChangePasswordAsync(int usuarioId, string oldPassword, string newPassword);
    }
}
