/***********
 * Nombre del archivo:  ListEmpresaResponsePresenter.cs
 * Descripción:         Clase que implementa la interfaz IPresenterDelivery para transformar
 *                      una lista de objetos EmpresaResult en un LstItemResponse que contiene
 *                      una lista de EmpresaResponse, facilitando la entrega de múltiples
 *                      respuestas del módulo Empresa al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presenter ListEmpresaResponsePresenter.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Responses;

namespace Empresa.Presentation.Empresa.Mappers
{
    public class ListEmpresaResponsePresenter : IPresenterDelivery<List<EmpresaResult>, LstItemResponse<EmpresaResponse>>
    {
        public LstItemResponse<EmpresaResponse> Present(List<EmpresaResult> input)
        {
            return new LstItemResponse<EmpresaResponse>
            {
                LstItem = EmpresaResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
