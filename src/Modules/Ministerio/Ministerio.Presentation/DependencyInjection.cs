using Ministerio.Application.Dtos;
using Ministerio.Application.Repositories;
using Ministerio.Domain.Repositories;
using Ministerio.Presentation.Dtos.Request;
using Ministerio.Presentation.Dtos.Responses;
using Ministerio.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Ministerio.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMinisterioPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarMinisterioClientRequest, ActualizarMinisterioRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarMinisterioPresenter>();

            services.AddScoped<
                IPresenter<CrearMinisterioClientRequest, CrearMinisterioRequest, SpResultBase, ItemResponse<int>>,
                CrearMinisterioPresenter>();

            services.AddScoped<
                IPresenter<EliminarMinisterioClientRequest, EliminarMinisterioRequest, SpResultBase, ItemResponse<bool>>,
                EliminarMinisterioPresenter>();

            services.AddScoped<
                IPresenter<ListarMinisterioPaginadoClientRequest, ListarMinisterioPaginadoRequest, PagedResult<MinisterioDto>, LstItemResponse<MinisterioClientDto>>,
                ListarMinisterioPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarMinisterioClientRequest, ListarMinisterioRequest, List<MinisterioDto>, LstItemResponse<MinisterioClientDto>>,
                ListarMinisterioPresenter>();

            services.AddScoped<
                IPresenter<int, long, MinisterioDto, ItemResponse<MinisterioClientDto>>,
                ObtenerMinisterioPorIdPresenter>();

            return services;
        }
    }
}
