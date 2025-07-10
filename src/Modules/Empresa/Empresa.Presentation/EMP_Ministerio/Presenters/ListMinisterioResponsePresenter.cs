/***********
 * Nombre del archivo:  ListMinisterioResponsePresenter.cs
 * Descripción:         Presentador encargado de transformar una lista de objetos de dominio 
 *                      (MinisterioResult) en una respuesta de presentación (LstItemResponse<MinisterioResponse>)
 *                      para su consumo en el cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para listar ministerios.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Mappers
{
    public class ListMinisterioResponsePresenter : IPresenterDelivery<List<MinisterioResult>, LstItemResponse<MinisterioResponse>>
    {
        public LstItemResponse<MinisterioResponse> Present(List<MinisterioResult> input)
        {
            return new LstItemResponse<MinisterioResponse>
            {
                LstItem = MinisterioResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
