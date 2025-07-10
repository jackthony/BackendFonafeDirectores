/***********
* Nombre del archivo: LoginRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar un **`LoginRequest`** (DTO de aplicación)
*                     a **`LoginParameters`** (parámetros de dominio). Este mapeador se encarga de extraer
*                     el correo electrónico de la solicitud de inicio de sesión y asignarlo a los parámetros
*                     que serán utilizados por la capa de dominio. La fecha de sesión está comentada,
*                     indicando que actualmente no se mapea directamente desde la solicitud.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora para solicitudes de login.
***********/

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
