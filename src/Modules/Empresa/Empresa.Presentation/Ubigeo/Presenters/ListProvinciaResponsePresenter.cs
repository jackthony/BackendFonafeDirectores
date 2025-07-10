/***********
 * Nombre del archivo:  ListProvinciaResponsePresenter.cs
 * Descripción:         Presenter que transforma una lista de ProvinciaResult
 *                      a una respuesta estructurada LstItemResponse con elementos ProvinciaResponse.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para provincias.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListProvinciaResponsePresenter : IPresenterDelivery<List<ProvinciaResult>, LstItemResponse<ProvinciaResponse>>
    {
        public LstItemResponse<ProvinciaResponse> Present(List<ProvinciaResult> input)
        {
            return new LstItemResponse<ProvinciaResponse>
            {
                LstItem = ProvinciaResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
