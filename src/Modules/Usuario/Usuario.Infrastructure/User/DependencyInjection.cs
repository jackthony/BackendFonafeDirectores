/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que encapsula las inyecciones de dependencias para 
 *                      la infraestructura relacionada al módulo de usuarios. Registra los 
 *                      repositorios concretos necesarios para el acceso a datos.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Registro del repositorio UserSqlRepository como implementación de IUserRepository.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Usuario.Domain.User.Repositories;
using Usuario.Infrastructure.User.Persistence.Repositories.SqlServer;

namespace Usuario.Infrastructure.User
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUserInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserSqlRepository>();
            return services;
        }
    }
}
