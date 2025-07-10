/***********
 * Nombre del archivo:  SpResultMapper.cs
 * Descripción:         Clase genérica que implementa un mapeador para convertir un `SpResultBase`
 *                      en una respuesta estándar `ResponseBase<T>`, realizando la conversión de datos al tipo especificado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Shared.Kernel.Mappers
{
    public class SpResultMapper<T> : IMapper<SpResultBase, ResponseBase<T>>
    {
        public ResponseBase<T> Map(SpResultBase source)
        {
            return new ResponseBase<T>
            {
                Success = source.Success,
                Message = source.Message,
                Data = (T)Convert.ChangeType(source.Data, typeof(T))
            };
        }
    }
}
