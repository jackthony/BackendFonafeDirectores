using FluentValidation;
using Empresa.Application.Director.Dtos;

namespace Empresa.Application.Director.Validators
{
    public class CrearDirectorRequestValidator : AbstractValidator<CrearDirectorRequest>
    {
        public CrearDirectorRequestValidator()
        {
            // Validación para el campo nEmpresaId (no puede ser 0 o negativo)
            RuleFor(x => x.nEmpresaId)
                .GreaterThan(0).WithMessage("El campo nEmpresaId debe ser mayor a 0.");

            // Validación para el campo nTipoDocumentoId (no puede ser 0 o negativo)
            RuleFor(x => x.nTipoDocumentoId)
                .GreaterThan(0).WithMessage("El campo nTipoDocumentoId debe ser mayor a 0.");

            // Validación para el campo sNumeroDocumento (no puede estar vacío y debe tener un formato adecuado)
            RuleFor(x => x.sNumeroDocumento)
                .NotEmpty().WithMessage("El campo sNumeroDocumento es obligatorio.")
                .Length(8, 20).WithMessage("El campo sNumeroDocumento debe tener entre 8 y 20 caracteres.");

            // Validación para el campo sNombres (no puede estar vacío)
            RuleFor(x => x.sNombres)
                .NotEmpty().WithMessage("El campo sNombres es obligatorio.")
                .Length(3, 100).WithMessage("El campo sNombres debe tener entre 3 y 100 caracteres.");

            // Validación para el campo sApellidos (no puede estar vacío)
            RuleFor(x => x.sApellidos)
                .NotEmpty().WithMessage("El campo sApellidos es obligatorio.")
                .Length(3, 100).WithMessage("El campo sApellidos debe tener entre 3 y 100 caracteres.");

            // Validación para la fecha de nacimiento (no puede ser mayor a la fecha actual)
            RuleFor(x => x.dtFechaNacimiento)
                .NotEmpty().WithMessage("El campo dtFechaNacimiento es obligatorio.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("El campo dtFechaNacimiento no puede ser mayor a la fecha actual.");

            // Validación para los campos de dirección, teléfono, correo, etc. (No vacíos)
            RuleFor(x => x.sDireccion)
                .NotEmpty().WithMessage("El campo sDireccion es obligatorio.")
                .MaximumLength(500).WithMessage("El campo sDireccion no puede tener más de 500 caracteres.");

            RuleFor(x => x.sTelefono)
                .NotEmpty().WithMessage("El campo sTelefono es obligatorio.")
                .Matches(@"^\+?\d{1,4}?[-.\s]?\(?\d+\)?[-.\s]?\d+[-.\s]?\d+$").WithMessage("El campo sTelefono tiene un formato inválido.");

            RuleFor(x => x.sCorreo)
                .NotEmpty().WithMessage("El campo sCorreo es obligatorio.")
                .EmailAddress().WithMessage("El campo sCorreo debe ser una dirección de correo válida.");

            // Validación para el campo sProfesion (no puede estar vacío)
            RuleFor(x => x.sProfesion)
                .NotEmpty().WithMessage("El campo sProfesion es obligatorio.")
                .Length(3, 100).WithMessage("El campo sProfesion debe tener entre 3 y 100 caracteres.");

            // Validación para el campo dDieta (debe ser un valor positivo)
            RuleFor(x => x.dDieta)
                .GreaterThan(0).WithMessage("El campo dDieta debe ser mayor a 0.");

            // Validación para las fechas de nombramiento y designación
            RuleFor(x => x.dtFechaNombramiento)
                .NotEmpty().WithMessage("El campo dtFechaNombramiento es obligatorio.");

            RuleFor(x => x.dtFechaDesignacion)
                .NotEmpty().WithMessage("El campo dtFechaDesignacion es obligatorio.");

            // Validación para los campos de fechas nulas (no es obligatorio llenar dtFechaRenuncia)
            RuleFor(x => x.dtFechaRenuncia)
                .GreaterThan(DateTime.MinValue).When(x => x.dtFechaRenuncia.HasValue).WithMessage("El campo dtFechaRenuncia debe tener una fecha válida.");

            // Validación para el campo sComentario (opcional, pero si se proporciona no debe exceder los 1000 caracteres)
            RuleFor(x => x.sComentario)
                .MaximumLength(1000).WithMessage("El campo sComentario no puede tener más de 1000 caracteres.");

            // Validación para nUsuarioRegistroId (debe ser mayor que 0)
            RuleFor(x => x.nUsuarioRegistroId)
                .GreaterThan(0).WithMessage("El campo nUsuarioRegistroId debe ser mayor a 0.");
        }
    }
}
