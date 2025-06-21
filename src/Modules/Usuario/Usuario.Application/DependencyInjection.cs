using Usuario.Application.Dtos;
using Usuario.Application.UseCases;
using Usuario.Application.Validators;
using Usuario.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUsuarioApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarUsuarioRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearUsuarioRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarUsuarioRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarUsuarioPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarUsuarioRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearUsuarioData, SpResultBase>, CrearUsuarioUseCase>();
            services.AddScoped<IUseCase<ActualizarUsuarioData, SpResultBase>, ActualizarUsuarioUseCase>();
            services.AddScoped<IUseCase<EliminarUsuarioData, SpResultBase>, EliminarUsuarioUseCase>();
            services.AddScoped<IUseCase<ListarUsuarioPaginadoRequest, PagedResult<UsuarioDto>>, ListarUsuarioPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarUsuarioRequest, List<UsuarioDto>>, ListarUsuarioUseCase>();
            services.AddScoped<IUseCase<long, UsuarioDto?>, ObtenerUsuarioPorIdUseCase>();

            return services;
        }
    }
}
