using Sector.Application.Dtos;
using Sector.Application.Repositories;
using Sector.Domain.Repositories;
using Sector.Presentation.Dtos.Request;
using Sector.Presentation.Dtos.Responses;
using Sector.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Sector.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddSectorPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarSectorClientRequest, ActualizarSectorRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarSectorPresenter>();

            services.AddScoped<
                IPresenter<CrearSectorClientRequest, CrearSectorRequest, SpResultBase, ItemResponse<int>>,
                CrearSectorPresenter>();

            services.AddScoped<
                IPresenter<EliminarSectorClientRequest, EliminarSectorRequest, SpResultBase, ItemResponse<bool>>,
                EliminarSectorPresenter>();

            services.AddScoped<
                IPresenter<ListarSectorPaginadoClientRequest, ListarSectorPaginadoRequest, PagedResult<SectorDto>, LstItemResponse<SectorClientDto>>,
                ListarSectorPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarSectorClientRequest, ListarSectorRequest, List<SectorDto>, LstItemResponse<SectorClientDto>>,
                ListarSectorPresenter>();

            services.AddScoped<
                IPresenter<int, long, SectorDto, ItemResponse<SectorClientDto>>,
                ObtenerSectorPorIdPresenter>();

            return services;
        }
    }
}
