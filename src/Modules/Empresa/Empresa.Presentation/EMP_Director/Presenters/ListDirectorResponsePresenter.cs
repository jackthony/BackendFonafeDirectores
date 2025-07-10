/***********
 * Nombre del archivo:  ListDirectorResponsePresenter.cs
 * Descripción:         Clase que implementa la interfaz IPresenterDelivery para transformar
 *                      una lista de objetos DirectorResult en un LstItemResponse que contiene
 *                      una lista de DirectorResponse, facilitando la entrega de múltiples
 *                      respuestas del módulo Director al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presenter ListDirectorResponsePresenter.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Responses;

namespace Empresa.Presentation.Director.Mappers
{
    public class ListDirectorResponsePresenter : IPresenterDelivery<List<DirectorResult>, LstItemResponse<DirectorResponse>>
    {
        public LstItemResponse<DirectorResponse> Present(List<DirectorResult> input)
        {
            return new LstItemResponse<DirectorResponse>
            {
                LstItem = DirectorResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
