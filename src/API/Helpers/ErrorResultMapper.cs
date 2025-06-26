using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Errors;

namespace Api.Helpers
{
    public static class ErrorResultMapper
    {
        public static IActionResult MapError(ErrorBase error, HttpContext? httpContext = null)
        {
            ProblemDetails problem = error switch
            {
                ValidationError validation => new ValidationProblemDetails(validation.Errors ?? [])
                {
                    Title = "Error de validación",
                    Status = StatusCodes.Status400BadRequest,
                    Type = "https://httpstatuses.com/400",
                    Detail = validation.Message ?? "Error de validación",
                    Instance = httpContext?.Request.Path
                },
                DatabaseError db => new ProblemDetails
                {
                    Title = "Error de base de datos",
                    Status = StatusCodes.Status503ServiceUnavailable,
                    Type = "https://httpstatuses.com/503",
                    Detail = db.Message ?? "Error al acceder a la base de datos.",
                    Instance = httpContext?.Request.Path
                },
                UnexpectedError unexpected => new ProblemDetails
                {
                    Title = "Error inesperado",
                    Status = StatusCodes.Status500InternalServerError,
                    Type = "https://httpstatuses.com/500",
                    Detail = unexpected.Message,
                    Instance = httpContext?.Request.Path
                },
                _ => new ProblemDetails
                {
                    Title = error.Message,
                    Status = StatusCodes.Status400BadRequest,
                    Type = "https://httpstatuses.com/400",
                    Instance = httpContext?.Request.Path
                }
            };

            return new ObjectResult(problem)
            {
                StatusCode = problem.Status
            };
        }
    }
}
