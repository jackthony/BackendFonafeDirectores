/*****
 * Nombre del archivo: ActualizarEmpresaRequestValidator.cs
 * Descripción: Este archivo contiene la clase `ActualizarEmpresaRequestValidator`, que valida los datos de entrada 
 *              para la actualización de la empresa. Está implementado utilizando FluentValidation para asegurar que los 
 *              valores sean correctos antes de ejecutar la operación correspondiente.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación del esqueleto del validador sin reglas adicionales.
 *****/
using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class ActualizarEmpresaRequestValidator : AbstractValidator<ActualizarEmpresaRequest>
    {
        public ActualizarEmpresaRequestValidator()
        {
        }
    }
}
