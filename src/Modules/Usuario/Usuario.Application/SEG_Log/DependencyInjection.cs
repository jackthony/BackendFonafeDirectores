using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Usuario.Application.Auth.Dtos;

namespace Usuario.Application.SEG_Log
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLogApplication(this IServiceCollection services)
        {
            services.AddScoped<ISistemaRequest, LoginRequest>();
            services.AddScoped<ISistemaResponse, LoginResponse>();

            return services;
        }
    }
}
