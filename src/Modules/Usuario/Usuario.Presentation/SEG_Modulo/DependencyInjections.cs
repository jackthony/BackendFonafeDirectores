/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática para registrar los presentadores del módulo "Modulo" 
 *                      en el contenedor de dependencias mediante extensión de IServiceCollection.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Registro del presentador ModuloConAccionesResponsePresenter.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Presenters;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddModuloPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<List<ModuloConAccionesResult>, LstItemResponse<ModuloConAccionesResponse>>, ModuloConAccionesResponsePresenter>();
            return services;
        }
    }
}
