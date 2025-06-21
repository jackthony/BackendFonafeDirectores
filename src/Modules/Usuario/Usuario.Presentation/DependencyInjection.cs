using Usuario.Application.Dtos;
using Usuario.Application.Repositories;
using Usuario.Domain.Repositories;
using Usuario.Presentation.Dtos.Request;
using Usuario.Presentation.Dtos.Responses;
using Usuario.Presentation.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Presentation
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUsuarioPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarUsuarioClientRequest, ActualizarUsuarioRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarUsuarioPresenter>();

            services.AddScoped<
                IPresenter<CrearUsuarioClientRequest, CrearUsuarioRequest, SpResultBase, ItemResponse<int>>,
                CrearUsuarioPresenter>();

            services.AddScoped<
                IPresenter<EliminarUsuarioClientRequest, EliminarUsuarioRequest, SpResultBase, ItemResponse<bool>>,
                EliminarUsuarioPresenter>();

            services.AddScoped<
                IPresenter<ListarUsuarioPaginadoClientRequest, ListarUsuarioPaginadoRequest, PagedResult<UsuarioDto>, LstItemResponse<UsuarioClientDto>>,
                ListarUsuarioPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarUsuarioClientRequest, ListarUsuarioRequest, List<UsuarioDto>, LstItemResponse<UsuarioClientDto>>,
                ListarUsuarioPresenter>();

            services.AddScoped<
                IPresenter<int, long, UsuarioDto, ItemResponse<UsuarioClientDto>>,
                ObtenerUsuarioPorIdPresenter>();

            return services;
        }
    }
}
