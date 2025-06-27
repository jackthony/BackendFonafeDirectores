using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Mappers;
using Empresa.Presentation.Ministerio.Presenters;
using Empresa.Presentation.Ministerio.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Ministerio
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMinisterioPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<MinisterioResult>, LstItemResponse<MinisterioResponse>>, ListMinisterioPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<MinisterioResult>, LstItemResponse<MinisterioResponse>>, ListMinisterioResponsePresenter>();
            services.AddScoped<IPresenterDelivery<MinisterioResult, ItemResponse<MinisterioResponse>>, ObtenerMinisterioResponsePorIdPresenter>();
            return services;
        }
    }
}
