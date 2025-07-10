/***********
 * Nombre del archivo:  ListModuloResponsePresenter.cs
 * Descripción:         Presenter encargado de transformar una lista de objetos ModuloResult
 *                      en una respuesta LstItemResponse<ModuloResponse> para el cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para el listado de módulos.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Mappers
{
    public class ListModuloResponsePresenter : IPresenterDelivery<List<ModuloResult>, LstItemResponse<ModuloResponse>>
    {
        public LstItemResponse<ModuloResponse> Present(List<ModuloResult> input)
        {
            return new LstItemResponse<ModuloResponse>
            {
                LstItem = ModuloResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
