/***********
 * Nombre del archivo:  IUseCase.cs
 * Descripción:         Interfaz genérica para casos de uso. Define un contrato para ejecutar operaciones
 *                      asincrónicas que retornan una respuesta o un error, utilizando la librería OneOf.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

using OneOf;
using Shared.Kernel.Errors;

namespace Shared.Kernel.Interfaces
{
    public interface IUseCase<TRequest, TResponse>
    {
        public Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request);
    }
}
