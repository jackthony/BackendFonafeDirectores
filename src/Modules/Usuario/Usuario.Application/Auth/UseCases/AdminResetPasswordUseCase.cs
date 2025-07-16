/***********
* Nombre del archivo: AdminResetPasswordUseCase.cs
* Descripción:        **Caso de uso** para que un administrador restablezca la contraseña de otro usuario.
*                     Orquesta la validación del **token del administrador** para asegurar los permisos,
*                     la búsqueda del usuario objetivo por ID en el **repositorio de autenticación**,
*                     el hashing de la nueva contraseña proporcionada por el administrador,
*                     y la actualización de la contraseña del usuario en la base de datos.
*                     Además, se encarga de limpiar el contador de intentos fallidos del usuario cuya contraseña fue restablecida.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para que un administrador restablezca contraseñas.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.Auth.Parameters;
using Shared.Time;

namespace Usuario.Application.Auth.UseCases
{
    public class AdminResetPasswordUseCase : IUseCase<AdminResetPasswordRequest, AdminResetPasswordResponse>
    {
        private readonly ITokenService _tokenService;
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITimeProvider _timeProvider;

        public AdminResetPasswordUseCase(ITokenService tokenService, IAuthRepository authRepository, IPasswordHasher passwordHasher, ITimeProvider timeProvider)
        {
            _tokenService = tokenService;
            _authRepository = authRepository;
            _passwordHasher = passwordHasher;
            _timeProvider = timeProvider;
        }

        public async Task<OneOf<ErrorBase, AdminResetPasswordResponse>> ExecuteAsync(AdminResetPasswordRequest request)
        {
            // 1. Validar el token del administrador (asegurarse de que sea un admin)
            /*var claimsPrincipal = _tokenService.ValidateAccessToken(request.Token);
            if (claimsPrincipal == null)
                return ErrorBase.Validation("Token inválido o expirado");*/

            //var adminRole = claimsPrincipal.FindFirst("role")?.Value;
            //if (adminRole != "admin")
            //    return ErrorBase.Validation("No tienes permiso para realizar esta acción");

            // 2. Buscar al usuario por ID
            var userResult = await _authRepository.ObtenerPorIdAsync(request.UsuarioId);
            if (!userResult.Success || userResult.Data is null)
                return ErrorBase.Validation("Usuario no encontrado");

            var usuario = userResult.Data;

            // 3. Hashear la nueva contraseña
            var newPasswordHash = _passwordHasher.Hash(request.NewPassword);

            // 4. Crear el parámetro ChangePasswordParameters
            var changePasswordParameters = new ChangePasswordParameters
            {
                UsuarioId = request.UsuarioId,
                newPasswordHash = newPasswordHash,
                UsuarioModificaId = request.nUserIdModifica,
                FechaModifica = _timeProvider.NowPeru
            };

            // 5. Actualizar la contraseña del usuario
            var updateResult = await _authRepository.UpdatePasswordAsync(changePasswordParameters);
            if (!updateResult.Success)
                return ErrorBase.Database("No se pudo actualizar la contraseña");

            // 6. Limpiar el contador de intentos fallidos
            var clearFailedAttemptsParameters = new ClearFailedAttemptsParameters
            {
                UsuarioId = request.UsuarioId
            };

            var clearResult = await _authRepository.ClearFailedAttemptsAsync(clearFailedAttemptsParameters);
            if (!clearResult.Success)
                return ErrorBase.Database("No se pudo limpiar los intentos fallidos");

            // 7. Registrar la auditoría (si lo deseas)
            // await _authRepository.LogPasswordChangeAsync(request.UsuarioId, claimsPrincipal.Identity.Name ?? "system");

            // 8. Responder al administrador
            return new AdminResetPasswordResponse
            {
                isSuccess = true,
                Message = "Contraseña restablecida con éxito"
            };
        }
    }
}
