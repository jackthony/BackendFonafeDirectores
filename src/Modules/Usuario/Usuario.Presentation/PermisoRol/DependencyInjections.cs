using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.PermisoRol.Results;
using Usuario.Presentation.PermisoRol.Mappers;
using Usuario.Presentation.PermisoRol.Presenters;
using Usuario.Presentation.PermisoRol.Responses;

namespace Usuario.Presentation.PermisoRol
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddPermisoRolPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<PermisoRolResult>, LstItemResponse<PermisoRolResponse>>, ListPermisoRolPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<PermisoRolResult>, LstItemResponse<PermisoRolResponse>>, ListPermisoRolResponsePresenter>();
            services.AddScoped<IPresenterDelivery<PermisoRolResult, ItemResponse<PermisoRolResponse>>, ObtenerPermisoRolResponsePorIdPresenter>();
            return services;
        }
    }
}
