using Rol.Application.Dtos;
using Rol.Application.Repositories;
using Rol.Domain.Repositories;
using Rol.Presentation.Dtos.Request;
using Rol.Presentation.Dtos.Responses;
using Rol.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRolPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarRolClientRequest, ActualizarRolRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarRolPresenter>();

            services.AddScoped<
                IPresenter<CrearRolClientRequest, CrearRolRequest, SpResultBase, ItemResponse<int>>,
                CrearRolPresenter>();

            services.AddScoped<
                IPresenter<EliminarRolClientRequest, EliminarRolRequest, SpResultBase, ItemResponse<bool>>,
                EliminarRolPresenter>();

            services.AddScoped<
                IPresenter<ListarRolPaginadoClientRequest, ListarRolPaginadoRequest, PagedResult<RolDto>, LstItemResponse<RolClientDto>>,
                ListarRolPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarRolClientRequest, ListarRolRequest, List<RolDto>, LstItemResponse<RolClientDto>>,
                ListarRolPresenter>();

            services.AddScoped<
                IPresenter<int, long, RolDto, ItemResponse<RolClientDto>>,
                ObtenerRolPorIdPresenter>();

            return services;
        }
    }
}
