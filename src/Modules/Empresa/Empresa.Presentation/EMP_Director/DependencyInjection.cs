using Empresa.Application.EMP_Director.Dtos;
using Empresa.Presentation.EMP_Director.Dtos.Request;
using Empresa.Presentation.EMP_Director.Dtos.Responses;
using Empresa.Presentation.EMP_Director.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Director
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
