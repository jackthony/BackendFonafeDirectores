using Director.Application.Dtos;
using Director.Application.UseCases;
using Director.Application.Validators;
using Director.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Director.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDirectorApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarDirectorPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarDirectorRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearDirectorData, SpResultBase>, CrearDirectorUseCase>();
            services.AddScoped<IUseCase<ActualizarDirectorData, SpResultBase>, ActualizarDirectorUseCase>();
            services.AddScoped<IUseCase<EliminarDirectorData, SpResultBase>, EliminarDirectorUseCase>();
            services.AddScoped<IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorDto>>, ListarDirectorPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarDirectorRequest, List<DirectorDto>>, ListarDirectorUseCase>();
            services.AddScoped<IUseCase<long, DirectorDto?>, ObtenerDirectorPorIdUseCase>();

            return services;
        }
    }
}
