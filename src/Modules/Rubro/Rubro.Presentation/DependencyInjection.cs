using Rubro.Application.Dtos;
using Rubro.Application.Repositories;
using Rubro.Domain.Repositories;
using Rubro.Presentation.Dtos.Request;
using Rubro.Presentation.Dtos.Responses;
using Rubro.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rubro.Presentation
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
