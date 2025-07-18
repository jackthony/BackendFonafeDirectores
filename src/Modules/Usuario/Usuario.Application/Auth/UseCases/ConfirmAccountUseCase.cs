﻿/***********
* Nombre del archivo: ConfirmAccountUseCase.cs
* Descripción:        **Caso de uso** para la confirmación de la cuenta de un usuario.
*                     Orquesta la validación de un **token de confirmación**, extrayendo el ID del usuario
*                     contenido en él, para luego invocar el **repositorio de autenticación**
*                     y confirmar la cuenta del usuario en la base de datos.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para la confirmación de cuentas.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Repositories;

namespace Usuario.Application.Auth.UseCases
{
    public class ConfirmAccountUseCase : IUseCase<string, SpResultBase>
    {
        private readonly IAuthRepository _authRepository;
        private readonly ITokenService _tokenService;

        public ConfirmAccountUseCase(
            IAuthRepository authRepository,
            ITokenService tokenService)
        {
            _authRepository = authRepository;
            _tokenService = tokenService;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(string token)
        {
            var claimsPrincipal = _tokenService.ValidateAccessToken(token);

            if (claimsPrincipal == null)
                return ErrorBase.Validation("Token inválido o expirado.");

            var userId = _tokenService.GetUsuarioIdFromClaims(claimsPrincipal);

            if (userId == null)
                return ErrorBase.Validation("El token no contiene información válida del usuario.");

            var result = await _authRepository.ConfirmarCuentaAsync(userId ?? 0);

            return result;
        }

    }
}
