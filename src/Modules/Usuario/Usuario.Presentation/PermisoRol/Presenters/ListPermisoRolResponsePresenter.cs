/***********
 * Nombre del archivo:  ListPermisoRolResponsePresenter.cs
 * Descripción:         Presentador responsable de transformar una lista de resultados de 
 *                      permisos por rol en una respuesta estandarizada para el cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para respuesta listada de permisos por rol.
 ***********/

using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.PermisoRol.Results;
using Usuario.Presentation.PermisoRol.Responses;

namespace Usuario.Presentation.PermisoRol.Mappers
{
    public class ListPermisoRolResponsePresenter : IPresenterDelivery<List<PermisoRolResult>, LstItemResponse<PermisoRolResponse>>
    {
        public LstItemResponse<PermisoRolResponse> Present(List<PermisoRolResult> input)
        {
            return new LstItemResponse<PermisoRolResponse>
            {
                LstItem = PermisoRolResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
