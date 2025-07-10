/***********
 * Nombre del archivo:  ObtenerDirectorResponsePorIdPresenter.cs
 * Descripción:         Clase que implementa la interfaz IPresenterDelivery para transformar
 *                      un objeto DirectorResult en un ItemResponse que contiene
 *                      un DirectorResponse, facilitando la entrega de la respuesta
 *                      del módulo Director al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presenter ObtenerDirectorResponsePorIdPresenter.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Responses;

namespace Empresa.Presentation.Director.Mappers
{
    public class ObtenerDirectorResponsePorIdPresenter : IPresenterDelivery<DirectorResult, ItemResponse<DirectorResponse>>
    {
        public ItemResponse<DirectorResponse> Present(DirectorResult input)
        {
            return new ItemResponse<DirectorResponse>
            {
                IsSuccess = true,
                Item = DirectorResponseMapper.ToResponse(input),
            };
        }
    }
}
