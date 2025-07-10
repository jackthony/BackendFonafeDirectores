/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase de configuración de inyección de dependencias para los presentadores
 *                      relacionados con la entidad Ministerio en la capa de presentación.
 *                      Registra presentadores para respuestas paginadas, listados y por ID.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Registro de presentadores para Ministerio.
 ***********/

using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Mappers;
using Empresa.Presentation.Ministerio.Presenters;
using Empresa.Presentation.Ministerio.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Ministerio
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMinisterioPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<MinisterioResult>, LstItemResponse<MinisterioResponse>>, ListMinisterioPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<MinisterioResult>, LstItemResponse<MinisterioResponse>>, ListMinisterioResponsePresenter>();
            services.AddScoped<IPresenterDelivery<MinisterioResult, ItemResponse<MinisterioResponse>>, ObtenerMinisterioResponsePorIdPresenter>();
            return services;
        }
    }
}
