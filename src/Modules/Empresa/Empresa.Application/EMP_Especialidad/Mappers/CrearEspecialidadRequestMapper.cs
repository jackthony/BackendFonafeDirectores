/*****
 * Nombre de clase:     CrearEspecialidadRequestMapper
 * Descripción:         Mapeador que convierte un DTO CrearEspecialidadRequest
 *                      en los parámetros necesarios para crear una nueva especialidad,
 *                      asignando el nombre, usuario que registra y la fecha actual en zona Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada para manejar el mapeo en la creación de especialidades.
 *****/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;

namespace Empresa.Application.Especialidad.Mappers
{
    public class CrearEspecialidadRequestMapper : IMapper<CrearEspecialidadRequest, CrearEspecialidadParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearEspecialidadRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearEspecialidadParameters Map(CrearEspecialidadRequest source)
        {
            return new CrearEspecialidadParameters
            {
                NombreEspecialidad = source.sNombreEspecialidad,
                UsuarioRegistroId = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
