/***********
 * Nombre del archivo:  ObtenerDietaResponsePresenter.cs
 * Descripción:         Clase que implementa la interfaz IPresenterDelivery para transformar
 *                      un objeto DietaResult en un ItemResponse que contiene
 *                      un DietaResponse, facilitando la entrega de la respuesta
 *                      del módulo Dieta al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del presenter ObtenerDietaResponsePresenter.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Dieta.Results;
using Empresa.Presentation.Dieta.Responses;

namespace Empresa.Presentation.Dieta.Presenters
{
    public class ObtenerDietaResponsePresenter : IPresenterDelivery<DietaResult, ItemResponse<DietaResponse>>
    {
        public ItemResponse<DietaResponse> Present(DietaResult input)
        {
            return new ItemResponse<DietaResponse>
            {
                IsSuccess = true,
                Item = DietaResponseMapper.ToResponse(input)
            };
        }
    }
}
