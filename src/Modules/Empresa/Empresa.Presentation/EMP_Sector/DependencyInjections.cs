/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase de extensión que registra los presentadores relacionados al módulo Sector 
 *                      en el contenedor de dependencias. Permite la inyección de presentadores para
 *                      operaciones como listar, paginar y obtener sectores por ID.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Registro de presentadores para el módulo EMP_Sector.
 ***********/

using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Mappers;
using Empresa.Presentation.Sector.Presenters;
using Empresa.Presentation.Sector.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Sector
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddSectorPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<SectorResult>, LstItemResponse<SectorResponse>>, ListSectorPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<SectorResult>, LstItemResponse<SectorResponse>>, ListSectorResponsePresenter>();
            services.AddScoped<IPresenterDelivery<SectorResult, ItemResponse<SectorResponse>>, ObtenerSectorResponsePorIdPresenter>();
            return services;
        }
    }
}
