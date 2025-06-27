using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Dtos
{
    public class ForgotPasswordResponse
    {
        public bool Success { get; set; }  // Indica si la operación fue exitosa
        public string Message { get; set; } = default!;  // Mensaje de respuesta
    }
}

