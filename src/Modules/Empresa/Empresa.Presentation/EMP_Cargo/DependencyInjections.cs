/***********
* Nombre del archivo: DependencyInjections.cs
* Descripción:        Clase de extensión que configura la inyección de dependencias para los **presentadores**
*                     del módulo `EMP_Cargo`. Se encarga de registrar las implementaciones de `IPresenterDelivery`
*                     para transformar los resultados del dominio (`CargoResult`, `PagedResult<CargoResult>`)
*                     en respuestas adecuadas para la capa de presentación (`LstItemResponse<CargoResponse>`, `ItemResponse<CargoResponse>`).
*                     Esto asegura una clara separación entre la lógica de negocio y la presentación de datos al cliente.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para la configuración de inyección de dependencias
* de los presentadores del módulo `EMP_Cargo`.
***********/

using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Mappers;
using Empresa.Presentation.Cargo.Presenters;
using Empresa.Presentation.Cargo.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Cargo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCargoPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<CargoResult>, LstItemResponse<CargoResponse>>, ListCargoPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<CargoResult>, LstItemResponse<CargoResponse>>, ListCargoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<CargoResult, ItemResponse<CargoResponse>>, ObtenerCargoResponsePorIdPresenter>();
            return services;
        }
    }
}
