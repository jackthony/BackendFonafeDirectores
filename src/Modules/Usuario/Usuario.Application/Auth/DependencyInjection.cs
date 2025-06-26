using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
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

            // Mappers
            services.AddScoped<IMapper<LoginRequest, LoginParameters>, LoginRequestMapper>();
            services.AddScoped<IMapper<RefreshTokenCreateRequest, RefreshToken>, RefreshTokenRequestMapper>();

            return services;
        }
    }
}
