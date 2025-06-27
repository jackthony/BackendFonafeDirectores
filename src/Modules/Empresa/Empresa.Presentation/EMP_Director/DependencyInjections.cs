using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Mappers;
using Empresa.Presentation.Director.Presenters;
using Empresa.Presentation.Director.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Director
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDirectorPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<DirectorResult>, LstItemResponse<DirectorResponse>>, ListDirectorPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<DirectorResult>, LstItemResponse<DirectorResponse>>, ListDirectorResponsePresenter>();
            services.AddScoped<IPresenterDelivery<DirectorResult, ItemResponse<DirectorResponse>>, ObtenerDirectorResponsePorIdPresenter>();
            return services;
        }
    }
}
