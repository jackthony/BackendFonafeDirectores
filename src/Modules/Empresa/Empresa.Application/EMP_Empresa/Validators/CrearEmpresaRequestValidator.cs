using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class CrearEmpresaRequestValidator : AbstractValidator<CrearEmpresaRequest>
    {
        public CrearEmpresaRequestValidator()
        {
            // Validación para el campo sRuc (obligatorio y con longitud adecuada)
            RuleFor(x => x.sRuc)
                .NotEmpty().WithMessage("El campo RUC es obligatorio.")
                .Length(11).WithMessage("El campo RUC debe tener 11 caracteres.")
                .Matches(@"^\d{11}$").WithMessage("El campo RUC debe contener solo números.");

            // Validación para el campo sRazonSocial (obligatorio y con longitud adecuada)
            RuleFor(x => x.sRazonSocial)
                .NotEmpty().WithMessage("El campo RazonSocial es obligatorio.")
                .Length(3, 255).WithMessage("El campo RazonSocial debe tener entre 3 y 255 caracteres.");

            // Validación para el campo nSectorId (debe ser mayor que 0)
            RuleFor(x => x.nSectorId)
                .GreaterThan(0).WithMessage("El campo SectorId debe ser mayor que 0.");

            // Validación para el campo nRubroId (debe ser mayor que 0)
            RuleFor(x => x.nRubroId)
                .GreaterThan(0).WithMessage("El campo RubroId debe ser mayor que 0.");

            // Validación para los campos relacionados con la ubicación (Departamento, Provincia, Distrito)
            RuleFor(x => x.nDepartamentoId)
                .GreaterThan(0).WithMessage("El campo DepartamentoId debe ser mayor que 0.");

            RuleFor(x => x.nProvinciaId)
                .GreaterThan(0).WithMessage("El campo ProvinciaId debe ser mayor que 0.");

            RuleFor(x => x.nDistritoId)
                .GreaterThan(0).WithMessage("El campo DistritoId debe ser mayor que 0.");

            // Validación para los campos de dirección y comentario (pueden ser nulos pero si se proporcionan deben tener una longitud adecuada)
            RuleFor(x => x.sDireccion)
                .MaximumLength(500).WithMessage("El campo Dirección no puede exceder 500 caracteres.");

            RuleFor(x => x.sComentario)
                .MaximumLength(1000).WithMessage("El campo Comentario no puede exceder 1000 caracteres.");

            // Validación para los campos de ingresos, utilidad y capital social (deben ser positivos)
            RuleFor(x => x.dIngresosUltimoAnio)
                .GreaterThan(0).WithMessage("El campo IngresosUltimoAnio debe ser mayor que 0.");

            RuleFor(x => x.dUtilidadUltimoAnio)
                .GreaterThan(0).WithMessage("El campo UtilidadUltimoAnio debe ser mayor que 0.");

            RuleFor(x => x.dConformacionCapitalSocial)
                .GreaterThan(0).WithMessage("El campo ConformacionCapitalSocial debe ser mayor que 0.");

            // Validación para el número de miembros (debe ser mayor que 0)
            RuleFor(x => x.nNumeroMiembros)
                .GreaterThan(0).WithMessage("El campo NumeroMiembros debe ser mayor que 0.");

            // Validación para bRegistradoMercadoValor (booleano obligatorio)
            RuleFor(x => x.bRegistradoMercadoValor)
                .NotNull().WithMessage("El campo bRegistradoMercadoValor es obligatorio.");

            // Validación para nUsuarioRegistroId (debe ser mayor que 0)
            RuleFor(x => x.nUsuarioRegistroId)
                .GreaterThan(0).WithMessage("El campo UsuarioRegistroId debe ser mayor que 0.");
        }
    }
}
