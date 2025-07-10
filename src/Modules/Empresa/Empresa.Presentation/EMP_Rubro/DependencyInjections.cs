/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que registra los presentadores relacionados al módulo Rubro
 *                      en el contenedor de dependencias, incluyendo presentadores de listado,
 *                      listado paginado y obtención por ID.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Registro de presentadores para el módulo Rubro.
 ***********/

using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Mappers;
using Empresa.Presentation.Rubro.Presenters;
using Empresa.Presentation.Rubro.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Rubro
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRubroPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<RubroResult>, LstItemResponse<RubroResponse>>, ListRubroPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<RubroResult>, LstItemResponse<RubroResponse>>, ListRubroResponsePresenter>();
            services.AddScoped<IPresenterDelivery<RubroResult, ItemResponse<RubroResponse>>, ObtenerRubroResponsePorIdPresenter>();
            return services;
        }
    }
}
