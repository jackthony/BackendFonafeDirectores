<<<<<<< HEAD
﻿using Empresa.Application.EMP_Cargo.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Cargo.Validators
=======
﻿using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
>>>>>>> origin/masterboa
{
    public class ListarCargoPaginadoRequestValidator : AbstractValidator<ListarCargoPaginadoRequest>
    {
        public ListarCargoPaginadoRequestValidator()
        {
<<<<<<< HEAD
=======
            // Page y PageSize deben ser > 0
            RuleFor(x => x.Page)
                .GreaterThan(0)
                .WithMessage("El número de página debe ser mayor que cero.");
            RuleFor(x => x.PageSize)
                .GreaterThan(0)
                .WithMessage("El tamaño de página debe ser mayor que cero.");

            // Nombre opcional, pero si se envía no puede exceder 200 caracteres
            When(x => !string.IsNullOrEmpty(x.Nombre), () =>
            {
                RuleFor(x => x.Nombre!)
                    .MaximumLength(200)
                    .WithMessage("El nombre no debe superar los 200 caracteres.");
            });

            // Estado es opcional y debe ser true o false (no se requiere validación adicional)
>>>>>>> origin/masterboa
        }
    }
}
