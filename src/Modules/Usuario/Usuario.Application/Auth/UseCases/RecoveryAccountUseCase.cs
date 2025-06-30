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
