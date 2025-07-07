using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.SEG_Log.UseCases;
using Usuario.Domain.SEG_Log.Parameters;

namespace Usuario.Application.SEG_Log
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLogApplication(this IServiceCollection services)
        {
            services.AddScoped<ISistemaRequest, LoginRequest>();
            services.AddScoped<ISistemaResponse, LoginResponse>();

            services.AddScoped<IUseCase<ObtenerAuditoriaUsuariosRequest, Stream>, ExportAuditoriaUsuariosUseCase>();
            services.AddScoped<IUseCase<ObtenerUsuariosPorTipoUsuarioRequest, Stream>, ExportUsuariosPorTipoUsuarioUseCase>();
            services.AddScoped<IUseCase<ObtenerLogSistemaPorFechasRequest, Stream>, ExportLogSistemaUseCase>();
            services.AddScoped<IUseCase<ObtenerLogTrazabilidadRequest, Stream>, ExportLogTrazabilidadUseCase>();

            return services;
        }
    }
}
