/***********
* Nombre del archivo: RefreshTokenRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar un **`RefreshTokenCreateRequest`** (DTO de aplicación)
*                     a una entidad de dominio **`RefreshToken`**. Este mapeador se encarga de asignar
*                     el ID de usuario y el token desde la solicitud, y de establecer automáticamente
*                     la fecha de creación (usando un **proveedor de tiempo** para la hora de Perú),
*                     la fecha de expiración (7 días después de la creación), y el estado de revocación.
*                     También inicializa la dirección IP de registro como nula.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora para solicitudes de creación de Refresh Tokens.
***********/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.Auth.Dtos;
using Usuario.Domain.Auth.Models;

namespace Usuario.Application.Auth.Mappers
{
    public class RefreshTokenRequestMapper : IMapper<RefreshTokenCreateRequest, RefreshToken>
    {
        private readonly ITimeProvider _timeProvider;

        public RefreshTokenRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public RefreshToken Map(RefreshTokenCreateRequest source)
        {
            return new RefreshToken
            {
                UsuarioId = source.UsuarioId,
                Token = source.Token,
                Creacion = _timeProvider.NowPeru,
                Expiracion = _timeProvider.NowPeru.AddDays(7),
                Revocado = false,
                IpRegistro = null
            };
        }
    }
}
