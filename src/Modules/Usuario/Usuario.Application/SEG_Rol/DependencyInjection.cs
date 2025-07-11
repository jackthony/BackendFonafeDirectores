﻿/***********
* Nombre del archivo: DependencyInjection.cs
* Descripción:        Clase de extensión para configurar la inyección de dependencias de la capa de aplicación
*                     del módulo de roles. Registra los casos de uso (UseCases), mappers y validadores
*                     relacionados con las operaciones de gestión de roles y sus permisos.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para la configuración de inyección de dependencias
*                     de la capa de aplicación del módulo de roles, incluyendo la gestión de permisos.
***********/

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Rol.Dtos;
using Usuario.Application.Rol.Mappers;
using Usuario.Application.Rol.UseCases;
using Usuario.Application.Rol.Validators;
using Usuario.Application.SEG_Rol.Dtos;
using Usuario.Application.SEG_Rol.Mappers;
using Usuario.Application.SEG_Rol.UseCases;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Results;
using Usuario.Domain.SEG_Rol.Parameters;

namespace Usuario.Application.Rol
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRolApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarRolRequest, SpResultBase>, ActualizarRolUseCase>();
            services.AddScoped<IUseCase<CrearRolRequest, SpResultBase>, CrearRolUseCase>();
            services.AddScoped<IUseCase<EliminarRolRequest, SpResultBase>, EliminarRolUseCase>();
            services.AddScoped<IUseCase<ListarRolPaginadoRequest, PagedResult<RolResult>>, ListarRolPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarRolRequest, List<RolResult>>, ListarRolUseCase>();
            services.AddScoped<IUseCase<int, RolResult?>, ObtenerRolPorIdUseCase>();
            services.AddScoped<IUseCase<CrearPermisosRolRequest, SpResultBase>, CrearPermisosRolUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarRolRequest, ActualizarRolParameters>, ActualizarRolRequestMapper>();
            services.AddScoped<IMapper<CrearRolRequest, CrearRolParameters>, CrearRolRequestMapper>();
            services.AddScoped<IMapper<EliminarRolRequest, EliminarRolParameters>, EliminarRolRequestMapper>();
            services.AddScoped<IMapper<ListarRolPaginadoRequest, ListarRolPaginadoParameters>, ListarRolPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarRolRequest, ListarRolParameters>, ListarRolRequestMapper>();
            services.AddScoped<IMapper<CrearPermisosRolRequest, CrearPermisosRolParameters>, CrearPermisosRolRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarRolRequest>, ActualizarRolRequestValidator>();
            services.AddScoped<IValidator<CrearRolRequest>, CrearRolRequestValidator>();
            services.AddScoped<IValidator<EliminarRolRequest>, EliminarRolRequestValidator>();
            services.AddScoped<IValidator<ListarRolPaginadoRequest>, ListarRolPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarRolRequest>, ListarRolRequestValidator>();

            return services;
        }

    }
}
