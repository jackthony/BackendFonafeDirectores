using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Mappers;
using Empresa.Presentation.Especialidad.Presenters;
using Empresa.Presentation.Especialidad.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Especialidad
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEspecialidadPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<EspecialidadResult>, LstItemResponse<EspecialidadResponse>>, ListEspecialidadPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<EspecialidadResult>, LstItemResponse<EspecialidadResponse>>, ListEspecialidadResponsePresenter>();
            services.AddScoped<IPresenterDelivery<EspecialidadResult, ItemResponse<EspecialidadResponse>>, ObtenerEspecialidadResponsePorIdPresenter>();
            return services;
        }
    }
}
