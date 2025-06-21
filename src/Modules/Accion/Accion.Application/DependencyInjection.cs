using Accion.Application.Dtos;
using Accion.Application.UseCases;
using Accion.Application.Validators;
using Accion.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAccionApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarAccionRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearAccionRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarAccionRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarAccionPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarAccionRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearAccionData, SpResultBase>, CrearAccionUseCase>();
            services.AddScoped<IUseCase<ActualizarAccionData, SpResultBase>, ActualizarAccionUseCase>();
            services.AddScoped<IUseCase<EliminarAccionData, SpResultBase>, EliminarAccionUseCase>();
            services.AddScoped<IUseCase<ListarAccionPaginadoRequest, PagedResult<AccionDto>>, ListarAccionPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarAccionRequest, List<AccionDto>>, ListarAccionUseCase>();
            services.AddScoped<IUseCase<long, AccionDto?>, ObtenerAccionPorIdUseCase>();

            return services;
        }
    }
}
