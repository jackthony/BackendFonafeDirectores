/***********
 * Nombre del archivo:  ListDepartamentoResponsePresenter.cs
 * Descripción:         Presenter encargado de transformar una lista de DepartamentoResult
 *                      en un LstItemResponse<DepartamentoResponse> para la capa de presentación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para departamentos.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListDepartamentoResponsePresenter : IPresenterDelivery<List<DepartamentoResult>, LstItemResponse<DepartamentoResponse>>
    {
        public LstItemResponse<DepartamentoResponse> Present(List<DepartamentoResult> input)
        {
            return new LstItemResponse<DepartamentoResponse>
            {
                LstItem = DepartamentoResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
