/***********
 * Nombre del archivo:  ListDepartamentoPaginadoResponsePresenter.cs
 * Descripción:         Presenter encargado de mapear una respuesta paginada de tipo 
 *                      PagedResult<DepartamentoResult> a un objeto de tipo 
 *                      LstItemResponse<DepartamentoResponse>, incluyendo información de paginación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador paginado para departamentos.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListDepartamentoPaginadoResponsePresenter : IPresenterDelivery<PagedResult<DepartamentoResult>, LstItemResponse<DepartamentoResponse>>
    {
        public LstItemResponse<DepartamentoResponse> Present(PagedResult<DepartamentoResult> input)
        {
            return new LstItemResponse<DepartamentoResponse>
            {
                LstItem = DepartamentoResponseMapper.ToListResponse(input.Items),
                Pagination = new Pagination
                {
                    PageIndex = input.Page,
                    PageSize = input.PageSize,
                    TotalRows = input.TotalItems
                },
                IsSuccess = true
            };
        }
    }
}
