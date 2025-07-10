/***********
 * Nombre del archivo:  ObtenerRolResponsePorIdPresenter.cs
 * Descripción:         Presentador encargado de transformar un resultado de dominio (RolResult)
 *                      en una respuesta de presentación (ItemResponse<RolResponse>).
 *                      Se utiliza para devolver un solo rol obtenido por ID.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para el endpoint ObtenerRolPorId.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.Rol.Mappers
{
    public class ObtenerRolResponsePorIdPresenter : IPresenterDelivery<RolResult, ItemResponse<RolResponse>>
    {
        public ItemResponse<RolResponse> Present(RolResult input)
        {
            return new ItemResponse<RolResponse>
            {
                IsSuccess = true,
                Item = RolResponseMapper.ToResponse(input),
            };
        }
    }
}
