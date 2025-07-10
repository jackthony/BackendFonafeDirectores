/***********
* Nombre del archivo: RecoveryAccountUseCase.cs
* Descripción:        **Caso de uso** para la recuperación de cuentas.
*                     Este caso de uso orquesta el envío de notificaciones por correo electrónico a los administradores
*                     cuando un usuario solicita la recuperación de su cuenta. Recupera la lista de administradores
*                     desde el **repositorio** y, para cada uno, invoca el **servicio de correo electrónico**
*                     para enviar un aviso, incluyendo el nombre del usuario y su dirección de correo electrónico.
*                     Finaliza siempre con una respuesta de éxito, indicando que el mensaje fue enviado.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para la recuperación de cuentas.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Repositories;

namespace Usuario.Application.Auth.UseCases
{
    public class RecoveryAccountUseCase : IUseCase<RecoveryAccountRequest, SpResultBase>
    {
        private readonly IAuthRepository _authRepository;
        private readonly IEmailService _emailService;

        public RecoveryAccountUseCase(IAuthRepository authRepository, IEmailService emailService)
        {
            _authRepository = authRepository;
            _emailService = emailService;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(RecoveryAccountRequest request)
        {
            var admins = await _authRepository.RecoveryAdminsAsync();
            foreach (var admin in admins)
            {
                await _emailService.SendAdminRecoveroyAccountEmailAsync(request.sNombre, admin, request.sCorreo);
            }
            return new SpResultBase() { Success = true, Data = 1 , Message = "Mensaje enviado" };
        }
    }
}
