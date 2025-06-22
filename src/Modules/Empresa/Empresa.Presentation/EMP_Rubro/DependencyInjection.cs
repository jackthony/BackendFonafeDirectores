using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Presentation.EMP_Rubro.Dtos.Request;
using Empresa.Presentation.EMP_Rubro.Dtos.Responses;
using Empresa.Presentation.EMP_Rubro.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Rubro
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRubroPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarRubroClientRequest, ActualizarRubroRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarRubroPresenter>();

            services.AddScoped<
                IPresenter<CrearRubroClientRequest, CrearRubroRequest, SpResultBase, ItemResponse<int>>,
                CrearRubroPresenter>();

            services.AddScoped<
                IPresenter<EliminarRubroClientRequest, EliminarRubroRequest, SpResultBase, ItemResponse<bool>>,
                EliminarRubroPresenter>();

            services.AddScoped<
                IPresenter<ListarRubroPaginadoClientRequest, ListarRubroPaginadoRequest, PagedResult<RubroDto>, LstItemResponse<RubroClientDto>>,
                ListarRubroPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarRubroClientRequest, ListarRubroRequest, List<RubroDto>, LstItemResponse<RubroClientDto>>,
                ListarRubroPresenter>();

            services.AddScoped<
                IPresenter<int, long, RubroDto, ItemResponse<RubroClientDto>>,
                ObtenerRubroPorIdPresenter>();

            return services;
        }
    }
}
