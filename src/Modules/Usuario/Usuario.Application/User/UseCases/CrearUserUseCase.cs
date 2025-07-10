/***********
* Nombre del archivo: CrearUserUseCase.cs
* Descripción:        Caso de uso para la creación de un nuevo usuario en el sistema.
*                     Coordina el hashing de la contraseña, el mapeo de la solicitud a parámetros de dominio,
*                     la adición del usuario a la base de datos, y el envío de un correo electrónico
*                     de confirmación de cuenta con un token de verificación.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para crear un usuario,
*                     incluyendo el manejo de contraseña, persistencia y envío de correo de confirmación.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Services;
using Usuario.Application.User.Dtos;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Repositories;

namespace Usuario.Application.User.UseCases
{
    public class CrearUserUseCase : IUseCase<CrearUserRequest, SpResultBase>
    {
        private readonly IUserRepository _repository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper<CrearUserRequest, CrearUserParameters> _mapper;
        private readonly IEmailService _emailService;
        private readonly ITokenService _tokenService;
        private readonly IAuthRepository _authRepository;

        public CrearUserUseCase(IUserRepository repository, IPasswordHasher passwordHasher, IMapper<CrearUserRequest, CrearUserParameters> mapper, IEmailService emailService, ITokenService tokenService, IAuthRepository authRepository)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _emailService = emailService;
            _tokenService = tokenService;
            _authRepository = authRepository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearUserRequest request)
        {
            request.sContrasena = _passwordHasher.Hash(request.sContrasena);
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);

            var loginParameters = new LoginParameters { Correo = request.sCorreoElectronico };
            
            var userResult = await _authRepository.ObtenerPorCorreoAsync(loginParameters);

            if (!userResult.Success || userResult.Data is null)
                return ErrorBase.Validation("Correo electrónico no registrado");

            var usuario = userResult.Data;

            var resetToken = _tokenService.GenerateConfirmationToken(usuario.UsuarioId);

            var resetLink = $"https://fonafe-directores.com/confirm-account?token={resetToken}";
            
            await _emailService.SendConfirmationEmailAsync(request.sCorreoElectronico, resetLink);
            
            return result;
        }
    }
}
