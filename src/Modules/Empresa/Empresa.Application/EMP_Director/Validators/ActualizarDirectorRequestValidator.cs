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
            // 1. Identificador del director (siempre requerido)
            RuleFor(x => x.nDirectorId)
                .GreaterThan(0)
                .WithMessage("El identificador del director es obligatorio.");

            // 2. Tipo de documento (opcional)
            When(x => x.nTipoDocumentoId.HasValue, () =>
            {
                RuleFor(x => x.nTipoDocumentoId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar un tipo de documento válido.");
            });

            // 3. Número de documento
            When(x => !string.IsNullOrEmpty(x.sNumeroDocumento), () =>
            {
                RuleFor(x => x.sNumeroDocumento!)
                    .MaximumLength(20)
                    .WithMessage("El número de documento no puede exceder 20 caracteres.");
            });

            // 4. Nombres y apellidos
            When(x => !string.IsNullOrEmpty(x.sNombres), () =>
            {
                RuleFor(x => x.sNombres!)
                    .MaximumLength(50)
                    .WithMessage("El nombre no puede exceder 50 caracteres.");
            });
            When(x => !string.IsNullOrEmpty(x.sApellidos), () =>
            {
                RuleFor(x => x.sApellidos!)
                    .MaximumLength(50)
                    .WithMessage("El apellido no puede exceder 50 caracteres.");
            });

            // 5. Fecha de nacimiento
            When(x => x.dtFechaNacimiento.HasValue, () =>
            {
                RuleFor(x => x.dtFechaNacimiento.Value)
                    .LessThan(DateTime.Today)
                    .WithMessage("La fecha de nacimiento debe ser anterior a hoy.");
            });

            // 6. Género
            When(x => x.nGeneroId.HasValue, () =>
            {
                RuleFor(x => x.nGeneroId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar un género válido.");
            });

            // 7. Ubicación (departamento, provincia, distrito)
            When(x => x.nDepartamentoId.HasValue, () =>
            {
                RuleFor(x => x.nDepartamentoId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar un departamento válido.");
            });
            When(x => x.nProvinciaId.HasValue, () =>
            {
                RuleFor(x => x.nProvinciaId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar una provincia válida.");
            });
            When(x => x.nDistritoId.HasValue, () =>
            {
                RuleFor(x => x.nDistritoId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar un distrito válido.");
            });

            // 8. Contacto
            When(x => !string.IsNullOrEmpty(x.sTelefono), () =>
            {
                RuleFor(x => x.sTelefono!)
                    .Matches(@"^\d+$")
                    .WithMessage("El teléfono debe contener sólo dígitos.");
            });
            When(x => !string.IsNullOrEmpty(x.sCorreo), () =>
            {
                RuleFor(x => x.sCorreo!)
                    .EmailAddress()
                    .WithMessage("El correo no tiene un formato válido.");
            });

            // 9. Cargo, tipo de director y sector
            When(x => x.nCargoId.HasValue, () =>
            {
                RuleFor(x => x.nCargoId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar un cargo válido.");
            });
            When(x => x.nTipoDirectorId.HasValue, () =>
            {
                RuleFor(x => x.nTipoDirectorId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar un tipo de director válido.");
            });
            When(x => x.nSectorId.HasValue, () =>
            {
                RuleFor(x => x.nSectorId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar un sector válido.");
            });

            // 10. Profesión y dieta
            When(x => !string.IsNullOrEmpty(x.sProfesion), () =>
            {
                RuleFor(x => x.sProfesion!)
                    .MaximumLength(100)
                    .WithMessage("La profesión no puede exceder 100 caracteres.");
            });
            When(x => x.dDieta.HasValue, () =>
            {
                RuleFor(x => x.dDieta.Value)
                    .GreaterThanOrEqualTo(0)
                    .WithMessage("La dieta debe ser un valor no negativo.");
            });

            // 11. Especialidad
            When(x => x.nEspecialidadId.HasValue, () =>
            {
                RuleFor(x => x.nEspecialidadId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar una especialidad válida.");
            });

            // 12. Fechas de nombramiento / designación / renuncia
            When(x => x.dtFechaNombramiento.HasValue && x.dtFechaNacimiento.HasValue, () =>
            {
                RuleFor(x => x.dtFechaNombramiento.Value)
                    .GreaterThan(x => x.dtFechaNacimiento.Value)
                    .WithMessage("La fecha de nombramiento debe ser posterior a la de nacimiento.");
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

            // 13. Auditoría de modificación
            When(x => x.nUsuarioModificacionId.HasValue, () =>
            {
                RuleFor(x => x.nUsuarioModificacionId.Value)
                    .GreaterThan(0)
                    .WithMessage("Debe indicar el usuario que modifica.");
            });
        }
    }
}
