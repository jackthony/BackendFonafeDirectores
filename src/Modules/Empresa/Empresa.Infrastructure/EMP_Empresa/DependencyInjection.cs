/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura las inyecciones de dependencias del módulo Empresa,
 *                      registrando el repositorio que implementa el acceso a datos mediante SQL Server.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase y configuración de la inyección del repositorio.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Empresa.Repositories;
using Empresa.Infrastructure.Empresa.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Empresa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEmpresaInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IEmpresaRepository, EmpresaSqlRepository>();
            return services;
        }
    }
}
