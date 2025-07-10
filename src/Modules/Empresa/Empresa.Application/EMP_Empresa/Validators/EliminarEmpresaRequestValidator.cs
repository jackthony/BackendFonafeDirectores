/*****
 * Nombre del archivo: EliminarEmpresaRequestValidator.cs
 * Descripción: Este archivo contiene la clase `EliminarEmpresaRequestValidator`, que es un validador de las solicitudes para 
 *              eliminar una empresa. Aunque actualmente está vacío, se puede extender para agregar reglas de validación 
 *              específicas en el futuro.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación de la clase de validador, sin reglas de validación específicas hasta el momento.
 *****/
using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class EliminarEmpresaRequestValidator : AbstractValidator<EliminarEmpresaRequest>
    {
        public EliminarEmpresaRequestValidator()
        {
        }
    }
}
