/***********
* Nombre del archivo: CrearModuloRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`CrearModuloRequest`** (DTO de aplicación)
*                     a **`CrearModuloParameters`** (parámetros de dominio). Este mapeador es responsable
*                     de convertir los datos de la solicitud de creación de módulo para que sean
*                     utilizables por la capa de dominio. Actualmente, su implementación está pendiente.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora.
***********/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;

namespace Usuario.Application.Modulo.Mappers
{
    public class CrearModuloRequestMapper : IMapper<CrearModuloRequest, CrearModuloParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearModuloRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearModuloParameters Map(CrearModuloRequest source)
        {
            return new CrearModuloParameters
            {
            };
        }
    }
}
