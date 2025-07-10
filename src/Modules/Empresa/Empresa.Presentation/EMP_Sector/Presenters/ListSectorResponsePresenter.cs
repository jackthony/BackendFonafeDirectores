/***********
 * Nombre del archivo:  ListSectorResponsePresenter.cs
 * Descripción:         Presentador encargado de transformar una lista de resultados de sectores 
 *                      en una respuesta de tipo `LstItemResponse<SectorResponse>`, utilizada para
 *                      exponer múltiples sectores sin paginación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para listar sectores.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Mappers
{
    public class ListSectorResponsePresenter : IPresenterDelivery<List<SectorResult>, LstItemResponse<SectorResponse>>
    {
        public LstItemResponse<SectorResponse> Present(List<SectorResult> input)
        {
            return new LstItemResponse<SectorResponse>
            {
                LstItem = SectorResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
