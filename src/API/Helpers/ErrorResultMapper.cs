﻿/***********
 * Nombre del archivo:  ErrorResultMapper.cs
 * Descripción:         Clase auxiliar que transforma objetos de error (`ErrorBase` y derivados) en respuestas
 *                      HTTP apropiadas (`IActionResult`) usando `ProblemDetailsOur`. Facilita el manejo
 *                      centralizado de errores en los controladores de la API.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Errors;

namespace Api.Helpers
{
    public static class ErrorResultMapper
    {
        public static IActionResult MapError(ErrorBase error, HttpContext? httpContext = null, bool? showToast = null)
        {
            var resolvedShowToast = showToast ?? true;

            ProblemDetailsOur problem = error switch
            {
                DatabaseError db => new ProblemDetailsOur
                {
                    Title = "Error de base de datos",
                    Status = StatusCodes.Status400BadRequest,
                    Type = "https://httpstatuses.com/400",
                    Detail = db.Message ?? "Error al acceder a la base de datos.",
                    Instance = httpContext?.Request.Path,
                    showToast = resolvedShowToast,
                },
                ControllerError controller => new ProblemDetailsOur
                {
                    Title = "Error en el controlador",
                    Status = StatusCodes.Status409Conflict,
                    Type = "https://httpstatuses.com/409",
                    Detail = controller.Message,
                    Instance = httpContext?.Request.Path,
                    showToast = resolvedShowToast
                },
                ValidationError validation => new ValidationProblemDetailsOur
                {
                    Title = "Error de validación",
                    Status = StatusCodes.Status400BadRequest,
                    Type = "https://httpstatuses.com/400",
                    Detail = validation.Message ?? "Error de validación",
                    Instance = httpContext?.Request.Path,
                    showToast = resolvedShowToast,
                    Errors = validation.Errors ?? [],
                },
                UnexpectedError unexpected => new ProblemDetailsOur
                {
                    Title = "Error inesperado",
                    Status = StatusCodes.Status500InternalServerError,
                    Type = "https://httpstatuses.com/500",
                    Detail = unexpected.Message,
                    Instance = httpContext?.Request.Path,
                    showToast = resolvedShowToast,
                },
                _ => new ProblemDetailsOur
                {
                    Title = error.Message,
                    Status = StatusCodes.Status400BadRequest,
                    Type = "https://httpstatuses.com/400",
                    Instance = httpContext?.Request.Path,
                    showToast = resolvedShowToast
                }
            };

            return new ObjectResult(problem)
            {
                StatusCode = problem.Status
            };
        }
    }
}
