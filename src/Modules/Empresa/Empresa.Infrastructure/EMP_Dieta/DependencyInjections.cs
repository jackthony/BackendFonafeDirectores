/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Dieta,
 *                      registrando el repositorio correspondiente implementado con SQL Server.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y registro del repositorio.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Dieta.Repositories;
using Empresa.Infrastructure.Dieta.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Dieta
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDietaInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDietaRepository, DietaSqlRepository>();
            return services;
        }
    }
}
