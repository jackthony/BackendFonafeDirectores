/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo TipoDirector,
 *                      registrando el repositorio de SQL Server que implementa la interfaz correspondiente.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y configuración de la inyección de dependencias.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Infrastructure.TipoDirector.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.TipoDirector
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddTipoDirectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ITipoDirectorRepository, TipoDirectorSqlRepository>();
            return services;
        }
    }
}
