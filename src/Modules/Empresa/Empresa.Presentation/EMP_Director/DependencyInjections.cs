/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática para configurar la inyección de dependencias
 *                      de los presenters del módulo Director, registrando los servicios
 *                      necesarios para la presentación de datos paginados, listas y por ID.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de la configuración de inyección de dependencias para el módulo Director.
 ***********/

using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Mappers;
using Empresa.Presentation.Director.Presenters;
using Empresa.Presentation.Director.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Director
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDirectorPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<DirectorResult>, LstItemResponse<DirectorResponse>>, ListDirectorPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<DirectorResult>, LstItemResponse<DirectorResponse>>, ListDirectorResponsePresenter>();
            services.AddScoped<IPresenterDelivery<DirectorResult, ItemResponse<DirectorResponse>>, ObtenerDirectorResponsePorIdPresenter>();
            return services;
        }
    }
}
