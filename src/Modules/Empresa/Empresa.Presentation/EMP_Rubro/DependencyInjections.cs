using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Mappers;
using Empresa.Presentation.Rubro.Presenters;
using Empresa.Presentation.Rubro.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Rubro
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRubroPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<RubroResult>, LstItemResponse<RubroResponse>>, ListRubroPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<RubroResult>, LstItemResponse<RubroResponse>>, ListRubroResponsePresenter>();
            services.AddScoped<IPresenterDelivery<RubroResult, ItemResponse<RubroResponse>>, ObtenerRubroResponsePorIdPresenter>();
            return services;
        }
    }
}
