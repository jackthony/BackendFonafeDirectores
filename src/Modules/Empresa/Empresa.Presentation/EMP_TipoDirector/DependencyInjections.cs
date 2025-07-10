/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que registra los presentadores (presenters) para el módulo de TipoDirector
 *                      en el contenedor de dependencias, facilitando su inyección y uso en la aplicación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Registro de presentadores para listar y obtener TipoDirector.
 ***********/

using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Mappers;
using Empresa.Presentation.TipoDirector.Presenters;
using Empresa.Presentation.TipoDirector.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_TipoDirector
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddTipoDirectorPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>>, ListTipoDirectorPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>>, ListTipoDirectorResponsePresenter>();
            services.AddScoped<IPresenterDelivery<TipoDirectorResult, ItemResponse<TipoDirectorResponse>>, ObtenerTipoDirectorResponsePorIdPresenter>();
            return services;
        }
    }
}
