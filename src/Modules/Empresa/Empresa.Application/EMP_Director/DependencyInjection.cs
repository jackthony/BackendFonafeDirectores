using Empresa.Application.EMP_Director.Dtos;
using Empresa.Application.EMP_Director.UseCases;
using Empresa.Application.EMP_Director.Validators;
using Empresa.Domain.EMP_Director.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Director
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
