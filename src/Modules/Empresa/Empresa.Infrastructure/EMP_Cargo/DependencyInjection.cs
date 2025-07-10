/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Cargo,
 *                      registrando el repositorio correspondiente implementado con SQL Server.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y configuración del repositorio.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Infrastructure.Cargo.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Cargo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCargoInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ICargoRepository, CargoSqlRepository>();
            return services;
        }
    }
}
