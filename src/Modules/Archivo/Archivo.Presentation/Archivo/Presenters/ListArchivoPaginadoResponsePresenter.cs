/*****
 * Nombre del archivo:  ListArchivoPaginadoResponsePresenter.cs
 * Descripción:         Presentador que convierte los resultados paginados de archivos (`PagedResult<ArchivoResult>`) en una respuesta estructurada de tipo `LstItemResponse<ArchivoResponse>`. 
 *                      Incluye información de paginación como el índice de la página, el tamaño de la página y el número total de filas.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Mappers;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Presenters
{
    public class ListArchivoPaginadoResponsePresenter : IPresenterDelivery<PagedResult<ArchivoResult>, LstItemResponse<ArchivoResponse>>
    {
        public LstItemResponse<ArchivoResponse> Present(PagedResult<ArchivoResult> input)
        {
            return new LstItemResponse<ArchivoResponse>
            {
                //LstItem = ArchivoResponseMapper.ToListResponse(input.Items),
                Pagination = new Pagination
                {
                    PageIndex = input.Page,
                    PageSize = input.PageSize,
                    TotalRows = input.TotalItems
                },
                IsSuccess = true
            };
        }
    }
}
