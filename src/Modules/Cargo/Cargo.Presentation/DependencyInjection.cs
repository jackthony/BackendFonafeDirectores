using Cargo.Application.Dtos;
using Cargo.Application.Repositories;
using Cargo.Domain.Repositories;
using Cargo.Presentation.Dtos.Request;
using Cargo.Presentation.Dtos.Responses;
using Cargo.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Cargo.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCargoPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarCargoClientRequest, ActualizarCargoRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarCargoPresenter>();

            services.AddScoped<
                IPresenter<CrearCargoClientRequest, CrearCargoRequest, SpResultBase, ItemResponse<int>>,
                CrearCargoPresenter>();

            services.AddScoped<
                IPresenter<EliminarCargoClientRequest, EliminarCargoRequest, SpResultBase, ItemResponse<bool>>,
                EliminarCargoPresenter>();

            services.AddScoped<
                IPresenter<ListarCargoPaginadoClientRequest, ListarCargoPaginadoRequest, PagedResult<CargoDto>, LstItemResponse<CargoClientDto>>,
                ListarCargoPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarCargoClientRequest, ListarCargoRequest, List<CargoDto>, LstItemResponse<CargoClientDto>>,
                ListarCargoPresenter>();

            services.AddScoped<
                IPresenter<int, long, CargoDto, ItemResponse<CargoClientDto>>,
                ObtenerCargoPorIdPresenter>();

            return services;
        }
    }
}
