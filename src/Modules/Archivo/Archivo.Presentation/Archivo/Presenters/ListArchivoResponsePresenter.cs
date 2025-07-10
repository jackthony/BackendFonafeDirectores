/*****
 * Nombre del archivo:  ListArchivoResponsePresenter.cs
 * Descripción:         Presentador que convierte una lista de resultados de archivos (`List<ArchivoResult>`) en una respuesta estructurada de tipo `TreeResponse<ArchivoNode>`. 
 *                      Utiliza el mapeador `ArchivoResponseMapper` para organizar los archivos en una estructura jerárquica (árbol).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Mappers;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Presenters
{
    public class ListArchivoResponsePresenter : IPresenterDelivery<List<ArchivoResult>, TreeResponse<ArchivoNode>>
    {
        public TreeResponse<ArchivoNode> Present(List<ArchivoResult> input)
        {
            return new TreeResponse<ArchivoNode>
            {
                LstItem = ArchivoResponseMapper.ToTree(input),
                IsSuccess = true
            };
        }
    }
}
