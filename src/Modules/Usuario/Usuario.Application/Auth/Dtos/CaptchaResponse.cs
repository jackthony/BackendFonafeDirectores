using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Dtos
{
    public class CaptchaResponse
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
    }
}
