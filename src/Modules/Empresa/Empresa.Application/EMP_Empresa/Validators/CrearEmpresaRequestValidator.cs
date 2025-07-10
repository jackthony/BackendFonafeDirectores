/*****
 * Nombre del archivo: CrearEmpresaRequestValidator.cs
 * Descripción: Este archivo contiene la clase `CrearEmpresaRequestValidator`, que valida los datos de entrada para 
 *              la creación de una empresa. Está implementado utilizando FluentValidation, y se asegura de que los valores 
 *              sean válidos antes de proceder con la operación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación de las reglas de validación para los datos de la empresa.
 *****/
using Empresa.Application.Empresa.Dtos;
using FluentValidation;

public class CrearEmpresaRequestValidator : AbstractValidator<CrearEmpresaRequest>
{
    public CrearEmpresaRequestValidator()
    {
        RuleFor(x => x.sRuc)
            .NotEmpty().WithMessage("El RUC es obligatorio.")
            .Length(11).WithMessage("El RUC debe tener 11 dígitos.")
            .Matches("^[0-9]+$").WithMessage("El RUC solo debe contener números.");

        RuleFor(x => x.sRazonSocial)
            .NotEmpty().WithMessage("La razón social es obligatoria.")
            .MaximumLength(200).WithMessage("La razón social no debe exceder los 200 caracteres.");

        RuleFor(x => x.nIdSector)
            .GreaterThan(0).WithMessage("El ID del sector debe ser mayor a 0.");

        RuleFor(x => x.nIdRubroNegocio)
            .GreaterThan(0).WithMessage("El ID del rubro de negocio debe ser mayor a 0.");

        RuleFor(x => x.sIdDepartamento)
            .NotEmpty().WithMessage("El departamento es obligatorio.")
            .Length(4).WithMessage("El código de departamento debe tener 4 caracteres.");

        RuleFor(x => x.sIdProvincia)
            .NotEmpty().WithMessage("La provincia es obligatoria.")
            .Length(4).WithMessage("El código de provincia debe tener 4 caracteres.");

        RuleFor(x => x.sIdDistrito)
            .NotEmpty().WithMessage("El distrito es obligatorio.")
            .Length(4).WithMessage("El código de distrito debe tener 4 caracteres.");

        RuleFor(x => x.sDireccion)
            .MaximumLength(500).WithMessage("La dirección no debe exceder los 500 caracteres.");

        RuleFor(x => x.sComentario)
            .MaximumLength(500).WithMessage("El comentario no debe exceder los 500 caracteres.");

        RuleFor(x => x.nNumeroMiembros)
            .GreaterThanOrEqualTo(0).WithMessage("El número de miembros no puede ser negativo.");

        RuleFor(x => x.mIngresosUltimoAnio)
            .GreaterThanOrEqualTo(0).WithMessage("Los ingresos deben ser un número positivo.");

        RuleFor(x => x.mUtilidadUltimoAnio)
            .GreaterThanOrEqualTo(0).WithMessage("La utilidad debe ser un número positivo.");

        RuleFor(x => x.mConformacionCapitalSocial)
            .GreaterThanOrEqualTo(0).WithMessage("La conformación de capital social debe ser un número positivo.");

        RuleFor(x => x.nUsuarioRegistro)
            .GreaterThan(0).WithMessage("El ID del usuario de registro debe ser mayor a 0.");
    }
}
