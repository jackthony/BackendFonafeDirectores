using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Presentation.EMP_Sector.Dtos.Request;
using Empresa.Presentation.EMP_Sector.Dtos.Responses;
using Empresa.Presentation.EMP_Sector.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Sector
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
