using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Presenters;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddModuloPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<List<ModuloConAccionesResult>, LstItemResponse<ModuloConAccionesResponse>>, ModuloConAccionesResponsePresenter>();
            return services;
        }
    }
}
