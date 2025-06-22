using FluentValidation;
using Empresa.Application.Sector.Dtos;

namespace Empresa.Application.Sector.Validators
{
    public class ListarSectorRequestValidator : AbstractValidator<ListarSectorRequest>
    {
        public ListarSectorRequestValidator()
        {
        }
    }
}
