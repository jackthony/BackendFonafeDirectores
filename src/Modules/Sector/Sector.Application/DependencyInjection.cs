using Sector.Application.Dtos;
using Sector.Application.UseCases;
using Sector.Application.Validators;
using Sector.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Sector.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSectorApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarSectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearSectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarSectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarSectorPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarSectorRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearSectorData, SpResultBase>, CrearSectorUseCase>();
            services.AddScoped<IUseCase<ActualizarSectorData, SpResultBase>, ActualizarSectorUseCase>();
            services.AddScoped<IUseCase<EliminarSectorData, SpResultBase>, EliminarSectorUseCase>();
            services.AddScoped<IUseCase<ListarSectorPaginadoRequest, PagedResult<SectorDto>>, ListarSectorPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarSectorRequest, List<SectorDto>>, ListarSectorUseCase>();
            services.AddScoped<IUseCase<long, SectorDto?>, ObtenerSectorPorIdUseCase>();

            return services;
        }
    }
}
