using TipoDirector.Application.Dtos;
using TipoDirector.Application.UseCases;
using TipoDirector.Application.Validators;
using TipoDirector.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace TipoDirector.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddTipoDirectorApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarTipoDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearTipoDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarTipoDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarTipoDirectorPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarTipoDirectorRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearTipoDirectorData, SpResultBase>, CrearTipoDirectorUseCase>();
            services.AddScoped<IUseCase<ActualizarTipoDirectorData, SpResultBase>, ActualizarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<EliminarTipoDirectorData, SpResultBase>, EliminarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorDto>>, ListarTipoDirectorPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarTipoDirectorRequest, List<TipoDirectorDto>>, ListarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<long, TipoDirectorDto?>, ObtenerTipoDirectorPorIdUseCase>();

            return services;
        }
    }
}
