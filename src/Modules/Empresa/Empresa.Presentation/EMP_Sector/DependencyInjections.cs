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
