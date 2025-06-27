using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Mappers;
using Usuario.Presentation.User.Presenters;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUserPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<UserResult>, LstItemResponse<UserResponse>>, ListUserPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<UserResult>, LstItemResponse<UserResponse>>, ListUserResponsePresenter>();
            services.AddScoped<IPresenterDelivery<UserResult, ItemResponse<UserResponse>>, ObtenerUserResponsePorIdPresenter>();
            return services;
        }
    }
}
