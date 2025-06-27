using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Dtos
{
    public class LogoutRequest
    {
        public string Token { get; set; } = string.Empty;
    }
}
