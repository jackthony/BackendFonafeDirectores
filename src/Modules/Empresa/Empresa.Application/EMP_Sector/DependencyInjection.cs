using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Sector.Dtos;
using Empresa.Application.Sector.Mappers;
using Empresa.Application.Sector.UseCases;
using Empresa.Application.Sector.Validators;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Results;

namespace Empresa.Application.Sector
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSectorApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarSectorRequest, SpResultBase>, ActualizarSectorUseCase>();
            services.AddScoped<IUseCase<CrearSectorRequest, SpResultBase>, CrearSectorUseCase>();
            services.AddScoped<IUseCase<EliminarSectorRequest, SpResultBase>, EliminarSectorUseCase>();
            services.AddScoped<IUseCase<ListarSectorPaginadoRequest, PagedResult<SectorResult>>, ListarSectorPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarSectorRequest, List<SectorResult>>, ListarSectorUseCase>();
            services.AddScoped<IUseCase<int, SectorResult?>, ObtenerSectorPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarSectorRequest, ActualizarSectorParameters>, ActualizarSectorRequestMapper>();
            services.AddScoped<IMapper<CrearSectorRequest, CrearSectorParameters>, CrearSectorRequestMapper>();
            services.AddScoped<IMapper<EliminarSectorRequest, EliminarSectorParameters>, EliminarSectorRequestMapper>();
            services.AddScoped<IMapper<ListarSectorPaginadoRequest, ListarSectorPaginadoParameters>, ListarSectorPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarSectorRequest, ListarSectorParameters>, ListarSectorRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarSectorRequest>, ActualizarSectorRequestValidator>();
            services.AddScoped<IValidator<CrearSectorRequest>, CrearSectorRequestValidator>();
            services.AddScoped<IValidator<EliminarSectorRequest>, EliminarSectorRequestValidator>();
            services.AddScoped<IValidator<ListarSectorPaginadoRequest>, ListarSectorPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarSectorRequest>, ListarSectorRequestValidator>();

            return services;
        }

    }
}
