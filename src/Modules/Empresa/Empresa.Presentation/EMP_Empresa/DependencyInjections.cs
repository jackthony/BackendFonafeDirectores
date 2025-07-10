/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática para configurar la inyección de dependencias
 *                      de los presenters del módulo Empresa, registrando los servicios
 *                      necesarios para la presentación de datos paginados, listas y por ID.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de la configuración de inyección de dependencias para el módulo Empresa.
 ***********/

using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Mappers;
using Empresa.Presentation.Empresa.Presenters;
using Empresa.Presentation.Empresa.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Empresa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEmpresaPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<PagedResult<EmpresaResult>, LstItemResponse<EmpresaResponse>>, ListEmpresaPaginadoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<EmpresaResult>, LstItemResponse<EmpresaResponse>>, ListEmpresaResponsePresenter>();
            services.AddScoped<IPresenterDelivery<EmpresaResult, ItemResponse<EmpresaResponse>>, ObtenerEmpresaResponsePorIdPresenter>();
            return services;
        }
    }
}
