/*****
 * Nombre del archivo:  ObtenerArchivoResponsePorIdPresenter.cs
 * Descripción:         Presentador que convierte un resultado de archivo (`ArchivoResult`) en una respuesta estructurada de tipo `ItemResponse<ArchivoResponse>`. 
 *                      Esta respuesta contiene los detalles de un archivo específico, aunque el mapeo a `ArchivoResponse` está comentado en el código.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Mappers
{
    public class ObtenerArchivoResponsePorIdPresenter : IPresenterDelivery<ArchivoResult, ItemResponse<ArchivoResponse>>
    {
        public ItemResponse<ArchivoResponse> Present(ArchivoResult input)
        {
            return new ItemResponse<ArchivoResponse>
            {
                IsSuccess = true,
                //Item = ArchivoResponseMapper.ToResponse(input),
            };
        }
    }
}
