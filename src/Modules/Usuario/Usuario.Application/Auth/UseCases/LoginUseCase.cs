using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using System.Text.Json;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.SEG_Modulo.Models;

namespace Usuario.Application.Auth.UseCases
{
    public class LoginUseCase : IUseCase<LoginRequest, LoginResponse>
    {
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenService _tokenService;
        private readonly IMapper<LoginRequest, LoginParameters> _mapper;
        public LoginUseCase(
            IAuthRepository authRepository,
            IPasswordHasher passwordHasher,
            ITokenService tokenService,
            IMapper<LoginRequest, LoginParameters> mapper)
        {
            _authRepository = authRepository;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, LoginResponse>> ExecuteAsync(LoginRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _authRepository.ObtenerPorCorreoAsync(parameters);

            if (!result.Success || result.Data is null)
                return ErrorBase.Database(result.Message);

            var usuario = result.Data;

            if (usuario.IntentosFallidos >= 3)
                return ErrorBase.Validation("Cuenta bloqueada por intentos fallidos. Contacte con el administrador.");

            var isPasswordValid = _passwordHasher.Verify(request.Password, usuario.PasswordHash);
            if (!isPasswordValid)
            {
                await _authRepository.IncrementarIntentosFallidosAsync(usuario.UsuarioId);
                return ErrorBase.Validation("Contraseña incorrecta");
            }

            if (usuario.Status != "1")
                return ErrorBase.Validation("El usuario no se encuentra activo");

            await _authRepository.ResetearIntentosFallidosAsync(usuario.UsuarioId);

            var token = _tokenService.GenerateAccessToken(usuario.UsuarioId, usuario.CorreoElectronico, []);

            var modulosPermisos = JsonSerializer.Deserialize<List<ModuloPermiso>>(usuario.JsonModulos) ?? [];

            return new LoginResponse
            {
                AccessToken = token,
                Modulos = modulosPermisos,
                UsuarioResult = usuario
            };
        }

    }
}
