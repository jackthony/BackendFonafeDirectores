/***********
 * Nombre del archivo:  ObtenerModuloResponsePorIdPresenter.cs
 * Descripción:         Presenter encargado de convertir un objeto ModuloResult en una respuesta
 *                      de tipo ItemResponse<ModuloResponse> para el consumo por parte del cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presentador para respuesta por ID de módulo.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Mappers
{
    public class ObtenerModuloResponsePorIdPresenter : IPresenterDelivery<ModuloResult, ItemResponse<ModuloResponse>>
    {
        public ItemResponse<ModuloResponse> Present(ModuloResult input)
        {
            return new ItemResponse<ModuloResponse>
            {
                IsSuccess = true,
                Item = ModuloResponseMapper.ToResponse(input),
            };
        }
    }
}
