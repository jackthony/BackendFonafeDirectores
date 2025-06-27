using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Presenters;
using Empresa.Presentation.Ubigeo.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Ubigeo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUbigeoPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<List<DepartamentoResult>, LstItemResponse<DepartamentoResponse>>, ListDepartamentoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<ProvinciaResult>, LstItemResponse<ProvinciaResponse>>, ListProvinciaResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<DistritoResult>, LstItemResponse<DistritoResponse>>, ListDistritoResponsePresenter>();
            return services;
        }
    }
}
