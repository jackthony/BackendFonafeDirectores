/***********
 * Nombre del archivo:  ObtenerPermisoRolResponsePorIdPresenter.cs
 * Descripción:         Presentador encargado de mapear el resultado de un permiso por rol
 *                      en una respuesta detallada para su retorno al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para respuesta por ID.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.PermisoRol.Results;
using Usuario.Presentation.PermisoRol.Responses;

namespace Usuario.Presentation.PermisoRol.Mappers
{
    public class ObtenerPermisoRolResponsePorIdPresenter : IPresenterDelivery<PermisoRolResult, ItemResponse<PermisoRolResponse>>
    {
        public ItemResponse<PermisoRolResponse> Present(PermisoRolResult input)
        {
            return new ItemResponse<PermisoRolResponse>
            {
                IsSuccess = true,
                Item = PermisoRolResponseMapper.ToResponse(input),
            };
        }
    }
}
