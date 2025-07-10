/***********
 * Nombre del archivo:   DependencyInjections.cs
 * Descripción:          Clase de extensión que configura la inyección de dependencias para los presentadores
 *                       de roles. Facilita la resolución de interfaces de presentadores con sus
 *                       implementaciones concretas para la capa de presentación de roles.
 * Autor:                Daniel Alva
 * Fecha de creación:    09/07/2025
 * Última modificación:  09/07/2025 por Daniel Alva
 * Cambios recientes:    Creación inicial de la clase para la configuración de inyección de dependencias
 *                       de presentadores de roles.
 **********/

using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Mappers;
using Usuario.Presentation.Rol.Presenters;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.SEG_Rol
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRolPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<RolResult>, LstItemResponse<RolResponse>>, ListRolPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<RolResult>, LstItemResponse<RolResponse>>, ListRolResponsePresenter>();
            services.AddScoped<IPresenterDelivery<RolResult, ItemResponse<RolResponse>>, ObtenerRolResponsePorIdPresenter>();
            return services;
        }
    }
}
