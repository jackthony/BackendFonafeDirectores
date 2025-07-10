/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que registra los presentadores (presenters) del módulo PermisoRol
 *                      en el contenedor de inyección de dependencias.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Registro de presentadores para paginación, listado y obtención por ID.
 ***********/

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
