using Empresa.Domain.Dieta.Results;
using Empresa.Presentation.Dieta.Presenters;
using Empresa.Presentation.Dieta.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Dieta
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDietaPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<DietaResult, ItemResponse<DietaResponse>>, ObtenerDietaResponsePresenter>();
            return services;
        }
    }
}
