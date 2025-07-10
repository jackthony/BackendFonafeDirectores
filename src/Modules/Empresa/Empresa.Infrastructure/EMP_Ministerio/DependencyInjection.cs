/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Ministerio,
 *                      registrando el repositorio de infraestructura basado en SQL Server.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y configuración del repositorio.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Infrastructure.Ministerio.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Ministerio
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMinisterioInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IMinisterioRepository, MinisterioSqlRepository>();
            return services;
        }
    }
}
