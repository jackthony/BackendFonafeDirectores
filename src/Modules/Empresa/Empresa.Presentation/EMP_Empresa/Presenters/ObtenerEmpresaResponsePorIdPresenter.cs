/***********
 * Nombre del archivo:  ObtenerEmpresaResponsePorIdPresenter.cs
 * Descripción:         Clase que implementa la interfaz IPresenterDelivery para transformar
 *                      un objeto EmpresaResult en un ItemResponse que contiene
 *                      un EmpresaResponse, facilitando la entrega de la respuesta
 *                      del módulo Empresa al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presenter ObtenerEmpresaResponsePorIdPresenter.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Responses;

namespace Empresa.Presentation.Empresa.Mappers
{
    public class ObtenerEmpresaResponsePorIdPresenter : IPresenterDelivery<EmpresaResult, ItemResponse<EmpresaResponse>>
    {
        public ItemResponse<EmpresaResponse> Present(EmpresaResult input)
        {
            return new ItemResponse<EmpresaResponse>
            {
                IsSuccess = true,
                Item = EmpresaResponseMapper.ToResponse(input),
            };
        }
    }
}
