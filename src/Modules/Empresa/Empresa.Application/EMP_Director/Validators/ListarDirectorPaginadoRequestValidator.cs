using FluentValidation;
using Empresa.Application.Director.Dtos;

namespace Empresa.Application.Director.Validators
{
    public class ListarDirectorPaginadoRequestValidator
            : AbstractValidator<ListarDirectorPaginadoRequest>
    {
        public ListarDirectorPaginadoRequestValidator()
        {
            // Page y PageSize deben ser mayores que cero
            RuleFor(x => x.Page)
                .GreaterThan(0)
                .WithMessage("El número de página debe ser mayor que cero.");

            RuleFor(x => x.PageSize)
                .GreaterThan(0)
                .WithMessage("El tamaño de página debe ser mayor que cero.");

            // Nombre opcional: si se envía, no puede exceder 250 caracteres
            When(x => !string.IsNullOrEmpty(x.Nombre), () =>
            {
                RuleFor(x => x.Nombre!)
                    .MaximumLength(250)
                    .WithMessage("El nombre no puede exceder 250 caracteres.");
            });

            // Empresa opcional: si se envía, debe ser mayor que cero
            When(x => x.nIdEmpresa.HasValue, () =>
            {
                RuleFor(x => x.nIdEmpresa!.Value)
                    .GreaterThan(0)
                    .WithMessage("El ID de empresa debe ser mayor que cero.");
            });

            // Estado es bool? opcional, no requiere validación adicional
        }
    }
}
