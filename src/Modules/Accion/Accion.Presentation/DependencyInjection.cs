using Accion.Application.Dtos;
using Accion.Application.Repositories;
using Accion.Domain.Repositories;
using Accion.Presentation.Dtos.Request;
using Accion.Presentation.Dtos.Responses;
using Accion.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddAccionPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarAccionClientRequest, ActualizarAccionRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarAccionPresenter>();

            services.AddScoped<
                IPresenter<CrearAccionClientRequest, CrearAccionRequest, SpResultBase, ItemResponse<int>>,
                CrearAccionPresenter>();

            services.AddScoped<
                IPresenter<EliminarAccionClientRequest, EliminarAccionRequest, SpResultBase, ItemResponse<bool>>,
                EliminarAccionPresenter>();

            services.AddScoped<
                IPresenter<ListarAccionPaginadoClientRequest, ListarAccionPaginadoRequest, PagedResult<AccionDto>, LstItemResponse<AccionClientDto>>,
                ListarAccionPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarAccionClientRequest, ListarAccionRequest, List<AccionDto>, LstItemResponse<AccionClientDto>>,
                ListarAccionPresenter>();

            services.AddScoped<
                IPresenter<int, long, AccionDto, ItemResponse<AccionClientDto>>,
                ObtenerAccionPorIdPresenter>();

            return services;
        }
    }
}
