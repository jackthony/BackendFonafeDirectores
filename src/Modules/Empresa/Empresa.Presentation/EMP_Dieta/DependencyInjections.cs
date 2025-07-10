/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática para configurar la inyección de dependencias
 *                      del módulo Dieta, registrando el presenter necesario
 *                      para la presentación de respuestas individuales.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de la configuración de inyección de dependencias para el módulo Dieta.
 ***********/

using Empresa.Domain.Dieta.Results;
using Empresa.Presentation.Dieta.Presenters;
using Empresa.Presentation.Dieta.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Dieta
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDietaPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<DietaResult, ItemResponse<DietaResponse>>, ObtenerDietaResponsePresenter>();
            return services;
        }
    }
}
