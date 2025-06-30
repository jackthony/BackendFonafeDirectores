using Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.UseCases;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUseCase<LoginRequest, LoginResponse> _loginUseCase;
        private readonly IUseCase<VerifyTokenRequest, LoginResponse> _verifyTokenUseCase;
        private readonly IUseCase<RefreshTokenRequest, LoginResponse> _refreshTokenUseCase;
        private readonly IUseCase<ChangePasswordRequest, SpResultBase> _changePasswordUseCase;
        private readonly IUseCase<ForgotPasswordRequest, ForgotPasswordResponse> _forgotPasswordUseCase;
        private readonly IUseCase<ResetPasswordRequest, ResetPasswordResponse> _resetPasswordUseCase;
        private readonly IUseCase<AdminResetPasswordRequest, AdminResetPasswordResponse> _adminResetPasswordUseCase;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterDelivery;
        private readonly IUseCase<string, SpResultBase> _confirmUseCase;
        private readonly IUseCase<RecoveryAccountRequest, SpResultBase> _recoveryAccountUseCase;

        public AuthController(IUseCase<LoginRequest, LoginResponse> loginUseCase, IUseCase<VerifyTokenRequest, LoginResponse> verifyTokenUseCase, IUseCase<RefreshTokenRequest, LoginResponse> refreshTokenUseCase, IUseCase<ChangePasswordRequest, SpResultBase> changePasswordUseCase, IUseCase<ForgotPasswordRequest, ForgotPasswordResponse> forgotPasswordUseCase, IUseCase<ResetPasswordRequest, ResetPasswordResponse> resetPasswordUseCase, IUseCase<AdminResetPasswordRequest, AdminResetPasswordResponse> adminResetPasswordUseCase, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterDelivery, IUseCase<string, SpResultBase> confirmUseCase, IUseCase<RecoveryAccountRequest, SpResultBase> recoveryAccountUseCase)
        {
            _loginUseCase = loginUseCase;
            _verifyTokenUseCase = verifyTokenUseCase;
            _refreshTokenUseCase = refreshTokenUseCase;
            _changePasswordUseCase = changePasswordUseCase;
            _forgotPasswordUseCase = forgotPasswordUseCase;
            _resetPasswordUseCase = resetPasswordUseCase;
            _adminResetPasswordUseCase = adminResetPasswordUseCase;
            _presenterDelivery = presenterDelivery;
            _confirmUseCase = confirmUseCase;
            _recoveryAccountUseCase = recoveryAccountUseCase;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _loginUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0, showToast: false);

            return Ok(result.AsT1);
        }

        [HttpGet("recovery-account")]
        public async Task<IActionResult> RecoveryAccount(RecoveryAccountRequest request)
        {
            var result = await _recoveryAccountUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0, showToast: false);
            var response = _presenterDelivery.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("confirm-account")]
        public async Task<IActionResult> ConfirmAccount(string token)
        {
            var result = await _confirmUseCase.ExecuteAsync(token);

            if (result.IsT0)
                return BadRequest(result.AsT0.Message);
            return Ok(result.AsT1.Message);
        }

        [HttpPost("verify-token")]
        public async Task<IActionResult> VerifyToken([FromBody] VerifyTokenRequest request)
        {
            var result = await _verifyTokenUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0, showToast: false);

            return Ok(result.AsT1);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            var result = await _refreshTokenUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0, showToast: false);

            return Ok(result.AsT1);
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            var result = await _changePasswordUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0, showToast: false);
            var response = _presenterDelivery.Present(result.AsT1);
            return Ok(response);

        }


        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequest request)
        {
            var result = await _forgotPasswordUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0, showToast: false);
            return Ok(result.AsT1);
        }


        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request)
        {
            var result = await _resetPasswordUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0, showToast: false);
            return Ok(result.AsT1);
        }

        [HttpPost("admin/reset-password")]
        public async Task<IActionResult> AdminResetPassword([FromBody] AdminResetPasswordRequest request)
        {
            var result = await _adminResetPasswordUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0, showToast: false);
            return Ok(result.AsT1);
        }
    }
}
