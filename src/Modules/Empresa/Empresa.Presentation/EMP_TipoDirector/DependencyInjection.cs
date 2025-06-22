using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Request;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Responses;
using Empresa.Presentation.EMP_TipoDirector.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_TipoDirector
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
