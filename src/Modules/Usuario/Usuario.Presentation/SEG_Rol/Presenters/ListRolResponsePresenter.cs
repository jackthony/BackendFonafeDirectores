/***********
 * Nombre del archivo:  ListRolResponsePresenter.cs
 * Descripción:         Presentador encargado de transformar una lista de resultados de dominio (RolResult)
 *                      en una respuesta de presentación (LstItemResponse<RolResponse>).
 *                      Se utiliza para retornar la lista completa de roles.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para el listado de roles.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.Rol.Mappers
{
    public class ListRolResponsePresenter : IPresenterDelivery<List<RolResult>, LstItemResponse<RolResponse>>
    {
        public LstItemResponse<RolResponse> Present(List<RolResult> input)
        {
            return new LstItemResponse<RolResponse>
            {
                LstItem = RolResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
