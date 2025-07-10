/***********
 * Nombre del archivo:  ObtenerRubroResponsePorIdPresenter.cs
 * Descripción:         Presentador que transforma un resultado de RubroResult a una respuesta 
 *                      tipo ItemResponse<RubroResponse>, utilizado para la presentación de un rubro por ID.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para obtener rubro por ID.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Responses;

namespace Empresa.Presentation.Rubro.Mappers
{
    public class ObtenerRubroResponsePorIdPresenter : IPresenterDelivery<RubroResult, ItemResponse<RubroResponse>>
    {
        public ItemResponse<RubroResponse> Present(RubroResult input)
        {
            return new ItemResponse<RubroResponse>
            {
                IsSuccess = true,
                Item = RubroResponseMapper.ToResponse(input),
            };
        }
    }
}
