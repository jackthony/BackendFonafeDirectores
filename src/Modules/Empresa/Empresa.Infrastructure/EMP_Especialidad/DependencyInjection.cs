/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Especialidad,
 *                      registrando el repositorio correspondiente que utiliza SQL Server como proveedor de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y configuración de la inyección de dependencias.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Infrastructure.Especialidad.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Especialidad
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEspecialidadInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IEspecialidadRepository, EspecialidadSqlRepository>();
            return services;
        }
    }
}
