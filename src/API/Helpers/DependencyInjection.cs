/***********
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Clase auxiliar para registrar dependencias en el contenedor de servicios.
 *                      En este caso, se registra una implementación concreta de `ITrackableRequest`
 *                      usada para auditoría o trazabilidad en la aplicación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del método `AddTrackableApplication`.
 ***********/

using Empresa.Application.Sector.Dtos;
using Shared.Kernel.Interfaces;

namespace Api.Helpers
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddTrackableApplication(this IServiceCollection services)
        {
            services.AddScoped<ITrackableRequest, ActualizarSectorRequest>();

            return services;
        }
    }
}
