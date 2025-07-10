/*****
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura la inyección de dependencias para los presentadores en la capa de presentación de archivos. 
 *                      Registra los presentadores que entregan respuestas estructuradas para la visualización de archivos y elementos en forma de árboles o listas.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Presenters;
using Archivo.Presentation.Archivo.Responses;
using Microsoft.Extensions.DependencyInjection;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Archivo.Presentation.Archivo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddArchivoPresenters(this IServiceCollection services)
        {

            services.AddScoped<IPresenterDelivery<List<ArchivoResult>, TreeResponse<ArchivoNode>>, ListArchivoResponsePresenter>();
            services.AddScoped<IPresenterDelivery<List<ArchivoResult>, ListResponse<ElementoNodoResponse<ElementoDetalleResponse>>>, ListElementoResponsePresenter>();

            return services;
        }
    }
}
