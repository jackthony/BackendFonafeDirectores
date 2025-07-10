/***********
 * Nombre del archivo:  ListEspecialidadResponsePresenter.cs
 * Descripción:         Clase que implementa la interfaz IPresenterDelivery para transformar
 *                      una lista de objetos EspecialidadResult en un LstItemResponse que contiene
 *                      una lista de EspecialidadResponse, facilitando la entrega de múltiples
 *                      respuestas del módulo Especialidad al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presenter ListEspecialidadResponsePresenter.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Mappers
{
    public class ListEspecialidadResponsePresenter : IPresenterDelivery<List<EspecialidadResult>, LstItemResponse<EspecialidadResponse>>
    {
        public LstItemResponse<EspecialidadResponse> Present(List<EspecialidadResult> input)
        {
            return new LstItemResponse<EspecialidadResponse>
            {
                LstItem = EspecialidadResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
