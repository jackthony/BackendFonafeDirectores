﻿/***********
* Nombre del archivo: DependencyInjection.cs
* Descripción:        Clase de extensión para configurar la inyección de dependencias de la capa de aplicación
*                     del módulo de usuario. Registra los casos de uso (UseCases), mappers y validadores
*                     relacionados con las operaciones de usuario.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para la configuración de inyección de dependencias
*                     de la capa de aplicación del módulo de usuario.
***********/

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.User.Dtos;
using Usuario.Application.User.Mappers;
using Usuario.Application.User.UseCases;
using Usuario.Application.User.Validators;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Results;

namespace Usuario.Application.User
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUserApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarUserRequest, SpResultBase>, ActualizarUserUseCase>();
            services.AddScoped<IUseCase<CrearUserRequest, SpResultBase>, CrearUserUseCase>();
            services.AddScoped<IUseCase<EliminarUserRequest, SpResultBase>, EliminarUserUseCase>();
            services.AddScoped<IUseCase<ListarUserPaginadoRequest, PagedResult<UserResult>>, ListarUserPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarUserRequest, List<UserResult>>, ListarUserUseCase>();
            services.AddScoped<IUseCase<int, UserResult?>, ObtenerUserPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarUserRequest, ActualizarUserParameters>, ActualizarUserRequestMapper>();
            services.AddScoped<IMapper<CrearUserRequest, CrearUserParameters>, CrearUserRequestMapper>();
            services.AddScoped<IMapper<EliminarUserRequest, EliminarUserParameters>, EliminarUserRequestMapper>();
            services.AddScoped<IMapper<ListarUserPaginadoRequest, ListarUserPaginadoParameters>, ListarUserPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarUserRequest, ListarUserParameters>, ListarUserRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarUserRequest>, ActualizarUserRequestValidator>();
            services.AddScoped<IValidator<CrearUserRequest>, CrearUserRequestValidator>();
            services.AddScoped<IValidator<EliminarUserRequest>, EliminarUserRequestValidator>();
            services.AddScoped<IValidator<ListarUserPaginadoRequest>, ListarUserPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarUserRequest>, ListarUserRequestValidator>();

            return services;
        }

    }
}
