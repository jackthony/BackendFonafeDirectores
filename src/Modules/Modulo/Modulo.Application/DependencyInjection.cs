using Modulo.Application.Dtos;
using Modulo.Application.UseCases;
using Modulo.Application.Validators;
using Modulo.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddModuloApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarModuloRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearModuloRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarModuloRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarModuloPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarModuloRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearModuloData, SpResultBase>, CrearModuloUseCase>();
            services.AddScoped<IUseCase<ActualizarModuloData, SpResultBase>, ActualizarModuloUseCase>();
            services.AddScoped<IUseCase<EliminarModuloData, SpResultBase>, EliminarModuloUseCase>();
            services.AddScoped<IUseCase<ListarModuloPaginadoRequest, PagedResult<ModuloDto>>, ListarModuloPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarModuloRequest, List<ModuloDto>>, ListarModuloUseCase>();
            services.AddScoped<IUseCase<long, ModuloDto?>, ObtenerModuloPorIdUseCase>();

            return services;
        }
    }
}
