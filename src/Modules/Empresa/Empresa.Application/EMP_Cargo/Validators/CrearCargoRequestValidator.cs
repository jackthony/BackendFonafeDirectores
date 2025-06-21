using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Application.EMP_Cargo.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Cargo.Validators
{
    public class CrearCargoRequestValidator : AbstractValidator<CrearCargoRequest>
    {
        public CrearCargoRequestValidator() { }
    }
}
