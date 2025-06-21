using Cargo.Application.Dtos;
using Cargo.Application.UseCases;
using Cargo.Application.Validators;
using Cargo.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Cargo.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCargoApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarCargoPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarCargoRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearCargoData, SpResultBase>, CrearCargoUseCase>();
            services.AddScoped<IUseCase<ActualizarCargoData, SpResultBase>, ActualizarCargoUseCase>();
            services.AddScoped<IUseCase<EliminarCargoData, SpResultBase>, EliminarCargoUseCase>();
            services.AddScoped<IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoDto>>, ListarCargoPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarCargoRequest, List<CargoDto>>, ListarCargoUseCase>();
            services.AddScoped<IUseCase<long, CargoDto?>, ObtenerCargoPorIdUseCase>();

            return services;
        }
    }
}
