/***********
 * Nombre del archivo:  ObtenerSectorResponsePorIdPresenter.cs
 * Descripción:         Presentador encargado de transformar un resultado de sector en una respuesta
 *                      de tipo `ItemResponse<SectorResponse>`, utilizada para exponer un único sector por ID.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para obtener sector por ID.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Mappers
{
    public class ObtenerSectorResponsePorIdPresenter : IPresenterDelivery<SectorResult, ItemResponse<SectorResponse>>
    {
        public ItemResponse<SectorResponse> Present(SectorResult input)
        {
            return new ItemResponse<SectorResponse>
            {
                IsSuccess = true,
                Item = SectorResponseMapper.ToResponse(input),
            };
        }
    }
}
