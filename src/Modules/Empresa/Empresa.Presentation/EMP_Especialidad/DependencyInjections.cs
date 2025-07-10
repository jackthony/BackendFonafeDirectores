/***********
* Nombre del archivo: DependencyInjections.cs
* Descripción:        Clase de extensión para configurar la inyección de dependencias de los **presentadores**
*                     del módulo `EMP_Especialidad`. Registra implementaciones de `IPresenterDelivery`
*                     para manejar la transformación de los resultados de dominio (`EspecialidadResult`, `PagedResult<EspecialidadResult>`)
*                     en respuestas de presentación (`LstItemResponse<EspecialidadResponse>`, `ItemResponse<EspecialidadResponse>`).
*                     Esto permite desacoplar la lógica de presentación de los casos de uso.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para la configuración de inyección de dependencias
*                     de los presentadores del módulo `EMP_Especialidad`.
***********/

using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Mappers;
using Empresa.Presentation.Especialidad.Presenters;
using Empresa.Presentation.Especialidad.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Especialidad
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEspecialidadPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<EspecialidadResult>, LstItemResponse<EspecialidadResponse>>, ListEspecialidadPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<EspecialidadResult>, LstItemResponse<EspecialidadResponse>>, ListEspecialidadResponsePresenter>();
            services.AddScoped<IPresenterDelivery<EspecialidadResult, ItemResponse<EspecialidadResponse>>, ObtenerEspecialidadResponsePorIdPresenter>();
            return services;
        }
    }
}
