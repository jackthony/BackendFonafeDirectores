using FluentValidation;
using Empresa.Application.Director.Dtos;
using System;

namespace Empresa.Application.Director.Validators
{
    public class CrearDirectorRequestValidator : AbstractValidator<CrearDirectorRequest>
    {
        public CrearDirectorRequestValidator()
        {
            // Empresa
            RuleFor(x => x.nIdEmpresa)
                .GreaterThan(0)
                .WithMessage("Debe especificar una empresa válida.");

            // Tipo de documento
            RuleFor(x => x.nTipoDocumento)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un tipo de documento.");

            // Número de documento
            RuleFor(x => x.sNumeroDocumento)
                .NotEmpty()
                .WithMessage("El número de documento es obligatorio.")
                .MaximumLength(20)
                .WithMessage("El número de documento no puede exceder 20 caracteres.");

            // Nombres y apellidos
            RuleFor(x => x.sNombres)
                .NotEmpty()
                .WithMessage("El nombre es obligatorio.")
                .MaximumLength(50)
                .WithMessage("El nombre no puede exceder 50 caracteres.");

            RuleFor(x => x.sApellidos)
                .NotEmpty()
                .WithMessage("El apellido es obligatorio.")
                .MaximumLength(50)
                .WithMessage("El apellido no puede exceder 50 caracteres.");

            // Fecha de nacimiento
            RuleFor(x => x.dFechaNacimiento)
                .LessThan(DateTime.Today)
                .WithMessage("La fecha de nacimiento debe ser anterior al día de hoy.");

            // Género
            RuleFor(x => x.nGenero)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un género.");

            // Ubicación
            RuleFor(x => x.sDepartamento)
                .NotEmpty()
                .WithMessage("El departamento es obligatorio.");
            RuleFor(x => x.sProvincia)
                .NotEmpty()
                .WithMessage("La provincia es obligatoria.");
            RuleFor(x => x.sDistrito)
                .NotEmpty()
                .WithMessage("El distrito es obligatorio.");

            // Contacto
            RuleFor(x => x.sTelefono)
                .NotEmpty()
                .WithMessage("El teléfono es obligatorio.")
                .Matches(@"^\d+$")
                .WithMessage("El teléfono debe contener sólo dígitos.");

            RuleFor(x => x.sCorreo)
                .NotEmpty()
                .WithMessage("El correo es obligatorio.")
                .EmailAddress()
                .WithMessage("El correo no tiene un formato válido.");

            // Cargo, tipo de director y sector
            RuleFor(x => x.nCargo)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un cargo.");
            RuleFor(x => x.nTipoDirector)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un tipo de director.");
            RuleFor(x => x.nSectorId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un sector.");

            // Profesión y dieta
            RuleFor(x => x.sProfesion)
                .NotEmpty()
                .WithMessage("La profesión es obligatoria.")
                .MaximumLength(100)
                .WithMessage("La profesión no puede exceder 100 caracteres.");
            RuleFor(x => x.mDieta)
                .GreaterThanOrEqualTo(0)
                .WithMessage("La dieta debe ser un valor no negativo.");

            // Especialidad
            RuleFor(x => x.nEspecialidad)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar una especialidad.");

            // Fechas de nombramiento y designación
            RuleFor(x => x.dFechaNombramiento)
                .GreaterThan(x => x.dFechaNacimiento)
                .WithMessage("La fecha de nombramiento debe ser posterior a la fecha de nacimiento.");

            RuleFor(x => x.dFechaDesignacion)
                .GreaterThanOrEqualTo(x => x.dFechaNombramiento)
                .WithMessage("La fecha de designación debe ser igual o posterior a la de nombramiento.");

            // Usuario que crea
            RuleFor(x => x.nUsuarioRegistro)
                .GreaterThan(0)
                .WithMessage("Debe especificar el usuario que registra.");
        }
    }
}
