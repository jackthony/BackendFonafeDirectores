using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
<<<<<<< HEAD
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;
=======
using System.Text.Json;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Models;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.Rol.Results;
using Usuario.Domain.SEG_Modulo.Models;
>>>>>>> origin/masterboa

namespace Usuario.Application.Auth.UseCases
{
    public class LoginUseCase : IUseCase<LoginRequest, LoginResponse>
    {
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenService _tokenService;
        private readonly IMapper<LoginRequest, LoginParameters> _mapper;
<<<<<<< HEAD
        public LoginUseCase(
            IAuthRepository authRepository,
            IPasswordHasher passwordHasher,
            ITokenService tokenService,
            IMapper<LoginRequest, LoginParameters> mapper)
=======
        private readonly IMapper<RefreshTokenCreateRequest, RefreshToken> _mapperRefreshToken;

        public LoginUseCase(IAuthRepository authRepository, IPasswordHasher passwordHasher, ITokenService tokenService, IMapper<LoginRequest, LoginParameters> mapper, IMapper<RefreshTokenCreateRequest, RefreshToken> mapperRefreshToken)
>>>>>>> origin/masterboa
        {
            _authRepository = authRepository;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
            _mapper = mapper;
<<<<<<< HEAD
=======
            _mapperRefreshToken = mapperRefreshToken;
>>>>>>> origin/masterboa
        }

        public async Task<OneOf<ErrorBase, LoginResponse>> ExecuteAsync(LoginRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _authRepository.ObtenerPorCorreoAsync(parameters);

            if (!result.Success || result.Data is null)
                return ErrorBase.Database(result.Message);

            var usuario = result.Data;

<<<<<<< HEAD
            var isPasswordValid = _passwordHasher.Verify(request.Password, usuario.PasswordHash);
            if (!isPasswordValid)
                return ErrorBase.Validation("Contraseña incorrecta");

            if (usuario.Status != "1")
                return ErrorBase.Validation("El usuario no se encuentra activo");

            var token = _tokenService.GenerateAccessToken(usuario.UsuarioId, usuario.CorreoElectronico, []);

            return new LoginResponse
            {
                AccessToken = token,
                UsuarioResult = usuario
            };
        }
=======
            if (usuario.IntentosFallidos >= 3)
                return ErrorBase.Validation("Su cuenta se inhabilitó, contactar con el administrador");

            var isPasswordValid = _passwordHasher.Verify(request.Password, usuario.PasswordHash);
            if (!isPasswordValid)
            {
                await _authRepository.IncrementarIntentosFallidosAsync(usuario.UsuarioId);
                return ErrorBase.Validation("Contraseña incorrecta");
            }

            var modulosPermisos = JsonSerializer.Deserialize<List<ModuloPermiso>>(usuario.JsonModulos) ?? [];

            List<RolResult> roles = JsonSerializer.Deserialize<List<RolResult>>(usuario.JsonRoles) ?? [];

            List<string> nombresRoles = roles.Select(r => r.NombreRol).ToList();

            var token = _tokenService.GenerateAccessToken(usuario.UsuarioId, usuario.CorreoElectronico, nombresRoles);
            //token de refresco que se almacenará en bd
            var refreshToken = _tokenService.GenerateRefreshToken();
            var refreshTokenRequest = new RefreshTokenCreateRequest { Token = refreshToken , UsuarioId = usuario.UsuarioId };
            var refreshMapper = _mapperRefreshToken.Map(refreshTokenRequest);

            await _authRepository.GuardarRefreshToken(refreshMapper);

            usuario.PasswordHash = "";
            return new LoginResponse
            {
                AccessToken = token,
                Modulos = modulosPermisos,
                UsuarioResult = usuario,
                RefreshToken = refreshToken
            };
        }

>>>>>>> origin/masterboa
    }
}
