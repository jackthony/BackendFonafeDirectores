﻿/*****
 * Nombre del archivo:  EliminarArchivoRequestValidator.cs
 * Descripción:         Validador para la solicitud de eliminación de archivo (`EliminarArchivoRequest`). 
 *                      Utiliza FluentValidation para validar las propiedades de la solicitud antes de procesarla.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Archivo.Application.Archivo.Dtos;

namespace Archivo.Application.Archivo.Validators
{
    public class EliminarArchivoRequestValidator : AbstractValidator<EliminarArchivoRequest>
    {
        public EliminarArchivoRequestValidator()
        {
        }
    }
}
