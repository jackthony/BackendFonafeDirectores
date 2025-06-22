using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.Auth.Dtos;
using Usuario.Domain.Auth.Parameters;

namespace Usuario.Application.Auth.Mappers
{
    public class LoginRequestMapper : IMapper<LoginRequest, LoginParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public LoginRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public LoginParameters Map(LoginRequest source)
        {
            return new LoginParameters
            {
                Correo = source.Email,
                //FechaSesion = _timeProvider.NowPeru,
            };
        }
    }
}
