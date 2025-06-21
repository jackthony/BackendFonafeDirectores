using TipoDirector.Application.Dtos;
using TipoDirector.Application.Repositories;
using TipoDirector.Domain.Repositories;
using TipoDirector.Presentation.Dtos.Request;
using TipoDirector.Presentation.Dtos.Responses;
using TipoDirector.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace TipoDirector.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddTipoDirectorPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarTipoDirectorClientRequest, ActualizarTipoDirectorRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarTipoDirectorPresenter>();

            services.AddScoped<
                IPresenter<CrearTipoDirectorClientRequest, CrearTipoDirectorRequest, SpResultBase, ItemResponse<int>>,
                CrearTipoDirectorPresenter>();

            services.AddScoped<
                IPresenter<EliminarTipoDirectorClientRequest, EliminarTipoDirectorRequest, SpResultBase, ItemResponse<bool>>,
                EliminarTipoDirectorPresenter>();

            services.AddScoped<
                IPresenter<ListarTipoDirectorPaginadoClientRequest, ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorDto>, LstItemResponse<TipoDirectorClientDto>>,
                ListarTipoDirectorPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarTipoDirectorClientRequest, ListarTipoDirectorRequest, List<TipoDirectorDto>, LstItemResponse<TipoDirectorClientDto>>,
                ListarTipoDirectorPresenter>();

            services.AddScoped<
                IPresenter<int, long, TipoDirectorDto, ItemResponse<TipoDirectorClientDto>>,
                ObtenerTipoDirectorPorIdPresenter>();

            return services;
        }
    }
}
