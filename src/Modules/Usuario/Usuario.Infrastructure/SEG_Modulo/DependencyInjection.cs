/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática encargada de registrar las dependencias del módulo Modulo,
 *                      incluyendo la implementación concreta del repositorio IModuloRepository.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Registro del repositorio ModuloSqlRepository como implementación de IModuloRepository.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Infrastructure.Modulo.Persistence.Repositories.SqlServer;

namespace Usuario.Infrastructure.Modulo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddModuloInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IModuloRepository, ModuloSqlRepository>();
            return services;
        }
    }
}
