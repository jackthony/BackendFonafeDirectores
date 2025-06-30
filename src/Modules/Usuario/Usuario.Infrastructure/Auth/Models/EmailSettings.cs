using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Infrastructure.Auth.Models
{
    public record EmailSettings
    {
        public string Host { get; init; } = "smtp.hostinger.com";
        public int Port { get; init; } = 465;                // TLS implícito
        public string User { get; init; } = default!;
        public string Pass { get; init; } = default!;
        public string From { get; init; } = default!;
    }
}
