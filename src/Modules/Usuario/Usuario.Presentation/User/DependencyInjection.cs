/***********
 * Nombre del archivo:   DependencyInjections.cs
 * Descripción:          Clase de extensión que configura la inyección de dependencias para los presentadores
 *                       de usuario. Facilita la resolución de interfaces de presentadores con sus
 *                       implementaciones concretas para la capa de presentación de usuarios.
 * Autor:                Daniel Alva
 * Fecha de creación:    09/07/2025
 * Última modificación:  09/07/2025 por Daniel Alva
 * Cambios recientes:    Creación inicial de la clase para la configuración de inyección de dependencias
 *                       de presentadores de usuario.
 **********/

using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Mappers;
using Usuario.Presentation.User.Presenters;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUserPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<UserResult>, LstItemResponse<UserResponse>>, ListUserPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<UserResult>, LstItemResponse<UserResponse>>, ListUserResponsePresenter>();
            services.AddScoped<IPresenterDelivery<UserResult, ItemResponse<UserResponse>>, ObtenerUserResponsePorIdPresenter>();
            return services;
        }
    }
}
