/***********
 * Nombre del archivo:  ObtenerMinisterioResponsePorIdPresenter.cs
 * Descripción:         Presentador que transforma un resultado de dominio (MinisterioResult)
 *                      en una respuesta de presentación (MinisterioResponse) envuelta en un
 *                      ItemResponse para ser enviada al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para obtener ministerio por ID.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Mappers
{
    public class ObtenerMinisterioResponsePorIdPresenter : IPresenterDelivery<MinisterioResult, ItemResponse<MinisterioResponse>>
    {
        public ItemResponse<MinisterioResponse> Present(MinisterioResult input)
        {
            return new ItemResponse<MinisterioResponse>
            {
                IsSuccess = true,
                Item = MinisterioResponseMapper.ToResponse(input),
            };
        }
    }
}
