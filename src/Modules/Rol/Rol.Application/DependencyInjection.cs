using Rol.Application.Dtos;
using Rol.Application.UseCases;
using Rol.Application.Validators;
using Rol.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRolApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarRolRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearRolRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarRolRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarRolPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarRolRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearRolData, SpResultBase>, CrearRolUseCase>();
            services.AddScoped<IUseCase<ActualizarRolData, SpResultBase>, ActualizarRolUseCase>();
            services.AddScoped<IUseCase<EliminarRolData, SpResultBase>, EliminarRolUseCase>();
            services.AddScoped<IUseCase<ListarRolPaginadoRequest, PagedResult<RolDto>>, ListarRolPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarRolRequest, List<RolDto>>, ListarRolUseCase>();
            services.AddScoped<IUseCase<long, RolDto?>, ObtenerRolPorIdUseCase>();

            return services;
        }
    }
}
