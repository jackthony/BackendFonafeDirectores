using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Application.EMP_Director.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Director.Validators
{
    public class ListarDirectorRequestValidator : AbstractValidator<ListarDirectorRequest>
    {
        public ListarDirectorRequestValidator() { }
    }
}
