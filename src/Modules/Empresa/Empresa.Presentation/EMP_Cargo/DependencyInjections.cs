using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Mappers;
using Empresa.Presentation.Cargo.Presenters;
using Empresa.Presentation.Cargo.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Cargo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCargoPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<CargoResult>, LstItemResponse<CargoResponse>>, ListCargoPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<CargoResult>, LstItemResponse<CargoResponse>>, ListCargoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<CargoResult, ItemResponse<CargoResponse>>, ObtenerCargoResponsePorIdPresenter>();
            return services;
        }
    }
}
