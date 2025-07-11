﻿/*****
 * Nombre del archivo:  ListarCargoRequestValidator.cs
 * Descripción:         Clase vacía que podría usarse para validar solicitudes de listado de cargos (`ListarCargoRequest`) en el futuro. 
 *                      Actualmente no contiene reglas de validación, pero está diseñada para ser extendida con reglas de validación si es necesario.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class ListarCargoRequestValidator : AbstractValidator<ListarCargoRequest>
    {
        public ListarCargoRequestValidator()
        {
        }
    }
}
