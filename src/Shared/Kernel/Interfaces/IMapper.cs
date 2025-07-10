/***********
 * Nombre del archivo:  IMapper.cs
 * Descripción:         Interfaz genérica para definir un contrato de mapeo entre un objeto de origen (`TSource`)
 *                      y un objeto de destino (`TDestination`), utilizado para transformar datos entre capas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Kernel.Interfaces
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination Map(TSource source);
    }
}
