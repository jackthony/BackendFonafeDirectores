using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Presentation.EMP_Especialidad.Dtos.Request;
using Empresa.Presentation.EMP_Especialidad.Dtos.Responses;
using Empresa.Presentation.EMP_Especialidad.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Especialidad
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEspecialidadPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarEspecialidadClientRequest, ActualizarEspecialidadRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarEspecialidadPresenter>();

            services.AddScoped<
                IPresenter<CrearEspecialidadClientRequest, CrearEspecialidadRequest, SpResultBase, ItemResponse<int>>,
                CrearEspecialidadPresenter>();

            services.AddScoped<
                IPresenter<EliminarEspecialidadClientRequest, EliminarEspecialidadRequest, SpResultBase, ItemResponse<bool>>,
                EliminarEspecialidadPresenter>();

            services.AddScoped<
                IPresenter<ListarEspecialidadPaginadoClientRequest, ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadDto>, LstItemResponse<EspecialidadClientDto>>,
                ListarEspecialidadPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarEspecialidadClientRequest, ListarEspecialidadRequest, List<EspecialidadDto>, LstItemResponse<EspecialidadClientDto>>,
                ListarEspecialidadPresenter>();

            services.AddScoped<
                IPresenter<int, long, EspecialidadDto, ItemResponse<EspecialidadClientDto>>,
                ObtenerEspecialidadPorIdPresenter>();

            return services;
        }
    }
}
