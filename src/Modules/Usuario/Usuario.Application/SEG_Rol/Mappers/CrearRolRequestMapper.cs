/***********
* Nombre del archivo: CrearRolRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'CrearRolRequest' (DTO de aplicación)
*                     a 'CrearRolParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de creación de rol para que sean
*                     utilizables por la capa de dominio, incluyendo la asignación de la fecha de registro.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper para solicitudes de creación de rol.
***********/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class CrearRolRequestMapper : IMapper<CrearRolRequest, CrearRolParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearRolRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearRolParameters Map(CrearRolRequest source)
        {
            return new CrearRolParameters
            {
                NombreRol = source.sNombreRol,
                UsuarioRegistroId = source.nIdUsuarioCreacion,
                FechaRegistro = _timeProvider.NowPeru,
            };
        }
    }
}
