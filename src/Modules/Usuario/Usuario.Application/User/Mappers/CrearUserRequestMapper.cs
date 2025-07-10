/***********
* Nombre del archivo: CrearUserRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'CrearUserRequest' (DTO de aplicación)
*                     a 'CrearUserParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de creación de usuario para que sean
*                     utilizables por la capa de dominio, incluyendo la asignación de la fecha de registro.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper para solicitudes de creación de usuario.
***********/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class CrearUserRequestMapper : IMapper<CrearUserRequest, CrearUserParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearUserRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearUserParameters Map(CrearUserRequest source)
        {
            return new CrearUserParameters
            {
                PasswordHash = source.sContrasena,
                CorreoElectronico = source.sCorreoElectronico,
                FechaRegistro = _timeProvider.NowPeru,
                UsuarioRegistroId = source.nUsuarioRegistro,
                CargoId = source.nIdCargo,
                RolId = source.nIdRol,
                Estado = source.nEstado,
                nTipoPersonal = source.nTipoPersonal,
                ApellidoPaterno = source.sApellidoPaterno,
                ApellidoMaterno = source.sApellidoMaterno,
                Nombres = source.sNombres
            };
        }
    }
}
