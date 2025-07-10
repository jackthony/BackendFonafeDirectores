/***********
* Nombre del archivo: DependencyInjection.cs
* Descripción:        Clase de extensión que configura la inyección de dependencias para la **capa de aplicación del módulo de autenticación (Auth)**.
*                     Registra los **casos de uso (UseCases)** encargados de gestionar operaciones como el login,
*                     verificación y refresco de tokens, confirmación y recuperación de cuentas, y gestión de contraseñas.
*                     Además, configura los **mapeadores (Mappers)** necesarios para transformar los DTOs de solicitud
*                     en parámetros de dominio.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para la configuración de inyección de dependencias del módulo de autenticación.
***********/

using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Mappers;
using Usuario.Application.Auth.UseCases;
using Usuario.Domain.Auth.Models;
using Usuario.Domain.Auth.Parameters;

namespace Usuario.Application.Auth
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuthApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<LoginRequest, LoginResponse>, LoginUseCase>();
            services.AddScoped<IUseCase<VerifyTokenRequest, LoginResponse>, VerifyTokenUseCase>();
            services.AddScoped<IUseCase<RefreshTokenRequest, LoginResponse>, RefreshTokenUseCase>();
            services.AddScoped<IUseCase<string, SpResultBase>, ConfirmAccountUseCase>();
            services.AddScoped<IUseCase<RecoveryAccountRequest, SpResultBase>, RecoveryAccountUseCase>();
            // Cambio de contraseña
            services.AddScoped<IUseCase<ChangePasswordRequest, SpResultBase>, ChangePasswordUseCase>();
            services.AddScoped<IUseCase<ForgotPasswordRequest, ForgotPasswordResponse>, ForgotPasswordUseCase>();
            services.AddScoped<IUseCase<ResetPasswordRequest, ResetPasswordResponse>, ResetPasswordUseCase>();
            services.AddScoped<IUseCase<AdminResetPasswordRequest, AdminResetPasswordResponse>, AdminResetPasswordUseCase>();
            // Mappers
            services.AddScoped<IMapper<LoginRequest, LoginParameters>, LoginRequestMapper>();
            services.AddScoped<IMapper<RefreshTokenCreateRequest, RefreshToken>, RefreshTokenRequestMapper>();

            return services;
        }
    }
}
