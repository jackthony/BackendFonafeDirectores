/***********
* Nombre del archivo: ActualizarModuloRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`ActualizarModuloRequest`** (DTO de aplicación)
*                     a **`ActualizarModuloParameters`** (parámetros de dominio). Este mapeador es responsable
*                     de convertir los datos de la solicitud de actualización de un módulo para que sean
*                     utilizables por la capa de dominio. Actualmente, su implementación está pendiente.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;

namespace Usuario.Application.Modulo.Mappers
{
    public class ActualizarModuloRequestMapper : IMapper<ActualizarModuloRequest, ActualizarModuloParameters>
    {
        public ActualizarModuloParameters Map(ActualizarModuloRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
