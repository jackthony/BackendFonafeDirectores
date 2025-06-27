using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Mappers;
using Usuario.Presentation.Rol.Presenters;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.SEG_Rol
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRolPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<RolResult>, LstItemResponse<RolResponse>>, ListRolPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<RolResult>, LstItemResponse<RolResponse>>, ListRolResponsePresenter>();
            services.AddScoped<IPresenterDelivery<RolResult, ItemResponse<RolResponse>>, ObtenerRolResponsePorIdPresenter>();
            return services;
        }
    }
}
