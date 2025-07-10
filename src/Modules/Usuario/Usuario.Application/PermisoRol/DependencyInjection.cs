/***********
* Nombre del archivo: DependencyInjection.cs
* Descripción:        Clase de extensión para configurar la inyección de dependencias de la capa de aplicación
*                     del módulo `PermisoRol`. Se encarga de registrar todos los **casos de uso (UseCases)**,
*                     **mapeadores (Mappers)** y **validadores (Validators)** relacionados con la gestión de permisos de roles.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para la configuración de inyección de dependencias
*                     del módulo `PermisoRol`.
***********/

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Application.PermisoRol.Mappers;
using Usuario.Application.PermisoRol.UseCases;
using Usuario.Application.PermisoRol.Validators;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Results;

namespace Usuario.Application.PermisoRol
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPermisoRolApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarPermisoRolRequest, SpResultBase>, ActualizarPermisoRolUseCase>();
            services.AddScoped<IUseCase<CrearPermisoRolRequest, SpResultBase>, CrearPermisoRolUseCase>();
            services.AddScoped<IUseCase<EliminarPermisoRolRequest, SpResultBase>, EliminarPermisoRolUseCase>();
            services.AddScoped<IUseCase<ListarPermisoRolPaginadoRequest, PagedResult<PermisoRolResult>>, ListarPermisoRolPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarPermisoRolRequest, List<PermisoRolResult>>, ListarPermisoRolUseCase>();
            services.AddScoped<IUseCase<int, PermisoRolResult?>, ObtenerPermisoRolPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarPermisoRolRequest, ActualizarPermisoRolParameters>, ActualizarPermisoRolRequestMapper>();
            services.AddScoped<IMapper<CrearPermisoRolRequest, CrearPermisoRolParameters>, CrearPermisoRolRequestMapper>();
            services.AddScoped<IMapper<EliminarPermisoRolRequest, EliminarPermisoRolParameters>, EliminarPermisoRolRequestMapper>();
            services.AddScoped<IMapper<ListarPermisoRolPaginadoRequest, ListarPermisoRolPaginadoParameters>, ListarPermisoRolPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarPermisoRolRequest, ListarPermisoRolParameters>, ListarPermisoRolRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarPermisoRolRequest>, ActualizarPermisoRolRequestValidator>();
            services.AddScoped<IValidator<CrearPermisoRolRequest>, CrearPermisoRolRequestValidator>();
            services.AddScoped<IValidator<EliminarPermisoRolRequest>, EliminarPermisoRolRequestValidator>();
            services.AddScoped<IValidator<ListarPermisoRolPaginadoRequest>, ListarPermisoRolPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarPermisoRolRequest>, ListarPermisoRolRequestValidator>();

            return services;
        }

    }
}
