/***********
 * Nombre del archivo:   ObtenerUserResponsePorIdPresenter.cs
 * Descripción:          Implementación de un presentador que transforma un 'UserResult' (resultado de dominio)
 *                       en un 'ItemResponse<UserResponse>' (respuesta para el cliente). Se utiliza para formatear
 *                       la información de un usuario específico obtenido por ID antes de ser enviado.
 * Autor:                Daniel Alva
 * Fecha de creación:    09/07/2025
 * Última modificación:  09/07/2025 por Daniel Alva
 * Cambios recientes:    Creación inicial de la clase para presentar la respuesta de un usuario por ID.
 **********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Mappers
{
    public class ObtenerUserResponsePorIdPresenter : IPresenterDelivery<UserResult, ItemResponse<UserResponse>>
    {
        public ItemResponse<UserResponse> Present(UserResult input)
        {
            return new ItemResponse<UserResponse>
            {
                IsSuccess = true,
                Item = UserResponseMapper.ToResponse(input),
            };
        }
    }
}
