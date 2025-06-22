using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Mappers;
using Usuario.Application.Auth.UseCases;
using Usuario.Domain.Auth.Parameters;

namespace Usuario.Application.Auth
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuthApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<LoginRequest, LoginResponse>, LoginUseCase>();

            // Mappers
            services.AddScoped<IMapper<LoginRequest, LoginParameters>, LoginRequestMapper>();

            return services;
        }
    }
}
