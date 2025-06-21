using Modulo.Application.Dtos;
using Modulo.Application.Repositories;
using Modulo.Domain.Repositories;
using Modulo.Presentation.Dtos.Request;
using Modulo.Presentation.Dtos.Responses;
using Modulo.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddModuloPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarModuloClientRequest, ActualizarModuloRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarModuloPresenter>();

            services.AddScoped<
                IPresenter<CrearModuloClientRequest, CrearModuloRequest, SpResultBase, ItemResponse<int>>,
                CrearModuloPresenter>();

            services.AddScoped<
                IPresenter<EliminarModuloClientRequest, EliminarModuloRequest, SpResultBase, ItemResponse<bool>>,
                EliminarModuloPresenter>();

            services.AddScoped<
                IPresenter<ListarModuloPaginadoClientRequest, ListarModuloPaginadoRequest, PagedResult<ModuloDto>, LstItemResponse<ModuloClientDto>>,
                ListarModuloPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarModuloClientRequest, ListarModuloRequest, List<ModuloDto>, LstItemResponse<ModuloClientDto>>,
                ListarModuloPresenter>();

            services.AddScoped<
                IPresenter<int, long, ModuloDto, ItemResponse<ModuloClientDto>>,
                ObtenerModuloPorIdPresenter>();

            return services;
        }
    }
}
