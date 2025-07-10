/*****
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Clase que configura la inyección de dependencias para los componentes relacionados con la gestión de dietas en la aplicación.
 *                      Registra los casos de uso (`UseCases`), mapeadores (`Mappers`) y validadores (`Validators`) necesarios para la obtención de dietas.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Empresa.Application.Dieta.Dtos;
using Empresa.Application.Dieta.Mappers;
using Empresa.Application.Dieta.UseCases;
using Empresa.Application.Dieta.Validators;
using Empresa.Domain.Dieta.Parameters;
using Empresa.Domain.Dieta.Results;
using FluentValidation;

namespace Empresa.Application.Dieta
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDietaApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ObtenerDietaRequest, DietaResult?>, ObtenerDietaUseCase>();

            // Mappers
            services.AddScoped<IMapper<ObtenerDietaRequest, ObtenerDietaParameter>, ObtenerDietaRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ObtenerDietaRequest>, ObtenerDietaRequestValidator>();

            return services;
        }
    }
}
