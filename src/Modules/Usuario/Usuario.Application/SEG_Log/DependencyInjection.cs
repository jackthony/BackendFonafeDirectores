/***********
* Nombre del archivo: DependencyInjection.cs
* Descripción:        Clase de extensión para configurar la inyección de dependencias de la capa de aplicación
*                     del módulo de logs. Registra servicios relacionados con el seguimiento y la auditoría,
*                     incluyendo interfaces de solicitud y respuesta, así como casos de uso para la exportación
*                     de diferentes tipos de registros (auditoría de usuarios, logs de sistema y trazabilidad).
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para la configuración de inyección de dependencias
* de la capa de aplicación del módulo de logs.
***********/

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
