/***********
 * Nombre del archivo:  ValidationUseCaseDecorator.cs
 * Descripción:         Decorador para casos de uso que aplica validación automática 
 *                      utilizando FluentValidation antes de ejecutar la lógica principal.
 *                      Si la validación falla, retorna un error con los detalles agrupados 
 *                      por propiedad, evitando la ejecución del caso de uso subyacente.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del decorador de validación para la capa de aplicación.
 ***********/

using FluentValidation;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Api.Decorators
{
    public class ValidationUseCaseDecorator<TRequest, TResponse> : IUseCase<TRequest, TResponse>
    {
        private readonly IUseCase<TRequest, TResponse> _inner;
        private readonly IValidator<TRequest>? _validator;

        public ValidationUseCaseDecorator(
            IUseCase<TRequest, TResponse> inner,
            IServiceProvider serviceProvider)
        {
            _inner = inner;
            _validator = serviceProvider.GetService<IValidator<TRequest>>();
        }

        public async Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request)
        {
            if (_validator is not null)
            {
                var validationResult = await _validator.ValidateAsync(request);

                if (!validationResult.IsValid)
                {
                    var errors = validationResult.Errors
                        .GroupBy(error => error.PropertyName)
                        .ToDictionary(
                            group => group.Key,
                            group => group.Select(e => e.ErrorMessage).ToArray()
                        );

                    return ErrorBase.Validation("Errores de validación encontrados.", errors);
                }
            }

            return await _inner.ExecuteAsync(request);
        }
    }
}
