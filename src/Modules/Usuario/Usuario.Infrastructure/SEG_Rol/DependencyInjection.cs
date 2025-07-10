/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que gestiona la inyección de dependencias para 
 *                      la infraestructura del módulo de roles. Registra las implementaciones 
 *                      concretas del repositorio de roles.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Registro del repositorio RolSqlRepository como implementación de IRolRepository.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Usuario.Domain.Rol.Repositories;
using Usuario.Infrastructure.Rol.Persistence.Repositories.SqlServer;

namespace Usuario.Infrastructure.Rol
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRolInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IRolRepository, RolSqlRepository>();
            return services;
        }
    }
}
