using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Mappers;
using Empresa.Presentation.Empresa.Presenters;
using Empresa.Presentation.Empresa.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Empresa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEmpresaPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<EmpresaResult>, LstItemResponse<EmpresaResponse>>, ListEmpresaPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<EmpresaResult>, LstItemResponse<EmpresaResponse>>, ListEmpresaResponsePresenter>();
            services.AddScoped<IPresenterDelivery<EmpresaResult, ItemResponse<EmpresaResponse>>, ObtenerEmpresaResponsePorIdPresenter>();
            return services;
        }
    }
}
