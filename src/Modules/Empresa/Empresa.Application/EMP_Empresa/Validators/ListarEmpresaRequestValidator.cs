/*****
 * Nombre del archivo: ListarEmpresaRequestValidator.cs
 * Descripción: Este archivo contiene la clase `ListarEmpresaRequestValidator`, que es un validador para las solicitudes de 
 *              listado de empresas. Actualmente está vacío, pero se puede extender para agregar reglas de validación 
 *              específicas como filtros de búsqueda o validación de parámetros opcionales.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase de validador, sin reglas de validación hasta el momento.
 *****/
using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class ListarEmpresaRequestValidator : AbstractValidator<ListarEmpresaRequest>
    {
        public ListarEmpresaRequestValidator()
        {
        }
    }
}
