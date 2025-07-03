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
