using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Domain.Auth.Parameters
{
    public class LogoutParameters
    {
        public required int UserId{ get; init; }
    }
}
