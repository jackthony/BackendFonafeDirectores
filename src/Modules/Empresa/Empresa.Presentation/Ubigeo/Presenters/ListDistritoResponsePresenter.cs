/***********
 * Nombre del archivo:  ListDistritoResponsePresenter.cs
 * Descripción:         Presenter responsable de convertir una lista de DistritoResult
 *                      en una respuesta estructurada LstItemResponse<DistritoResponse>.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para distritos.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Mappers;
using Empresa.Presentation.Ubigeo.Responses;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Ubigeo.Presenters
{
    public class ListDistritoResponsePresenter : IPresenterDelivery<List<DistritoResult>, LstItemResponse<DistritoResponse>>
    {
        public LstItemResponse<DistritoResponse> Present(List<DistritoResult> input)
        {
            return new LstItemResponse<DistritoResponse>
            {
                LstItem = DistritoResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
