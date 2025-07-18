﻿/***********
* Nombre del archivo: ActualizarUserRequestMapper.cs
* Descripción:        Implementación del mapeador para transformar una 'ActualizarUserRequest' (DTO de aplicación)
*                     a 'ActualizarUserParameters' (parámetros de dominio). Este mapper se encarga
*                     de convertir los datos de la solicitud de actualización de usuario para que sean
*                     utilizables por la capa de dominio, incluyendo la asignación de la fecha de modificación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapper para solicitudes de actualización de usuario.
***********/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class ActualizarUserRequestMapper : IMapper<ActualizarUserRequest, ActualizarUserParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarUserRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public ActualizarUserParameters Map(ActualizarUserRequest source)
        {
            return new ActualizarUserParameters
            {
                UsuarioId = source.nIdUsuario,
                UsuarioModificacionId = source.nUsuarioModificacion,
                RolId = source.nIdRol,
                Estado = source.nEstado,
                CargoId = source.nIdCargo,
                nTipoPersonal = source.nTipoPersonal,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
