/*****
 * Nombre del archivo:  ActualizarDirectorRequestValidator.cs
 * Descripción:         Validador para el caso de uso de actualización de director. Valida que los campos del request cumplan con las reglas de negocio.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación del validador para verificar que los datos de entrada son correctos.
 *****/
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
            RuleFor(x => x.nIdRegistro)
                .GreaterThan(0)
                .WithMessage("El identificador del director es obligatorio y debe ser mayor que cero.");

            // 2. Empresa (FK NOT NULL)
            RuleFor(x => x.nIdEmpresa)
                .GreaterThan(0)
                .WithMessage("Debe especificar una empresa válida.");

        }
    }
}
