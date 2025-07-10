/***********
 * Nombre del archivo:   ListUserResponsePresenter.cs
 * Descripción:          Implementación de un presentador que transforma una lista de 'UserResult' (resultados de dominio)
 *                       en un 'LstItemResponse<UserResponse>' (respuesta para el cliente). Se utiliza para formatear
 *                       una colección de información de usuarios antes de ser enviada.
 * Autor:                Daniel Alva
 * Fecha de creación:    09/07/2025
 * Última modificación:  09/07/2025 por Daniel Alva
 * Cambios recientes:    Creación inicial de la clase para presentar una lista de respuestas de usuario.
 **********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Mappers
{
    public class ListUserResponsePresenter : IPresenterDelivery<List<UserResult>, LstItemResponse<UserResponse>>
    {
        public LstItemResponse<UserResponse> Present(List<UserResult> input)
        {
            return new LstItemResponse<UserResponse>
            {
                LstItem = UserResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
