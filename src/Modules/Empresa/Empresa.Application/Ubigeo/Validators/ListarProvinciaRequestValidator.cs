﻿/*****
 * Nombre del archivo:  ListarProvinciaRequestValidator.cs
 * Descripción:         Validador para la solicitud de listado de provincias. Hereda de AbstractValidator
 *                      y define las reglas de validación para el DTO ListarProvinciaRequest.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Empresa.Application.Ubigeo.Dtos;
using FluentValidation;

namespace Empresa.Application.Ubigeo.Validators
{
    public class ListarProvinciaRequestValidator : AbstractValidator<ListarProvinciaRequest>
    {
        public ListarProvinciaRequestValidator()
        {
        }
    }
}
