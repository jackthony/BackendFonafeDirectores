using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Application.EMP_TipoDirector.UseCases;
using Empresa.Application.EMP_TipoDirector.Validators;
using Empresa.Domain.EMP_TipoDirector.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_TipoDirector
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
