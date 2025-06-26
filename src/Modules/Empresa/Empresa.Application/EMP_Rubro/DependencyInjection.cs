using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Application.Rubro.Mappers;
using Empresa.Application.Rubro.UseCases;
using Empresa.Application.Rubro.Validators;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Application.Rubro
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRubroApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarRubroRequest, SpResultBase>, ActualizarRubroUseCase>();
            services.AddScoped<IUseCase<CrearRubroRequest, SpResultBase>, CrearRubroUseCase>();
            services.AddScoped<IUseCase<EliminarRubroRequest, SpResultBase>, EliminarRubroUseCase>();
            services.AddScoped<IUseCase<ListarRubroPaginadoRequest, PagedResult<RubroResult>>, ListarRubroPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarRubroRequest, List<RubroResult>>, ListarRubroUseCase>();
            services.AddScoped<IUseCase<int, RubroResult?>, ObtenerRubroPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarRubroRequest, ActualizarRubroParameters>, ActualizarRubroRequestMapper>();
            services.AddScoped<IMapper<CrearRubroRequest, CrearRubroParameters>, CrearRubroRequestMapper>();
            services.AddScoped<IMapper<EliminarRubroRequest, EliminarRubroParameters>, EliminarRubroRequestMapper>();
            services.AddScoped<IMapper<ListarRubroPaginadoRequest, ListarRubroPaginadoParameters>, ListarRubroPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarRubroRequest, ListarRubroParameters>, ListarRubroRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarRubroRequest>, ActualizarRubroRequestValidator>();
            services.AddScoped<IValidator<CrearRubroRequest>, CrearRubroRequestValidator>();
            services.AddScoped<IValidator<EliminarRubroRequest>, EliminarRubroRequestValidator>();
            services.AddScoped<IValidator<ListarRubroPaginadoRequest>, ListarRubroPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarRubroRequest>, ListarRubroRequestValidator>();

            return services;
        }

    }
}
