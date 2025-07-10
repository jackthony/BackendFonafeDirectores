/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Sector,
 *                      registrando el repositorio que implementa la interfaz utilizando SQL Server.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y configuración de la inyección de dependencias.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Sector.Repositories;
using Empresa.Infrastructure.Sector.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Sector
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddSectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISectorRepository, SectorSqlRepository>();
            return services;
        }
    }
}
