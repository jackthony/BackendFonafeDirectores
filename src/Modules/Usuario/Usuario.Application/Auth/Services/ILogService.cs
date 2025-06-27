using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Services
{
    public interface ILogService
    {
        Task LogEventAsync(int usuarioId, string eventType, string description);
    }
}
