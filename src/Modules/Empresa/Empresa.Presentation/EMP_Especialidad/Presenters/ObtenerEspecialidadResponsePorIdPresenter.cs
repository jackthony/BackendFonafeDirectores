/***********
 * Nombre del archivo:  ObtenerEspecialidadResponsePorIdPresenter.cs
 * Descripción:         Clase que implementa la interfaz IPresenterDelivery para transformar
 *                      un objeto EspecialidadResult en un ItemResponse que contiene
 *                      un EspecialidadResponse, facilitando la entrega de la respuesta
 *                      del módulo Especialidad al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presenter ObtenerEspecialidadResponsePorIdPresenter.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Mappers
{
    public class ObtenerEspecialidadResponsePorIdPresenter : IPresenterDelivery<EspecialidadResult, ItemResponse<EspecialidadResponse>>
    {
        public ItemResponse<EspecialidadResponse> Present(EspecialidadResult input)
        {
            return new ItemResponse<EspecialidadResponse>
            {
                IsSuccess = true,
                Item = EspecialidadResponseMapper.ToResponse(input),
            };
        }
    }
}
