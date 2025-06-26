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
