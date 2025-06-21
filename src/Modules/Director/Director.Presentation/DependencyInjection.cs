using Director.Application.Dtos;
using Director.Application.Repositories;
using Director.Domain.Repositories;
using Director.Presentation.Dtos.Request;
using Director.Presentation.Dtos.Responses;
using Director.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Director.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDirectorPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarDirectorClientRequest, ActualizarDirectorRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarDirectorPresenter>();

            services.AddScoped<
                IPresenter<CrearDirectorClientRequest, CrearDirectorRequest, SpResultBase, ItemResponse<int>>,
                CrearDirectorPresenter>();

            services.AddScoped<
                IPresenter<EliminarDirectorClientRequest, EliminarDirectorRequest, SpResultBase, ItemResponse<bool>>,
                EliminarDirectorPresenter>();

            services.AddScoped<
                IPresenter<ListarDirectorPaginadoClientRequest, ListarDirectorPaginadoRequest, PagedResult<DirectorDto>, LstItemResponse<DirectorClientDto>>,
                ListarDirectorPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarDirectorClientRequest, ListarDirectorRequest, List<DirectorDto>, LstItemResponse<DirectorClientDto>>,
                ListarDirectorPresenter>();

            services.AddScoped<
                IPresenter<int, long, DirectorDto, ItemResponse<DirectorClientDto>>,
                ObtenerDirectorPorIdPresenter>();

            return services;
        }
    }
}
