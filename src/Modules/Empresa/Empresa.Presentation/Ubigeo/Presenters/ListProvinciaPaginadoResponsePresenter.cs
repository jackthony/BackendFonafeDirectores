/***********
 * Nombre del archivo:  ListProvinciaPaginadoResponsePresenter.cs
 * Descripción:         Presenter encargado de mapear una respuesta paginada de provincias
 *                      (ProvinciaResult) a un objeto LstItemResponse<ProvinciaResponse>,
 *                      incluyendo metadatos de paginación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador paginado para provincias.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListProvinciaPaginadoResponsePresenter : IPresenterDelivery<PagedResult<ProvinciaResult>, LstItemResponse<ProvinciaResponse>>
    {
        public LstItemResponse<ProvinciaResponse> Present(PagedResult<ProvinciaResult> input)
        {
            return new LstItemResponse<ProvinciaResponse>
            {
                LstItem = ProvinciaResponseMapper.ToListResponse(input.Items),
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
