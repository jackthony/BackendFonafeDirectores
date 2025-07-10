/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Director,
 *                      registrando el repositorio que implementa el acceso a datos mediante SQL Server.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y registro del repositorio.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Director.Repositories;
using Empresa.Infrastructure.Director.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Director
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDirectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDirectorRepository, DirectorSqlRepository>();
            return services;
        }
    }
}
