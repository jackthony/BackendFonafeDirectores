/*****
 * Nombre del archivo: ListarEmpresaPaginadoRequestValidator.cs
 * Descripción: Este archivo contiene la clase `ListarEmpresaPaginadoRequestValidator`, que es un validador para las solicitudes 
 *              de paginación de empresas. Actualmente está vacío, pero puede ampliarse para agregar reglas de validación 
 *              específicas como las de `Page`, `PageSize`, y filtros opcionales.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación de la clase de validador, sin reglas de validación hasta el momento.
 *****/
using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class ListarEmpresaPaginadoRequestValidator : AbstractValidator<ListarEmpresaPaginadoRequest>
    {
        public ListarEmpresaPaginadoRequestValidator()
        {
        }
    }
}
