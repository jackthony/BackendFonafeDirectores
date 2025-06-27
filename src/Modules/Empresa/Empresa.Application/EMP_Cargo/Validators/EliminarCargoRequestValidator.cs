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
    public class EliminarCargoRequestValidator : AbstractValidator<EliminarCargoRequest>
    {
        public EliminarCargoRequestValidator()
        {
<<<<<<< HEAD
=======
            // El ID del cargo a eliminar debe ser mayor que cero
            RuleFor(x => x.nIdCargo)
                .GreaterThan(0)
                .WithMessage("El identificador del cargo es obligatorio y debe ser mayor que cero.");

            // El usuario que realiza la eliminación debe ser un ID válido
            RuleFor(x => x.nUsuarioModificacion)
                .GreaterThan(0)
                .WithMessage("El ID del usuario que modifica debe ser mayor que cero.");
>>>>>>> origin/masterboa
        }
    }
}
