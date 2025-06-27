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
    public class ActualizarCargoRequestValidator : AbstractValidator<ActualizarCargoRequest>
    {
        public ActualizarCargoRequestValidator()
        {
<<<<<<< HEAD
=======
            // 1) nIdCargo: PK int NOT NULL
            RuleFor(x => x.nIdCargo)
                .GreaterThan(0)
                .WithMessage("El identificador del cargo es obligatorio y debe ser mayor que cero.");

            // 2) sNombreCargo: varchar(200) NOT NULL
            RuleFor(x => x.sNombreCargo)
                .NotEmpty()
                .WithMessage("El nombre del cargo es obligatorio.")
                .MaximumLength(200)
                .WithMessage("El nombre del cargo no puede exceder los 200 caracteres.");

            // 3) nUsuarioModificacion: FK int NOT NULL
            RuleFor(x => x.nUsuarioModificacion)
                .GreaterThan(0)
                .WithMessage("Debe especificar el usuario que realiza la modificación.");
>>>>>>> origin/masterboa
        }
    }
}
