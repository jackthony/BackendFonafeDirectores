/***********
 * Nombre del archivo:  ListTipoDirectorResponsePresenter.cs
 * Descripción:         Presentador encargado de transformar una lista de objetos TipoDirectorResult
 *                      en una respuesta de tipo LstItemResponse<TipoDirectorResponse>, que representa
 *                      una colección de TipoDirector para entregar al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para listar TipoDirector.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Mappers
{
    public class ListTipoDirectorResponsePresenter : IPresenterDelivery<List<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>>
    {
        public LstItemResponse<TipoDirectorResponse> Present(List<TipoDirectorResult> input)
        {
            return new LstItemResponse<TipoDirectorResponse>
            {
                LstItem = TipoDirectorResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
