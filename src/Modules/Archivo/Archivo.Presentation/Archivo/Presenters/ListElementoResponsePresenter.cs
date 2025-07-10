/*****
 * Nombre del archivo:  ListElementoResponsePresenter.cs
 * Descripción:         Presentador que convierte una lista de resultados de archivos (`List<ArchivoResult>`) en una respuesta estructurada de tipo `ListResponse<ElementoNodoResponse<ElementoDetalleResponse>>`. 
 *                      Utiliza el mapeador `ElementoResponseMapper` para organizar los archivos en una estructura jerárquica (árbol) y generar una lista de nodos con detalles de cada archivo.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Mappers;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Presenters
{
    public class ListElementoResponsePresenter : IPresenterDelivery<List<ArchivoResult>, ListResponse<ElementoNodoResponse<ElementoDetalleResponse>>>
    {
        public ListResponse<ElementoNodoResponse<ElementoDetalleResponse>> Present(List<ArchivoResult> input)
        {
            return new ListResponse<ElementoNodoResponse<ElementoDetalleResponse>>
            {
                LstItem = ElementoResponseMapper.ToTree(input),
                IsSuccess = true
            };
        }
    }
}
