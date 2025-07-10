/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Configuración de inyección de dependencias para el módulo de permisos por rol.
 *                      Registra la implementación concreta del repositorio de permisos de rol.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Registro de PermisoRolSqlRepository como implementación de IPermisoRolRepository.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Usuario.Domain.PermisoRol.Repositories;
using Usuario.Infrastructure.PermisoRol.Persistence.Repositories.SqlServer;

namespace Usuario.Infrastructure.PermisoRol
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddPermisoRolInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IPermisoRolRepository, PermisoRolSqlRepository>();
            return services;
        }
    }
}
