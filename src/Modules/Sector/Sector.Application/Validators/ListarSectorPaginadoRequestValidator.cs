using Sector.Application.Dtos;
using FluentValidation;

namespace Sector.Application.Validators
{
    public class ListarSectorPaginadoRequestValidator : AbstractValidator<ListarSectorPaginadoRequest>
    {
        public ListarSectorPaginadoRequestValidator()
        {
        }
    }
}
