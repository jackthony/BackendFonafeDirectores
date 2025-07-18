﻿/*****
 * Nombre del archivo:  ObtenerDietaRequestValidator.cs
 * Descripción:         Clase vacía que puede ser utilizada para validar solicitudes para obtener la dieta (`ObtenerDietaRequest`) en el futuro. 
 *                      Actualmente no contiene reglas de validación, pero está diseñada para ser extendida con reglas de validación si es necesario.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Empresa.Application.Dieta.Dtos;
using FluentValidation;

namespace Empresa.Application.Dieta.Validators
{
    public class ObtenerDietaRequestValidator : AbstractValidator<ObtenerDietaRequest>
    {
        public ObtenerDietaRequestValidator()
        {
        }
    }
}
