/***********
 * Nombre del archivo:  IPresenterDelivery.cs
 * Descripción:         Interfaz genérica que define un contrato para transformar una entrada (`TInput`)
 *                      en una salida (`TOutput`), usada comúnmente en la capa de presentación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Kernel.Interfaces
{
    public interface IPresenterDelivery<TInput, TOutput>
    {
        TOutput Present(TInput input);
    }
}
