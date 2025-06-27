using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Mappers;
using Empresa.Presentation.TipoDirector.Presenters;
using Empresa.Presentation.TipoDirector.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_TipoDirector
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddTipoDirectorPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>>, ListTipoDirectorPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>>, ListTipoDirectorResponsePresenter>();
            services.AddScoped<IPresenterDelivery<TipoDirectorResult, ItemResponse<TipoDirectorResponse>>, ObtenerTipoDirectorResponsePorIdPresenter>();
            return services;
        }
    }
}
