/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Rubro,
 *                      registrando el repositorio de infraestructura que utiliza SQL Server.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y registro del repositorio.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Infrastructure.Rubro.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Rubro
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRubroInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IRubroRepository, RubroSqlRepository>();
            return services;
        }
    }
}
