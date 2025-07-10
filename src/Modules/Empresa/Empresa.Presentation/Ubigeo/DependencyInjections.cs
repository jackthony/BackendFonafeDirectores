/***********
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que registra los presentadores de Ubigeo en el contenedor de dependencias.
 *                      Asocia cada tipo de resultado (Departamento, Provincia, Distrito) con su respectivo presentador.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Registro de presentadores de Ubigeo para departamentos, provincias y distritos.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Presenters;
using Empresa.Presentation.Ubigeo.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Ubigeo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUbigeoPresenters(this IServiceCollection services)
        {
            services.AddScoped<IPresenterDelivery<List<DepartamentoResult>, LstItemResponse<DepartamentoResponse>>, ListDepartamentoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<ProvinciaResult>, LstItemResponse<ProvinciaResponse>>, ListProvinciaResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<DistritoResult>, LstItemResponse<DistritoResponse>>, ListDistritoResponsePresenter>();
            return services;
        }
    }
}
