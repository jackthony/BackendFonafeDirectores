/***********
 * Nombre del archivo:  ExceptionHandlingMiddleware.cs
 * Descripción:         Middleware para el manejo global de excepciones no controladas en la API.
 *                      Captura errores durante el procesamiento de las solicitudes, los registra
 *                      y devuelve una respuesta genérica al cliente.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del middleware.
 ***********/

namespace Api.Middlewares
{
    public class ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        private readonly RequestDelegate _next = next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger = logger;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Se ha producido un error inesperado.");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = new
            {
                Success = false,
                Message = "Ocurrió un error inesperado.",
                Exception = exception.Message
            };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            return context.Response.WriteAsJsonAsync(response);
        }
    }
}
