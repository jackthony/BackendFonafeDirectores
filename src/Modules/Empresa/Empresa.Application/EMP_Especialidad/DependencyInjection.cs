using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Application.EMP_Especialidad.UseCases;
using Empresa.Application.EMP_Especialidad.Validators;
using Empresa.Domain.EMP_Especialidad.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Especialidad
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddEspecialidadApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarEspecialidadRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearEspecialidadRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarEspecialidadRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarEspecialidadPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarEspecialidadRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearEspecialidadData, SpResultBase>, CrearEspecialidadUseCase>();
            services.AddScoped<IUseCase<ActualizarEspecialidadData, SpResultBase>, ActualizarEspecialidadUseCase>();
            services.AddScoped<IUseCase<EliminarEspecialidadData, SpResultBase>, EliminarEspecialidadUseCase>();
            services.AddScoped<IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadDto>>, ListarEspecialidadPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarEspecialidadRequest, List<EspecialidadDto>>, ListarEspecialidadUseCase>();
            services.AddScoped<IUseCase<long, EspecialidadDto?>, ObtenerEspecialidadPorIdUseCase>();

            return services;
        }
    }
}
