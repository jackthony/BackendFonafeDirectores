/***********
 * Nombre del archivo:  ObtenerTipoDirectorResponsePorIdPresenter.cs
 * Descripción:         Presentador encargado de transformar un objeto de tipo TipoDirectorResult
 *                      en una respuesta de tipo ItemResponse<TipoDirectorResponse> para su entrega
 *                      al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para obtener TipoDirector por ID.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Mappers
{
    public class ObtenerTipoDirectorResponsePorIdPresenter : IPresenterDelivery<TipoDirectorResult, ItemResponse<TipoDirectorResponse>>
    {
        public ItemResponse<TipoDirectorResponse> Present(TipoDirectorResult input)
        {
            return new ItemResponse<TipoDirectorResponse>
            {
                IsSuccess = true,
                Item = TipoDirectorResponseMapper.ToResponse(input),
            };
        }
    }
}
