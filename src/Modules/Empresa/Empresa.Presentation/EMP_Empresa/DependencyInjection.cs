using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Presentation.EMP_Empresa.Dtos.Request;
using Empresa.Presentation.EMP_Empresa.Dtos.Responses;
using Empresa.Presentation.EMP_Empresa.Presenters;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Empresa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEmpresaPresentation(this IServiceCollection services)
        {
            services.AddScoped<
                IPresenter<ActualizarEmpresaClientRequest, ActualizarEmpresaRequest, SpResultBase, ItemResponse<bool>>,
                ActualizarEmpresaPresenter>();

            services.AddScoped<
                IPresenter<CrearEmpresaClientRequest, CrearEmpresaRequest, SpResultBase, ItemResponse<int>>,
                CrearEmpresaPresenter>();

            services.AddScoped<
                IPresenter<EliminarEmpresaClientRequest, EliminarEmpresaRequest, SpResultBase, ItemResponse<bool>>,
                EliminarEmpresaPresenter>();

            services.AddScoped<
                IPresenter<ListarEmpresaPaginadoClientRequest, ListarEmpresaPaginadoRequest, PagedResult<EmpresaDto>, LstItemResponse<EmpresaClientDto>>,
                ListarEmpresaPaginadoPresenter>();

            services.AddScoped<
                IPresenter<ListarEmpresaClientRequest, ListarEmpresaRequest, List<EmpresaDto>, LstItemResponse<EmpresaClientDto>>,
                ListarEmpresaPresenter>();

            services.AddScoped<
                IPresenter<int, long, EmpresaDto, ItemResponse<EmpresaClientDto>>,
                ObtenerEmpresaPorIdPresenter>();

            return services;
        }
    }
}
