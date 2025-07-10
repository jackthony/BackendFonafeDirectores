/***********
 * Nombre del archivo:  ListRubroResponsePresenter.cs
 * Descripción:         Presentador que transforma una lista de resultados RubroResult a una respuesta 
 *                      tipo LstItemResponse<RubroResponse>, utilizada para mostrar múltiples rubros.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para listar rubros.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Responses;

namespace Empresa.Presentation.Rubro.Mappers
{
    public class ListRubroResponsePresenter : IPresenterDelivery<List<RubroResult>, LstItemResponse<RubroResponse>>
    {
        public LstItemResponse<RubroResponse> Present(List<RubroResult> input)
        {
            return new LstItemResponse<RubroResponse>
            {
                LstItem = RubroResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
