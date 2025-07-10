/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Ubigeo,
 *                      registrando implementaciones concretas como el repositorio SQL Server.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Infrastructure.Ubigeo.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Ubigeo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUbigeoInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUbigeoRepository, UbigeoSqlRepository>();
            return services;
        }
    }
}
