using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Presentation.EMP_Ministerio.Dtos.Request;
using Empresa.Presentation.EMP_Ministerio.Dtos.Responses;
using Empresa.Presentation.EMP_Ministerio.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Ministerio
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
