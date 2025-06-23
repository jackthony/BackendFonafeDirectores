using Empresa.Application.Ubigeo.Dtos;
using FluentValidation;

namespace Empresa.Application.Departamento.Validators
{
    public class ListarDepartamentoRequestValidator : AbstractValidator<ListarDepartamentoRequest>
    {
        public ListarDepartamentoRequestValidator()
        {
        }
    }
}
