using FluentValidation;
using Empresa.Application.Director.Dtos;
using System;

namespace Empresa.Application.Director.Validators
{
    public class ActualizarDirectorRequestValidator
        : AbstractValidator<ActualizarDirectorRequest>
    {
        public ActualizarDirectorRequestValidator()
        {
            // 1. ID del director
            RuleFor(x => x.nDirectorId)
                .GreaterThan(0)
                .WithMessage("El identificador del director es obligatorio y debe ser mayor que cero.");

            // 2. Empresa (FK NOT NULL)
            RuleFor(x => x.nEmpresaId)
                .GreaterThan(0)
                .WithMessage("Debe especificar una empresa válida.");

            // 3. Tipo de documento (FK NOT NULL)
            RuleFor(x => x.nTipoDocumentoId)
                .NotNull()
                .WithMessage("El tipo de documento es obligatorio.")
                .GreaterThan(0)
                .WithMessage("Debe indicar un tipo de documento válido.");

            // 4. Número de documento (UNIQUE, varchar(20) NOT NULL)
            RuleFor(x => x.sNumeroDocumento)
                .NotEmpty()
                .WithMessage("El número de documento es obligatorio.")
                .MaximumLength(20)
                .WithMessage("El número de documento no puede exceder 20 caracteres.");

            // 5. Nombres y apellidos (varchar(250) NOT NULL)
            RuleFor(x => x.sNombres)
                .NotEmpty()
                .WithMessage("El nombre es obligatorio.")
                .MaximumLength(250)
                .WithMessage("El nombre no puede exceder 250 caracteres.");
            RuleFor(x => x.sApellidos)
                .NotEmpty()
                .WithMessage("El apellido es obligatorio.")
                .MaximumLength(250)
                .WithMessage("El apellido no puede exceder 250 caracteres.");

            // 6. Fecha de nacimiento (date NULLABLE)
            RuleFor(x => x.dtFechaNacimiento)
                .NotNull()
                .WithMessage("La fecha de nacimiento es obligatoria.")
                .LessThan(DateTime.Today)
                .WithMessage("La fecha de nacimiento debe ser anterior a hoy.");

            // 7. Género (FK NOT NULL)
            RuleFor(x => x.nGeneroId)
                .NotNull()
                .WithMessage("El género es obligatorio.")
                .GreaterThan(0)
                .WithMessage("Debe indicar un género válido.");

            // 8. Ubicación (FKs NOT NULL)
            RuleFor(x => x.nDepartamentoId)
                .NotNull()
                .WithMessage("El departamento es obligatorio.")
                .GreaterThan(0)
                .WithMessage("Debe indicar un departamento válido.");
            RuleFor(x => x.nProvinciaId)
                .NotNull()
                .WithMessage("La provincia es obligatoria.")
                .GreaterThan(0)
                .WithMessage("Debe indicar una provincia válida.");
            RuleFor(x => x.nDistritoId)
                .NotNull()
                .WithMessage("El distrito es obligatorio.")
                .GreaterThan(0)
                .WithMessage("Debe indicar un distrito válido.");

            // 9. Dirección (varchar(300) NULLABLE)
            When(x => !string.IsNullOrEmpty(x.sDireccion), () =>
            {
                RuleFor(x => x.sDireccion!)
                    .MaximumLength(300)
                    .WithMessage("La dirección no puede exceder 300 caracteres.");
            });

            // 10. Contactos (varchar(20/250) NULLABLE)
            When(x => !string.IsNullOrEmpty(x.sTelefono), () =>
            {
                RuleFor(x => x.sTelefono!)
                    .Matches(@"^\d+$")
                    .WithMessage("El teléfono debe contener solo dígitos.")
                    .MaximumLength(20)
                    .WithMessage("El teléfono no puede exceder 20 caracteres.");
            });
            When(x => !string.IsNullOrEmpty(x.sTelefonoSecundario), () =>
            {
                RuleFor(x => x.sTelefonoSecundario!)
                    .Matches(@"^\d+$").WithMessage("El teléfono secundario debe contener solo dígitos.")
                    .MaximumLength(20).WithMessage("El teléfono secundario no puede exceder 20 caracteres.");
            });
            When(x => !string.IsNullOrEmpty(x.sTelefonoTerciario), () =>
            {
                RuleFor(x => x.sTelefonoTerciario!)
                    .Matches(@"^\d+$").WithMessage("El teléfono terciario debe contener solo dígitos.")
                    .MaximumLength(20).WithMessage("El teléfono terciario no puede exceder 20 caracteres.");
            });
            When(x => !string.IsNullOrEmpty(x.sCorreo), () =>
            {
                RuleFor(x => x.sCorreo!)
                    .EmailAddress()
                    .WithMessage("El correo no tiene un formato válido.")
                    .MaximumLength(250)
                    .WithMessage("El correo no puede exceder 250 caracteres.");
            });
            When(x => !string.IsNullOrEmpty(x.sCorreoSecundario), () =>
            {
                RuleFor(x => x.sCorreoSecundario!)
                    .EmailAddress().WithMessage("El correo secundario no tiene un formato válido.")
                    .MaximumLength(250).WithMessage("El correo secundario no puede exceder 250 caracteres.");
            });
            When(x => !string.IsNullOrEmpty(x.sCorreoTerciario), () =>
            {
                RuleFor(x => x.sCorreoTerciario!)
                    .EmailAddress().WithMessage("El correo terciario no tiene un formato válido.")
                    .MaximumLength(250).WithMessage("El correo terciario no puede exceder 250 caracteres.");
            });

            // 11. Cargo, TipoDirector, Sector, Especialidad (FKs NOT NULL)
            RuleFor(x => x.nCargoId)
                .NotNull().WithMessage("El cargo es obligatorio.")
                .GreaterThan(0).WithMessage("Debe indicar un cargo válido.");
            RuleFor(x => x.nTipoDirectorId)
                .NotNull().WithMessage("El tipo de director es obligatorio.")
                .GreaterThan(0).WithMessage("Debe indicar un tipo de director válido.");
            RuleFor(x => x.nSectorId)
                .NotNull().WithMessage("El sector es obligatorio.")
                .GreaterThan(0).WithMessage("Debe indicar un sector válido.");
            RuleFor(x => x.nEspecialidadId)
                .NotNull().WithMessage("La especialidad es obligatoria.")
                .GreaterThan(0).WithMessage("Debe indicar una especialidad válida.");

            // 12. Profesión (varchar(250) NULLABLE)
            When(x => !string.IsNullOrEmpty(x.sProfesion), () =>
            {
                RuleFor(x => x.sProfesion!)
                    .MaximumLength(250)
                    .WithMessage("La profesión no puede exceder 250 caracteres.");
            });

            // 13. Dieta (decimal(9,2) NULLABLE)
            When(x => x.dDieta.HasValue, () =>
            {
                RuleFor(x => x.dDieta.Value)
                    .GreaterThanOrEqualTo(0m)
                    .WithMessage("La dieta debe ser un valor no negativo.");
            });

            // 14. Fechas (DATETIME NULLABLE en algunos casos)
            RuleFor(x => x.dtFechaNombramiento)
                .NotNull()
                .WithMessage("La fecha de nombramiento es obligatoria.");
            RuleFor(x => x.dtFechaDesignacion)
                .NotNull()
                .WithMessage("La fecha de designación es obligatoria.");
            When(x => x.dtFechaNombramiento.HasValue && x.dtFechaNacimiento.HasValue, () =>
            {
                RuleFor(x => x.dtFechaNombramiento.Value)
                    .GreaterThan(x => x.dtFechaNacimiento.Value)
                    .WithMessage("La fecha de nombramiento debe ser posterior a la fecha de nacimiento.");
            });
            When(x => x.dtFechaDesignacion.HasValue && x.dtFechaNombramiento.HasValue, () =>
            {
                RuleFor(x => x.dtFechaDesignacion.Value)
                    .GreaterThanOrEqualTo(x => x.dtFechaNombramiento.Value)
                    .WithMessage("La fecha de designación debe ser igual o posterior a la de nombramiento.");
            });
            When(x => x.dtFechaRenuncia.HasValue && x.dtFechaDesignacion.HasValue, () =>
            {
                RuleFor(x => x.dtFechaRenuncia.Value)
                    .GreaterThanOrEqualTo(x => x.dtFechaDesignacion.Value)
                    .WithMessage("La fecha de renuncia debe ser igual o posterior a la de designación.");
            });

            // 15. Auditoría (nUsuarioModificacionId NOT NULL)
            RuleFor(x => x.nUsuarioModificacionId)
                .NotNull()
                .WithMessage("El usuario de modificación es obligatorio.")
                .GreaterThan(0)
                .WithMessage("El ID del usuario de modificación debe ser mayor que cero.");
        }
    }
}
