/***********
* Nombre del archivo: EliminarModuloRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`EliminarModuloRequest`** (DTO de aplicación)
*                     a **`EliminarModuloParameters`** (parámetros de dominio). Este mapeador es responsable
*                     de convertir los datos de la solicitud de eliminación de un módulo para que sean
*                     utilizables por la capa de dominio. Actualmente, su implementación está pendiente.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;

namespace Usuario.Application.Modulo.Mappers
{
    public class EliminarModuloRequestMapper : IMapper<EliminarModuloRequest, EliminarModuloParameters>
    {
        public EliminarModuloParameters Map(EliminarModuloRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
