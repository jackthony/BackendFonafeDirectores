/***********
 * Nombre del archivo:  ModuloConAccionesResponsePresenter.cs
 * Descripción:         Presenter encargado de transformar una lista de objetos ModuloConAccionesResult
 *                      en una respuesta LstItemResponse<ModuloConAccionesResponse> adecuada para el cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para módulos con acciones permitidas.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Mappers;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Presenters
{
    public class ModuloConAccionesResponsePresenter : IPresenterDelivery<List<ModuloConAccionesResult>, LstItemResponse<ModuloConAccionesResponse>>
    {
        public LstItemResponse<ModuloConAccionesResponse> Present(List<ModuloConAccionesResult> input)
        {
            return new LstItemResponse<ModuloConAccionesResponse>
            {
                LstItem = ModuloConAccionesResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
